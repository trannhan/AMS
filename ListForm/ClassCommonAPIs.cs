using System;

namespace ListForm
{
	/// <summary>
	/// Summary description for ClassCommonAPIs.
	/// </summary>
	public class ClassCommonAPIs
	{
		public ClassCommonAPIs()
		{
			//
			// TODO: Add constructor logic here
			//
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
	}
}
