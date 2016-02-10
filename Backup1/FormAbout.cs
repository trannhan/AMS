using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics; // For Process.Start

namespace AMS
{
	/// <summary>
	/// Summary description for FormAbout.
	/// </summary>
	public class FormAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkMailNhan;
		private System.Windows.Forms.LinkLabel linkMailCom;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormAbout()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormAbout));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkMailNhan = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.linkMailCom = new System.Windows.Forms.LinkLabel();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(144, 120);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(344, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Collection Management System";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(176, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tran Thanh Nhan:";
			// 
			// linkMailNhan
			// 
			this.linkMailNhan.Location = new System.Drawing.Point(304, 80);
			this.linkMailNhan.Name = "linkMailNhan";
			this.linkMailNhan.Size = new System.Drawing.Size(128, 16);
			this.linkMailNhan.TabIndex = 4;
			this.linkMailNhan.TabStop = true;
			this.linkMailNhan.Text = "nhantran11@yahoo.com";
			this.linkMailNhan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMail_LinkClicked);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(296, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "For more information about this product, please contact: ";
			// 
			// linkMailCom
			// 
			this.linkMailCom.Location = new System.Drawing.Point(288, 208);
			this.linkMailCom.Name = "linkMailCom";
			this.linkMailCom.Size = new System.Drawing.Size(128, 16);
			this.linkMailCom.TabIndex = 7;
			this.linkMailCom.TabStop = true;
			this.linkMailCom.Text = "nhantran11@yahoo.com";
			this.linkMailCom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMail_LinkClicked);
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(184, 240);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(88, 24);
			this.buttonOK.TabIndex = 8;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(424, 56);
			this.label5.TabIndex = 9;
			this.label5.Text = @"WARNING: This computer program is protected by copyright law and international treaties. Unauthorized duplication or distribution of this program, or any portion of it, may result in severe civil or criminal penalties, and will be prosecuted to the maximum extent possible under the law.";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(176, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(264, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Copyright© Archsoft 2007-2008. All rights reserved.";
			// 
			// FormAbout
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 278);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.linkMailCom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.linkMailNhan);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAbout";
			this.Opacity = 0.8;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About Collection Management System";
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void linkMail_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("Mailto:nhantran11@yahoo.com");
		}
	}
}
