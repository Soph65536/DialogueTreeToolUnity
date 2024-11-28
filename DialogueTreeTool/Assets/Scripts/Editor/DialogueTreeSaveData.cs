using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class DialogueSaveData : DialogueData
{
    public void Init(GUID guidParam, DialogueItem dialogueItemParam, Vector2 positionParam)
    {
        guid = guidParam.ToString();
        dialogueItem = dialogueItemParam;
        position = positionParam;
        previousguids = new List<string>();
    }

    public void SetPreviousNode(GUID previousguidParam)
    {
        previousguids.Add(previousguidParam.ToString());
    }

    public override string ToString()
    {
        return dialogueItem == null ? "No Dialogue Item" : dialogueItem.NameTextRO;
    }
}

public class DialogueTreeSaveData : DialogueTreeData
{
    public new List<DialogueData> dialogueData = new List<DialogueData>();

    public DialogueSaveData LinearSearchForGUID(GUID guidParam)
    {
        foreach(DialogueSaveData dialogue in dialogueData)
        {
            if(dialogue.guid == guidParam.ToString()) { return dialogue; }
        }
        return null;
    }
}
