using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

public class DialogueTreeEditorWindow : EditorWindow
{
    //path in unity UI to access the tool window
    [MenuItem("Window/Tools/Dialogue Tree Maker")]
    public static void OpenWindow()
    {
        //makes the editor window for the tool
        GetWindow<DialogueTreeEditorWindow>("Dialogue Tree Maker");
    }
    private void CreateGUI()
    {
        CreateToolbar();
    }

    private void CreateToolbar()
    {
        //makes toolbar elements and adds them to the toolbar
    }
}
