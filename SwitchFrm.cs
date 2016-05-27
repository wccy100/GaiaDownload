/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/3/10 星期四
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HttpDemo
{
	/// <summary>
	/// Description of SwitchFrm.
	/// </summary>
	public partial class SwitchFrm : Form
	{
		public SwitchFrm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		TextBox edit_url;
		Label state;
		Downloader downloader;
		SelectOp selection;
		public enum SelectOp
		{
			LIVE,
			RECORD,
			PREVIOUS
		}
		void Btn_RecordClick(object sender, EventArgs e)
		{
			
			RecordSelect();
		}
		void RecordSelect()
		{
			selection = SelectOp.RECORD;
			btn_Previous.BackColor = SystemColors.Control;
			btn_Live.BackColor = SystemColors.Control;
			btn_Record.BackColor = Color.LimeGreen;
			panel_Main.Controls.Clear();
			edit_url = new TextBox();
			edit_url.Text = "http://www.zhanqi.tv/videos/xindong/2016/01/66977.html";
			edit_url.Location = new Point(18, 36);
			edit_url.Width = 442;
			edit_url.Height = 306;
			panel_Main.Controls.Add(edit_url);
		}
		void Btn_LiveClick(object sender, EventArgs e)
		{
			LiveSelect();
			
		}
		void LiveSelect()
		{
			selection = SelectOp.LIVE;
			btn_Previous.BackColor = SystemColors.Control;
			btn_Live.BackColor = Color.LimeGreen;
			btn_Record.BackColor = System.Drawing.SystemColors.Control;
			panel_Main.Controls.Clear();
			state = new Label();
			this.state.Location = new System.Drawing.Point(65, 30);
			this.state.Name = "lbl_live_info";
			this.state.Size = new System.Drawing.Size(330, 45);
			this.state.Text = "直播下载";
			this.state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			panel_Main.Controls.Add(state);
		}
		void Btn_PreviousClick(object sender, EventArgs e)
		{
			
			PreviousSelect();
		}
		void PreviousSelect()
		{
			selection = SelectOp.PREVIOUS;
			btn_Previous.BackColor = Color.LimeGreen;
			btn_Live.BackColor = System.Drawing.SystemColors.Control;
			btn_Record.BackColor = System.Drawing.SystemColors.Control;
			panel_Main.Controls.Clear();
			state = new Label();
			this.state.Location = new System.Drawing.Point(65, 30);
			this.state.Name = "lbl_previous_info";
			this.state.Size = new System.Drawing.Size(330, 45);
			this.state.Text = "回播下载,仅开播时有效,结束为0的时候，会有几率为全部下载，需要手动停止，8个为一分钟";
			this.state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			panel_Main.Controls.Add(state);
		}
		void Btn_startClick(object sender, EventArgs e)
		{
			downloader = null;
			lbl_info.Text = "当前保存位置为：" + filePath;
			btn_Live.Enabled = false;
			btn_Record.Enabled = false;
			btn_Previous.Enabled = false;
			btn_start.Enabled = false;
			btn_stop.Enabled = true;
			switch (selection) {
				case SelectOp.LIVE:
					LiveStart();
					break;
				case SelectOp.PREVIOUS:
					PreviousStart();
					break;
				case SelectOp.RECORD:
					RecordStart();
					break;
					
			}
			if (checkBox.Checked) {
				Downloader.merger = true;
			} else
				Downloader.merger = false;
			checkBox.Enabled = false;
			
			
		}
		
		#region Live Start
		void LiveStart()
		{
			downloader = new LiveVideoDownloader(filePath);
			downloader.Clear();
			((LiveVideoDownloader)downloader).DownloadUpdate += UpdateProgress;
			((LiveVideoDownloader)downloader).FinishATs += UpdateInfo;
			
			((LiveVideoDownloader)downloader).UnKownHappen += UnkownHappen;
			
			txt_Status.BackColor = Color.Lime;
			((LiveVideoDownloader)downloader).Start();
		}
		
		
		void UpdateProgress(int percent, int i, int pos)
		{
			SetInfoText(progressBar, percent.ToString());
			SetInfoText(txt_totalTs, (i + 1).ToString());
			SetInfoText(txt_CurrentDownload, pos.ToString());
		}
		void UpdateInfo(string str)
		{
			SetInfoText(lbl_info, str);
			if (Downloader.first) {
				SetInfoText(this, str);
			}
		}
		void UnkownHappen(string str)
		{
			lbl_info.Text = str;
			btn_start.Enabled = true;
			btn_stop.Enabled = false;
			checkBox.Enabled = true;
			txt_Status.BackColor = Color.Gray;
		}
		#endregion
		

		#region 回播下载
		void PreviousStart()
		{
			downloader = new DownloadPreviousVideo(filePath);
			((DownloadPreviousVideo)downloader).SetPosition += SetPosByWndPre;
			((DownloadPreviousVideo)downloader).FinishATs += UpdateInfo;
			((DownloadPreviousVideo)downloader).DownloadUpdate += UpdateProgress; 
			((DownloadPreviousVideo)downloader).Start();
			
		}
		bool SetPosByWndPre()
		{
			SetPositionFrm setpos = new SetPositionFrm();
			setpos.total = ((DownloadPreviousVideo)downloader).GetDlr().i;
			setpos.SetUnit();
			setpos.ShowDialog();
			
			string url = setpos.UrlGenerate();
			Downloader.filedir = setpos.fileDir;
			((DownloadPreviousVideo)downloader).videoUrl = url;
			if (setpos.Cancel) {
				btn_start.Enabled = true;
				btn_stop.Enabled = false;
				lbl_info.Text = "下载已经取消";
			}
			return setpos.Cancel;
		}

		#endregion
		
		
		
		#region Record Start
		void RecordStart()
		{
			downloader = new DownloadRecordVideo(filePath);
			((DownloadRecordVideo)downloader).SetPosition += SetPosByWnd;
			((DownloadRecordVideo)downloader).FinishATs += UpdateInfo;
			((DownloadRecordVideo)downloader).DownloadUpdate += UpdateProgress;
			((DownloadRecordVideo)downloader).record_url = edit_url.Text;
			((DownloadRecordVideo)downloader).Start();
		}

		
		bool SetPosByWnd()
		{
			SetPositionFrm setpos = new SetPositionFrm();
			setpos.total = ((DownloadRecordVideo)downloader).GetDlr().i;
			setpos.duration = ((DownloadRecordVideo)downloader).GetDuration();
			setpos.ShowDialog();
			((DownloadRecordVideo)downloader).GetDlr().SetPos(setpos.start, setpos.end);
			if (setpos.Cancel) {
				btn_start.Enabled = true;
				btn_stop.Enabled = false;
				lbl_info.Text = "下载已经取消";
			}
			return setpos.Cancel;
		}
		
		
		
		#endregion
		void Btn_stopClick(object sender, EventArgs e)
		{
			
			btn_Live.Enabled = true;
			btn_Record.Enabled = true;
			btn_Previous.Enabled = true;
			btn_start.Enabled = true;
			btn_stop.Enabled = false;
			switch (selection) {
				case SelectOp.LIVE:
					LiveStop();
					break;
				case SelectOp.PREVIOUS:
					PreviousStop();
					break;
				case SelectOp.RECORD:
					RecordStop();
					break;
					
			}
		}

		#region Live Stop
		void LiveStop()
		{
			DownloadStop();
		}
		void DownloadStop()
		{
			btn_start.Enabled = true;
			btn_stop.Enabled = false;
			checkBox.Enabled = true;
			txt_Status.BackColor = Color.Gray;
			if (((LiveVideoDownloader)downloader).trytimer.Enabled) {
				((LiveVideoDownloader)downloader).trytimer.Stop();
				((LiveVideoDownloader)downloader).trytimer.Enabled = false;
				((LiveVideoDownloader)downloader).count_try = 0;
				((LiveVideoDownloader)downloader).cancle = true;
			}
			((LiveVideoDownloader)downloader).Stop();
			
		}
		#endregion

		void PreviousStop()
		{
			((DownloadPreviousVideo)downloader).cancle = true;
		}

		void RecordStop()
		{
			((DownloadRecordVideo)downloader).cancle = true;
		}
		void SwitchFrmLoad(object sender, EventArgs e)
		{
			LiveSelect();
			TabIndex = 1;
			if (File.Exists("./set.in")) {
				filePath = File.ReadAllText("./set.in");
			}
			
			
		}
		string filePath = "C:/ZhanqiGaia";
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
				ctr.Invoke(d, new object[] { ctr, text });
			} else {
				if (ctr is Label) {
					(ctr as Label).Text = text;
				}
				if (ctr is ProgressBar) {
					(ctr as ProgressBar).Value = Int32.Parse(text);
				}
				if (ctr is SwitchFrm) {
					(ctr as SwitchFrm).Text = text;
				}
				
			}
		}
		
		#endregion
		
		
		void Btn_MergeClick(object sender, EventArgs e)
		{
			SimpleMerger sm = new SimpleMerger();
			sm.Show();
			
		}
		void SwitchFrmFormClosed(object sender, FormClosedEventArgs e)
		{
			if (filePath != "C:/ZhanqiGaia") {
				File.WriteAllText("./set.in", filePath);
			}
			
		}
		Fans fans;
		Thread th_fans;
		 
		void Txt_StatusClick(object sender, EventArgs e)
		{
			lbl_info.Text = "启动粉丝榜单中";
			txt_Status.Enabled = false;
			if (timer1.Enabled == false) {
				timer1.Start();
			}
			th_fans = new Thread(new ThreadStart(InitialFans));
			th_fans.Start();
			
		}
		WorkLogin worklog = new WorkLogin();
		void InitialFans()
		{
			JObject json = worklog.GetFans();
			if (json == null) {
				return;
			}
			fans = new Fans();
			JsonConvert.PopulateObject(json.ToString(), fans);
		
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if (th_fans != null && !th_fans.IsAlive) {
				FansBoard fb = new FansBoard();
			
				fb.SetFans(fans);
				fb.Show();
				txt_Status.Enabled = true;
				lbl_info.Text = "完成";
				timer1.Stop();
			}
		}
	}
	
	
}
