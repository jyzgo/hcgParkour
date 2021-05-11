﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class EditorExtension  {

	[MenuItem("GameObject/Expand Hierarchy", false,0)]
	static void Unfold()
	{
		SetExpandeRecursive(Selection.activeGameObject,true);
	}

	


	public static void SetExpandeRecursive(GameObject go,bool expand)
	{

		if(go == null)
		{
			foreach (GameObject obj in Object.FindObjectsOfType(typeof(GameObject)))
			{
				SetExpandeRecursive(obj,expand);
			}

			return;
		}
		var type = typeof(EditorWindow).Assembly.GetType("UnityEditor.SceneHierarchyWindow");
		var methodInfo = type.GetMethod("SetExpandedRecursive");


        EditorApplication.ExecuteMenuItem("Window/General/Hierarchy");
        var window = EditorWindow.focusedWindow;
		methodInfo.Invoke(window,new object[]{go.GetInstanceID(),expand});
	}
}
