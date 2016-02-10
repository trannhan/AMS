using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using ListForm;

namespace AMS
{
	/// <summary>
	/// Summary description for FormRenameWindow.
	/// </summary>
	public class FormRenameWindow : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		ListForm.ListForm lf;
		TabPage tp;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public string newName;

		public FormRenameWindow()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public FormRenameWindow(ListForm.ListForm lf, TabPage tp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.textBoxName.Text = lf.Caption.Text;
			this.lf = lf;
			this.tp = tp;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormRenameWindow));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(160, 79);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 24);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(48, 79);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(80, 24);
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Please enter new name for this Drawing Window:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(24, 40);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(240, 20);
			this.textBoxName.TabIndex = 0;
			this.textBoxName.Text = "";
			// 
			// FormRenameWindow
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(288, 118);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormRenameWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Rename Drawing Window";
			this.ResumeLayout(false);

		}
		#endregion

		public bool isNameConflict(string Name)
		{
			int count = this.tp.Controls.Count;
			string FolderName;
			for(int i=0 ; i< count; i++)
			{
				ListForm.ListForm li = ((ListForm.ListForm)this.tp.Controls[i]);
				if(li.Name != this.lf.Name)
				{
					FolderName = ((ListForm.ListForm)this.tp.Controls[i]).Caption.Text;
					if(Name == FolderName)
					{
						return true;
					}
				}
			}
			return false;
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			bool bcheck = true;	
			if(this.textBoxName.Text!="")
			{
				if(this.textBoxName.Text.IndexOfAny(new char[]{':', ';', '<', '>', '?', '*', '|', '/', '\\'}) == -1)
				{
					if(!isNameConflict(this.textBoxName.Text.ToLower()))
					{
						string FirstChar = this.textBoxName.Text.Substring(0,1);
						FirstChar = FirstChar.ToUpper();
						this.newName = FirstChar + this.textBoxName.Text.Remove(0,1);
						bcheck = false;
					}
					else
					{
						MessageBox.Show("Conflict name.\n" + 
							"This name is already existed.", 
							"Caption Rename",MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Invalid name.\n" + 
						"The invalid characters are: ':', ';', '<', '>', '?', '*', '|', '/', '\\'", 
						"Caption Rename",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Invalid name.\n" + 
					"The name length should not be zero", 
					"Caption Rename",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if(bcheck)
			{
				//this.newName = null;
			}
		}
	}
}
