/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/15/2016
 * Time: 18:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Timers;
using System.Linq;

namespace HttpDemo
{
	/// <summary>
	/// 负责管理下载视频的地址
	/// </summary>
	public class DownLoadLiveVideoUrl:DownLoadUrl
	{
		Dictionary<int ,string > dic = new  Dictionary<int ,string >();
		public DownLoadLiveVideoUrl()
		{
			local="http://dlhls.cdn.zhanqi.tv/zqlive/" + texturl + "_1024/";
		}
		//		 videoId=75835_YKlQ8   videoId=102152_R1tO7  52320_RuIHA
		
		public override  void   AnalysisUrl(string str)
		{
			string[] strlist = str.Split('\n');
			for (int i = 0; i < strlist.Length; i++) {
				if (strlist[i].Contains("TARGETDURATION")) {
					int ins = strlist[i].IndexOf(":") + 1;
					int end = strlist[i].Length;
					duration = strlist[i].Substring(ins, end - ins);
				}
				if (strlist[i].Contains(".ts")) {
					 
					string key = strlist[i] ;
					AddUrl(local + key);
					
				}
			}
			
			StartDownload();
			
		}
		public event CallToDownload StartDownload;
		
//	人艰不拆	113103_ztJCn  大哥  52320_RuIHA  81老爷 112398_1YT4X
		public  static string texturl = "52320_RuIHA";
		
		
		//		const  string local="http://dlhls.cdn.zhanqi.tv/zqlive/52320_RuIHA_1024/";
		
		
	}

	public delegate void CallToDownload();
	public delegate void UnKownWrongHappen(string str);
	public delegate void CallToStop();
	public delegate bool CallToStopRecord();
	public delegate void CallToUpdateUI(int percent, int i, int pos);
	public delegate void FinishADownload(string str);
	/// <summary>
	/// 负责下载视频
	/// </summary>
	public class LiveVideoDownloader :Downloader
	{
		
		public  bool cancle=false;	
		public    event    FinishADownload FinishATs;
		Timer timer = new System.Timers.Timer();
		public Timer trytimer = new Timer();
		protected override void FinishATShow(string str)
		{
			
			FinishATs(str);
		}
		public void Stop()
		{
			if (timer != null) {
				timer.Stop();
			}
			
			
			//慎重点
			if (Directory.Exists(filedir) && Directory.GetFiles(filedir).Length == 0) {
				Directory.Delete(filedir);
			}
			
			if (WrongConnect) {
				if (cancle==true) {
					cancle=false;
					count_try=0;
					FinishATs("已停止，完成");
					
				}
				else
				{
					FinishATs("不在线 或者 连接异常.尝试重新连接 1分钟");
					Retry();
					return;
				}
				
			}
			
			if (notOnline) {
				FinishATs("不在线。尝试合并文件，可能失败，单击0.0可以打开简单合并程序");
				
				
			}
			if (!dlr.Hasurl() && !downloading) {
				if (safecount==0) {
					FileTsDeal();
				}				
			}						
		}
		

		public   int count_try = 0;
		void Retry()
		{
			
			if (count_try > 6 || trytimer.Enabled) {
				FinishATs("重试次数" + count_try+"。   你可以点停止了0.0");
				return;
			}
			if (!trytimer.Enabled) {
				trytimer.Interval = 10 * 1000;
				trytimer.Elapsed += TickTry;
				trytimer.Start();
			}
						
		}

		void TickTry(object sender, EventArgs e)
		{
			
			if (count_try >= 6 || !WrongConnect) {
				trytimer.Stop();
				
				if (count_try >= 6) {
					downloading=false;
					UnKownHappen("连接异常,重试没结果。大哥不在线,可以关闭");
					FinishATs("合并文件");
					if (safecount==0&&downloading==false) {
						FileTsDeal();
					}
					
					return;
				}
				else
				{
					count_try = 0;
					DownloadVideoList();
					return;
				}
							
			}
			count_try++;
			DownloadVideoList();
					
		}
						
		public void Start()
		{
			notOnline = false;
			WrongConnect = false;
			DateTime dt = DateTime.Now;
			filedir = dt.Year + "-" + dt.Month + "-" + dt.Day + "-" + dt.Hour.ToString() + "@" + dt.Minute.ToString() + "@" + dt.Second;
			
			
			filedir = filePath + "/" + filedir;
			if (!Directory.Exists(filedir)) {
				Directory.CreateDirectory(filedir);
			}
			
			if (timer == null) {
				timer = new Timer();
			}
			timer.Interval = 2 * 1000;
			timer.Start();
			
			
		}
		
		
		public event CallToStop NotOnline;
		public event CallToUpdateUI DownloadUpdate;
		
		public event UnKownWrongHappen UnKownHappen;
		
		public LiveVideoDownloader(string filepath = "D:/Gaia")
		{
			
			dlr = new DownLoadLiveVideoUrl();
			filePath = filepath;
			timer.Elapsed += DownloadVideoList;
			
			((DownLoadLiveVideoUrl)dlr).StartDownload += DownLoadVedio;
		}
		static bool notOnline = false;
		static bool WrongConnect;
		
		string videoList = "http://dlhls.cdn.zhanqi.tv/zqlive/" + DownLoadLiveVideoUrl.texturl + "_1024/index.m3u8";
		
		
		void DownloadVideoList(object sender, ElapsedEventArgs e)
		{
			DownloadVideoList();
		}
		
		void DownloadVideoList()
		{
			Console.WriteLine("准备下载");
			if (WrongConnect) {
				FinishATs("连接重试");
			}
			string str;
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(videoList);
			request.Method = "GET";
			WebResponse response;
			try {
				response = request.GetResponse();
			} catch (Exception) {
				WrongConnect = true;
				Stop();
				
				Console.WriteLine("biubiu");
				return;
			}
			
			
			using (Stream s = response.GetResponseStream()) {
				StreamReader reader = new StreamReader(s, Encoding.UTF8);
				str = reader.ReadToEnd();
				if (WrongConnect) {
					FinishATs("恢复连接成功");
					WrongConnect = false;
					trytimer.Stop();
					count_try=0;
					timer.Interval=10*1000;
					timer.Start();
				}
				
				#region 检查在不在？这个好像没有用
				if (str.Contains("#EXT"))
					Console.WriteLine("开始下载");
				else {
					
					notOnline = true;
					Stop();
					NotOnline();
					return;
				}
				#endregion
				notOnline = false;
				
				 

			}
			
			PushToDownloadUrl(str);
			
		}

		void PushToDownloadUrl(string str)
		{
			dlr.AnalysisUrl(str);
			if (string.IsNullOrEmpty(dlr.duration)) {
				return;
			}
			timer.Interval = 1400 * Double.Parse(dlr.duration);
			
		}
		
		void DownLoadVedio()
		{
			if (first) {
				try {
					int time = Int32.Parse(dlr.timelength) * Int32.Parse(dlr.duration) / 60;
					int hour = time / 60;
					int minute = time - hour * 60;
					FinishATs("已经直播时间：" + hour + "小时" + minute + "分钟");
					// disable once EmptyGeneralCatchClause
				} catch (Exception) {
					
					
				}
				
			}
			if (!dlr.Hasurl()) {
				return;
			}
			string str = dlr.GetOneLink();
			safecount++;
			if (str ==null) {
				return;
			}
			downloading=true;
			dlr.RemoveUrl(dlr.downloadpos - 30);
			int split = str.IndexOf('$');
			fileName = str.Substring(0, split);
			string url = str.Substring(split + 1, str.Length - split - 1);
			using (	WebClient webClient = new WebClient()){
			
		
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
			string fileLocal = filedir + "/" + fileName + ".ts";
			webClient.DownloadFileAsync(new Uri(url), fileLocal);
			
			}
			first = false;
		}
		
		
		void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			first = true;
			downloading = true;
			DownloadUpdate(e.ProgressPercentage, dlr.i, dlr.downloadpos);
		}
		void Completed(object sender, AsyncCompletedEventArgs e)
		{
			safecount--;
			if (e.Error!=null) {
				
				return;
			}
			if(WrongConnect)
				return;
			FinishATs("文件" + fileName + "已经下载好了");
			downloading = false;
			if (dlr.Hasurl()) {
				DownLoadVedio();
				
			} else if (!timer.Enabled  ) {
				
				if(safecount==0)
				FileTsDeal();
				else
					FinishATs("等待");
			}
			
			
			
		}
	}
}
