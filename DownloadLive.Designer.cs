/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/16/2016
 * Time: 13:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class DownloadLive
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_StartDownload;
		private System.Windows.Forms.Button btn_StopDownload;
		private System.Windows.Forms.Label txt_Status;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txt_totalTs;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label txt_CurrentDownload;
		private System.Windows.Forms.Button btn_SavePosition;
		private System.Windows.Forms.Label txt_Info;
		private System.Windows.Forms.Label txt_FilePath;
		private System.Windows.Forms.CheckBox checkBox;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadLive));
			this.btn_StartDownload = new System.Windows.Forms.Button();
			this.btn_StopDownload = new System.Windows.Forms.Button();
			this.txt_Status = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_totalTs = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_CurrentDownload = new System.Windows.Forms.Label();
			this.btn_SavePosition = new System.Windows.Forms.Button();
			this.txt_Info = new System.Windows.Forms.Label();
			this.txt_FilePath = new System.Windows.Forms.Label();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btn_StartDownload
			// 
			this.btn_StartDownload.BackColor = System.Drawing.Color.LightGreen;
			this.btn_StartDownload.FlatAppearance.BorderSize = 0;
			this.btn_StartDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_StartDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_StartDownload.Location = new System.Drawing.Point(299, 60);
			this.btn_StartDownload.Name = "btn_StartDownload";
			this.btn_StartDownload.Size = new System.Drawing.Size(75, 23);
			this.btn_StartDownload.TabIndex = 0;
			this.btn_StartDownload.Text = "开始";
			this.btn_StartDownload.UseVisualStyleBackColor = false;
			this.btn_StartDownload.Click += new System.EventHandler(this.Btn_StartDownloadClick);
			// 
			// btn_StopDownload
			// 
			this.btn_StopDownload.BackColor = System.Drawing.Color.LightGreen;
			this.btn_StopDownload.FlatAppearance.BorderSize = 0;
			this.btn_StopDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_StopDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_StopDownload.Location = new System.Drawing.Point(408, 60);
			this.btn_StopDownload.Name = "btn_StopDownload";
			this.btn_StopDownload.Size = new System.Drawing.Size(75, 23);
			this.btn_StopDownload.TabIndex = 0;
			this.btn_StopDownload.Text = "停止";
			this.btn_StopDownload.UseVisualStyleBackColor = false;
			this.btn_StopDownload.Click += new System.EventHandler(this.Btn_StopDownloadClick);
			// 
			// txt_Status
			// 
			this.txt_Status.BackColor = System.Drawing.Color.LightGreen;
			this.txt_Status.Location = new System.Drawing.Point(12, 9);
			this.txt_Status.Name = "txt_Status";
			this.txt_Status.Size = new System.Drawing.Size(23, 23);
			this.txt_Status.TabIndex = 1;
			this.txt_Status.Text = "0.0";
			this.txt_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txt_Status.Click += new System.EventHandler(this.Txt_StatusClick);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(47, 9);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(436, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(80, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "总数：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_totalTs
			// 
			this.txt_totalTs.BackColor = System.Drawing.Color.LightGreen;
			this.txt_totalTs.Location = new System.Drawing.Point(133, 60);
			this.txt_totalTs.Name = "txt_totalTs";
			this.txt_totalTs.Size = new System.Drawing.Size(48, 23);
			this.txt_totalTs.TabIndex = 1;
			this.txt_totalTs.Text = "0";
			this.txt_totalTs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txt_totalTs.Click += new System.EventHandler(this.Txt_totalTsClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(187, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "当前：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_CurrentDownload
			// 
			this.txt_CurrentDownload.Location = new System.Drawing.Point(240, 60);
			this.txt_CurrentDownload.Name = "txt_CurrentDownload";
			this.txt_CurrentDownload.Size = new System.Drawing.Size(47, 23);
			this.txt_CurrentDownload.TabIndex = 1;
			this.txt_CurrentDownload.Text = "1";
			this.txt_CurrentDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_SavePosition
			// 
			this.btn_SavePosition.BackColor = System.Drawing.Color.LightGreen;
			this.btn_SavePosition.FlatAppearance.BorderSize = 0;
			this.btn_SavePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_SavePosition.Location = new System.Drawing.Point(0, 60);
			this.btn_SavePosition.Name = "btn_SavePosition";
			this.btn_SavePosition.Size = new System.Drawing.Size(74, 23);
			this.btn_SavePosition.TabIndex = 0;
			this.btn_SavePosition.Text = "保存位置";
			this.btn_SavePosition.UseVisualStyleBackColor = false;
			this.btn_SavePosition.Click += new System.EventHandler(this.Btn_SavePositionClick);
			// 
			// txt_Info
			// 
			this.txt_Info.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_Info.Location = new System.Drawing.Point(0, 128);
			this.txt_Info.Name = "txt_Info";
			this.txt_Info.Size = new System.Drawing.Size(483, 23);
			this.txt_Info.TabIndex = 3;
			this.txt_Info.Text = "状态。。 一个视频长度10-15s   大小1-2M    下载间隔约20s ";
			this.txt_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_FilePath
			// 
			this.txt_FilePath.Location = new System.Drawing.Point(0, 95);
			this.txt_FilePath.Name = "txt_FilePath";
			this.txt_FilePath.Size = new System.Drawing.Size(409, 24);
			this.txt_FilePath.TabIndex = 3;
			this.txt_FilePath.Text = "0.0";
			this.txt_FilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox
			// 
			this.checkBox.Checked = true;
			this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox.Location = new System.Drawing.Point(423, 96);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(71, 24);
			this.checkBox.TabIndex = 4;
			this.checkBox.Text = "合并";
			this.checkBox.UseVisualStyleBackColor = true;
			// 
			// DownloadLive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 160);
			this.Controls.Add(this.checkBox);
			this.Controls.Add(this.txt_FilePath);
			this.Controls.Add(this.txt_Info);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.txt_CurrentDownload);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_totalTs);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Status);
			this.Controls.Add(this.btn_StopDownload);
			this.Controls.Add(this.btn_SavePosition);
			this.Controls.Add(this.btn_StartDownload);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DownloadLive";
			this.Text = "DownloadLive";
			this.ResumeLayout(false);
		}
	}
}
