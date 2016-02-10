using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using ListForm;


namespace AMS
{
	
	/// <summary>
	/// Summary description for FormMain.
	/// </summary>
	/*
	public struct DrawingListTab
	{
		public ListForm.ListForm[] DrawingListWindows;
		public DrawingListTab(int size)
		{
			DrawingListWindows = new ListForm.ListForm[size];
		}
	}
	*/
	public class FormMain : System.Windows.Forms.Form
	{
		public const int DrawinglistNum = 1000;
		public const int TabNum = 1000;
		public const int WindowNum = 1000;
		public const int MaxCol = 6;
		public const string sIssued = "04 Issued";
		public const string sDrawingList = "03 Output";
		public const string sDrawingForAttachment = "02 Input";
		public const string sInformation = "01 Information";
		public const string sApplicationName = "Archsoft Project 2008";
		public const int AMS = 0;
		public const int AMT = 1;
		
		

		//private DrawingListTab[] DrawingListTabs;
		public bool AutoResize = true;
		private string[] ProjSavePath;
		public string[] sProjectTypesList;
		public int[] ProjectType; //amt or ams
		public ListForm.ListForm SelectedWindow;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ContextMenu contextMenuDrawingList;
		private System.Windows.Forms.MenuItem menuItemSendtoIssued;
		private System.Windows.Forms.MenuItem menuItemNewWindow;
		private System.Windows.Forms.MenuItem menuItemPublish;
		private System.Windows.Forms.MenuItem menuItemDelDrawingList;
		private System.Windows.Forms.ContextMenu contextMenuWindow;
		private System.Windows.Forms.MenuItem menuItemPublishWindow;
		private System.Windows.Forms.MenuItem menuItemRenameWindow;
		private System.Windows.Forms.MenuItem menuItemDeleteWindow;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemNew;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemClose;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItemNewChild;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItemSave;
		private System.Windows.Forms.MenuItem menuItemSaveAs;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItemPageSetup;
		private System.Windows.Forms.MenuItem menuItemPrintPreview;
		private System.Windows.Forms.MenuItem menuItemPrint;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItemProperties;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemEdit;
		private System.Windows.Forms.MenuItem menuItemUndo;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItemCut;
		private System.Windows.Forms.MenuItem menuItemCopy;
		private System.Windows.Forms.MenuItem menuItemDelete;
		private System.Windows.Forms.MenuItem menuItemPaste;
		private System.Windows.Forms.MenuItem menuItemWindow;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItemAMSHelp;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItemAbout;
		internal System.Windows.Forms.ImageList ilStandard;
		private System.Windows.Forms.MenuItem menuItemAutoArrange;
		private System.Windows.Forms.MenuItem menuItemFollowedArrange;
		private SharpLibrary.WinControls.StatusBarEx statusBarEx1;
		private SharpLibrary.WinControls.StatusBarExPanel statusBarExPanel1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem menuItemRenameAllWindows;
		private System.Windows.Forms.TabControl tabControlDrawingList;

		public FormMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();	
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			//Forms = new System.Windows.Forms.Form[1000];			
			this.menuItemNewChild.Enabled = false;
			//DrawingListTabs = new DrawingListTab[TabNum];	
			sProjectTypesList = new string[] {"ams", "amt"};
			ProjSavePath = new string[TabNum];
			ProjectType = new int[TabNum];
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlDrawingList = new System.Windows.Forms.TabControl();
            this.contextMenuDrawingList = new System.Windows.Forms.ContextMenu();
            this.menuItemSendtoIssued = new System.Windows.Forms.MenuItem();
            this.menuItemNewWindow = new System.Windows.Forms.MenuItem();
            this.menuItemPublish = new System.Windows.Forms.MenuItem();
            this.menuItemDelDrawingList = new System.Windows.Forms.MenuItem();
            this.ilStandard = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuWindow = new System.Windows.Forms.ContextMenu();
            this.menuItemPublishWindow = new System.Windows.Forms.MenuItem();
            this.menuItemRenameWindow = new System.Windows.Forms.MenuItem();
            this.menuItemDeleteWindow = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemClose = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItemNewChild = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItemPageSetup = new System.Windows.Forms.MenuItem();
            this.menuItemPrintPreview = new System.Windows.Forms.MenuItem();
            this.menuItemPrint = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItemProperties = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemEdit = new System.Windows.Forms.MenuItem();
            this.menuItemUndo = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItemCut = new System.Windows.Forms.MenuItem();
            this.menuItemCopy = new System.Windows.Forms.MenuItem();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemPaste = new System.Windows.Forms.MenuItem();
            this.menuItemWindow = new System.Windows.Forms.MenuItem();
            this.menuItemAutoArrange = new System.Windows.Forms.MenuItem();
            this.menuItemFollowedArrange = new System.Windows.Forms.MenuItem();
            this.menuItemRenameAllWindows = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItemAMSHelp = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.statusBarEx1 = new SharpLibrary.WinControls.StatusBarEx();
            this.statusBarExPanel1 = new SharpLibrary.WinControls.StatusBarExPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tabControlDrawingList
            // 
            this.tabControlDrawingList.ContextMenu = this.contextMenuDrawingList;
            this.tabControlDrawingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDrawingList.ImageList = this.ilStandard;
            this.tabControlDrawingList.Location = new System.Drawing.Point(0, 0);
            this.tabControlDrawingList.Multiline = true;
            this.tabControlDrawingList.Name = "tabControlDrawingList";
            this.tabControlDrawingList.SelectedIndex = 0;
            this.tabControlDrawingList.Size = new System.Drawing.Size(384, 181);
            this.tabControlDrawingList.TabIndex = 0;
            this.tabControlDrawingList.Click += new System.EventHandler(this.tabControlDrawingList_Click);
            this.tabControlDrawingList.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabControlDrawingList_Layout);
            // 
            // contextMenuDrawingList
            // 
            this.contextMenuDrawingList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSendtoIssued,
            this.menuItemNewWindow,
            this.menuItemPublish,
            this.menuItemDelDrawingList});
            // 
            // menuItemSendtoIssued
            // 
            this.menuItemSendtoIssued.Index = 0;
            this.menuItemSendtoIssued.Text = "Send to Issued";
            this.menuItemSendtoIssued.Click += new System.EventHandler(this.menuItemSendtoIssued_Click);
            // 
            // menuItemNewWindow
            // 
            this.menuItemNewWindow.Index = 1;
            this.menuItemNewWindow.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.menuItemNewWindow.Text = "New window";
            this.menuItemNewWindow.Click += new System.EventHandler(this.menuItemNewChild_Click);
            // 
            // menuItemPublish
            // 
            this.menuItemPublish.Index = 2;
            this.menuItemPublish.Text = "Publish";
            // 
            // menuItemDelDrawingList
            // 
            this.menuItemDelDrawingList.Index = 3;
            this.menuItemDelDrawingList.Text = "Delete";
            this.menuItemDelDrawingList.Click += new System.EventHandler(this.menuItemDelDrawingList_Click);
            // 
            // ilStandard
            // 
            this.ilStandard.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStandard.ImageStream")));
            this.ilStandard.TransparentColor = System.Drawing.Color.Silver;
            this.ilStandard.Images.SetKeyName(0, "");
            this.ilStandard.Images.SetKeyName(1, "");
            this.ilStandard.Images.SetKeyName(2, "");
            this.ilStandard.Images.SetKeyName(3, "");
            this.ilStandard.Images.SetKeyName(4, "");
            this.ilStandard.Images.SetKeyName(5, "");
            this.ilStandard.Images.SetKeyName(6, "");
            this.ilStandard.Images.SetKeyName(7, "");
            this.ilStandard.Images.SetKeyName(8, "");
            this.ilStandard.Images.SetKeyName(9, "");
            this.ilStandard.Images.SetKeyName(10, "");
            this.ilStandard.Images.SetKeyName(11, "");
            this.ilStandard.Images.SetKeyName(12, "");
            this.ilStandard.Images.SetKeyName(13, "");
            this.ilStandard.Images.SetKeyName(14, "");
            this.ilStandard.Images.SetKeyName(15, "");
            // 
            // contextMenuWindow
            // 
            this.contextMenuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemPublishWindow,
            this.menuItemRenameWindow,
            this.menuItemDeleteWindow});
            // 
            // menuItemPublishWindow
            // 
            this.menuItemPublishWindow.Index = 0;
            this.menuItemPublishWindow.Text = "Publish";
            this.menuItemPublishWindow.Click += new System.EventHandler(this.menuItemPublishWindow_Click);
            // 
            // menuItemRenameWindow
            // 
            this.menuItemRenameWindow.Index = 1;
            this.menuItemRenameWindow.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItemRenameWindow.Text = "Rename";
            this.menuItemRenameWindow.Click += new System.EventHandler(this.menuItemRenameWindow_Click);
            // 
            // menuItemDeleteWindow
            // 
            this.menuItemDeleteWindow.Index = 2;
            this.menuItemDeleteWindow.Text = "Delete";
            this.menuItemDeleteWindow.Click += new System.EventHandler(this.menuItemDeleteWindow_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemEdit,
            this.menuItemWindow,
            this.menuItem19});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemClose,
            this.menuItem10,
            this.menuItemNewChild,
            this.menuItem11,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.menuItem16,
            this.menuItemPageSetup,
            this.menuItemPrintPreview,
            this.menuItemPrint,
            this.menuItem12,
            this.menuItemProperties,
            this.menuItem5,
            this.menuItemExit});
            this.menuItemFile.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Index = 0;
            this.menuItemNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = 1;
            this.menuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Index = 2;
            this.menuItemClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
            this.menuItemClose.Text = "Close";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            this.menuItem10.Text = "-";
            // 
            // menuItemNewChild
            // 
            this.menuItemNewChild.Index = 4;
            this.menuItemNewChild.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.menuItemNewChild.Text = "New Window";
            this.menuItemNewChild.Click += new System.EventHandler(this.menuItemNewChild_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 5;
            this.menuItem11.Text = "-";
            // 
            // menuItemSave
            // 
            this.menuItemSave.Index = 6;
            this.menuItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Index = 7;
            this.menuItemSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.menuItemSaveAs.Text = "Save As";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 8;
            this.menuItem16.Text = "-";
            // 
            // menuItemPageSetup
            // 
            this.menuItemPageSetup.Index = 9;
            this.menuItemPageSetup.Text = "Page Setup";
            this.menuItemPageSetup.Click += new System.EventHandler(this.menuItemPageSetup_Click);
            // 
            // menuItemPrintPreview
            // 
            this.menuItemPrintPreview.Index = 10;
            this.menuItemPrintPreview.Text = "Print Preview";
            this.menuItemPrintPreview.Click += new System.EventHandler(this.menuItemPrintPreview_Click);
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Index = 11;
            this.menuItemPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItemPrint.Text = "Print";
            this.menuItemPrint.Click += new System.EventHandler(this.menuItemPrint_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 12;
            this.menuItem12.Text = "-";
            // 
            // menuItemProperties
            // 
            this.menuItemProperties.Index = 13;
            this.menuItemProperties.Text = "Properties";
            this.menuItemProperties.Click += new System.EventHandler(this.menuItemProperties_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 14;
            this.menuItem5.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 15;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Index = 1;
            this.menuItemEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemUndo,
            this.menuItem6,
            this.menuItemCut,
            this.menuItemCopy,
            this.menuItemDelete,
            this.menuItemPaste});
            this.menuItemEdit.Text = "&Edit";
            // 
            // menuItemUndo
            // 
            this.menuItemUndo.Index = 0;
            this.menuItemUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.menuItemUndo.Text = "Undo";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "-";
            // 
            // menuItemCut
            // 
            this.menuItemCut.Index = 2;
            this.menuItemCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItemCut.Text = "Cut";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Index = 3;
            this.menuItemCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItemCopy.Text = "Copy";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Index = 4;
            this.menuItemDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuItemDelete.Text = "Delete";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Index = 5;
            this.menuItemPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuItemPaste.Text = "Paste";
            this.menuItemPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.Index = 2;
            this.menuItemWindow.MdiList = true;
            this.menuItemWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAutoArrange,
            this.menuItemFollowedArrange,
            this.menuItemRenameAllWindows});
            this.menuItemWindow.Text = "&Window";
            // 
            // menuItemAutoArrange
            // 
            this.menuItemAutoArrange.Index = 0;
            this.menuItemAutoArrange.Text = "&Auto Arrange";
            this.menuItemAutoArrange.Click += new System.EventHandler(this.menuItemAutoArrange_Click);
            // 
            // menuItemFollowedArrange
            // 
            this.menuItemFollowedArrange.Index = 1;
            this.menuItemFollowedArrange.Text = "&Followed Arrange";
            this.menuItemFollowedArrange.Click += new System.EventHandler(this.menuItemFollowedArrange_Click);
            // 
            // menuItemRenameAllWindows
            // 
            this.menuItemRenameAllWindows.Index = 2;
            this.menuItemRenameAllWindows.Text = "Rename All Windows";
            this.menuItemRenameAllWindows.Click += new System.EventHandler(this.menuItemRenameAllWindows_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 3;
            this.menuItem19.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAMSHelp,
            this.menuItem22,
            this.menuItemAbout});
            this.menuItem19.Text = "&Help";
            // 
            // menuItemAMSHelp
            // 
            this.menuItemAMSHelp.Index = 0;
            this.menuItemAMSHelp.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItemAMSHelp.Text = "AMS Help";
            this.menuItemAMSHelp.Click += new System.EventHandler(this.menuItemAMSHelp_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 1;
            this.menuItem22.Text = "-";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 2;
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // statusBarEx1
            // 
            this.statusBarEx1.BorderStyleEx = SharpLibrary.WinControls.BorderStyleEx.StaticEdge;
            this.statusBarEx1.CustomBorderColor = System.Drawing.Color.Navy;
            this.statusBarEx1.GradientEndColor = System.Drawing.Color.Empty;
            this.statusBarEx1.GradientStartColor = System.Drawing.Color.Empty;
            this.statusBarEx1.Location = new System.Drawing.Point(0, 154);
            this.statusBarEx1.Name = "statusBarEx1";
            this.statusBarEx1.Panels.AddRange(new SharpLibrary.WinControls.StatusBarExPanel[] {
            this.statusBarExPanel1});
            this.statusBarEx1.ResizeGripColor = System.Drawing.SystemColors.Control;
            this.statusBarEx1.ShowPanels = true;
            this.statusBarEx1.Size = new System.Drawing.Size(384, 27);
            this.statusBarEx1.TabIndex = 1;
            this.statusBarEx1.UseXPThemeGripper = true;
            // 
            // statusBarExPanel1
            // 
            this.statusBarExPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarExPanel1.BackColor = System.Drawing.Color.Empty;
            this.statusBarExPanel1.BorderStyle = SharpLibrary.WinControls.StatusBarExPanelBorderStyle.None;
            this.statusBarExPanel1.CustomBorderColor = System.Drawing.Color.Empty;
            this.statusBarExPanel1.ForeColor = System.Drawing.Color.Empty;
            this.statusBarExPanel1.GradientEndColor = System.Drawing.Color.Empty;
            this.statusBarExPanel1.GradientStartColor = System.Drawing.Color.Empty;
            this.statusBarExPanel1.ImageIndex = 1;
            this.statusBarExPanel1.Text = "";
            this.statusBarExPanel1.TooltipText = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.statusBarEx1);
            this.Controls.Add(this.tabControlDrawingList);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormMain_Closing);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new FormMain());
			//Application.Run(new Form2());
		}

		private void ResizeChildWindows(TabPage Tab)
		{
			int FileNum = 0;
			if(AutoResize)
			{
				ResizeChildWindowsAuto(Tab);
			}
			else
			{
				ResizeChildWindowsFollow(Tab);
			}
			for(int i=0 ; i< Tab.Controls.Count; i++)
			{
				FileNum += ((ListForm.ListForm)Tab.Controls[i]).FileList.Count;
			}
			//this.statusBarEx1.Panels[0].Text = "Project " + this.tabControlDrawingList.SelectedTab.Text + ": " + this.tabControlDrawingList.SelectedTab.Controls.Count.ToString() + " Drawing Windows - " + FileNum.ToString() + " Files";
			this.statusBarEx1.Panels[0].Text = "Project " + Tab.Text + ": " + Tab.Controls.Count.ToString() + " Drawing Windows - " + FileNum.ToString() + " Files";
		}

		private void ResizeChildWindowsAuto(TabPage Tab)
		{
			if(Tab.Controls.Count > 0)
			{
				int WindowCount = Tab.Controls.Count;
				int Column,Row;

				Row = (int)Math.Floor((WindowCount-1)/MaxCol)+1;
				if(WindowCount < MaxCol)
				{
					Column = WindowCount;
				}
				else
				{
					Column = MaxCol;
				}
				Tab.SetAutoScrollMargin(0,0);
				int Width = (this.ClientRectangle.Width-7)/Column;
				int Height = (this.ClientRectangle.Height-this.statusBarEx1.Height-27)/Row;
				int curRow;
				int Mod;
				for(int i=0;i<WindowCount;i++)
				{
					Tab.Controls[i].Width = Width;
					Tab.Controls[i].Height = Height;
					curRow = Math.DivRem(i,Column,out Mod);
					Tab.Controls[i].Left = Mod*Width;
					Tab.Controls[i].Top = curRow*Height;
				}
			}
		}

		private void ResizeChildWindowsFollow(TabPage Tab)
		{
			if(Tab.Controls.Count > 0)
			{
				int WindowCount = Tab.Controls.Count;
				int Column,Row;

				Row = (int)Math.Floor((WindowCount-1)/MaxCol)+1;
				if(WindowCount < MaxCol)
				{
					Column = WindowCount;
				}
				else
				{
					Column = MaxCol;
				}
				Tab.SetAutoScrollMargin(0,0);
				//Tab.ScrollControlIntoView(Tab);
				int Width = (this.ClientSize.Width-7)/Column;
				int Height;
				int MaxHeight = 0, tmp;
				ListForm.ListForm lf;
				for(int i=0;i<Tab.Controls.Count;i++)
				{
					lf = (ListForm.ListForm)Tab.Controls[i];
					tmp = lf.ListBox.ItemHeight * (lf.ListBox.Items.Count+3) + lf.Caption.Height;
					if(MaxHeight < tmp)
					{
						MaxHeight = tmp;
					}
				}
				Height = MaxHeight;
				int curRow;
				int Mod;
				for(int i=0;i<WindowCount;i++)
				{
					Tab.Controls[i].Width = Width;
					Tab.Controls[i].Height = Height;
					curRow = Math.DivRem(i,Column,out Mod);
					Tab.Controls[i].Left = Mod*Width;
					Tab.Controls[i].Top = curRow*Height;
				}
			}
		}

		private void menuItemAutoArrange_Click(object sender, System.EventArgs e)
		{
			//this.LayoutMdi(MdiLayout.Cascade);
			this.AutoResize = true;
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				this.ResizeChildWindows(this.tabControlDrawingList.SelectedTab);
			}
		}

		private void menuItemFollowedArrange_Click(object sender, System.EventArgs e)
		{
			//this.LayoutMdi(MdiLayout.TileHorizontal);
			this.AutoResize = false;
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				this.ResizeChildWindows(this.tabControlDrawingList.SelectedTab);
			}
		}

		private void menuItemProperties_Click(object sender, System.EventArgs e)
		{
			
		}

		private void Control_Click(object sender, System.EventArgs e)
		{
			switch(sender.GetType().ToString())
			{
				case "ListForm.ListForm":
					//this.label1.Text = ((ListForm.ListForm)sender).Name + " Click";
					break;
				case "System.Windows.Forms.TabPage":
					this.ResizeChildWindows((TabPage)sender);
					break;
				default:
					break;
			}
		}

		private void menuItemNew_Click(object sender, System.EventArgs e)
		{
			// 
			// tabPage Drawing List
			// 
			TabPage newTab = new TabPage();
			newTab.Location = new System.Drawing.Point(4, 4);
			newTab.Name = "DrawingList" + ((int)(tabControlDrawingList.TabCount+1)).ToString();
			newTab.AutoScroll = true;
			newTab.AutoScrollPosition = new Point(0,0);
			newTab.TabIndex = tabControlDrawingList.TabCount;
			newTab.Text = "Drawing List " + ((int)(tabControlDrawingList.TabCount+1)).ToString();
			newTab.Click += new System.EventHandler(this.Control_Click);

			FormNewProject FNewProject = new FormNewProject();			
			if(FNewProject.ShowDialog() == DialogResult.OK)
			{
				this.ProjectType[this.tabControlDrawingList.Controls.Count] = FNewProject.ProjectType;
				if(FNewProject.ProjectType == AMS)
				{
					this.ProjSavePath[this.tabControlDrawingList.Controls.Count] = FNewProject.SavePath + "\\" + FNewProject.FileName;
				}
				else
				{
					this.ProjSavePath[this.tabControlDrawingList.Controls.Count] = FNewProject.SavePath;
				}

				//Set Name
				newTab.Text = FNewProject.FileName;

				this.tabControlDrawingList.Controls.Add(newTab);
				this.tabControlDrawingList.SelectedTab = newTab;
				this.menuItemNewChild.Enabled = true;

				this.SaveProject(false);
			}
		}

		private void menuItemClose_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.SelectedTab != null)
			{
				DialogResult dr = MessageBox.Show("Do you want to save the current project: " + this.tabControlDrawingList.SelectedTab.Text + "?", 
					"Save Drawing List",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if(dr == DialogResult.Yes)
				{
					this.SaveProject(false);
					MessageBox.Show("Drawing List " + this.tabControlDrawingList.SelectedTab.Text + " is saved to " + this.ProjSavePath[this.tabControlDrawingList.SelectedIndex], 
						"Save Drawing List",MessageBoxButtons.OK, MessageBoxIcon.Information);
					ArrayRemoveAt(this.ProjSavePath,this.tabControlDrawingList.SelectedIndex);
					ArrayRemoveAt(this.ProjectType,this.tabControlDrawingList.SelectedIndex);
					this.tabControlDrawingList.Controls.RemoveAt(this.tabControlDrawingList.SelectedIndex);
				}
				else
				{
					if(dr == DialogResult.No)
					{
						ArrayRemoveAt(this.ProjSavePath,this.tabControlDrawingList.SelectedIndex);
						ArrayRemoveAt(this.ProjectType,this.tabControlDrawingList.SelectedIndex);
						this.tabControlDrawingList.Controls.RemoveAt(this.tabControlDrawingList.SelectedIndex);
					}
				}
				if(this.tabControlDrawingList.Controls.Count == 0)
				{
					ResetTitleAndStatusBar();
				}
			}
		}

		private void menuItemSave_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				SaveProject(false);
			}
		}

		private void menuItemSaveAs_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				SaveProject(true);
				//save current project as well to reset the save path since SaveProject will change the save path
				SaveProject(false);
			}
		}

		public void SaveProject(bool bSaveAs)
		{
			if(this.tabControlDrawingList.SelectedTab != null)
			{
				//Save project
				ListForm.ListForm[] DrawingListWindow = new ListForm.ListForm[this.tabControlDrawingList.SelectedTab.Controls.Count];
				for(int i=0;i<this.tabControlDrawingList.SelectedTab.Controls.Count;i++)
				{
					DrawingListWindow[i] = (ListForm.ListForm)this.tabControlDrawingList.SelectedTab.Controls[i];
				}
				DrawingListProject dp = new DrawingListProject(ProjectType[this.tabControlDrawingList.SelectedIndex],
					this.tabControlDrawingList.SelectedTab.Text,
					this.ProjSavePath[this.tabControlDrawingList.SelectedIndex],
					this.tabControlDrawingList.SelectedTab.Controls.Count,
					DrawingListWindow);
				dp.Save(bSaveAs);
			}
		}

		private void menuItemPageSetup_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItemPrintPreview_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItemPrint_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItemAMSHelp_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItemAbout_Click(object sender, System.EventArgs e)
		{
			FormAbout FA = new FormAbout();
			FA.Show();
		}

		public int GetMaxWindowNumber(int TabPageIndex)
		{
			int Max=0, tmp, count;
			string s;
			count = this.tabControlDrawingList.GetControl(TabPageIndex).Controls.Count;
			if(count == 0)
			{
				return 0;
			}
			//check Caption number
			for(int i=0;i<count; i++)
			{
				ListForm.ListForm lf = (ListForm.ListForm)this.tabControlDrawingList.SelectedTab.Controls[i];
				s = lf.Caption.Text.Remove(0,1);
				try
				{
					tmp = System.Convert.ToInt32(s);
				}
				catch(Exception e)
				{
					tmp = 0;
				}
				if(Max < tmp)
				{
					Max = tmp;
				}
			}
			//check Name number
			for(int i=0;i<count; i++)
			{
				ListForm.ListForm lf = (ListForm.ListForm)this.tabControlDrawingList.SelectedTab.Controls[i];
				s = lf.Name.Remove(0,1);
				try
				{
					tmp = System.Convert.ToInt32(s);
				}
				catch(Exception e)
				{
					tmp = 0;
				}
				if(Max < tmp)
				{
					Max = tmp;
				}
			}
			return Max+1;
		}

		private void menuItemNewChild_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				ListForm.ListForm newListForm = new ListForm.ListForm();
				newListForm.Caption.Text = "A" + this.GetMaxWindowNumber(this.tabControlDrawingList.SelectedIndex);
				newListForm.Name = newListForm.Caption.Text;
				newListForm.SavePath = this.ProjSavePath[this.tabControlDrawingList.SelectedIndex] + "\\" + sDrawingList +"\\" + newListForm.Caption.Text;
				newListForm.ContextMenu = this.contextMenuWindow;
				newListForm.Enter += new System.EventHandler(this.Control_Enter);

				this.tabControlDrawingList.SelectedTab.Controls.Add(newListForm);

				ResizeChildWindows(this.tabControlDrawingList.SelectedTab);
			}
		}

		private void Control_Enter(object sender, System.EventArgs e)
		{
			switch(sender.GetType().ToString())
			{
				case "ListForm.ListForm":
					this.SelectedWindow = (ListForm.ListForm)sender;
					//this.tabControlDrawingList.SelectedTab.Text = this.SelectedWindow.Name + " Enter";
					break;
				default:
					//this.tabControlDrawingList.SelectedTab.Text = sender.ToString()+" Enter";
					break;
			}
		}

		private void menuItemDelDrawingList_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.SelectedTab != null)
			{
				DialogResult DlgResult = MessageBox.Show("Are you sure you want to delete this project: " + this.tabControlDrawingList.SelectedTab.Text + "?" , 
					"Delete Drawing List",MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
				if(DlgResult == DialogResult.Yes)
				{
					ArrayRemoveAt(this.ProjSavePath,this.tabControlDrawingList.SelectedIndex);
					ArrayRemoveAt(this.ProjectType,this.tabControlDrawingList.SelectedIndex);
					this.tabControlDrawingList.Controls.RemoveAt(this.tabControlDrawingList.SelectedIndex);
				}
				if(this.tabControlDrawingList.Controls.Count == 0)
				{
					ResetTitleAndStatusBar();
				}
			}
		}

		public void ArrayRemoveAt(Array ar, int index)
		{
			if((index >= ar.Length) || (index < 0))
			{
				return;
			}
			for(int i=index; i<ar.Length-1;i++)
			{
				ar.SetValue(ar.GetValue(i+1),i);
			}
			ar.SetValue(null,ar.Length-1);
		}

		private void tabControlDrawingList_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				ResizeChildWindows(this.tabControlDrawingList.SelectedTab);
			}
		}

		private void tabControlDrawingList_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				this.Text = sApplicationName + " - " + this.ProjSavePath[this.tabControlDrawingList.SelectedIndex] + "\\" + this.tabControlDrawingList.SelectedTab.Text + "." + sProjectTypesList[this.ProjectType[this.tabControlDrawingList.SelectedIndex]];
				ResizeChildWindows(this.tabControlDrawingList.SelectedTab);
			}
		}

		private void menuItemRenameWindow_Click(object sender, System.EventArgs e)
		{
			Point pt = this.tabControlDrawingList.SelectedTab.PointToClient(Control.MousePosition);
			ListForm.ListForm lf = (ListForm.ListForm)this.tabControlDrawingList.SelectedTab.GetChildAtPoint(pt);
			if(lf!=null)
			{
				FormRenameWindow RenameForm1 = new FormRenameWindow(lf,this.tabControlDrawingList.SelectedTab);
				if(RenameForm1.ShowDialog() == DialogResult.OK)
				{
					if(RenameForm1.newName!=null)
					{
						//lf.DeleteInDisk();
						string NewPath = this.ProjSavePath[this.tabControlDrawingList.SelectedIndex] + "\\" + sDrawingList + "\\" + RenameForm1.newName;
						DirectoryInfo di = new DirectoryInfo(this.ProjSavePath[this.tabControlDrawingList.SelectedIndex] + "\\" + sDrawingList + "\\" + lf.Caption.Text);
						try
						{
							if(di.Exists)
							{
								di.MoveTo(NewPath);
							}
						}
						catch(Exception exp)
						{
							MessageBox.Show("Error saving new name: " + exp.Message.ToString(),"Drawing List Window");
							return;
						}
						lf.Caption.Text = RenameForm1.newName;
						lf.SavePath = NewPath;
						this.SaveProject(false);
					}
				}
			}
		}

		private void menuItemDeleteWindow_Click(object sender, System.EventArgs e)
		{
			Point pt = this.tabControlDrawingList.SelectedTab.PointToClient(Control.MousePosition);
			ListForm.ListForm lf = (ListForm.ListForm)this.tabControlDrawingList.SelectedTab.GetChildAtPoint(pt);

			DialogResult DlgResult = MessageBox.Show("Are you sure you want to delete this Drawing Window: " + lf.Caption.Text + "?" , 
				"Delete Drawing Window",MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
			if(DlgResult == DialogResult.Yes)
			{
				this.tabControlDrawingList.SelectedTab.Controls.Remove(lf);
				if(this.tabControlDrawingList.Controls.Count > 0)
				{
					ResizeChildWindows(this.tabControlDrawingList.SelectedTab);
				}
			}
		}

		public void ChangeNameAllWindow()
		{
			int count = this.tabControlDrawingList.SelectedTab.Controls.Count;
			string NewName;
			for(int i=0 ; i< count; i++)
			{
				NewName = "A" + i.ToString();
				((ListForm.ListForm)this.tabControlDrawingList.SelectedTab.Controls[i]).Name = NewName;
				((ListForm.ListForm)this.tabControlDrawingList.SelectedTab.Controls[i]).Caption.Text = NewName;
			}
		}

		private void menuItemPublishWindow_Click(object sender, System.EventArgs e)
		{
			/*
			Point pt = this.tabControlDrawingList.SelectedTab.PointToClient(Control.MousePosition);
			ListForm.ListForm lf = (ListForm.ListForm)this.tabControlDrawingList.SelectedTab.GetChildAtPoint(pt);
			lf.Print();
			*/
		}

		private void menuItemCut_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.SelectedTab != null)
			{
				if((this.tabControlDrawingList.SelectedTab.Controls != null) && (this.SelectedWindow != null))
				{
					this.SelectedWindow.menuItemCut_Click(sender,e);
				}
			}
		}

		private void menuItemCopy_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.SelectedTab != null)
			{
				if((this.tabControlDrawingList.SelectedTab.Controls != null) && (this.SelectedWindow != null))
				{
					this.SelectedWindow.menuItemCopy_Click(sender,e);
				}
			}
		}

		private void menuItemDelete_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.SelectedTab != null)
			{
				if((this.tabControlDrawingList.SelectedTab.Controls != null) && (this.SelectedWindow != null))
				{
					this.SelectedWindow.menuItemDelete_Click(sender,e);
				}
			}
		}

		private void menuItemPaste_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.SelectedTab != null)
			{
				if((this.tabControlDrawingList.SelectedTab.Controls != null) && (this.SelectedWindow != null))
				{
					this.SelectedWindow.menuItemPaste_Click(sender,e);
				}
			}
		}

		private void menuItemSendtoIssued_Click(object sender, System.EventArgs e)
		{
			if(this.ProjectType[this.tabControlDrawingList.SelectedIndex] == AMS)
			{
				string Today = System.DateTime.Today.ToString("yyyy-MM-dd");
				string SavePath = this.ProjSavePath[this.tabControlDrawingList.SelectedIndex]+ "\\" + sIssued + "\\" + Today;
				string subSavePath;
				//Folder current date
				DirectoryInfo di = new DirectoryInfo(SavePath);
				if(di.Exists)
				{
					di.Delete(true);
				}
				di.Create();
				//Copy all from Drawing List to Issued
				if(this.tabControlDrawingList.SelectedTab != null)
				{
					int count = this.tabControlDrawingList.SelectedTab.Controls.Count;
					for(int i=0 ; i< count; i++)
					{
						subSavePath = SavePath + "\\" + ((ListForm.ListForm)this.tabControlDrawingList.SelectedTab.Controls[i]).Caption.Text;
						((ListForm.ListForm)this.tabControlDrawingList.SelectedTab.Controls[i]).SaveTo(subSavePath);
					}
					MessageBox.Show("Save completed to " + this.ProjSavePath[this.tabControlDrawingList.SelectedIndex] + "\\" + sIssued, 
						"Save Issued",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void menuItemOpen_Click(object sender, System.EventArgs e)
		{
			DrawingListProject dp = new DrawingListProject();
			string CurPath = dp.Open();
			if(dp.ProjectName != null)
			{
				for(int i=0; i< this.tabControlDrawingList.Controls.Count; i++)
				{
					if(this.tabControlDrawingList.Controls[i].Text == dp.ProjectName)
					{
						this.tabControlDrawingList.SelectedTab = (TabPage)this.tabControlDrawingList.Controls[i];
						return;
					}
				}
				ChangeSavePath(dp,CurPath);
				AddTabPage(dp);
			}
		}

		private void ChangeSavePath(DrawingListProject dp, string CurPath)
		{
			int index = CurPath.LastIndexOf("\\");
			int count = CurPath.Length - index;
			CurPath = CurPath.Remove(index,count);

			dp.ProjSavePath = CurPath;
			for(int i=0; i<dp.WindowCount;i++)
			{
				dp.DrawingListWindows[i].SavePath = CurPath + "\\" + sDrawingList + "\\" + dp.DrawingListWindows[i].Caption.Text;
				/*
				if(dp.ProjectType == AMS)
				{
					for(int j=0; j< dp.DrawingListWindows[i].FileList.Count;j++)
					{
						dp.DrawingListWindows[i].FileList.AMSFiles[j].FilePath = dp.DrawingListWindows[i].SavePath + "\\" + dp.DrawingListWindows[i].FileList.AMSFiles[j].FileName + ".dwg";
					}
				}
				*/
			}
		}

		public void AddTabPage(DrawingListProject dp)
		{
			// 
			// tabPage Drawing List
			// 
			TabPage newTab = new TabPage();
			newTab.Location = new System.Drawing.Point(4, 4);
			newTab.Name = "DrawingList" + ((int)(tabControlDrawingList.TabCount+1)).ToString();
			newTab.AutoScroll = true;
			newTab.TabIndex = tabControlDrawingList.TabCount;
			newTab.Text = "Drawing List " + ((int)(tabControlDrawingList.TabCount+1)).ToString();

			this.ProjSavePath[this.tabControlDrawingList.Controls.Count] = dp.ProjSavePath;
			this.ProjectType[this.tabControlDrawingList.Controls.Count] = dp.ProjectType;

			//Set Name
			newTab.Text = dp.ProjectName;
			
			//Add TabPage
			this.tabControlDrawingList.Controls.Add(newTab);
			this.menuItemNewChild.Enabled = true;
			
			//Add child Drawing List Window
			this.tabControlDrawingList.SelectedTab = newTab;
			for(int i=0; i<dp.WindowCount;i++)
			{
				//dp.DrawingListWindows[i].Name = "A" + this.tabControlDrawingList.SelectedTab.Controls.Count.ToString();
				dp.DrawingListWindows[i].Enter += new System.EventHandler(this.Control_Enter);
				dp.DrawingListWindows[i].ContextMenu = this.contextMenuWindow;
				newTab.Controls.Add(dp.DrawingListWindows[i]);
			}
			ResizeChildWindows(this.tabControlDrawingList.SelectedTab);
		}

		private void menuItemRenameAllWindows_Click(object sender, System.EventArgs e)
		{
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				this.ChangeNameAllWindow();
			}
		}

		public void ResetTitleAndStatusBar()
		{
			this.Text = sApplicationName;
			this.statusBarEx1.Panels[0].Text = "";
		}

		private void FormMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.tabControlDrawingList.Controls.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Do you want to save all the opening projects?", 
					"Save Drawing List",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if(dr == DialogResult.Yes)
				{
					int count = this.tabControlDrawingList.Controls.Count;
					for(int j=0; j< count;j++)
					{
						this.SaveProject(false);
						ArrayRemoveAt(this.ProjSavePath,this.tabControlDrawingList.SelectedIndex);
						ArrayRemoveAt(this.ProjectType,this.tabControlDrawingList.SelectedIndex);
						this.tabControlDrawingList.Controls.RemoveAt(this.tabControlDrawingList.SelectedIndex);
					}						
				}
				else
				{
					if(dr == DialogResult.No)
					{
					}
					else
					{
						return;
					}
				}
			}
		}
	}
}
