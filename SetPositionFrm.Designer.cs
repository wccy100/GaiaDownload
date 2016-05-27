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
partial class SetPositionFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edit_start;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edit_end;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.Label lbl_info;
		private System.Windows.Forms.Label lbl_unit;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.edit_start = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edit_end = new System.Windows.Forms.TextBox();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.lbl_info = new System.Windows.Forms.Label();
			this.lbl_unit = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "起始";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edit_start
			// 
			this.edit_start.Location = new System.Drawing.Point(170, 37);
			this.edit_start.Name = "edit_start";
			this.edit_start.Size = new System.Drawing.Size(100, 21);
			this.edit_start.TabIndex = 1;
			this.edit_start.Text = "0";
			this.edit_start.TextChanged += new System.EventHandler(this.Edit_startTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "结尾";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edit_end
			// 
			this.edit_end.Location = new System.Drawing.Point(170, 87);
			this.edit_end.Name = "edit_end";
			this.edit_end.Size = new System.Drawing.Size(100, 21);
			this.edit_end.TabIndex = 1;
			this.edit_end.Text = "100";
			this.edit_end.TextChanged += new System.EventHandler(this.Edit_startTextChanged);
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
			// lbl_info
			// 
			this.lbl_info.Location = new System.Drawing.Point(3, 0);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(363, 23);
			this.lbl_info.TabIndex = 3;
			this.lbl_info.Text = "输入起始，结尾位置";
			this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_unit
			// 
			this.lbl_unit.Location = new System.Drawing.Point(294, 37);
			this.lbl_unit.Name = "lbl_unit";
			this.lbl_unit.Size = new System.Drawing.Size(60, 21);
			this.lbl_unit.TabIndex = 4;
			this.lbl_unit.Text = "个数";
			// 
			// SetPositionFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 172);
			this.Controls.Add(this.lbl_unit);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.edit_end);
			this.Controls.Add(this.edit_start);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SetPositionFrm";
			this.Text = "爱大哥 Setting";
			this.Load += new System.EventHandler(this.SetPositionLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
