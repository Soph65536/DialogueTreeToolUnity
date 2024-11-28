using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//creates dialoguedata outside of the editor which the save data inherits from
//so we can access the dialoguetreesavedata from the file we saved

public class DialogueData
{
    public string guid;
    public DialogueItem dialogueItem;
    public Vector2 position;
    public List<string> previousguids;
}

public class DialogueTreeData : ScriptableObject
{
    public List<DialogueData> dialogueData = new List<DialogueData>();
}
