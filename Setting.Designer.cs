/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/17/2016
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class Setting
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edit_version;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edit_Imei;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.Label label3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
			this.label1 = new System.Windows.Forms.Label();
			this.edit_version = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edit_Imei = new System.Windows.Forms.TextBox();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "安卓版本：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edit_version
			// 
			this.edit_version.Location = new System.Drawing.Point(170, 37);
			this.edit_version.Name = "edit_version";
			this.edit_version.Size = new System.Drawing.Size(100, 21);
			this.edit_version.TabIndex = 1;
			this.edit_version.Text = "2.6.1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "imei";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edit_Imei
			// 
			this.edit_Imei.Location = new System.Drawing.Point(170, 87);
			this.edit_Imei.Name = "edit_Imei";
			this.edit_Imei.Size = new System.Drawing.Size(100, 21);
			this.edit_Imei.TabIndex = 1;
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Location = new System.Drawing.Point(170, 125);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(100, 23);
			this.btn_Confirm.TabIndex = 2;
			this.btn_Confirm.Text = "确定";
			this.btn_Confirm.UseVisualStyleBackColor = true;
			this.btn_Confirm.Click += new System.EventHandler(this.Btn_ConfirmClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(363, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "什么都不改直接确定也是可以的";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Setting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 172);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.edit_Imei);
			this.Controls.Add(this.edit_version);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Setting";
			this.Text = "爱大哥 Setting";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
