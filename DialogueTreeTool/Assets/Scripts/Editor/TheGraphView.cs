using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class TheGraphView : GraphView
{
    public TheGraphView()
    {
        SetStyleSheet();
        CreateGridBackground();
    }

    private void SetStyleSheet()
    {
        StyleSheet styleSheet = EditorGUIUtility.Load("DialogueTreeStyleSheet.uss") as StyleSheet;
        styleSheets.Add(styleSheet);
    }

    private void CreateGridBackground()
    {
        GridBackground gridBackground = new GridBackground();
        gridBackground.StretchToParentSize();
        Insert(0, gridBackground);
    }
}
