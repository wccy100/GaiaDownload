/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/16/2016
 * Time: 20:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace HttpDemo
{
	/// <summary>
	/// Interaction logic for FansBoard.xaml
	/// </summary>
	public partial class FansBoard : Window
	{
		public FansBoard()
		{
			InitializeComponent();
		}
		Fans fans;
		public void SetFans(Fans fans)
		{
			this.fans=fans;
			InitialData();
			
		}

		void InitialData()
		{
			IList<Week> week=fans.data.week;
			IList<Total> total=fans.data.total;
			this.listBox.ItemsSource = week;
			this.listBox2.ItemsSource = total;
			string path="Pic/luoli1.jpg";
			BitmapImage image=LoadImage(path);
			
			background.Background=new ImageBrush( image);
		}
		BitmapImage LoadImage(string path)
		{
			StreamResourceInfo ifo= Application.GetResourceStream(new Uri(path,UriKind.Relative));
			Stream data=ifo.Stream;
			BitmapImage image=new BitmapImage();
			
			image.BeginInit();
			image.StreamSource=data;
			image.EndInit();
			data.Close();
			
			
			return image;
		}
		bool change=true;
		void background_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Title="大哥是萝莉！！" ;
			background.IsEnabled=false;
			string path;
			if (change) {
				path="Pic/luoli2.jpg";
			}
			else
				path="Pic/luoli1.jpg";
			
			
			var fadeoutAnimation=new DoubleAnimation() {
				From = 1,
				To = 0,
				Duration = TimeSpan.FromSeconds(2)
					
			};
			
			background.BeginAnimation(OpacityProperty,fadeoutAnimation);
			
			BitmapImage image=LoadImage(path);
			background.IsEnabled=true;;
			
			background.Background=new ImageBrush( image);
//			background.Background.Opacity=0;
			
			var showupAnimation=new DoubleAnimation() {
				From = 0,
				To = 1,
				Duration = TimeSpan.FromSeconds(1),
					FillBehavior=FillBehavior.HoldEnd
			};
			background.BeginAnimation(OpacityProperty,showupAnimation);
			change=!change;
			
		}
		static int count=0;
		void avatar_MouseDown(object sender, MouseButtonEventArgs e)
		{
			
			if (count>1) {
				return;
			}
			count++;
			UMessageBox.Show("Gaia","大哥是萝莉？");
			
		}
	}
	public class AvatarConVerter:IValueConverter
	{
		//单向绑定
		public object  Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			BitmapImage image=null;
			try {
				image = new BitmapImage(new Uri(value + "-big"));
				
			} catch (Exception) {
				StreamResourceInfo ifo= Application.GetResourceStream(new Uri("Pic/defaultavatar.png",UriKind.Relative));
				Stream data=ifo.Stream;
				image=new BitmapImage();
				
				image.BeginInit();
				image.StreamSource=data;
				image.EndInit();
				data.Close();
			}
			Button btn=new Button();
			btn.Width=60;
			btn.Height=60;
			
			btn.Background=new ImageBrush(image);
			return new VisualBrush(btn);
			
		}

		
		public object  ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}