/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/3/8 星期二
 * Time: 22:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;

namespace HttpDemo
{
	/// <summary>
	/// Description of RecordVideo.
	/// </summary>
	public class DownloadRecordVideoUrl :DownLoadUrl
	{
		public DownloadRecordVideoUrl()
		{
			local = "http://dlvod.cdn.zhanqi.tv";
		}
		public double duration;
		  double duration2;
		  double duration3;
		public override   void  AnalysisUrl(string str)
		{
			
			string[] strlist = str.Split('\n');
			for (int i = 0; i < strlist.Length; i++) {
				if (strlist[i].Contains("#EXTINF") && this.i < 8) {
					int ins = strlist[i].IndexOf(":") + 1;
					int end = strlist[i].Length;
					if (this.i==3 ) {
						duration = double.Parse(strlist[i].Substring(ins, end - ins - 1));
					}
					if (this.i==5) {
						duration2 = double.Parse(strlist[i].Substring(ins, end - ins - 1));
					}
					if (this.i ==7) {
						duration3 = double.Parse(strlist[i].Substring(ins, end - ins - 1));
					}
				 
					
				}
				if (strlist[i].Contains("SEQUENCE")) {
					string[] li = strlist[i].Split(':');
					timelength = li[1];
				}
				if (strlist[i].Contains(".ts")) {
					 
					string key = strlist[i];
					AddUrl(local + key);
					
				}
			}
			duration=(duration+duration2+duration3)/3;
		 
		}
		protected override void CallStartDownload()
		{
			StartDownload();
		}
		public event CallToDownload StartDownload;
		public void SetPos(int start, int end)
		{
			End = end;
			downloadpos = start+1;
		}
		public    int End;
		
	}
	
	
	public struct VideoInfo
	{
		public string videoUrl;
		public string dateDir;
		public string imagUrl;
		public string titleName;
		
	}
	public class DownloadRecordVideo :Downloader
	{
		 

		VideoInfo videoInfo = new VideoInfo();
		
		public void GetVideoInfo(string content)
		{
			string regtest = "<title>(.+)</title>";
			Match match =	Regex.Match(content, regtest);
			string title = match.Groups[0].Value;
			int titleend = title.Length - 15;
			
			title = title.Substring(7, titleend);
			
			string regpic = "bdPic\":\".+\\.jpg";
			string imag_url = Regex.Match(content, regpic).Groups[0].Value;
			imag_url = imag_url.Split('"')[2];
			string dirName = "2016-03-08-09-10";
			string dirReg = "\\d{4}-\\d{2}-\\d{2}-\\d{2}-\\d{2}";
			dirName = Regex.Match(title, dirReg).Groups[0].Value;
			
			string video_url;
			string videoReg = "VideoID\":.+\\.m3u8";
			video_url = Regex.Match(content, videoReg).Groups[0].Value;			
			video_url = String.Join("", video_url.Split('\\'));
		 
			video_url = Regex.Replace(video_url, "\"", "");
			video_url = "http://dlvod.cdn.zhanqi.tv" + video_url.Split(':')[1];
			
			videoInfo.dateDir = dirName;
			videoInfo.imagUrl = imag_url;
			videoInfo.titleName = title;
			videoInfo.videoUrl = video_url;
			
		}
		
		public bool cancle;
		public    event    CallToUpdateUI DownloadUpdate;
		public event FinishADownload FinishATs;
		public void Stop()
		{
			
			if (Directory.Exists(Downloader.filedir) && Directory.GetFiles(Downloader.filedir).Length == 0) {
				Directory.Delete(Downloader.filedir);
			}
		 
			
			if (!Downloader.downloading) {
				FinishAtsd("合并文件");
				this.FileTsDeal();
				FinishAtsd("下载完成");
			}
		}

		
		

		

		public double GetDuration()
		{
			return  ((DownloadRecordVideoUrl)dlr).duration ;
		}
		public string record_url;
		 
		void GetPic()
		{
			WebClient webClient = new WebClient();
 
			string text = Downloader.filedir + "/" + videoInfo.titleName + ".jpg";
			webClient.DownloadFileAsync(new Uri(videoInfo.imagUrl), text);
		}

		void GetInfo()
		{
			Console.WriteLine("解析地址");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(record_url);
			httpWebRequest.Method = "GET";
			WebResponse response;
			try {
				response = httpWebRequest.GetResponse();
			} catch (Exception) {
				 
				
				Console.WriteLine("biubiu连接出错");
				return;
			}
			string text;
			using (Stream responseStream = response.GetResponseStream()) {
				StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
				text = streamReader.ReadToEnd();
				content = text;
				Console.WriteLine("开始下载");
				
				 
			}
			
		}
		public event CallToStopRecord SetPosition;
		
		
		public DownloadRecordVideoUrl GetDlr()
		{
			return (DownloadRecordVideoUrl)dlr;
		}
		
		public virtual void Start()
		{
			GetInfo();
			GetVideoInfo(content);
			
			filedir = videoInfo.dateDir;
			InitialFileDir();
			videoUrl=videoInfo.videoUrl;
			DownloadVideoList();
			if(SetPosition())
				return;
			GetPic();
			DownLoadVedio();
//			((DownloadRecordVideoUrl)dlr).SetPos(start,end);
			
		
			
		}

		
		public DownloadRecordVideo(string filepath = "D:/Gaia")
		{
			filePath = filepath;
			dlr = new DownloadRecordVideoUrl();
			(dlr as DownloadRecordVideoUrl).StartDownload += new CallToDownload(this.DownLoadVedio);
		}

		

		public string videoUrl;
		
		public virtual void  FinishAtsd(string str)
		{
			if (FinishATs!=null) {
				FinishATs(str);
			}
		}
		
		protected   void DownloadVideoList()
		{
			FinishAtsd("准备下载");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(videoUrl);
			httpWebRequest.Method = "GET";
			WebResponse response;
			try {
				response = httpWebRequest.GetResponse();
			} catch (Exception) {
				FinishAtsd("获取视频列表失败");
				this.Stop();
				Console.WriteLine("biubiu");
				return;
			}
			string text;
			using (Stream responseStream = response.GetResponseStream()) {
				StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
				text = streamReader.ReadToEnd();
				
			FinishAtsd("添加视频地址中");
				
				
			}
			this.PushToDownloadUrl(text);
		}

		string content;
		private void PushToDownloadUrl(string str)
		{
			((DownloadRecordVideoUrl)dlr).AnalysisUrl(str);
			
			
		}

		
		protected virtual void DownLoadVedio()
		{
			
			if (cancle) {
				Stop();
				return;
			}
			if (dlr.downloadpos < ((DownloadRecordVideoUrl)dlr).End) {
			 
			} else {
				Stop();
				return;
			}
			
			if (!dlr.Hasurl()) {
				return;
			}
			string oneLink = dlr.GetOneLink();
			
			int num4 = oneLink.IndexOf('$');
			this.fileName = oneLink.Substring(0, num4);
			string uriString = oneLink.Substring(num4 + 1, oneLink.Length - num4 - 1);
			WebClient webClient = new WebClient();
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.ProgressChanged);
			string text = Downloader.filedir + "/" + this.fileName + ".ts";
			webClient.DownloadFileAsync(new Uri(uriString), text);
			Downloader.first = false;
		}

		protected void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			Downloader.first = true;
			Downloader.downloading = true;
			
			DownloadUpdate(e.ProgressPercentage, dlr.i, dlr.downloadpos);
		}
		protected override void FinishATShow(string str)
		{
			FinishAtsd(str);
		}

		protected void Completed(object sender, AsyncCompletedEventArgs e)
		{
			FinishAtsd("文件" + fileName + "已经下载好了");
			Downloader.downloading = false;
			if (dlr.Hasurl()) {
				this.DownLoadVedio();
			}
			else
			{
				FileTsDeal();
			}
			
			
			
		}
	}
	
	
	
}
