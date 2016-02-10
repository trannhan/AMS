using System;

namespace ListForm
{
	/// <summary>
	/// Summary description for ClassUndo.
	/// </summary>
	public class ClassUndo
	{		
		public const int UndoMax = 1000;
		public const int NEWDRAWING = 1;
		public const int CUT = 2;
		public const int PASTE = 3;
		public const int DELETE = 4;
		public const int RENAME = 5;
		
		public StructUndo[] UndoSteps;
		public int SelectedStep;
		public int Count;

		public struct StructUndo
		{
			public int Action;
			public AMSFileList PreItems;

			public StructUndo(int Action, AMSFileList PreItems)
			{
				//
				// TODO: Add constructor logic here
				//
				this.Action = Action;
				this.PreItems = new AMSFileList();
				this.PreItems.Count = PreItems.Count;
				for(int i=0; i<this.PreItems.Count; i++)
				{
					this.PreItems.AMSFiles[i].FileName = PreItems.AMSFiles[i].FileName;
					this.PreItems.AMSFiles[i].FilePath = PreItems.AMSFiles[i].FilePath;
				}
			}
		}

		public ClassUndo()
		{
			//
			// TODO: Add constructor logic here
			//
			this.UndoSteps = new StructUndo[UndoMax];
		}

		public void Add(int Action, AMSFileList PreItems)
		{
			if(this.Count < UndoMax)
			{
				this.UndoSteps[Count] = new StructUndo(Action, PreItems);
				this.SelectedStep = this.Count++;
			}
		}

		public void UndoAction()
		{
			if(this.SelectedStep >= 0)
			{
				ClassCommonAPIs CApi= new ClassCommonAPIs();
				CApi.ArrayRemoveAt(this.UndoSteps,this.SelectedStep);
				this.SelectedStep--;
				this.Count--;
			}
		}

		public void RedoAction()
		{
			if(this.SelectedStep < Count-1)
			{
				this.SelectedStep++;
			}
		}
	}
}
