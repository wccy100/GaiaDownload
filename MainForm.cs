/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/7 星期日
 * Time: 9:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HttpDemo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm :Form
	{
		Room room;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			if (checkUpdateThread==null||!checkUpdateThread.IsAlive) {
				checkUpdateThread=new Thread(new ThreadStart(()=>{
				                                             	try{
				                                             		int NewVersion= int.Parse(worklog.GetUpdate());
				                                             		if (NewVersion>DVersion) {
				                                             				MessageBox.Show("有新版本，请去贴吧下载，扬co发的女王那个贴子或者这里http://yun.baidu.com/share/link?shareid=3067013852&uk=3514645625");
				                                               	
				                                             			SetInfoText("有新版本，请去贴吧下载，扬co发的女王那个贴子");
				                                             		}
				                                             		else
				                                             			SetInfoText("没有更新");
				                                             	}
				                                             	catch{SetInfoText("检查更新失败");}
				                                             }));
			}
			checkUpdateThread.Start();
		}
		Thread checkUpdateThread;
		WorkLogin worklog = new WorkLogin();
		int DVersion=12;
		
		
		public void Run()
		{
			string numpicurl = worklog.GetCapNumber();
			
			pictureNum.ImageLocation = numpicurl;
			
		}

		void DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker bw = sender as BackgroundWorker;
			
			if (bw.CancellationPending) {
				e.Cancel = true;
				
			}
			RoomData roomdata = worklog.InitialGaia();
			JObject json = worklog.GetUserInfo();
			JObject jsoncoin = worklog.GetCoins();
			mytemp = new MyTemp(json, jsoncoin, roomdata);
			e.Result = mytemp;
			
			
		}
		
		private MyTemp mytemp;
		
		
		void CompletedWork(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null) {
				MessageBox.Show("Error");
			} else if (e.Cancelled) {
				MessageBox.Show("Canceled");
			} else {
				MyTemp my = (MyTemp)e.Result;
				GetGaiaStatus(my.roomdata);
				
				
				GetUserInfo(my.json, my.jsoncoin);
				
				btn_LoadUserInfo.Enabled = true;
			}
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			
			
		}
		
		void Btn_Login(object sender, EventArgs e)
		{
			
			
			LogIn();
			
			
		}
		void LogIn()
		{
			btn_Login.Enabled = false;
			string numcap = edit_num.Text;
			string userName = edit_userName.Text;
			string userPass = edit_password.Text;
			JObject json = worklog.Login(numcap, userName, userPass);
			Run();
			if (json == null || json["code"].ToString() != "0") {
				txt_userName.BackColor = System.Drawing.Color.Gray;
				txt_userName.Text = json["message"].ToString();
				btn_Login.Enabled = true;
				
				return;
			}
			GetUserInfo(json);
			File.WriteAllText("./UserNameAndPassword.txt", userName + '$' + userPass);
			
		}
		
		
		
		void PictureNumClick(object sender, EventArgs e)
		{
			Run();
			
		}
		void GetUserInfo(JObject mjson = null, JObject mjsoncoin = null)
		{
			
			JObject json;
			if (mjson != null) {
				json = mjson;
			} else
				json = worklog.GetUserInfo();
			if (json == null) {
				txt_userName.BackColor = System.Drawing.Color.Gray;
				txt_userName.Text = WorkLogin.Error;
				return;
			}
			string a=json.ToString();
			string avatarpicurl = json["data"]["avatar"].ToString();
			string accountName = json["data"]["nickname"].ToString();
			string experience = json["data"]["slevel"]["curexp"].ToString();
			avatarpicurl = avatarpicurl + "-big";
			pictureAvatar.ImageLocation = avatarpicurl;
			
			txt_userName.Text = accountName;
			txt_experience.Text = experience;
			
			JObject jsoncoin;
			if (mjsoncoin != null) {
				jsoncoin = mjsoncoin;
			} else
				jsoncoin = worklog.GetCoins();
			if (jsoncoin == null) {
				txt_userName.BackColor = System.Drawing.Color.Gray;
				txt_userName.Text = WorkLogin.Error;
				return;
			}
			string zqcoin = jsoncoin["data"]["coin"]["count"].ToString();
			string goldcoin = jsoncoin["data"]["gold"]["count"].ToString();
			
			txt_zqcoin.Text = zqcoin;
			txt_goldcoin.Text = goldcoin;
			txt_userName.BackColor = Color.LimeGreen;
			
			
			txt_showInfo.Text = json["message"].ToString();
			
			
			
			
		}
		
		void Btn_Fresh(object sender, EventArgs e)
		{
			btn_LoadUserInfo.Enabled = false;
			
			m_BackgroundWorker.RunWorkerAsync(this);
			
		}
		
		
		
		void GetGaiaStatus(RoomData roomdata = null)
		{
			if (roomdata == null) {
				roomdata = worklog.InitialGaia();
			}
			
			if (roomdata != null && roomdata.status == "4") {
				txt_gaiaStatus.BackColor = Color.Lime;
				txt_gaiaStatus.Text = "在线";
			} else {
				txt_gaiaStatus.BackColor = Color.Silver;
				
				txt_gaiaStatus.Text = "不在线";
				
			}
			txt_onlines.Text = roomdata.online;
			txt_showInfo.Text = worklog.gaia_message;
		}
		void Btn_LogOut(object sender, EventArgs e)
		{
			btn_Logout.Enabled = false;
			JObject json = worklog.LogOut();
			if (json != null) {
				txt_showInfo.Text = json["message"].ToString();
				txt_userName.BackColor = Color.Gray;
			} else
				txt_showInfo.Text = "登出出错";
			btn_Logout.Enabled = true;
			LogClear();
		}
		void LogClear()
		{
			txt_cookie.BackColor = Color.Gray;
			btn_Login.Enabled = true;
			if (File.Exists("./cookie.txt"))
				File.Delete("./cookie.txt");
			if (File.Exists("./UserNameAndPassword.txt"))
				File.Delete("./UserNameAndPassword.txt");
		}
		void Txt_cookieClick(object sender, EventArgs e)
		{
			LogClear();		
			
		}
		void Txt_gaiaStatusClick(object sender, EventArgs e)
		{
 
			SwitchFrm li = new SwitchFrm();
			li.Show();
			
			
		}
		void Btn_testClick(object sender, EventArgs e)
		{
//			JObject json = worklog.SignRoom("52320");
//			if (json == null) {
//				return;
//			}
//			string strjson=json.ToString();
//			Fans fans=new Fans();
//			JsonConvert.PopulateObject(strjson, fans);
//			string str=fans.message;
			
//			JObject json=worklog.GetGaiaRoom();
//			if (json==null) {
//				return;
//			}
//			string strjson=json.ToString();
//			GaiaRoom fans=new GaiaRoom();
//			JsonConvert.PopulateObject(strjson, fans);
//			string str=fans.message;
//			string str = json["message"].ToString();
//			txt_showInfo.Text = str;
			
			About an = new About();
			an.Show();
		}
		void Btn_signClick(object sender, EventArgs e)
		{
//			Thread th=new Thread(new ParameterizedThreadStart((object str)=>GetUrlJson((string)str)));
//			th.Start(log_out2);
//			txt_showInfo.BeginInvoke(new SignRoom(SignInThread));
			
			Thread th = new Thread(new ThreadStart(SignAllRoom));
			th.Start();
			
			
		}
		
		#region 跨线程更新txt_showInfo的Text属性
		
		delegate void SetTextCallback(string text);
		void SetInfoText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.txt_showInfo.InvokeRequired) {//如果调用控件的线程和创建创建控件的线程不是同一个则为True
				while (!this.txt_showInfo.IsHandleCreated) {
					//解决窗体关闭时出现“访问已释放句柄“的异常
					if (this.txt_showInfo.Disposing || this.txt_showInfo.IsDisposed)
						return;
				}
				SetTextCallback d = new SetTextCallback(SetInfoText);
				this.txt_showInfo.Invoke(d, new object[] { text });
			} else {
				this.txt_showInfo.Text = text;
			}
		}
		
		void SignAllRoom()
		{
			JObject json = worklog.GetFollow();
			if (json == null) {
				return;
			}
			string strinfo = json["message"].ToString();
			SetInfoText(strinfo);
			MyFollow follow = new MyFollow();
			
			
			JsonConvert.PopulateObject(json.ToString(), follow);
			IList<Datum> list = follow.data;
			for (int i = 0; i < list.Count; i++) {
				SignARoom(list[i].roomId);
				if (signCount >= 10) {
					break;
				}
				
			}
		}
		void SignARoom(string roomID)
		{
			JObject json = worklog.SignRoom(roomID);
			if (json == null) {
				return;
			}
			string str = json["message"].ToString();
			if (str == "SUCCESS") {
				signCount++;
			}
			SetInfoText(str);
			
			
		}
		#endregion
		static int signCount = 0;
		Fans fans;
		Thread th_fans;
		void Lbl_FansClick(object sender, EventArgs e)
		{
			
			txt_showInfo.Text="启动粉丝榜单中";
			lbl_Fans.Enabled=false;
			if (timer1.Enabled==false) {
				timer1.Start();
			}
			  th_fans = new Thread(new ThreadStart(InitialFans));
			th_fans.Start();
			
			
			
		}
		
		void InitialFans()
		{
			JObject json = worklog.GetFans();
			if (json == null) {
				return;
			}
			fans=new Fans();
			JsonConvert.PopulateObject(json.ToString(), fans);
		
		}
		void MainFormLoad(object sender, EventArgs e)
		{		
			
			if (HttpHelper.LoadCookie()) {
				txt_cookie.BackColor = Color.Lime;
				btn_Login.Enabled = false;
				if (File.Exists("./UserNameAndPassword.txt")) {
					string log = File.ReadAllText("./UserNameAndPassword.txt");
					string[] lgs = log.Split('$');
					string userName = lgs[0];
					string userPass = lgs[1];
					worklog.SimpleLogin(userName, userPass);
				
					GetUserInfo();
				}
		
			}
			if (HttpHelper.GetCookie().Count != 0) {
				m_BackgroundWorker.RunWorkerAsync(this);
			} else {
				Run();
				GetGaiaStatus(null);
			}
			
			m_BackgroundWorker.WorkerReportsProgress = true; // 设置可以通告进度
			m_BackgroundWorker.WorkerSupportsCancellation = true; // 设置可以取消
			
			m_BackgroundWorker.DoWork += new DoWorkEventHandler(DoWork);
//			m_BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgress);
			m_BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompletedWork);

//		*/
		}
		void Timer1Tick(object sender, EventArgs e)
		{
	
			if (th_fans!=null&&!th_fans.IsAlive) {
				FansBoard fb=new FansBoard();
			
			fb.SetFans(fans);
			fb.Show();
			lbl_Fans.Enabled=true;
			txt_showInfo.Text="完成";
			timer1.Stop();
			}
		}
		void Txt_onlinesClick(object sender, EventArgs e)
		{
			Setting setting=new Setting();
			setting.ShowDialog();
	
		}
	}
	public class MyTemp
	{
		public 	MyTemp(JObject json,
			JObject jsoncoin,
			RoomData roomdata)
		{
			
			this.json = json;
			this.jsoncoin = jsoncoin;
			this.roomdata = roomdata;
		}
		
		
		public JObject json;
		public JObject jsoncoin;
		public RoomData roomdata;
	}
}
