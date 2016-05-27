/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/3/9 星期三
 * Time: 20:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class DownloadRecordFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox edit_url;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.ProgressBar progressBar_File;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_current;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_total;
		private System.Windows.Forms.Label lbl_info;
		private System.Windows.Forms.Button btn_mid;
		
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
			this.edit_url = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_stop = new System.Windows.Forms.Button();
			this.progressBar_File = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_current = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_total = new System.Windows.Forms.Label();
			this.lbl_info = new System.Windows.Forms.Label();
			this.btn_mid = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edit_url
			// 
			this.edit_url.Location = new System.Drawing.Point(158, 12);
			this.edit_url.Name = "edit_url";
			this.edit_url.Size = new System.Drawing.Size(480, 21);
			this.edit_url.TabIndex = 0;
			this.edit_url.Text = "http://www.zhanqi.tv/videos/xindong/2016/01/66977.html";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "录播地址";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(321, 75);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(86, 26);
			this.btn_start.TabIndex = 2;
			this.btn_start.Text = "开始";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.Btn_startClick);
			// 
			// btn_stop
			// 
			this.btn_stop.Location = new System.Drawing.Point(441, 75);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(86, 26);
			this.btn_stop.TabIndex = 2;
			this.btn_stop.Text = "结束";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.Btn_stopClick);
			// 
			// progressBar_File
			// 
			this.progressBar_File.Location = new System.Drawing.Point(28, 43);
			this.progressBar_File.Name = "progressBar_File";
			this.progressBar_File.Size = new System.Drawing.Size(609, 22);
			this.progressBar_File.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "当前";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_current
			// 
			this.lbl_current.Location = new System.Drawing.Point(58, 83);
			this.lbl_current.Name = "lbl_current";
			this.lbl_current.Size = new System.Drawing.Size(40, 18);
			this.lbl_current.TabIndex = 1;
			this.lbl_current.Text = "当前";
			this.lbl_current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(122, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 18);
			this.label4.TabIndex = 1;
			this.label4.Text = "总数";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_total
			// 
			this.lbl_total.Location = new System.Drawing.Point(168, 83);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(40, 18);
			this.lbl_total.TabIndex = 1;
			this.lbl_total.Text = "当前";
			this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_info
			// 
			this.lbl_info.Location = new System.Drawing.Point(321, 108);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(316, 16);
			this.lbl_info.TabIndex = 4;
			this.lbl_info.Text = "0.0";
			// 
			// btn_mid
			// 
			this.btn_mid.Location = new System.Drawing.Point(551, 75);
			this.btn_mid.Name = "btn_mid";
			this.btn_mid.Size = new System.Drawing.Size(86, 26);
			this.btn_mid.TabIndex = 2;
			this.btn_mid.Text = "开始";
			this.btn_mid.UseVisualStyleBackColor = true;
			this.btn_mid.Click += new System.EventHandler(this.BTN_MID);
			// 
			// DownloadRecordFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 126);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.progressBar_File);
			this.Controls.Add(this.btn_stop);
			this.Controls.Add(this.btn_mid);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.lbl_total);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbl_current);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edit_url);
			this.IsMdiContainer = true;
			this.Name = "DownloadRecordFrm";
			this.Text = "DownloadRecordFrm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
