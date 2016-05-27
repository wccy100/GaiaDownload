/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/3/10 星期四
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class SwitchFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Previous;
		private System.Windows.Forms.Button btn_Live;
		private System.Windows.Forms.Panel panel_Main;
		private System.Windows.Forms.Button btn_Record;
		private System.Windows.Forms.Button btn_Merge;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label lbl_info;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txt_totalTs;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label txt_CurrentDownload;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.Label txt_Status;
		private System.Windows.Forms.Button btn_fileLocation;
		private System.Windows.Forms.CheckBox checkBox;
		private System.Windows.Forms.Timer timer1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchFrm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Record = new System.Windows.Forms.Button();
			this.btn_fileLocation = new System.Windows.Forms.Button();
			this.btn_Merge = new System.Windows.Forms.Button();
			this.btn_Previous = new System.Windows.Forms.Button();
			this.btn_Live = new System.Windows.Forms.Button();
			this.panel_Main = new System.Windows.Forms.Panel();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.lbl_info = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_totalTs = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_CurrentDownload = new System.Windows.Forms.Label();
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_stop = new System.Windows.Forms.Button();
			this.txt_Status = new System.Windows.Forms.Label();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btn_Record);
			this.panel1.Controls.Add(this.btn_fileLocation);
			this.panel1.Controls.Add(this.btn_Merge);
			this.panel1.Controls.Add(this.btn_Previous);
			this.panel1.Controls.Add(this.btn_Live);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(116, 251);
			this.panel1.TabIndex = 0;
			// 
			// btn_Record
			// 
			this.btn_Record.Location = new System.Drawing.Point(7, 65);
			this.btn_Record.Name = "btn_Record";
			this.btn_Record.Size = new System.Drawing.Size(100, 40);
			this.btn_Record.TabIndex = 0;
			this.btn_Record.Text = "录播下载";
			this.btn_Record.UseVisualStyleBackColor = false;
			this.btn_Record.Click += new System.EventHandler(this.Btn_RecordClick);
			// 
			// btn_fileLocation
			// 
			this.btn_fileLocation.Location = new System.Drawing.Point(7, 180);
			this.btn_fileLocation.Name = "btn_fileLocation";
			this.btn_fileLocation.Size = new System.Drawing.Size(100, 28);
			this.btn_fileLocation.TabIndex = 0;
			this.btn_fileLocation.Text = "选择文件位置";
			this.btn_fileLocation.UseVisualStyleBackColor = true;
			this.btn_fileLocation.Click += new System.EventHandler(this.Btn_fileLocationClick);
			// 
			// btn_Merge
			// 
			this.btn_Merge.Location = new System.Drawing.Point(7, 212);
			this.btn_Merge.Name = "btn_Merge";
			this.btn_Merge.Size = new System.Drawing.Size(100, 28);
			this.btn_Merge.TabIndex = 0;
			this.btn_Merge.Text = "合并";
			this.btn_Merge.UseVisualStyleBackColor = true;
			this.btn_Merge.Click += new System.EventHandler(this.Btn_MergeClick);
			// 
			// btn_Previous
			// 
			this.btn_Previous.Location = new System.Drawing.Point(7, 115);
			this.btn_Previous.Name = "btn_Previous";
			this.btn_Previous.Size = new System.Drawing.Size(100, 40);
			this.btn_Previous.TabIndex = 0;
			this.btn_Previous.Text = "回播下载";
			this.btn_Previous.UseVisualStyleBackColor = true;
			this.btn_Previous.Click += new System.EventHandler(this.Btn_PreviousClick);
			// 
			// btn_Live
			// 
			this.btn_Live.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Live.Location = new System.Drawing.Point(7, 17);
			this.btn_Live.Name = "btn_Live";
			this.btn_Live.Size = new System.Drawing.Size(100, 40);
			this.btn_Live.TabIndex = 0;
			this.btn_Live.Text = "直播下载";
			this.btn_Live.UseVisualStyleBackColor = false;
			this.btn_Live.Click += new System.EventHandler(this.Btn_LiveClick);
			// 
			// panel_Main
			// 
			this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Main.Location = new System.Drawing.Point(146, 12);
			this.panel_Main.Name = "panel_Main";
			this.panel_Main.Size = new System.Drawing.Size(478, 106);
			this.panel_Main.TabIndex = 1;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(175, 135);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(449, 27);
			this.progressBar.TabIndex = 2;
			// 
			// lbl_info
			// 
			this.lbl_info.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lbl_info.Location = new System.Drawing.Point(146, 224);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(404, 28);
			this.lbl_info.TabIndex = 3;
			this.lbl_info.Text = "info";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(146, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 28);
			this.label1.TabIndex = 4;
			this.label1.Text = "总数";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_totalTs
			// 
			this.txt_totalTs.Location = new System.Drawing.Point(196, 187);
			this.txt_totalTs.Name = "txt_totalTs";
			this.txt_totalTs.Size = new System.Drawing.Size(41, 28);
			this.txt_totalTs.TabIndex = 4;
			this.txt_totalTs.Text = "1";
			this.txt_totalTs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(253, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "当前";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_CurrentDownload
			// 
			this.txt_CurrentDownload.Location = new System.Drawing.Point(312, 187);
			this.txt_CurrentDownload.Name = "txt_CurrentDownload";
			this.txt_CurrentDownload.Size = new System.Drawing.Size(41, 28);
			this.txt_CurrentDownload.TabIndex = 4;
			this.txt_CurrentDownload.Text = "0";
			this.txt_CurrentDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(390, 181);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(100, 40);
			this.btn_start.TabIndex = 0;
			this.btn_start.Text = "开始";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.Btn_startClick);
			// 
			// btn_stop
			// 
			this.btn_stop.Location = new System.Drawing.Point(524, 181);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(100, 40);
			this.btn_stop.TabIndex = 0;
			this.btn_stop.Text = "结束";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.Btn_stopClick);
			// 
			// txt_Status
			// 
			this.txt_Status.Location = new System.Drawing.Point(146, 135);
			this.txt_Status.Name = "txt_Status";
			this.txt_Status.Size = new System.Drawing.Size(23, 27);
			this.txt_Status.TabIndex = 4;
			this.txt_Status.Text = "0.0";
			this.txt_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txt_Status.Click += new System.EventHandler(this.Txt_StatusClick);
			// 
			// checkBox
			// 
			this.checkBox.Checked = true;
			this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox.Location = new System.Drawing.Point(569, 232);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(55, 21);
			this.checkBox.TabIndex = 5;
			this.checkBox.Text = "合并";
			this.checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// SwitchFrm
			// 
			this.AcceptButton = this.btn_start;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 267);
			this.Controls.Add(this.checkBox);
			this.Controls.Add(this.btn_stop);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.txt_CurrentDownload);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_totalTs);
			this.Controls.Add(this.txt_Status);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.panel_Main);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SwitchFrm";
			this.Text = "大哥视频缓存";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SwitchFrmFormClosed);
			this.Load += new System.EventHandler(this.SwitchFrmLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		 
	}
}
