/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/18 星期四
 * Time: 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class ReviewMessage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_generateReviewUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edit_Minute;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewMessage));
			this.btn_generateReviewUrl = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.edit_Minute = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btn_generateReviewUrl
			// 
			this.btn_generateReviewUrl.Location = new System.Drawing.Point(346, 193);
			this.btn_generateReviewUrl.Name = "btn_generateReviewUrl";
			this.btn_generateReviewUrl.Size = new System.Drawing.Size(75, 23);
			this.btn_generateReviewUrl.TabIndex = 0;
			this.btn_generateReviewUrl.Text = "生成";
			this.btn_generateReviewUrl.UseVisualStyleBackColor = true;
			this.btn_generateReviewUrl.Click += new System.EventHandler(this.Btn_generateReviewUrlClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(100, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "大哥回播地址生成";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "回播时长（分钟）：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edit_Minute
			// 
			this.edit_Minute.Location = new System.Drawing.Point(216, 54);
			this.edit_Minute.Name = "edit_Minute";
			this.edit_Minute.Size = new System.Drawing.Size(100, 21);
			this.edit_Minute.TabIndex = 3;
			this.edit_Minute.Text = "1";
			// 
			// richTextBox1
			// 
			this.richTextBox1.AutoWordSelection = true;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.richTextBox1.DetectUrls = false;
			this.richTextBox1.Location = new System.Drawing.Point(24, 81);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(467, 96);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "直播才有效";
			// 
			// ReviewMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 237);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.edit_Minute);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_generateReviewUrl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ReviewMessage";
			this.Text = "ReviewMessage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
