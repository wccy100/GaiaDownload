/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/18 星期四
 * Time: 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HttpDemo
{
	/// <summary>
	/// Description of ReviewMessage.
	/// </summary>
	public partial class ReviewMessage : Form
	{
		public ReviewMessage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string endtime;
		string starttime;
		void Btn_generateReviewUrlClick(object sender, EventArgs e)
		{
			richTextBox1.Text="";
			endtime=GetTimeStamp();
			int start = (int)(Int64.Parse(endtime) - int.Parse(edit_Minute.Text) * 60);
			starttime=start.ToString();
			string url="http://dlhls.cdn.zhanqi.tv/zqreview/"+DownLoadLiveVideoUrl.texturl+"_1024.m3u8?starttime="+starttime+"&endtime="+endtime+"&stream_name=52320_RuIHA_1024&dnkey=52320_RuIHA";
	
			richTextBox1.Text=url;
			this.Text="爱大哥";
			
		}
			/// <summary>
		/// 获取当前时间戳
		/// </summary>
		/// <param name="bflag">为真时获取10位时间戳,为假时获取13位时间戳.</param>
		/// <returns></returns>
		public static string GetTimeStamp(bool bflag = true)
		{
			TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
			string ret = string.Empty;
			if (bflag)
				ret = Convert.ToInt64(ts.TotalSeconds).ToString();
			else
				ret = Convert.ToInt64(ts.TotalMilliseconds).ToString();
			
			return ret;
		}
	}
}
