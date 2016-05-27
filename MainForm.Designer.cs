/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/7 星期日
 * Time: 9:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class MainForm  
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureAvatar;
		private System.Windows.Forms.PictureBox pictureNum;
		private System.Windows.Forms.TextBox edit_userName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edit_password;
		private System.Windows.Forms.Label txt_userName;
		private System.Windows.Forms.TextBox edit_num;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Button btn_LoadUserInfo;
		private System.Windows.Forms.Label txt_showInfo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label txt_zqcoin;
		private System.Windows.Forms.Label txt_onlines;
		private System.Windows.Forms.Label txt_goldcoin;
		private System.Windows.Forms.Label txt_gaiaStatus;
		private System.Windows.Forms.Label lbl_Fans;
		private System.Windows.Forms.Label txt_experience_show;
		private System.Windows.Forms.Label txt_experience;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Logout;
		private System.ComponentModel.BackgroundWorker m_BackgroundWorker;
		private System.Windows.Forms.Label txt_cookie;
		private System.Windows.Forms.Button btn_test;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureAvatar = new System.Windows.Forms.PictureBox();
			this.pictureNum = new System.Windows.Forms.PictureBox();
			this.edit_userName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.edit_password = new System.Windows.Forms.TextBox();
			this.txt_userName = new System.Windows.Forms.Label();
			this.edit_num = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_LoadUserInfo = new System.Windows.Forms.Button();
			this.txt_showInfo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_zqcoin = new System.Windows.Forms.Label();
			this.txt_onlines = new System.Windows.Forms.Label();
			this.txt_goldcoin = new System.Windows.Forms.Label();
			this.txt_gaiaStatus = new System.Windows.Forms.Label();
			this.lbl_Fans = new System.Windows.Forms.Label();
			this.txt_experience_show = new System.Windows.Forms.Label();
			this.txt_experience = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Logout = new System.Windows.Forms.Button();
			this.m_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.txt_cookie = new System.Windows.Forms.Label();
			this.btn_test = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureNum)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureAvatar
			// 
			this.pictureAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureAvatar.Location = new System.Drawing.Point(462, 0);
			this.pictureAvatar.MaximumSize = new System.Drawing.Size(80, 80);
			this.pictureAvatar.Name = "pictureAvatar";
			this.pictureAvatar.Size = new System.Drawing.Size(76, 76);
			this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureAvatar.TabIndex = 0;
			this.pictureAvatar.TabStop = false;
			this.pictureAvatar.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pictureNum
			// 
			this.pictureNum.Location = new System.Drawing.Point(12, 83);
			this.pictureNum.Name = "pictureNum";
			this.pictureNum.Size = new System.Drawing.Size(100, 50);
			this.pictureNum.TabIndex = 1;
			this.pictureNum.TabStop = false;
			this.pictureNum.Click += new System.EventHandler(this.PictureNumClick);
			// 
			// edit_userName
			// 
			this.edit_userName.Location = new System.Drawing.Point(119, 12);
			this.edit_userName.Name = "edit_userName";
			this.edit_userName.Size = new System.Drawing.Size(100, 21);
			this.edit_userName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "号码：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "密码：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edit_password
			// 
			this.edit_password.Location = new System.Drawing.Point(119, 42);
			this.edit_password.Name = "edit_password";
			this.edit_password.Size = new System.Drawing.Size(100, 21);
			this.edit_password.TabIndex = 2;
			// 
			// txt_userName
			// 
			this.txt_userName.Location = new System.Drawing.Point(439, 83);
			this.txt_userName.Name = "txt_userName";
			this.txt_userName.Size = new System.Drawing.Size(100, 23);
			this.txt_userName.TabIndex = 3;
			this.txt_userName.Text = "UserName";
			this.txt_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edit_num
			// 
			this.edit_num.Location = new System.Drawing.Point(118, 83);
			this.edit_num.Name = "edit_num";
			this.edit_num.Size = new System.Drawing.Size(100, 21);
			this.edit_num.TabIndex = 2;
			this.edit_num.Text = "验证码";
			// 
			// btn_Login
			// 
			this.btn_Login.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_Login.FlatAppearance.BorderSize = 0;
			this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Login.Location = new System.Drawing.Point(133, 110);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(75, 23);
			this.btn_Login.TabIndex = 4;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = false;
			this.btn_Login.Click += new System.EventHandler(this.Btn_Login);
			// 
			// btn_LoadUserInfo
			// 
			this.btn_LoadUserInfo.BackColor = System.Drawing.Color.LightGreen;
			this.btn_LoadUserInfo.FlatAppearance.BorderSize = 0;
			this.btn_LoadUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_LoadUserInfo.Location = new System.Drawing.Point(463, 189);
			this.btn_LoadUserInfo.Name = "btn_LoadUserInfo";
			this.btn_LoadUserInfo.Size = new System.Drawing.Size(75, 23);
			this.btn_LoadUserInfo.TabIndex = 4;
			this.btn_LoadUserInfo.Text = "刷新";
			this.btn_LoadUserInfo.UseVisualStyleBackColor = false;
			this.btn_LoadUserInfo.Click += new System.EventHandler(this.Btn_Fresh);
			// 
			// txt_showInfo
			// 
			this.txt_showInfo.Location = new System.Drawing.Point(1, 215);
			this.txt_showInfo.Name = "txt_showInfo";
			this.txt_showInfo.Size = new System.Drawing.Size(537, 34);
			this.txt_showInfo.TabIndex = 5;
			this.txt_showInfo.Text = "状态。。";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(302, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "战旗币";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_zqcoin
			// 
			this.txt_zqcoin.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.txt_zqcoin.Location = new System.Drawing.Point(366, 12);
			this.txt_zqcoin.Name = "txt_zqcoin";
			this.txt_zqcoin.Size = new System.Drawing.Size(58, 23);
			this.txt_zqcoin.TabIndex = 3;
			this.txt_zqcoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_onlines
			// 
			this.txt_onlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.txt_onlines.Location = new System.Drawing.Point(327, 143);
			this.txt_onlines.Name = "txt_onlines";
			this.txt_onlines.Size = new System.Drawing.Size(58, 23);
			this.txt_onlines.TabIndex = 3;
			this.txt_onlines.Text = "0.0";
			this.txt_onlines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txt_onlines.Click += new System.EventHandler(this.Txt_onlinesClick);
			// 
			// txt_goldcoin
			// 
			this.txt_goldcoin.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_goldcoin.Location = new System.Drawing.Point(366, 52);
			this.txt_goldcoin.Name = "txt_goldcoin";
			this.txt_goldcoin.Size = new System.Drawing.Size(58, 23);
			this.txt_goldcoin.TabIndex = 3;
			this.txt_goldcoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_gaiaStatus
			// 
			this.txt_gaiaStatus.BackColor = System.Drawing.Color.LightGreen;
			this.txt_gaiaStatus.Location = new System.Drawing.Point(476, 143);
			this.txt_gaiaStatus.Name = "txt_gaiaStatus";
			this.txt_gaiaStatus.Size = new System.Drawing.Size(51, 23);
			this.txt_gaiaStatus.TabIndex = 3;
			this.txt_gaiaStatus.Text = "下载";
			this.txt_gaiaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txt_gaiaStatus.Click += new System.EventHandler(this.Txt_gaiaStatusClick);
			// 
			// lbl_Fans
			// 
			this.lbl_Fans.BackColor = System.Drawing.Color.LightGreen;
			this.lbl_Fans.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Fans.Location = new System.Drawing.Point(391, 143);
			this.lbl_Fans.Name = "lbl_Fans";
			this.lbl_Fans.Size = new System.Drawing.Size(79, 23);
			this.lbl_Fans.TabIndex = 3;
			this.lbl_Fans.Text = "GaiaStatus";
			this.lbl_Fans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Fans.Click += new System.EventHandler(this.Lbl_FansClick);
			// 
			// txt_experience_show
			// 
			this.txt_experience_show.Location = new System.Drawing.Point(302, 92);
			this.txt_experience_show.Name = "txt_experience_show";
			this.txt_experience_show.Size = new System.Drawing.Size(58, 23);
			this.txt_experience_show.TabIndex = 3;
			this.txt_experience_show.Text = "等级经验";
			this.txt_experience_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_experience
			// 
			this.txt_experience.BackColor = System.Drawing.Color.Silver;
			this.txt_experience.Location = new System.Drawing.Point(366, 92);
			this.txt_experience.Name = "txt_experience";
			this.txt_experience.Size = new System.Drawing.Size(58, 23);
			this.txt_experience.TabIndex = 3;
			this.txt_experience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(302, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "金币";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Logout
			// 
			this.btn_Logout.BackColor = System.Drawing.Color.LightGreen;
			this.btn_Logout.FlatAppearance.BorderSize = 0;
			this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Logout.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Logout.Location = new System.Drawing.Point(382, 189);
			this.btn_Logout.Name = "btn_Logout";
			this.btn_Logout.Size = new System.Drawing.Size(75, 23);
			this.btn_Logout.TabIndex = 4;
			this.btn_Logout.Text = "登出(不要点)";
			this.btn_Logout.UseVisualStyleBackColor = false;
			this.btn_Logout.Click += new System.EventHandler(this.Btn_LogOut);
			// 
			// txt_cookie
			// 
			this.txt_cookie.Location = new System.Drawing.Point(119, 109);
			this.txt_cookie.Name = "txt_cookie";
			this.txt_cookie.Size = new System.Drawing.Size(10, 23);
			this.txt_cookie.TabIndex = 6;
			this.txt_cookie.Text = ".";
			this.txt_cookie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txt_cookie.Click += new System.EventHandler(this.Txt_cookieClick);
			// 
			// btn_test
			// 
			this.btn_test.BackColor = System.Drawing.Color.LightGreen;
			this.btn_test.FlatAppearance.BorderSize = 0;
			this.btn_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_test.Location = new System.Drawing.Point(183, 189);
			this.btn_test.Name = "btn_test";
			this.btn_test.Size = new System.Drawing.Size(75, 23);
			this.btn_test.TabIndex = 7;
			this.btn_test.Text = "关于|说明";
			this.btn_test.UseVisualStyleBackColor = false;
			this.btn_test.Click += new System.EventHandler(this.Btn_testClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightGreen;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(301, 189);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "签到";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Btn_signClick);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 520;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 247);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_test);
			this.Controls.Add(this.txt_cookie);
			this.Controls.Add(this.txt_showInfo);
			this.Controls.Add(this.btn_Logout);
			this.Controls.Add(this.btn_LoadUserInfo);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_userName);
			this.Controls.Add(this.txt_experience);
			this.Controls.Add(this.txt_goldcoin);
			this.Controls.Add(this.lbl_Fans);
			this.Controls.Add(this.txt_gaiaStatus);
			this.Controls.Add(this.txt_experience_show);
			this.Controls.Add(this.txt_onlines);
			this.Controls.Add(this.txt_zqcoin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edit_num);
			this.Controls.Add(this.edit_password);
			this.Controls.Add(this.edit_userName);
			this.Controls.Add(this.pictureNum);
			this.Controls.Add(this.pictureAvatar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "爱大哥";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
