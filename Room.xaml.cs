/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/8 星期一
 * Time: 19:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
 
 
namespace HttpDemo
{
	/// <summary>
	/// Interaction logic for Room.xaml
	/// </summary>
	public  partial class Room : Window
	{
		private GaiaRoom roodata;
		public Room()
		{
			InitializeComponent();
			
			
		}
		
		
		
		void Inital()
		{
			try {
				BitmapImage image = new BitmapImage(new Uri(roodata.data.avatar + "-big"));
				image_avatar.Source = image;
			} catch (Exception) {
				txt_info.Content = "图片加载出错";
				
			}
			
		 
			
		}
		public void SetRoomData(GaiaRoom roodata)
		{
			this.roodata = roodata;
//			Inital();
		}
		void window1_Loaded(object sender, RoutedEventArgs e)
		{
//			var appPath = AppDomain.CurrentDomain.BaseDirectory;
//			VlcContext.LibVlcDllsPath = appPath + @"VLC\";
//			//Set the vlc plugins directory path
//			VlcContext.LibVlcPluginsPath = appPath + @"plugins\";
//
//			//Set the startup options
//			VlcContext.StartupOptions.IgnoreConfig = true;
//			VlcContext.StartupOptions.LogOptions.LogInFile = false;
//			VlcContext.StartupOptions.LogOptions.ShowLoggerConsole = false;
//			VlcContext.StartupOptions.LogOptions.Verbosity = VlcLogVerbosities.None;
//
//			//Initialize the VlcContext
//			VlcContext.Initialize();
//
//			VlcControl myVlcControl = new VlcControl();
//			// 创建绑定，绑定Image
//			Binding bing = new Binding();
//			bing.Source = myVlcControl;
//			bing.Path = new PropertyPath("VideoSource");
//			img.SetBinding(Image.SourceProperty, bing);
//
//			//流媒体播放
//
//			var media=new LocationMedia("udp://@:ip:port");
//
//			myVlcControl.Play(media);
//
//			//本地播放
//
//			myVlcControl.Play(new PathMedia(添加本地视频路径));
//
//			//VlcContext.CloseAll();
		}
//		private void PlayerPause()
//		{
		////			SetPlayer(true);
//			if (playBtn.Content.ToString() == "Play") {
//				mediaElement.Play();
//				playBtn.Content = "Pause";
//				mediaElement.ToolTip = "Click to Pause";
//			} else {
//				mediaElement.Pause();
//				playBtn.Content = "Play";
//				mediaElement.ToolTip = "Click to Play";
//			}
//		}
//
//		void stopBtn_Click(object sender, RoutedEventArgs e)
//		{
//			mediaElement.Stop();
//		}
//		void backBtn_Click(object sender, RoutedEventArgs e)
//		{
//
//		}
//		void forwardBtn_Click(object sender, RoutedEventArgs e)
//		{
//
//		}
//
//
//		void openBtn_Click(object sender, RoutedEventArgs e)
//		{
//
//			string videoUrl = "http://dlhls.cdn.zhanqi.tv/zqlive/107134_pNTX2_1024";
//			mediaElement.Source = new Uri("C:/Users/young/Desktop/123.mkv");
//			playBtn.IsEnabled = true;
//
//		}
//		private void playBtn_Click(object sender, RoutedEventArgs e)
//		{
//			PlayerPause();
//		}
//
//		private void mediaElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
//		{
//			PlayerPause();
//		}
	}
}