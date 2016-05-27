/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/5/11 星期三
 * Time: 22:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class ATestDanmuku
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label lblInfo;
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
			this.btnSend = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.lblInfo = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(274, 59);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "发送";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.BtnSendClick);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(42, 59);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(204, 21);
			this.txtMessage.TabIndex = 1;
			this.txtMessage.Text = "0.0。。";
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(12, 9);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(300, 23);
			this.lblInfo.TabIndex = 2;
			this.lblInfo.Text = "message";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(31, 111);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(318, 122);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// ATestDanmuku
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 255);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnSend);
			this.Name = "ATestDanmuku";
			this.Text = "ATestDanmuku";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
