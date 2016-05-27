/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/18 星期四
 * Time: 10:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HttpDemo
{
	partial class SimpleMerger
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_fileLocation;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Label txt_state;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleMerger));
			this.label1 = new System.Windows.Forms.Label();
			this.btn_fileLocation = new System.Windows.Forms.Button();
			this.btn_Start = new System.Windows.Forms.Button();
			this.txt_state = new System.Windows.Forms.Label();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(30, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(549, 64);
			this.label1.TabIndex = 0;
			this.label1.Text = "简单合并程序，直接叠加.ts文件，按windows文件管理器的名称排序,没有进行任何处理，停止下载后会自动调用，也有几率不调用，建议用专业合并软件";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_fileLocation
			// 
			this.btn_fileLocation.BackColor = System.Drawing.Color.Silver;
			this.btn_fileLocation.FlatAppearance.BorderSize = 0;
			this.btn_fileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_fileLocation.Location = new System.Drawing.Point(30, 76);
			this.btn_fileLocation.Name = "btn_fileLocation";
			this.btn_fileLocation.Size = new System.Drawing.Size(75, 23);
			this.btn_fileLocation.TabIndex = 1;
			this.btn_fileLocation.Text = "文件夹位置";
			this.btn_fileLocation.UseVisualStyleBackColor = false;
			this.btn_fileLocation.Click += new System.EventHandler(this.Btn_fileLocationClick);
			// 
			// btn_Start
			// 
			this.btn_Start.BackColor = System.Drawing.Color.Silver;
			this.btn_Start.FlatAppearance.BorderSize = 0;
			this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Start.Location = new System.Drawing.Point(166, 76);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(75, 23);
			this.btn_Start.TabIndex = 2;
			this.btn_Start.Text = "开始";
			this.btn_Start.UseVisualStyleBackColor = false;
			this.btn_Start.Click += new System.EventHandler(this.Btn_StartClick);
			// 
			// txt_state
			// 
			this.txt_state.Location = new System.Drawing.Point(30, 102);
			this.txt_state.Name = "txt_state";
			this.txt_state.Size = new System.Drawing.Size(157, 23);
			this.txt_state.TabIndex = 3;
			this.txt_state.Text = "..";
			// 
			// checkBox
			// 
			this.checkBox.Checked = true;
			this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox.Location = new System.Drawing.Point(477, 78);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(102, 21);
			this.checkBox.TabIndex = 4;
			this.checkBox.Text = "按文件名排序.";
			this.checkBox.UseVisualStyleBackColor = true;
			// 
			// SimpleMerger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 134);
			this.Controls.Add(this.checkBox);
			this.Controls.Add(this.txt_state);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.btn_fileLocation);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SimpleMerger";
			this.Text = "SimpleMerger";
			this.ResumeLayout(false);

		}
	}
}
