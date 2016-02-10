using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace AMS
{
	/// <summary>
	/// Summary description for FormNewProject.
	/// </summary>
	public class FormNewProject : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ComboBox comboBoxPrjType;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public const int AMS = 0;
		public const int AMT = 1;
		public int ProjectType;
		public string SavePath;
		public string FileName;

		public FormNewProject()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormNewProject));
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxFileName = new System.Windows.Forms.TextBox();
			this.comboBoxPrjType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxPath
			// 
			this.textBoxPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textBoxPath.Location = new System.Drawing.Point(112, 24);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(256, 20);
			this.textBoxPath.TabIndex = 0;
			this.textBoxPath.Text = "textBox1";
			this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
			// 
			// buttonOpen
			// 
			this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
			this.buttonOpen.Location = new System.Drawing.Point(376, 24);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(32, 24);
			this.buttonOpen.TabIndex = 1;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Save Path";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Project Name";
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Location = new System.Drawing.Point(112, 56);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.Size = new System.Drawing.Size(256, 20);
			this.textBoxFileName.TabIndex = 2;
			this.textBoxFileName.Text = "textBox2";
			this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
			// 
			// comboBoxPrjType
			// 
			this.comboBoxPrjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPrjType.Items.AddRange(new object[] {
																 "Archsoft Project",
																 "Archsoft Project Template"});
			this.comboBoxPrjType.Location = new System.Drawing.Point(112, 88);
			this.comboBoxPrjType.Name = "comboBoxPrjType";
			this.comboBoxPrjType.Size = new System.Drawing.Size(256, 21);
			this.comboBoxPrjType.TabIndex = 3;
			this.comboBoxPrjType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrjType_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Project Type";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(136, 136);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(72, 24);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(240, 136);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(72, 24);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormNewProject
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(432, 174);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxPrjType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxFileName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.textBoxPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormNewProject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Project";
			this.Load += new System.EventHandler(this.FormNewProject_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FormNewProject_Load(object sender, System.EventArgs e)
		{
			this.textBoxPath.Text = "";
			this.textBoxFileName.Text = "";
			this.comboBoxPrjType.SelectedIndex = AMS;
			this.ProjectType = AMS;

			this.textBoxPath.ReadOnly = true;
		}

		private void comboBoxPrjType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.ProjectType = this.comboBoxPrjType.SelectedIndex;
		}

		private void buttonOpen_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if(fbd.ShowDialog() == DialogResult.OK)
			{
				this.textBoxPath.Text = fbd.SelectedPath;
			}
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			if((this.textBoxPath.Text == "")||(this.textBoxFileName.Text == ""))
			{
				return;
			}
			else
			{
				if(this.ProjectType == AMS)
				{
					DirectoryInfo di = new DirectoryInfo(this.textBoxPath.Text + "\\" + this.textBoxFileName.Text);
					if(di.Exists)
					{
						if(MessageBox.Show("Folder " + this.textBoxFileName.Text + " is already existed. Do you want to overwrite it?", 
							"New Project",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							this.textBoxFileName.Text = "";
							return;
						}
					}
				}
				else //AMT
				{
					FileInfo fi = new FileInfo(this.textBoxPath.Text + "\\" + this.textBoxFileName.Text + ".amt");
					if(fi.Exists)
					{
						if(MessageBox.Show("File " + this.textBoxFileName.Text + ".amt" + " is already existed. Do you want to overwrite it?", 
							"New Project",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							this.textBoxFileName.Text = "";
							return;
						}
					}
				}
				this.SavePath = this.textBoxPath.Text;
				this.FileName = this.textBoxFileName.Text;
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxPath_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxFileName_TextChanged(object sender, System.EventArgs e)
		{
			if(this.textBoxFileName.Text.IndexOfAny(new char[]{':', ';', '<', '>', '?', '*', '|', '/', '\\'}) != -1)
			{
				MessageBox.Show("Invalid name.\n" + 
					"The invalid characters are: ':', ';', '<', '>', '?', '*', '|', '/', '\\'", 
					"New Project",MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.textBoxFileName.Text = "";
			}	
		}
	}
}
