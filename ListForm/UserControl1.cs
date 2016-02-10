using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; // For Process.Start

namespace ListForm
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class ListForm : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public const int DrawinglistNum =1000;
		public const int ERROR_MAX_FILES_EXCEEDED = -2;
		public const int ERROR_FILE_EXISTED = -3;
		public const int ERROR_INVALID_FILE = -4;
		public const int SUSCESS = 1;

		public const int NEWDRAWING = 1;
		public const int CUT = 2;
		public const int PASTE = 3;
		public const int DELETE = 4;
		public const int RENAME = 5;

		public AMSFileList FileList;
		public string SavePath;
		public ClassUndo UndoList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuItem menuItemDelete;
		private System.Windows.Forms.MenuItem menuItemPaste;
		private System.Windows.Forms.MenuItem menuItemCopy;
		private System.Windows.Forms.MenuItem menuItemRename;
		private System.Windows.Forms.Label labelCaptionDisplay;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuItem menuItemCut;
		private System.Windows.Forms.ContextMenu contextMenuListBox;
		private System.Windows.Forms.MenuItem menuItemNewDrawing;
		private System.Windows.Forms.MenuItem menuItemPublishItem;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItemUndo;
		private System.Windows.Forms.ListBox listBoxItem;
		private System.Windows.Forms.Label labelCaption;
		private AMSFileList.AMSFileInfo copyItem;

		public ListForm()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			// TODO: Add any initialization after the InitComponent call
			FileList = new AMSFileList();
			UndoList = new ClassUndo();
		}
		
		public ListForm(int size)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			// TODO: Add any initialization after the InitComponent call
			FileList = new AMSFileList(size);
			UndoList = new ClassUndo();
		}

		public ListForm(int size, string SavePath)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			// TODO: Add any initialization after the InitComponent call
			FileList = new AMSFileList(size);
			this.SavePath = SavePath;
			UndoList = new ClassUndo();
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ListForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelCaption = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBoxItem = new System.Windows.Forms.ListBox();
			this.contextMenuListBox = new System.Windows.Forms.ContextMenu();
			this.menuItemNewDrawing = new System.Windows.Forms.MenuItem();
			this.menuItemPublishItem = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemUndo = new System.Windows.Forms.MenuItem();
			this.menuItemCut = new System.Windows.Forms.MenuItem();
			this.menuItemCopy = new System.Windows.Forms.MenuItem();
			this.menuItemPaste = new System.Windows.Forms.MenuItem();
			this.menuItemDelete = new System.Windows.Forms.MenuItem();
			this.menuItemRename = new System.Windows.Forms.MenuItem();
			this.labelCaptionDisplay = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.labelCaption);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.listBoxItem);
			this.panel1.Controls.Add(this.labelCaptionDisplay);
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Text = resources.GetString("panel1.Text");
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// labelCaption
			// 
			this.labelCaption.AccessibleDescription = resources.GetString("labelCaption.AccessibleDescription");
			this.labelCaption.AccessibleName = resources.GetString("labelCaption.AccessibleName");
			this.labelCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCaption.Anchor")));
			this.labelCaption.AutoSize = ((bool)(resources.GetObject("labelCaption.AutoSize")));
			this.labelCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelCaption.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCaption.Dock")));
			this.labelCaption.Enabled = ((bool)(resources.GetObject("labelCaption.Enabled")));
			this.labelCaption.Font = ((System.Drawing.Font)(resources.GetObject("labelCaption.Font")));
			this.labelCaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelCaption.Image = ((System.Drawing.Image)(resources.GetObject("labelCaption.Image")));
			this.labelCaption.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCaption.ImageAlign")));
			this.labelCaption.ImageIndex = ((int)(resources.GetObject("labelCaption.ImageIndex")));
			this.labelCaption.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCaption.ImeMode")));
			this.labelCaption.Location = ((System.Drawing.Point)(resources.GetObject("labelCaption.Location")));
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCaption.RightToLeft")));
			this.labelCaption.Size = ((System.Drawing.Size)(resources.GetObject("labelCaption.Size")));
			this.labelCaption.TabIndex = ((int)(resources.GetObject("labelCaption.TabIndex")));
			this.labelCaption.Text = resources.GetString("labelCaption.Text");
			this.labelCaption.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCaption.TextAlign")));
			this.labelCaption.Visible = ((bool)(resources.GetObject("labelCaption.Visible")));
			this.labelCaption.Click += new System.EventHandler(this.labelCaption_Click);
			this.labelCaption.TextChanged += new System.EventHandler(this.labelCaption_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.AccessibleDescription = resources.GetString("textBox2.AccessibleDescription");
			this.textBox2.AccessibleName = resources.GetString("textBox2.AccessibleName");
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox2.Anchor")));
			this.textBox2.AutoSize = ((bool)(resources.GetObject("textBox2.AutoSize")));
			this.textBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox2.BackgroundImage")));
			this.textBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox2.Dock")));
			this.textBox2.Enabled = ((bool)(resources.GetObject("textBox2.Enabled")));
			this.textBox2.Font = ((System.Drawing.Font)(resources.GetObject("textBox2.Font")));
			this.textBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox2.ImeMode")));
			this.textBox2.Location = ((System.Drawing.Point)(resources.GetObject("textBox2.Location")));
			this.textBox2.MaxLength = ((int)(resources.GetObject("textBox2.MaxLength")));
			this.textBox2.Multiline = ((bool)(resources.GetObject("textBox2.Multiline")));
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = ((char)(resources.GetObject("textBox2.PasswordChar")));
			this.textBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox2.RightToLeft")));
			this.textBox2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox2.ScrollBars")));
			this.textBox2.Size = ((System.Drawing.Size)(resources.GetObject("textBox2.Size")));
			this.textBox2.TabIndex = ((int)(resources.GetObject("textBox2.TabIndex")));
			this.textBox2.Text = resources.GetString("textBox2.Text");
			this.textBox2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox2.TextAlign")));
			this.textBox2.Visible = ((bool)(resources.GetObject("textBox2.Visible")));
			this.textBox2.WordWrap = ((bool)(resources.GetObject("textBox2.WordWrap")));
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.AccessibleDescription = resources.GetString("textBox1.AccessibleDescription");
			this.textBox1.AccessibleName = resources.GetString("textBox1.AccessibleName");
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox1.Anchor")));
			this.textBox1.AutoSize = ((bool)(resources.GetObject("textBox1.AutoSize")));
			this.textBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox1.BackgroundImage")));
			this.textBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox1.Dock")));
			this.textBox1.Enabled = ((bool)(resources.GetObject("textBox1.Enabled")));
			this.textBox1.Font = ((System.Drawing.Font)(resources.GetObject("textBox1.Font")));
			this.textBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox1.ImeMode")));
			this.textBox1.Location = ((System.Drawing.Point)(resources.GetObject("textBox1.Location")));
			this.textBox1.MaxLength = ((int)(resources.GetObject("textBox1.MaxLength")));
			this.textBox1.Multiline = ((bool)(resources.GetObject("textBox1.Multiline")));
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = ((char)(resources.GetObject("textBox1.PasswordChar")));
			this.textBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox1.RightToLeft")));
			this.textBox1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox1.ScrollBars")));
			this.textBox1.Size = ((System.Drawing.Size)(resources.GetObject("textBox1.Size")));
			this.textBox1.TabIndex = ((int)(resources.GetObject("textBox1.TabIndex")));
			this.textBox1.Text = resources.GetString("textBox1.Text");
			this.textBox1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox1.TextAlign")));
			this.textBox1.Visible = ((bool)(resources.GetObject("textBox1.Visible")));
			this.textBox1.WordWrap = ((bool)(resources.GetObject("textBox1.WordWrap")));
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// listBoxItem
			// 
			this.listBoxItem.AccessibleDescription = resources.GetString("listBoxItem.AccessibleDescription");
			this.listBoxItem.AccessibleName = resources.GetString("listBoxItem.AccessibleName");
			this.listBoxItem.AllowDrop = true;
			this.listBoxItem.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listBoxItem.Anchor")));
			this.listBoxItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listBoxItem.BackgroundImage")));
			this.listBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxItem.ColumnWidth = ((int)(resources.GetObject("listBoxItem.ColumnWidth")));
			this.listBoxItem.ContextMenu = this.contextMenuListBox;
			this.listBoxItem.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listBoxItem.Dock")));
			this.listBoxItem.Enabled = ((bool)(resources.GetObject("listBoxItem.Enabled")));
			this.listBoxItem.Font = ((System.Drawing.Font)(resources.GetObject("listBoxItem.Font")));
			this.listBoxItem.HorizontalExtent = ((int)(resources.GetObject("listBoxItem.HorizontalExtent")));
			this.listBoxItem.HorizontalScrollbar = ((bool)(resources.GetObject("listBoxItem.HorizontalScrollbar")));
			this.listBoxItem.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listBoxItem.ImeMode")));
			this.listBoxItem.IntegralHeight = ((bool)(resources.GetObject("listBoxItem.IntegralHeight")));
			this.listBoxItem.ItemHeight = ((int)(resources.GetObject("listBoxItem.ItemHeight")));
			this.listBoxItem.Location = ((System.Drawing.Point)(resources.GetObject("listBoxItem.Location")));
			this.listBoxItem.Name = "listBoxItem";
			this.listBoxItem.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listBoxItem.RightToLeft")));
			this.listBoxItem.ScrollAlwaysVisible = ((bool)(resources.GetObject("listBoxItem.ScrollAlwaysVisible")));
			this.listBoxItem.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxItem.Size = ((System.Drawing.Size)(resources.GetObject("listBoxItem.Size")));
			this.listBoxItem.TabIndex = ((int)(resources.GetObject("listBoxItem.TabIndex")));
			this.listBoxItem.Visible = ((bool)(resources.GetObject("listBoxItem.Visible")));
			this.listBoxItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxItem_MouseDown);
			this.listBoxItem.DoubleClick += new System.EventHandler(this.listBoxItem_DoubleClick);
			this.listBoxItem.Validated += new System.EventHandler(this.ListBoxItem_Validated);
			this.listBoxItem.Layout += new System.Windows.Forms.LayoutEventHandler(this.listBoxItem_Layout);
			// 
			// contextMenuListBox
			// 
			this.contextMenuListBox.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							   this.menuItemNewDrawing,
																							   this.menuItemPublishItem,
																							   this.menuItem1,
																							   this.menuItemUndo,
																							   this.menuItemCut,
																							   this.menuItemCopy,
																							   this.menuItemPaste,
																							   this.menuItemDelete,
																							   this.menuItemRename});
			this.contextMenuListBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenuListBox.RightToLeft")));
			// 
			// menuItemNewDrawing
			// 
			this.menuItemNewDrawing.Enabled = ((bool)(resources.GetObject("menuItemNewDrawing.Enabled")));
			this.menuItemNewDrawing.Index = 0;
			this.menuItemNewDrawing.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemNewDrawing.Shortcut")));
			this.menuItemNewDrawing.ShowShortcut = ((bool)(resources.GetObject("menuItemNewDrawing.ShowShortcut")));
			this.menuItemNewDrawing.Text = resources.GetString("menuItemNewDrawing.Text");
			this.menuItemNewDrawing.Visible = ((bool)(resources.GetObject("menuItemNewDrawing.Visible")));
			this.menuItemNewDrawing.Click += new System.EventHandler(this.menuItemNewDrawing_Click);
			// 
			// menuItemPublishItem
			// 
			this.menuItemPublishItem.Enabled = ((bool)(resources.GetObject("menuItemPublishItem.Enabled")));
			this.menuItemPublishItem.Index = 1;
			this.menuItemPublishItem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemPublishItem.Shortcut")));
			this.menuItemPublishItem.ShowShortcut = ((bool)(resources.GetObject("menuItemPublishItem.ShowShortcut")));
			this.menuItemPublishItem.Text = resources.GetString("menuItemPublishItem.Text");
			this.menuItemPublishItem.Visible = ((bool)(resources.GetObject("menuItemPublishItem.Visible")));
			this.menuItemPublishItem.Click += new System.EventHandler(this.menuItemPublishItem_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Enabled = ((bool)(resources.GetObject("menuItem1.Enabled")));
			this.menuItem1.Index = 2;
			this.menuItem1.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem1.Shortcut")));
			this.menuItem1.ShowShortcut = ((bool)(resources.GetObject("menuItem1.ShowShortcut")));
			this.menuItem1.Text = resources.GetString("menuItem1.Text");
			this.menuItem1.Visible = ((bool)(resources.GetObject("menuItem1.Visible")));
			// 
			// menuItemUndo
			// 
			this.menuItemUndo.Enabled = ((bool)(resources.GetObject("menuItemUndo.Enabled")));
			this.menuItemUndo.Index = 3;
			this.menuItemUndo.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemUndo.Shortcut")));
			this.menuItemUndo.ShowShortcut = ((bool)(resources.GetObject("menuItemUndo.ShowShortcut")));
			this.menuItemUndo.Text = resources.GetString("menuItemUndo.Text");
			this.menuItemUndo.Visible = ((bool)(resources.GetObject("menuItemUndo.Visible")));
			this.menuItemUndo.Click += new System.EventHandler(this.menuItemUndo_Click);
			// 
			// menuItemCut
			// 
			this.menuItemCut.Enabled = ((bool)(resources.GetObject("menuItemCut.Enabled")));
			this.menuItemCut.Index = 4;
			this.menuItemCut.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemCut.Shortcut")));
			this.menuItemCut.ShowShortcut = ((bool)(resources.GetObject("menuItemCut.ShowShortcut")));
			this.menuItemCut.Text = resources.GetString("menuItemCut.Text");
			this.menuItemCut.Visible = ((bool)(resources.GetObject("menuItemCut.Visible")));
			this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
			// 
			// menuItemCopy
			// 
			this.menuItemCopy.Enabled = ((bool)(resources.GetObject("menuItemCopy.Enabled")));
			this.menuItemCopy.Index = 5;
			this.menuItemCopy.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemCopy.Shortcut")));
			this.menuItemCopy.ShowShortcut = ((bool)(resources.GetObject("menuItemCopy.ShowShortcut")));
			this.menuItemCopy.Text = resources.GetString("menuItemCopy.Text");
			this.menuItemCopy.Visible = ((bool)(resources.GetObject("menuItemCopy.Visible")));
			this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
			// 
			// menuItemPaste
			// 
			this.menuItemPaste.Enabled = ((bool)(resources.GetObject("menuItemPaste.Enabled")));
			this.menuItemPaste.Index = 6;
			this.menuItemPaste.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemPaste.Shortcut")));
			this.menuItemPaste.ShowShortcut = ((bool)(resources.GetObject("menuItemPaste.ShowShortcut")));
			this.menuItemPaste.Text = resources.GetString("menuItemPaste.Text");
			this.menuItemPaste.Visible = ((bool)(resources.GetObject("menuItemPaste.Visible")));
			this.menuItemPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
			// 
			// menuItemDelete
			// 
			this.menuItemDelete.Enabled = ((bool)(resources.GetObject("menuItemDelete.Enabled")));
			this.menuItemDelete.Index = 7;
			this.menuItemDelete.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemDelete.Shortcut")));
			this.menuItemDelete.ShowShortcut = ((bool)(resources.GetObject("menuItemDelete.ShowShortcut")));
			this.menuItemDelete.Text = resources.GetString("menuItemDelete.Text");
			this.menuItemDelete.Visible = ((bool)(resources.GetObject("menuItemDelete.Visible")));
			this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
			// 
			// menuItemRename
			// 
			this.menuItemRename.Enabled = ((bool)(resources.GetObject("menuItemRename.Enabled")));
			this.menuItemRename.Index = 8;
			this.menuItemRename.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItemRename.Shortcut")));
			this.menuItemRename.ShowShortcut = ((bool)(resources.GetObject("menuItemRename.ShowShortcut")));
			this.menuItemRename.Text = resources.GetString("menuItemRename.Text");
			this.menuItemRename.Visible = ((bool)(resources.GetObject("menuItemRename.Visible")));
			this.menuItemRename.Click += new System.EventHandler(this.menuItemRename_Click);
			// 
			// labelCaptionDisplay
			// 
			this.labelCaptionDisplay.AccessibleDescription = resources.GetString("labelCaptionDisplay.AccessibleDescription");
			this.labelCaptionDisplay.AccessibleName = resources.GetString("labelCaptionDisplay.AccessibleName");
			this.labelCaptionDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCaptionDisplay.Anchor")));
			this.labelCaptionDisplay.AutoSize = ((bool)(resources.GetObject("labelCaptionDisplay.AutoSize")));
			this.labelCaptionDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelCaptionDisplay.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCaptionDisplay.Dock")));
			this.labelCaptionDisplay.Enabled = ((bool)(resources.GetObject("labelCaptionDisplay.Enabled")));
			this.labelCaptionDisplay.Font = ((System.Drawing.Font)(resources.GetObject("labelCaptionDisplay.Font")));
			this.labelCaptionDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelCaptionDisplay.Image = ((System.Drawing.Image)(resources.GetObject("labelCaptionDisplay.Image")));
			this.labelCaptionDisplay.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCaptionDisplay.ImageAlign")));
			this.labelCaptionDisplay.ImageIndex = ((int)(resources.GetObject("labelCaptionDisplay.ImageIndex")));
			this.labelCaptionDisplay.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCaptionDisplay.ImeMode")));
			this.labelCaptionDisplay.Location = ((System.Drawing.Point)(resources.GetObject("labelCaptionDisplay.Location")));
			this.labelCaptionDisplay.Name = "labelCaptionDisplay";
			this.labelCaptionDisplay.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCaptionDisplay.RightToLeft")));
			this.labelCaptionDisplay.Size = ((System.Drawing.Size)(resources.GetObject("labelCaptionDisplay.Size")));
			this.labelCaptionDisplay.TabIndex = ((int)(resources.GetObject("labelCaptionDisplay.TabIndex")));
			this.labelCaptionDisplay.Text = resources.GetString("labelCaptionDisplay.Text");
			this.labelCaptionDisplay.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCaptionDisplay.TextAlign")));
			this.labelCaptionDisplay.Visible = ((bool)(resources.GetObject("labelCaptionDisplay.Visible")));
			this.labelCaptionDisplay.Click += new System.EventHandler(this.labelCaptionDisplay_Click);
			// 
			// ListForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.panel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "ListForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public Label Caption
		{
			get
			{
				return labelCaption;
			}
			set
			{
				labelCaption = value;
			}
		}

		public ListBox ListBox
		{
			get
			{
				return listBoxItem;
			}
			set
			{
				listBoxItem = value;
			}
		}

		private void menuChangeName_Click(object sender, System.EventArgs e)
		{
			renameCaption();
		}

		public void renameCaption()
		{
			this.textBox1.Left = this.labelCaption.Left;
			this.textBox1.Top = this.labelCaption.Top;
			this.textBox1.Width = this.labelCaption.Width;
			this.textBox1.Height = this.labelCaption.Height;
			this.textBox1.Visible = true;
			this.textBox1.Text = this.labelCaption.Text;
			this.textBox1.Focus();
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.Enter:
					if(this.textBox1.Text!="")
					{
						if(this.textBox1.Text.IndexOfAny(new char[]{':', ';', '<', '>', '?', '*', '|', '/', '\\'}) == -1)
						{
							this.labelCaption.Text = this.textBox1.Text;
							//this.Name = this.labelCaption.Text;
							this.textBox1.Visible = false;
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
					break;
				case Keys.Escape:
					this.textBox1.Visible = false;
					break;
				default:
					break;
			}
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			this.textBox1.Visible = false;
		}

		private void labelCaption_Click(object sender, System.EventArgs e)
		{
			this.listBoxItem.Focus();
		}

		private void menuItemNewDrawing_Click(object sender, System.EventArgs e)
		{
			this.UndoList.Add(NEWDRAWING,this.FileList);
			newDrawing();
			UpdateNumFile();
		}
		public void newDrawing()
		{
			OpenFileDialog oDlg = new OpenFileDialog();
			oDlg.Filter = "Drawing Template (*.dwt)|*.dwt|Drawing (*.dwg)|*.dwg";
			oDlg.Title = "Open - " + this.Caption.Text;
			DialogResult DlgResult = oDlg.ShowDialog();
			if(DlgResult == DialogResult.OK)
			{
				string FileName;
				string[] FileParts = oDlg.FileName.Split('\\');
				string[] FileNames = FileParts[FileParts.Length-1].Split('.');

				switch(oDlg.FilterIndex)
				{
					case 1:
						FormGetNumFiles numForm = new FormGetNumFiles();
						if(numForm.ShowDialog() == DialogResult.OK)
						{
							for(int i =0; i< numForm.NumFiles; i++)
							{
								string Number;
								if(this.listBoxItem.Items.Count < 9)
								{
									Number = "0" + ((int)(this.listBoxItem.Items.Count + 1)).ToString();
								}
								else
								{
									Number = ((int)(this.listBoxItem.Items.Count + 1)).ToString();
								}
								FileName = this.Name + "-" + Number + "_";
								FileName += FileNames[0];
								if(AddFile(FileName,oDlg.FileName) == ERROR_MAX_FILES_EXCEEDED)
								{
									MessageBox.Show("Error adding file.\n" + 
										"The number of files has exceeded the maximum: " + this.FileList.AMSFiles.Length.ToString(), 
										"Add New Drawing",MessageBoxButtons.OK, MessageBoxIcon.Warning);
									break;
								}
							}
						}
						break;
					case 2:
						FileName = FileNames[0];
						if(AddFile(FileName,oDlg.FileName) == ERROR_MAX_FILES_EXCEEDED)
						{
							MessageBox.Show("Error adding file.\n" + 
								"The number of files has exceeded the maximum: " + this.FileList.AMSFiles.Length.ToString(), 
								"Add New Drawing",MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						break;
					default:
						break;
				}
				
			}
		}

		public int AddFile(string FileName, string FilePath)
		{
			if((FileName != "") && (FilePath != ""))
			{
				if(!this.FileList.isExisted(FileName))
				{
					if(this.FileList.Add(FileName,FilePath) > -1)
					{
						this.listBoxItem.Items.Add(FileName);
						return SUSCESS;
					}
					return ERROR_MAX_FILES_EXCEEDED;
				}
				else
				{
					MessageBox.Show("Item is already existed: "+ FileName +"\n" + 
						"The file name should not be the same with the current files'", 
						"Add New Drawing",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return ERROR_FILE_EXISTED;
				}
			}
			else
			{
				MessageBox.Show("Error adding file.\n" + 
					"The file name does not exist.", 
					"Add New Drawing",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return ERROR_INVALID_FILE;
			}
		}

		private void ListBoxItem_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.listBoxItem.Select();
			if(e.Button == MouseButtons.Right)
			{
				int index = this.listBoxItem.IndexFromPoint(e.X,e.Y);
				if(index >= 0)
				{
					this.listBoxItem.ClearSelected();
					this.listBoxItem.SelectedIndex = index;
				}
			}
		}

		public void menuItemCut_Click(object sender, System.EventArgs e)
		{
			if(this.listBoxItem.SelectedItem != null)
			{
				this.UndoList.Add(CUT,this.FileList);
				
				int index = this.listBoxItem.SelectedIndex;
				//IDataObject dataObj = new DataObject("AMSFileList.AMSFileInfo",this.FileList.AMSFiles[index]);
				//Clipboard.SetDataObject(dataObj,true);
				copyItem = new AMSFileList.AMSFileInfo(this.FileList.AMSFiles[index]);
				this.listBoxItem.Items.RemoveAt(index);
				this.FileList.RemoveAt(index);

				UpdateNumFile();
			}
		}

		public void menuItemCopy_Click(object sender, System.EventArgs e)
		{
			if(this.listBoxItem.SelectedItem != null)
			{
				//IDataObject dataObj = new DataObject("AMSFileList.AMSFileInfo",this.FileList.AMSFiles[listBoxItem.SelectedIndex]);
				//Clipboard.SetDataObject(dataObj,true);
				copyItem = new AMSFileList.AMSFileInfo(this.FileList.AMSFiles[listBoxItem.SelectedIndex]);
			}
		}

		public void menuItemPaste_Click(object sender, System.EventArgs e)
		{
			/*IDataObject DataObj = Clipboard.GetDataObject();
			AMSFileList.AMSFileInfo FileInfo = (AMSFileList.AMSFileInfo)DataObj.GetData("AMSFileList.AMSFileInfo",true);
			if(FileInfo.FileName != null)
			{
				AddFile(FileInfo.FileName,FileInfo.FilePath);
			}*/
			if(this.copyItem.FileName != null)
			{
				this.UndoList.Add(PASTE,this.FileList);

				FormGetNumFiles numForm = new FormGetNumFiles();
				if(numForm.ShowDialog() == DialogResult.OK)
				{
					string FileName;
					for(int i =0; i< numForm.NumFiles; i++)
					{
						string Number;
						if(this.listBoxItem.Items.Count < 9)
						{
							Number = "0" + ((int)(this.listBoxItem.Items.Count + 1)).ToString();
						}
						else
						{
							Number = ((int)(this.listBoxItem.Items.Count + 1)).ToString();
						}
						//Set name of new Item to A#-##-Filename (e.g. A0-10_Acad1)
						FileName = this.Name + "-" + Number + "_";
						FileName += this.copyItem.FileName;

						if(AddFile(FileName,this.copyItem.FilePath) == ERROR_MAX_FILES_EXCEEDED)
						{
							MessageBox.Show("Error adding file.\n" + 
								"The number of files has exceeded the maximum: " + this.FileList.AMSFiles.Length.ToString(), 
								"Add New Drawing",MessageBoxButtons.OK, MessageBoxIcon.Warning);
							break;
						}
					}
				}
				this.copyItem = new AMSFileList.AMSFileInfo();
			
				UpdateNumFile();
			}
		}

		public void menuItemDelete_Click(object sender, System.EventArgs e)
		{
			/*
			 * //Single delete
			if(this.listBoxItem.SelectedItem != null)
			{
				DialogResult DlgResult = MessageBox.Show("Are you sure you want to delete this file: " + this.listBoxItem.SelectedItem.ToString() + "?" , 
					"Delete Drawing",MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
				if(DlgResult == DialogResult.Yes)
				{
					int index = this.listBoxItem.SelectedIndex;
					this.listBoxItem.Items.RemoveAt(index);
					this.FileList.RemoveAt(index);
				}
			}
			*/
			//Multiple delete
			if(this.listBoxItem.SelectedItem !=null)
			{
				this.UndoList.Add(DELETE,this.FileList);
				/*
				string msg = "";
				for(int i=0; i< this.listBoxItem.SelectedIndices.Count; i++)
				{
					msg += "\n" + this.listBoxItem.SelectedItems[i].ToString();
				}
				DialogResult DlgResult = MessageBox.Show("Are you sure you want to delete these files? " + msg, 
					"Delete Drawing",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				*/
				DialogResult DlgResult = MessageBox.Show("Are you sure you want to delete these files? ", 
					"Delete Drawing",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(DlgResult == DialogResult.Yes)
				{
					int index, count;
					count = this.listBoxItem.SelectedIndices.Count;
					for(int i=0; i< count; i++)
					{
						index = this.listBoxItem.SelectedIndex;
						this.listBoxItem.Items.RemoveAt(index);
						this.FileList.RemoveAt(index);
					}
				}
				this.UpdateNumFile();
			}
		}

		private void menuItemRename_Click(object sender, System.EventArgs e)
		{
			//renameItem();
			if(this.listBoxItem.SelectedItem != null)
			{
				this.UndoList.Add(RENAME,this.FileList);

				FormRenameDrawing RNDrawing = new FormRenameDrawing(this.listBoxItem.SelectedItem.ToString(), this.listBoxItem.SelectedIndex, this.FileList);
				if(RNDrawing.ShowDialog() == DialogResult.OK)
				{
					if(RNDrawing.newName != null)
					{
						int index = this.listBoxItem.SelectedIndex;
						this.listBoxItem.Items.RemoveAt(index);
						this.listBoxItem.Items.Insert(index,RNDrawing.newName);
						this.FileList.AMSFiles[index].FileName = RNDrawing.newName;
					}
				}
				this.UpdateNumFile();
			}
		}

		public void renameItem()
		{
			if(this.listBoxItem.SelectedItem != null)
			{
				this.textBox2.Left = this.listBoxItem.Left;
				this.textBox2.Top = this.listBoxItem.Top + this.listBoxItem.ItemHeight*listBoxItem.SelectedIndex;
				this.textBox2.Width = this.listBoxItem.Width;
				this.textBox2.Height = this.listBoxItem.ItemHeight;
				this.textBox2.Visible = true;
				this.textBox2.Text = this.listBoxItem.SelectedItem.ToString();
				this.textBox2.Focus();
			}
		}

		private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.Enter:
					if(this.textBox2.Text!="")
					{
						if(this.textBox2.Text.IndexOfAny(new char[]{':', ';', '<', '>', '?', '*', '|', '/', '\\'}) == -1)
						{
							if(!this.FileList.isExisted(this.textBox2.Text))
							{
								int index = this.listBoxItem.SelectedIndex;
								this.listBoxItem.Items.RemoveAt(index);
								this.listBoxItem.Items.Insert(index,this.textBox2.Text);
								this.FileList.AMSFiles[index].FileName = this.textBox2.Text;
								this.textBox2.Visible = false;
							}
							else
							{
								MessageBox.Show("File name is already existed.\n", 
									"File Rename",MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("Invalid file name.\n" + 
								"The invalid characters are: ':', ';', '<', '>', '?', '*', '|', '/', '\\'", 
								"File Rename",MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Invalid file name.\n" + 
							"The name length should not be zero", 
							"File Rename",MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				case Keys.Escape:
					this.textBox2.Visible = false;
					break;
				default:
					break;
			}
		}

		private void textBox2_Leave(object sender, System.EventArgs e)
		{
			this.textBox2.Visible = false;
		}

		private void menuItemPublishItem_Click(object sender, System.EventArgs e)
		{
			/*if(this.listBoxItem.SelectedItem != null)
			{
				int index = this.listBoxItem.SelectedIndex;
				PrintItem(this.FileList.AMSFiles[index]);
			}*/
		}

		public void SaveItem(AMSFileList.AMSFileInfo fi)
		{
			FileInfo FiSrc;
			string FiDest;
			FiSrc = new FileInfo(fi.FilePath);
			FiDest = this.SavePath + "\\" + fi.FileName + ".dwg";	
			try
			{
				FiSrc.CopyTo(FiDest,true);
			}
			catch
			{
				MessageBox.Show("Cannot save file to " + this.SavePath, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show("Save completed to " + this.SavePath, 
				"Save",MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		public void SaveAll()
		{
			FileInfo FiSrc;
			string FiDest;
			DirectoryInfo di = new DirectoryInfo(this.SavePath);
			try
			{
				if(di.Exists)
				{
					di.Delete(true);
				}
				di.Create();
			}
			catch(Exception e)
			{
				MessageBox.Show("Save error: \n" + e.Message, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			for(int i=0; i<this.FileList.Count;i++)
			{
				FiSrc = new FileInfo(this.FileList.AMSFiles[i].FilePath);
				FiDest = this.SavePath + "\\" + this.FileList.AMSFiles[i].FileName + ".dwg";	
				try
				{
					FiSrc.CopyTo(FiDest,true);
				}
				catch
				{
					MessageBox.Show("Cannot save file " + this.FileList.AMSFiles[i].FileName + ".dwg" + " to " + this.SavePath, 
						"Save Drawing",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			/*MessageBox.Show("Save completed to " + this.SavePath, 
				"Save",MessageBoxButtons.OK, MessageBoxIcon.Information);*/
		}

		public void SaveTo(string SavePath)
		{
			FileInfo FiSrc;
			string FiDest;
			DirectoryInfo di = new DirectoryInfo(SavePath);
			try
			{
				if(di.Exists)
				{
					di.Delete(true);
				}
				di.Create();
			}
			catch(Exception e)
			{
				MessageBox.Show("Save error: \n" + e.Message, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			for(int i=0; i<this.FileList.Count;i++)
			{
				FiSrc = new FileInfo(this.FileList.AMSFiles[i].FilePath);
				FiDest = SavePath + "\\" + this.FileList.AMSFiles[i].FileName + ".dwg";	
				try
				{
					FiSrc.CopyTo(FiDest,true);
				}
				catch
				{
					MessageBox.Show("Cannot save file " + this.FileList.AMSFiles[i].FileName + ".dwg" + " to " + SavePath, 
						"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			/*MessageBox.Show("Save completed to " + SavePath, 
				"Save",MessageBoxButtons.OK, MessageBoxIcon.Information);*/
		}

		public void DeleteInDisk()
		{
			DirectoryInfo di = new DirectoryInfo(this.SavePath);
			try
			{
				if(di.Exists)
				{
					di.Delete(true);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Delete file in disk error: \n" + e.Message, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void SaveOutlineText(StreamWriter sw)
		{
			/*Save:
			 * 1. ListForm:
					caption;
					string SavePath;
					AMSFileList FileList;
			   2. FileList:
					FileList.Count;
					FileList.AMSFiles;
					*/
			try
			{
				sw.WriteLine(this.Caption.Text);
				sw.WriteLine(this.SavePath);
				sw.WriteLine(this.FileList.Count);
				for(int i=0;i<this.FileList.Count;i++)
				{
					sw.WriteLine(this.FileList.AMSFiles[i].FileName);
					sw.WriteLine(this.FileList.AMSFiles[i].FilePath);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Save outline error: \n" + e.Message, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		public void SaveOutlineBinary(BinaryWriter bw)
		{
			/*Save:
			 * 1. ListForm:
					caption;
					string SavePath;
					AMSFileList FileList;
			   2. FileList:
					FileList.Count;
					FileList.AMSFiles;
					*/
			try
			{
				bw.Write(this.Caption.Text);
				bw.Write(this.SavePath);
				bw.Write((int)this.FileList.Count);
				for(int i=0;i<this.FileList.Count;i++)
				{
					bw.Write(this.FileList.AMSFiles[i].FileName);
					bw.Write(this.FileList.AMSFiles[i].FilePath);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Save outline error: \n" + e.Message, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		public void ReadOutlineText(StreamReader sr)
		{
			/*Read:
			 * 1. ListForm:
					caption;
					string SavePath;
					AMSFileList FileList;
			   2. FileList:
					FileList.Count;
					FileList.AMSFiles;
			*/
			try
			{
				this.Caption.Text = sr.ReadLine();
				this.SavePath = sr.ReadLine();
				this.FileList.Count = System.Convert.ToInt32(sr.ReadLine());
				//this.FileList.AMSFiles = new AMSFileList.AMSFileInfo[DrawinglistNum];
				for(int i=0;i<this.FileList.Count;i++)
				{
					this.FileList.AMSFiles[i].FileName = sr.ReadLine();
					this.FileList.AMSFiles[i].FilePath = sr.ReadLine();
					this.listBoxItem.Items.Add(this.FileList.AMSFiles[i].FileName);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Read outline error: \n" + e.Message, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		public void ReadOutlineBinary(BinaryReader br)
		{
			/*Read:
			 * 1. ListForm:
					caption;
					string SavePath;
					AMSFileList FileList;
			   2. FileList:
					FileList.Count;
					FileList.AMSFiles;
			*/
			try
			{
				this.Caption.Text = br.ReadString();
				this.SavePath = br.ReadString();
				this.FileList.Count = br.ReadInt32();
				//this.FileList.AMSFiles = new AMSFileList.AMSFileInfo[DrawinglistNum];
				for(int i=0;i<this.FileList.Count;i++)
				{
					this.FileList.AMSFiles[i].FileName = br.ReadString();
					this.FileList.AMSFiles[i].FilePath = br.ReadString();
					this.listBoxItem.Items.Add(this.FileList.AMSFiles[i].FileName);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Read outline error: \n" + e.Message, 
					"Drawing Window",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void listBoxItem_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			UpdateNumFile();
		}

		private void ListBoxItem_Validated(object sender, System.EventArgs e)
		{
			UpdateNumFile();
		}

		public void UpdateNumFile()
		{
			this.labelCaptionDisplay.Text = "      " + this.labelCaption.Text + "  -  " + this.listBoxItem.Items.Count.ToString() + " Drawing(s)";
		}

		private void menuItemUndo_Click(object sender, System.EventArgs e)
		{
			if(this.UndoList.Count > 0)
			{
				this.FileList = new AMSFileList();
				this.FileList = this.UndoList.UndoSteps[this.UndoList.SelectedStep].PreItems;
				this.listBoxItem.Items.Clear();
				for(int i=0;i<this.FileList.Count;i++)
				{
					this.listBoxItem.Items.Add(this.FileList.AMSFiles[i].FileName);
				}
				this.UndoList.UndoAction();
				UpdateNumFile();
			}
		}

		private void labelCaption_TextChanged(object sender, System.EventArgs e)
		{
			this.UpdateNumFile();
		}

		private void labelCaptionDisplay_Click(object sender, System.EventArgs e)
		{
			this.listBoxItem.Focus();
		}

		private void listBoxItem_DoubleClick(object sender, System.EventArgs e)
		{
			if(this.listBoxItem.SelectedItem != null)
			{
				string FileName = Path.Combine(this.SavePath + "\\", this.FileList.AMSFiles[this.listBoxItem.SelectedIndex].FileName + ".dwg");
				FileInfo fi = new FileInfo(FileName);
				
				try 
				{
					/*if(!fi.Exists)
					{
						FileName = this.FileList.AMSFiles[this.listBoxItem.SelectedIndex].FilePath;
					}*/
					if(fi.Exists)
					{
						Process.Start(FileName);
					}
				} 
				catch
				{
				}
			}
		}
	}
}
