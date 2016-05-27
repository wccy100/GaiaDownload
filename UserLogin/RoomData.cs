/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/7 星期日
 * Time: 16:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HttpDemo
{
	/// <summary>
	/// Description of RoomData.
	/// </summary>
	public class RoomData
	{
		public RoomData()
		{
		}
		public string pic_url="bpic";
		public Host host;
		public string fans="fans";
		public string fansTitle="";
		public string gameName="";
		public string nickName="";
		public string online="";
		public string title="";
		public string status;
	}
	public struct Host{
			public string fight;
			public string level;
			public string nextlevelfight;
			
		}
}
