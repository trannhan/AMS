using System;
using ListForm;
using System.IO;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;


namespace AMS
{
	/// <summary>
	/// Summary description for DrawingListProject.
	/// </summary>
	public class DrawingListProject
	{
		public const int DrawinglistNum =1000;
		public const string sIdentity = "Architecture Management System - nhantran11@yahoo.com";
		public const int AMS = 0;
		public const int AMT = 1;
		/*
		public const string sIssued = "Issued";
		public const string sDrawingList = "Drawing List";
		public const string sDrawingForAttachment = "Drawing For Attachment";
		*/
		public const string sIssued = "04 Issued";
		public const string sDrawingList = "03 Output";
		public const string sDrawingForAttachment = "02 Input";
		public const string sInformation = "01 Information";

		public string[] sProjectTypesList;
		public int ProjectType; //"ams"=0; "amt"=1
		public string ProjectName;
		public string ProjSavePath;
		public int WindowCount;
		public ListForm.ListForm[] DrawingListWindows;
		public DrawingListProject()
		{
			//
			// TODO: Add constructor logic here
			//
			sProjectTypesList = (new string[] {"ams", "amt"});
		}

		public DrawingListProject(int ProjectType, string ProjectName, string ProjSavePath, int WindowCount, ListForm.ListForm[] DrawingListWindows)
		{
			//
			// TODO: Add constructor logic here
			//
			sProjectTypesList = (new string[] {"ams", "amt"});

			this.ProjectType = ProjectType;
			this.ProjectName = ProjectName;
			this.ProjSavePath = ProjSavePath;
			this.WindowCount = WindowCount;
			this.DrawingListWindows = DrawingListWindows;
		}

		public void Save(bool bSaveAs)
		{
			if(bSaveAs)
			{
				FormNewProject FNewProject = new FormNewProject();			
				if(FNewProject.ShowDialog() == DialogResult.OK)
				{
					this.ProjectType = FNewProject.ProjectType;
					this.ProjectName = FNewProject.FileName;
					if(FNewProject.ProjectType == AMS)
					{
						this.ProjSavePath = FNewProject.SavePath + "\\" + FNewProject.FileName;
					}
					else
					{
						this.ProjSavePath = FNewProject.SavePath;
					}
				}
				else
				{
					return;
				}
			}
			Cursor.Current = Cursors.WaitCursor;

			if(this.ProjectType == AMS) //need to save directories and files
			{
				DirectoryInfo diTemp;
				DirectoryInfo di;
				string Path = this.ProjSavePath;
				try
				{
					//Project Folder
					di = new DirectoryInfo(Path);
					if(!di.Exists)
					{
						di.Create();
					}
					//
					//Save Directories and project
					//
					string TempPath = Path + "\\" + "temp";
					diTemp = new DirectoryInfo(TempPath);
					if(diTemp.Exists)
					{
						diTemp.Delete(true);
					}
					
					//Folder Issued
					string subPath = Path + "\\" + sIssued;
					di = new DirectoryInfo(subPath);
					if(!di.Exists)
					{
						di.Create();
					}
					
					//Folder Drawing List
					subPath = Path + "\\" + sDrawingList;
					di = new DirectoryInfo(subPath);
					if(!di.Exists)
					{
						di.Create();
					}
					else
					{
						di.MoveTo(TempPath);
						ChangeFilePath(TempPath);
						di = new DirectoryInfo(subPath);
						di.Create();
					}
					
					//Folder Drawing For Attachment
					subPath = Path + "\\" + sDrawingForAttachment;
					di = new DirectoryInfo(subPath);
					if(!di.Exists)
					{
						di.Create();
					}
					
					//Folder Information
					subPath = Path + "\\" + sInformation;
					di = new DirectoryInfo(subPath);
					if(!di.Exists)
					{
						di.Create();
					}
				}
				catch(Exception e)
				{
					MessageBox.Show("Save error: \n" + e.Message, 
						"Drawing List Project",MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				for(int i=0 ; i< this.WindowCount; i++)
				{
					this.DrawingListWindows[i].SavePath = this.ProjSavePath + "\\" + sDrawingList + "\\" + this.DrawingListWindows[i].Caption.Text;
					this.DrawingListWindows[i].SaveAll();
				}
				ChangeFilePath();
				if(diTemp.Exists)
				{
					diTemp.Delete(true);
				}
			}
			
			SaveOutlineBinary(this.ProjSavePath + "\\" + this.ProjectName + "." + sProjectTypesList[this.ProjectType]);

			Cursor.Current = Cursors.Default;
			/*
			MessageBox.Show("Drawing List " + this.ProjectName + " is saved to " + this.ProjSavePath, 
				"Save Drawing List",MessageBoxButtons.OK, MessageBoxIcon.Information);
			*/
		}

		public void ChangeFilePath()
		{
			int i,j;
			for( i=0; i<this.WindowCount;i++)
			{
				for( j=0; j< this.DrawingListWindows[i].FileList.Count;j++)
				{
					this.DrawingListWindows[i].FileList.AMSFiles[j].FilePath = this.DrawingListWindows[i].SavePath + "\\" + this.DrawingListWindows[i].FileList.AMSFiles[j].FileName + ".dwg";
				}
			}
		}

		public void ChangeFilePath(string NewPathOfDrawingList)
		{
			int i,j;
			string NewPath, NewFilePath;
			string[] FileName;
			FileInfo fi;

			for( i=0; i<this.WindowCount;i++)
			{
				for( j=0; j< this.DrawingListWindows[i].FileList.Count;j++)
				{
					/*
					if(this.DrawingListWindows[i].FileList.AMSFiles[j].FilePath.IndexOf(this.DrawingListWindows[i].SavePath)!=-1)
					{
						NewPath = NewPathOfDrawingList + "\\" + this.DrawingListWindows[i].Caption.Text;
						NewFilePath = this.DrawingListWindows[i].FileList.AMSFiles[j].FilePath.Replace(this.DrawingListWindows[i].SavePath,NewPath);
						this.DrawingListWindows[i].FileList.AMSFiles[j].FilePath = NewFilePath;
					}
					*/	
					NewPath = NewPathOfDrawingList + "\\" + this.DrawingListWindows[i].Caption.Text;
					FileName = this.DrawingListWindows[i].FileList.AMSFiles[j].FilePath.Split('\\');
					//NewFilePath = NewPath + "\\" + this.DrawingListWindows[i].FileList.AMSFiles[j].FileName + ".dwg";
					NewFilePath = NewPath + "\\" + FileName[FileName.Length -1];
					fi =new FileInfo(NewFilePath);
					if(fi.Exists)
					{
						this.DrawingListWindows[i].FileList.AMSFiles[j].FilePath = NewFilePath;
					}
				}
			}
		}

		public void SaveOutlineText(string FileName)
		{
			StreamWriter SWriter = new StreamWriter(FileName,false,System.Text.Encoding.ASCII);
			if(SWriter!=null)
			{
				try
				{
					SWriter.WriteLine(sIdentity);
					SWriter.WriteLine(this.ProjectType);
					SWriter.WriteLine(this.ProjectName);
					SWriter.WriteLine(this.ProjSavePath);
					SWriter.WriteLine(this.WindowCount);
				
					for(int i=0;i<this.WindowCount;i++)
					{
						this.DrawingListWindows[i].SaveOutlineText(SWriter);
					}
					SWriter.Flush();
					SWriter.Close();
				}
				catch(Exception e)
				{
					MessageBox.Show("Save outline error: \n" + e.Message, 
						"Drawing List Project",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public void SaveOutlineBinary(string FileName)
		{
			FileStream fs = new FileStream(FileName,System.IO.FileMode.Create,System.IO.FileAccess.ReadWrite);
			BinaryWriter bw = new BinaryWriter(fs);
			if(bw!=null)
			{
				try
				{
					bw.Write(sIdentity);
					bw.Write((int)this.ProjectType);
					bw.Write(this.ProjectName);
					bw.Write(this.ProjSavePath);
					bw.Write((int)this.WindowCount);
				
					for(int i=0;i<this.WindowCount;i++)
					{
						this.DrawingListWindows[i].SaveOutlineBinary(bw);
					}
					bw.Close();
					fs.Close();
				}
				catch(Exception e)
				{
					MessageBox.Show("Save outline error: \n" + e.Message, 
						"Drawing List Project",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public string Open()
		{
			OpenFileDialog OpenDlg = new OpenFileDialog();
			OpenDlg.Filter = "Archsoft Project (*.ams)|*.ams|Archsoft Project Template (*.amt)|*.amt";
			DialogResult DlgResult = OpenDlg.ShowDialog();
			if(DlgResult == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				LoadOutlineBinary(OpenDlg.FileName);
				Cursor.Current = Cursors.Default;
				return OpenDlg.FileName;
			}
			return null;
		}

		public void LoadOutlineText(string FileName)
		{
			StreamReader SReader = new StreamReader(FileName);
			if(SReader!=null)
			{
				try
				{
					string Identity = SReader.ReadLine();
					if(Identity == sIdentity)
					{
						this.ProjectType = System.Convert.ToInt32(SReader.ReadLine());
						this.ProjectName = SReader.ReadLine();
						this.ProjSavePath = SReader.ReadLine();
						this.WindowCount = System.Convert.ToInt32(SReader.ReadLine());
						this.DrawingListWindows = new ListForm.ListForm[DrawinglistNum];
						for(int i=0;i<this.WindowCount;i++)
						{
							if(SReader.Peek()>0)
							{
								this.DrawingListWindows[i] = new ListForm.ListForm();
								this.DrawingListWindows[i].ReadOutlineText(SReader);
								this.DrawingListWindows[i].Name = "A" + i.ToString();
							}
							else
							{
								break;
							}
						}
					}
					SReader.Close();
				}
				catch(Exception e)
				{
					MessageBox.Show("Read outline error: \n" + e.Message, 
						"Drawing List Project",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public void LoadOutlineBinary(string FileName)
		{
			FileStream fs = new FileStream(FileName,System.IO.FileMode.Open,System.IO.FileAccess.ReadWrite);
			BinaryReader br = new BinaryReader(fs);
			if(br!=null)
			{
				try
				{
					string Identity = br.ReadString();
					if(Identity == sIdentity)
					{
						this.ProjectType = br.ReadInt32();
						this.ProjectName = br.ReadString();
						this.ProjSavePath = br.ReadString();
						this.WindowCount = br.ReadInt32();
						this.DrawingListWindows = new ListForm.ListForm[DrawinglistNum];
						for(int i=0;i<this.WindowCount;i++)
						{
							if(br.PeekChar()>0)
							{
								this.DrawingListWindows[i] = new ListForm.ListForm();
								this.DrawingListWindows[i].ReadOutlineBinary(br);
								this.DrawingListWindows[i].Name = "A" + i.ToString();
							}
							else
							{
								break;
							}
						}
					}
					br.Close();
					fs.Close();
				}
				catch(Exception e)
				{
					MessageBox.Show("Read outline error: \n" + e.Message, 
						"Drawing List Project",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
