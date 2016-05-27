/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/3/13 星期日
 * Time: 1:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Net;

namespace HttpDemo
{
	/// <summary>
	/// Description of DownloadPreviousVideoUrl.
	/// </summary>
	public class DownloadPreviousVideoUrl
	{
		public DownloadPreviousVideoUrl()
		{
		}
	}
	public class DownloadPreviousVideo :DownloadRecordVideo
	{
		public new  event CallToStopRecord SetPosition;
		public override void FinishAtsd(string str)
		{
			 FinishATs(str);
		}
		public override void Start()
		{
			if (SetPosition())
				return;
			GetDlr().Setlocal("http://dlhls.cdn.zhanqi.tv/zqreview/");
			base.DownloadVideoList();
			InitialFileDir();
			 
			DownLoadVedio();
		}
		public new event   FinishADownload FinishATs;
		protected override void FinishATShow(string str)
		{
			FinishATs(str);
		}
		public DownloadPreviousVideo(string filepath):base(filepath)
		{
			 
		}
		
		protected	  override void  DownLoadVedio()
		{
			
			if (cancle) {
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
	}
}
