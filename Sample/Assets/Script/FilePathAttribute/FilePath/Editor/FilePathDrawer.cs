using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomPropertyDrawer (typeof(FilePathAttribute))]
class FilePathDrawer : PropertyDrawer {
	
	// Draw the property inside the given rect
	public override void OnGUI (Rect position , SerializedProperty property, GUIContent label) {
		
		// First get the attribute since it contains the range for the slider
		var attr = (FilePathAttribute) this.attribute;
		
		// Now draw the property as a Slider or an IntSlider based on whether it's a float or integer.
		switch( property.propertyType ) {
			case SerializedPropertyType.String:

				var path = property.stringValue;
				var contentRect = EditorGUI.PrefixLabel( position, label );
				var textRect = contentRect;
				var ButtonRect = contentRect;
				
				textRect.width -= attr.m_ButtonWidth;
				ButtonRect.width = attr.m_ButtonWidth;
				ButtonRect.x = textRect.xMax;
				//EditorGUI.TextField( textRect, label.text );
				path = EditorGUI.TextField( textRect, path );
				var select = GUI.Button( ButtonRect, "..." );
				if( select ){
					path = EditorUtility.OpenFilePanel( "Select File", path, "" );
				}

				if( !string.IsNullOrEmpty( path ) ) property.stringValue = path;

				break;
			default:
				EditorGUI.LabelField( position, label.text, "Use FilePathDrawer with string." );
				break;
		}

	}
}