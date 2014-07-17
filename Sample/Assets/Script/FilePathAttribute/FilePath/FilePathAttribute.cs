using UnityEngine;
using System.Collections;

public class FilePathAttribute : PropertyAttribute {

	public int m_ButtonWidth;

	public FilePathAttribute( int wid=20 )
	{
		this.m_ButtonWidth = wid;
	}

}
