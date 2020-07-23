namespace WinApp_UI_Examples
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.circularPicturebox1 = new WinApp_UI_Examples.圓型Picturebox.CircularPicturebox();
			this.close_button = new WinApp_UI_Examples.CircularButton();
			((System.ComponentModel.ISupportInitialize)(this.circularPicturebox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(250, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "1. 圓型按鈕，FlatStyle 改為 Flat, 放一張 Image, Perfect\r\n2. 用 Panel 來畫線，設定 backcolor，高度調為 1" +
    "\r\n";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Location = new System.Drawing.Point(128, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(578, 1);
			this.panel1.TabIndex = 2;
			// 
			// circularPicturebox1
			// 
			this.circularPicturebox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.circularPicturebox1.Image = global::WinApp_UI_Examples.Properties.Resources.Joncash_Hsieh;
			this.circularPicturebox1.Location = new System.Drawing.Point(311, 81);
			this.circularPicturebox1.Name = "circularPicturebox1";
			this.circularPicturebox1.Size = new System.Drawing.Size(188, 188);
			this.circularPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.circularPicturebox1.TabIndex = 3;
			this.circularPicturebox1.TabStop = false;
			// 
			// close_button
			// 
			this.close_button.FlatAppearance.BorderSize = 0;
			this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close_button.Image = global::WinApp_UI_Examples.Properties.Resources.button_close_23x23;
			this.close_button.Location = new System.Drawing.Point(756, 12);
			this.close_button.Name = "close_button";
			this.close_button.Size = new System.Drawing.Size(32, 32);
			this.close_button.TabIndex = 0;
			this.close_button.UseVisualStyleBackColor = true;
			this.close_button.Click += new System.EventHandler(this.close_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.circularPicturebox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.close_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.circularPicturebox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CircularButton close_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private 圓型Picturebox.CircularPicturebox circularPicturebox1;
	}
}

