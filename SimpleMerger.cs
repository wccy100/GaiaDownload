/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/18 星期四
 * Time: 10:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HttpDemo
{
	/// <summary>
	/// Description of SimpleMerger.
	/// </summary>
	public partial class SimpleMerger : Form
	{
		public SimpleMerger()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		static int Safe = 0;
		string filePath;
		void Btn_fileLocationClick(object sender, EventArgs e)
		{
			string path = "";
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
				path = folderBrowserDialog.SelectedPath;
			} else {
			}
			if (!string.IsNullOrEmpty(path)) {
				filePath = path;
			}
		}
		void Btn_StartClick(object sender, EventArgs e)
		{
			btn_Start.Enabled = false;
			this.Text = "爱大哥";
			if (string.IsNullOrEmpty(filePath)) {
				btn_Start.Enabled = true;
				txt_state.Text = "路径为空";
				return;
			}
			FileTsDeal();
		}

		bool SelectTs(FileInfo di)
		{
	 
			if (di.Extension == ".ts") {
				return true;
			}
			return false;
		}

		void FileTsDeal()
		{
		
			if (!Directory.Exists(filePath)) {
				btn_Start.Enabled = true;
				txt_state.Text = "路径不存在";
				return;
			}
			
			
			var files = Directory.GetFiles(filePath);
			if (files.Length == 0) {
				btn_Start.Enabled = true;
				txt_state.Text = "文件夹为空";
				return;
			}
			Safe += 1;
			if (Safe != 1) {
				return;
			}
			IEnumerable<FileInfo> tsfiles;

			if (checkBox.Checked) {
				tsfiles = from file in files
				           let tsfile = new FileInfo(file)
				           where SelectTs(tsfile)
				           orderby tsfile.Name
				           select tsfile;
			} else {
				tsfiles = from file in files
				           let tsfile = new FileInfo(file)
				           where SelectTs(tsfile)
				           orderby tsfile.LastWriteTime
				           select tsfile;
			}
			
			
			var filelist = tsfiles.ToList();
		
			FileStream sumfile;
			
			sumfile = File.Create(filePath + "/" + "Gaia视频文件合并" + ".ts");
			sumfile.Close();
			
			
			for (int i = 0; i < filelist.Count; i++) {
				sumfile = File.Open(filePath + "/" + "Gaia视频文件合并" + ".ts",FileMode.Append);
				var file = File.Open(filelist[i].FullName, FileMode.Open);
				byte[] buffer = new byte[2048];
				int len = 0;
				while ((len = file.Read(buffer, 0, buffer.Length)) != 0) {
					sumfile.Write(buffer, 0, len);
					
				}
				file.Close();
				File.Delete(filelist[i].FullName);
				sumfile.Flush();
				sumfile.Close();
			}
			sumfile.Close();
			btn_Start.Enabled = true;
			txt_state.Text = "完成";
			Safe -= 1;
			
			
		}
		
	}
}
