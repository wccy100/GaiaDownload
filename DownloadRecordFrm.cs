/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/3/9 星期三
 * Time: 20:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HttpDemo
{
	/// <summary>
	/// Description of DownloadRecordFrm.
	/// </summary>
	public partial class DownloadRecordFrm : Form
	{
		public DownloadRecordFrm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		bool SetPosByWnd()
		{
			setpos.total=download.GetDlr().i;
			setpos.duration=download.GetDuration();
			setpos.ShowDialog();
			download.GetDlr().SetPos(setpos.start,setpos.end);
			return setpos.Cancel;
		}

		void UpdateInfo(string str)
		{
			  SetInfoText(lbl_info,str);
			 
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
				 
				
			}
		}
	 
 
		#endregion

		void ProgressUpdate(int percent, int i, int pos)
		{
			SetInfoText(progressBar_File,percent.ToString());
			SetInfoText(lbl_total, (i+1).ToString());
			SetInfoText(lbl_current, pos.ToString());
		}

		void Btn_startClick(object sender, EventArgs e)
		{
			
			download.SetPosition+=SetPosByWnd;
			download.FinishATs+=UpdateInfo;
			download.DownloadUpdate+=ProgressUpdate;
			download.record_url=edit_url.Text;
			download.Start();
		
			 
	
		}
		DownloadRecordVideo download=new DownloadRecordVideo();
		SetPositionFrm setpos=new SetPositionFrm();
		void Btn_stopClick(object sender, EventArgs e)
		{
	
			download.cancle=true;
		}
		void BTN_MID(object sender, EventArgs e)
		{
			SetPositionFrm set=new SetPositionFrm();
			set.MdiParent=this;
			set.Show();
	
		}
	}
}
