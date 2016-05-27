/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/16/2016
 * Time: 19:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HttpDemo
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			txt_content.Text="兴趣爱好。自学的一点点，比较不正规。\n\t以前大哥激萌的时候，担心明天看不到，战旗逗比又不一定给大哥录。于是自己自学，写个下载小软件可以下下来，方便点。\n\t\n\t点击GaiaStatus旁边的在线，再点开始就可以下载了。不设置目录默认在C:/ZhanqiGaia下面"+
				"\n\t点击开始 结束 就可以存一次当前视频片段。勾选合并会自动调用简单合并程序，否则直接下载原视频分段文件，直接下分段不会出问题。合并有可能崩溃，并丢失正在合并的视频\n\t"+
				"\n\t登陆后，点签到，可以随机找10个订阅的房间签到,服务器返回的Cookie会存在cookie.txt中，所以只要不登出，第二次不用输入验证码。自学的一点编程不够做其他。\n\t\n\t最好别长时间下载存视频，会有几率出错崩溃";
			

 
		}
	}
}
