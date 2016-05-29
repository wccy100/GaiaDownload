﻿/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/7 星期日
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HttpDemo.UserLogin;

namespace HttpDemo
{
	/// <summary>
	/// Description of WorkLogin.
	/// </summary>
	public class WorkLogin
	{
		public static bool Wrong = false;
		public static string Error;
		const int timeout = 500;
		const string user_agent = "Zhanqi.tv Api Client";
		string numcodekey;
		string numpicurl;
		public string gaia_message;
		const string loginurl = "http://www.zhanqi.tv/api/auth/user.login?";
		string capurl = "http://www.zhanqi.tv/api/auth/user.captcha";
		string userinfo_url = "http://www.zhanqi.tv/api/user/user.info";
		string user_follow = "http://www.zhanqi.tv/api/user/follow.listall?";
		string Gaia_room = "http://www.zhanqi.tv/api/static/live.roomid/52320.json";
		string user_coin = "http://www.zhanqi.tv/api/user/rich.get?";
		string fans_board="http://www.zhanqi.tv/api/static/room.fansweekrank/52320-10.json";
		string gaia_enter="http://www.zhanqi.tv/api/user/record.watch?type=1&id=52320";
		string sign_all="http://www.zhanqi.tv/api/actives/signin/fans.sign?";
		string follow_list="http://www.zhanqi.tv/api/user/follow.listall";
		string update="https://github.com/younghang/GaiaDownload/blob/master/gaiaupdate.txt";
		string get_room_view="http://www.zhanqi.tv/api/public/room.viewer?sid=t3rtnp7fl8fdhdneunks4975k0.C2D54228-3F07-F843-BAAD-B56C91E92C0F&ver=2.6.8&os=3";
		string log_out="http://www.zhanqi.tv/api/auth/user.logout?";
		string log_out2="http://www.zhanqi.tv/api/actives/task/info.promote";
		
		
		public WorkLogin()
		{
		}
		//获取验证码
		public string GetCapNumber()
		{
			
			HttpWebResponse response = HttpHelper.CreateGetHttpResponse(capurl, timeout, user_agent, null);
			string recievedata = HttpHelper.GetResponseString(response);
			JObject json = null;
			try {
				json = JObject.Parse(recievedata);
			} catch (Exception e) {
				throw new Exception("验证码获取出错\n" + e.Message);
				
			}
			if (json["code"].ToString() == "0") {
				numpicurl = json["data"]["img"].ToString();
				numcodekey = json["data"]["captchaKey"].ToString();
			}
		
			return numpicurl;
				
		}
		//登陆
		public JObject Login(string numCap, string userName, string passWord)
		{
			string numcap =numCap;
	 
			Dictionary<string,string> parameters = new Dictionary<string,string>();
//			parameters.Add("appVersion","2.6.1");

			parameters.Add("captcha", numcap);
			parameters.Add("password", passWord);
			parameters.Add("account", userName);
			parameters.Add("captchaKey", numcodekey);
			HttpWebResponse response = HttpHelper.CreatePostHttpResponse(loginurl, parameters, timeout, user_agent, null);
			
			string recievedata = HttpHelper.GetResponseString(response);
			JObject json = null;
			try {
				json = JObject.Parse(recievedata);
			} catch (Exception e) {
				throw new Exception("登陆出错\n" + e.Message);
			}
			return json;
			 
			 
		}
		//签到
		public JObject SignRoom(string roomID)
		{
			Dictionary <string ,string> parameters=new Dictionary<string,string >();
			parameters.Add("roomId",roomID);
			WebHeaderCollection header=new WebHeaderCollection();
			header.Add("os","3");
			header.Add("ver",HttpHelper.Version);
		  
			HttpWebResponse response = HttpHelper.CreatePostHttpResponse(sign_all, parameters, timeout, user_agent, null,false,true,header);
			string recievedata = HttpHelper.GetResponseString(response);
			JObject json = null;
			try {
				json = JObject.Parse(recievedata);
			} catch (Exception e) {
				throw new Exception("登陆出错\n" + e.Message);
			}
			json["message"]+=roomID;
			return json;
		}
		//用cookie登陆
		public void SimpleLogin(string userName, string passWord)
		{
			Dictionary<string,string> parameters = new Dictionary<string,string>();

 
			parameters.Add("password", passWord);
			parameters.Add("account", userName);
			HttpWebResponse response = HttpHelper.CreatePostHttpResponse(loginurl, parameters, timeout, user_agent, null,false);
		}
		
		//订阅列表		
		public JObject GetFollowList()
		{
			return GetUrlJson(follow_list);
		}
		//获取金币信息
		public JObject GetCoins()
		{
			return GetUrlJson(user_coin);
			
		}
				/// <summary>
		/// 检测更新 gaiaDownloadVersion=12#
		/// </summary>	 
		public string GetUpdate()
		{
			HttpWebResponse response = HttpHelper.CreateGetHttpResponse(update, timeout, null, null);	
		 
			string recievedata = HttpHelper.GetResponseString(response);
			string versionReg="gaiaDownloadVersion=[0-9]+#";
			string version=Regex.Match(recievedata, versionReg).Groups[0].Value;
			version=version.Split('=')[1];
			version=version.Substring(0,version.Length-1);
			return version;	 
		}
		
		//获取房间详细
		public RoomDetail GetRoomDetail()
		{
	 
			Dictionary <string ,int> parameters=new Dictionary<string,int >();
			parameters.Add("uid",107616417);
			WebHeaderCollection header=new WebHeaderCollection();		 
		  
			HttpWebResponse response = HttpHelper.CreatePostHttpResponseInt(get_room_view, parameters, timeout, null, null,false,true,header);
			string recievedata = HttpHelper.GetResponseString(response);
			JObject json = null;
			try {
			 	json = JObject.Parse(recievedata);
			} catch (Exception e) {
				throw new Exception("登陆出错\n" + e.Message);
			}
			RoomDetail roomdetail=new RoomDetail();
			 
			JsonConvert.PopulateObject(recievedata, roomdetail);
			return roomdetail ;
		 
		}
		
		//获取用户信息
		public 	JObject GetUserInfo()
		{ 
			return GetUrlJson(userinfo_url);
		}
		
		//获取粉丝信息
		public JObject GetFans()
		{
			return GetUrlJson(fans_board,false);
		}
		public JObject GetFollow()
		{
			return GetUrlJson(user_follow);
		}
		public JObject GetGaiaRoom()
		{
			return GetUrlJson(Gaia_room,false);
		}
		public RoomData InitialGaia()
		{
			JObject json = GetUrlJson(Gaia_room, false);
			if (json == null) {
				return null;
			}
			RoomData gaia_room = new RoomData();
			gaia_room.fans = json["data"]["fans"].ToString();
			gaia_room.fansTitle = json["data"]["fansTitle"].ToString();
			gaia_room.gameName = json["data"]["gameName"].ToString();
			gaia_room.nickName = json["data"]["nickname"].ToString();
			gaia_room.online = json["data"]["online"].ToString();
			gaia_room.pic_url = json["data"]["bpic"].ToString();
			gaia_room.title = json["data"]["title"].ToString();
			Host mhost = new Host();
			mhost.fight = json["data"]["anchorAttr"]["hots"]["fight"].ToString();
			mhost.level = json["data"]["anchorAttr"]["hots"]["level"].ToString();
			mhost.nextlevelfight = json["data"]["anchorAttr"]["hots"]["nextLevelFight"].ToString();
			
			gaia_room.host = mhost;
			gaia_room.status = json["data"]["status"].ToString();
			 
			return gaia_room;
			
		}
		public JObject LogOut()
		{
			
			HttpWebResponse response = HttpHelper.CreatePostHttpResponse(log_out,null ,timeout, user_agent, null);
			
			string recievedata = HttpHelper.GetResponseString(response);
			JObject json = null;
			try {
				json = JObject.Parse(recievedata);
			} catch (Exception e) {
				throw new Exception("登出出错\n" + e.Message);
			}
			Thread th=new Thread(new ParameterizedThreadStart((object str)=>GetUrlJson((string)str)));
			th.Start(log_out2);
			return json;
			
		}
		
		
		
		/// <summary>
		/// 获得cookie之后调用 Get方法
		/// </summary>
		/// <param name="url">Get的URL</param>
		/// <param name="needlogin">是否需要登陆 才能访问，默认需要true</param>
		/// <returns>返回JObject对象 出错返回null</returns>
		public JObject GetUrlJson(string url, bool needlogin = true)
		{
			HttpWebResponse response = HttpHelper.CreateGetHttpResponse(url, timeout, user_agent, null);
			if (needlogin) {
				if (HttpHelper.GetCookie().Count == 0)
					return null;
			}
		
			string recievedata = HttpHelper.GetResponseString(response);
			JObject json = null;
			try {
				json = JObject.Parse(recievedata);
			} catch (Exception e) {
//				throw new Exception("获取该命令的url出错 \n" + e.Message);
				Error=e.Message;
			}
			gaia_message=json["message"].ToString();
			if (  json["code"].ToString() == "0") {
				return json;	
			}
			Wrong = true;
			Error = json["message"].ToString();
			return null;
			
			
		}
	}
}
