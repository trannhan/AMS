using System;

namespace ListForm
{
	/// <summary>
	/// Summary description for AMSFileList.
	/// </summary>
	public class AMSFileList
	{
		public const int DrawinglistNum = 1000;

		public AMSFileInfo[] AMSFiles;
		public int Count;

		public struct AMSFileInfo
		{
			public string FileName;
			public string FilePath;
			
			public AMSFileInfo(string FileName, string FilePath)
			{
				this.FileName = FileName;
				this.FilePath = FilePath;
			}
			public AMSFileInfo(AMSFileInfo fi)
			{
				this.FileName = fi.FileName;
				this.FilePath = fi.FilePath;
			}
		}
			
		public AMSFileList()
		{
			//
			// TODO: Add constructor logic here
			//
			this.AMSFiles = new AMSFileInfo[DrawinglistNum];
			this.Count=0;
		}

		public AMSFileList(int size)
		{
			this.AMSFiles = new AMSFileInfo[size];
			this.Count=0;
		}

		public int Add(string FileName, string FilePath)
		{
			if(this.Count < this.AMSFiles.Length)
			{
				this.AMSFiles[this.Count].FileName = FileName;
				this.AMSFiles[this.Count].FilePath = FilePath;
				this.Count++;
				return this.Count-1;
			}
			return -1;
		}

		public int Add(AMSFileInfo FileInfo)
		{
			if(this.Count < this.AMSFiles.Length)
			{
				this.AMSFiles[this.Count].FileName = FileInfo.FileName;
				this.AMSFiles[this.Count].FilePath = FileInfo.FilePath;
				this.Count++;
				return this.Count-1;
			}
			return -1;
		}

		public void RemoveAt(int index)
		{
			if((index >= this.Count) || (index < 0))
			{
				return;
			}
			for(int i=index; i<this.Count-1;i++)
			{
				this.AMSFiles.SetValue(this.AMSFiles[i+1],i);
			}
			this.AMSFiles.SetValue(new AMSFileInfo(),this.Count-1);
			this.Count--;
		}

		public bool isExisted(string FileName)
		{
			for(int i=0; i<this.Count; i++)
			{
				if(this.AMSFiles[i].FileName == FileName)
				{
					return true;
				}
			}
			return false;
		}

		public bool isExisted(string FileName, int index)
		{
			for(int i=0; i<this.Count; i++)
			{
				if(i == index)
					continue;
				if(this.AMSFiles[i].FileName == FileName)
				{
					return true;
				}
			}
			return false;
		}
	}
}
