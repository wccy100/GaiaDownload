﻿/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/17/2016
 * Time: 15:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace HttpDemo
{
	/// <summary>
	/// Interaction logic for UMessageBox.xaml
	/// </summary>
	public partial class UMessageBox : Window
	{
		/// <summary>

		/// 禁止在外部实例化

		/// </summary>

		private UMessageBox()

		{

			InitializeComponent();

		}



		public new string Title

		{

			get { return this.lblTitle.Text; }

			set { this.lblTitle.Text = value; }

		}



		public string Message

		{

			get { return this.lblMsg.Text; }

			set { this.lblMsg.Text = value; }

		}



		/// <summary>

		/// 静态方法 模拟MESSAGEBOX.Show方法

		/// </summary>

		/// <param name="title">标题</param>

		/// <param name="msg">消息</param>

		/// <returns></returns>

		public static bool? Show(string title,string msg)

		{

			var msgBox = new UMessageBox();

			msgBox.Title = title;

			msgBox.Message = msg;

			return msgBox.ShowDialog();

		}



		private void Yes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)

		{

			this.DialogResult = true;

			this.Close();

		}





		private void No_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)

		{

			this.DialogResult = false;

			this.Close();

		}
	}
}