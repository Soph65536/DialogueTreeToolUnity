using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

public class DialogueTreeEditorWindow : EditorWindow
{
    TheGraphView graphView;

    //path in unity UI to access the tool window
    [MenuItem("Window/Tools/Dialogue Tree Maker")]
    //static method belongs to the whole class
    public static void OpenWindow()
    {
        //makes the editor window for the tool
        GetWindow<DialogueTreeEditorWindow>("Dialogue Tree Maker");
    }
    public void CreateGUI()
    {
        CreateGraphView();
        CreateToolbar();
    }

    private void CreateGraphView()
    {
        graphView = new TheGraphView();
        graphView.StretchToParentSize();
        rootVisualElement.Add(graphView);
    }

    private void CreateToolbar()
    {
        TextField filenameTextField = new TextField()
        {
            value = "File Name", label = "Filename"
        };

        Button saveTreeButton = new Button()
        {
            text = "Save", clickable = new Clickable(() => LoadTree()),//<change this to the save function!!!
        };

        Button loadTreeButton = new Button()
        {
            text = "Load", clickable = new Clickable(() => LoadTree()),
        };

        Button clearTreeButton = new Button()
        {
            text = "Clear",
            clickable = new Clickable(() => ClearTree()),
        };

        Toolbar toolbar = new Toolbar();
        toolbar.Add(filenameTextField);
        toolbar.Add(saveTreeButton);
        toolbar.Add(loadTreeButton);
        toolbar.Add(clearTreeButton);
        rootVisualElement.Add(toolbar);
    }

    private void ClearTree()
    {
        rootVisualElement.Clear();
        CreateGUI();
    }

    private void LoadTree()
    {
        ClearTree();
        //open a graph file
    }
}
