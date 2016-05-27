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
	/// Description of SetPosition.
	/// </summary>
	public partial class SetPositionFrm : Form
	{
		public SetPositionFrm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_ConfirmClick(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			fileDir = dt.Year + "-" + dt.Month + "-" + dt.Day + "-" + dt.Hour.ToString() + "@" + (dt.Minute-start ).ToString() +"@" + dt.Second+"到"+end+"分钟前";
			 
			Cancel=false;
			GetInput();
			this.Close();
			
		}
		public  bool Cancel=true;
		public int start=0;
		public int end=0;
		public double duration=0;
		public int  total=0;
		public void SetUnit( )
		{
			Preview=true;
			edit_end.Text="0";
			edit_start.Text="1";
			lbl_unit.Text="分钟前";
		}
		void GetInput()
		{
			try{
				start=int.Parse(edit_start.Text);
				end =int.Parse(edit_end.Text);
			}
			catch{
				if (Preview) {
					start=1;
					end=0;
				}
				else
				{
					start=0;
					end=10;
				}
			}
		}
		void Edit_startTextChanged(object sender, EventArgs e)
		{
			GetInput();
			if (Preview) {
				return;
			}
			lbl_info.Text="总数"+total+"  大约在"+ChangeToTime(start)+"到"+ChangeToTime(end);
		}
		public string fileDir;
		string ChangeToTime(int position)
		{
			double totaltime =  position * duration / 60 ;
			int hour = (int)(totaltime / 60);
			int minute = (int)(totaltime - hour * 60);
			return ""+hour+"小时:"+minute+"分钟前至";
		}
		void SetPositionLoad(object sender, EventArgs e)
		{
			if (Preview) {
				return;
			}
			lbl_info.Text="总数"+total+"   时长"+ChangeToTime(total);
			
		}
		bool Preview;
		
		string endtime;
		string starttime;
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
		public string UrlGenerate()
		{
			 
			string now;
			now=GetTimeStamp();
			GetInput();
			starttime = ( (int )(Int64.Parse(now) -  start * 60)).ToString();
			endtime=( (int)(Int64.Parse(now) -  end * 60-10)).ToString();
		 
			string url="http://dlhls.cdn.zhanqi.tv/zqreview/"+DownLoadLiveVideoUrl.texturl+"_1024.m3u8?starttime="+starttime+"&endtime="+endtime+"&stream_name=52320_RuIHA_1024&dnkey=52320_RuIHA";
						 
			this.Text="爱大哥";
			return url;
		}
		
	}
}
