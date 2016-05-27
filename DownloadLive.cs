/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/16/2016
 * Time: 13:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HttpDemo
{
	/// <summary>
	/// Description of DownloadLive.
	/// </summary>
	public partial class DownloadLive : Form
	{
		public DownloadLive()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		 
		
			txt_Status.BackColor = Color.Gray;
			btn_StopDownload.Enabled=false;
		 
		}

		void UpdateProgress(int percent, int i, int pos)
		{
			SetInfoText(progressBar1,percent.ToString());
			SetInfoText(txt_totalTs, (i+1).ToString());
			SetInfoText(txt_CurrentDownload, pos.ToString());
		}

		void UpdateInfo(string str)
		{
			SetInfoText(txt_Info,str);
			if (LiveVideoDownloader.first) {
				SetInfoText(this,str);
			}
		}
		LiveVideoDownloader downloader;
		string filePath = "C:/ZhanqiGaia";
		void Btn_SavePositionClick(object sender, EventArgs e)
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
		
		#region 跨线程更新txt_Info的Text属性
		
		delegate void SetTextCallback(Control ctr, string text);
		void SetInfoText(Control ctr, string text)
		{
			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			if (ctr.InvokeRequired) {//如果调用控件的线程和创建创建控件的线程不是同一个则为True
				while (!ctr.IsHandleCreated) {
					//解决窗体关闭时出现“访问已释放句柄“的异常
					if (ctr.Disposing || ctr.IsDisposed)
						return;
				}
				SetTextCallback d = new SetTextCallback(SetInfoText);
				ctr.Invoke(d, new object[] {ctr ,text });
			} else {
				if (ctr is Label) {
					(ctr as Label ).Text= text;
				}
				if (ctr is ProgressBar) {
					(ctr as ProgressBar).Value=Int32.Parse(text);
				}
				if (ctr is DownloadLive) {
					(ctr as DownloadLive).Text= text;
				}
				
			}
		}
	 
 
		#endregion
		
		void Btn_StartDownloadClick(object sender, EventArgs e)
		{
			downloader = null;
			if ( checkBox.Checked) {
				LiveVideoDownloader.merger=true;
			}
			else
				LiveVideoDownloader.merger=false;
			checkBox.Enabled=false;
			btn_StartDownload.Enabled=false;
			btn_StopDownload.Enabled=true;
			 
			txt_FilePath.Text = "当前保存位置为：" + filePath;
			downloader = new LiveVideoDownloader(filePath);
			downloader.Clear();
			downloader.DownloadUpdate += UpdateProgress;
			downloader.FinishATs += UpdateInfo;
			downloader.NotOnline +=GaiaNotOnline;
			downloader.UnKownHappen+=UnkownHappen;
			
			txt_Status.BackColor = Color.Lime;
			downloader.Start();
			
	
		}
		void Btn_StopDownloadClick(object sender, EventArgs e)
		{
	
			DownloadStop();
		}

		void GaiaNotOnline()
		{
			 
			UnkownHappen("大哥不在线");
		}

		void UnkownHappen(string str)
		{
			txt_Info.Text=str;			
				btn_StartDownload.Enabled=true;
			btn_StopDownload.Enabled=false;
			checkBox.Enabled=true;
			txt_Status.BackColor = Color.Gray;
		}
		void DownloadStop()
		{
			btn_StartDownload.Enabled=true;
			btn_StopDownload.Enabled=false;
			checkBox.Enabled=true;
			txt_Status.BackColor = Color.Gray;
			if (downloader.trytimer.Enabled) {
				downloader.trytimer.Stop();
				downloader.trytimer.Enabled=false;
	            downloader.cancle=true;
			}
			downloader.Stop();
			 
		}
		
		
		void Txt_StatusClick(object sender, EventArgs e)
		{
	
			SimpleMerger sm=new SimpleMerger();
			sm.Show();
		}
		void Txt_totalTsClick(object sender, EventArgs e)
		{
			ReviewMessage re=new ReviewMessage();
			re.Show();
	
		}
		 
		
		
	}
}
