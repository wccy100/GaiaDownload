/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/17/2016
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HttpDemo
{
	/// <summary>
	/// Description of Setting.
	/// </summary>
	public partial class Setting : Form
	{
		public Setting()
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
			HttpHelper.Version=edit_version.Text;
			HttpHelper.Imei=edit_Imei.Text;
			this.Close();
	
		}
	}
}
