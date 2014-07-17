using UnityEngine;
using System.Collections;

public class FolderPathAttribute : PropertyAttribute
{

	public int m_ButtonWidth;

	public FolderPathAttribute( int wid = 20 )
	{
		this.m_ButtonWidth = wid;
	}

}
