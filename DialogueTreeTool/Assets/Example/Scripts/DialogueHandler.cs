using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHandler : MonoBehaviour
{
    private DialogueTreeData dialogueTreeData;

    public DialogueData currentData = null;
    public List<DialogueData> currentPlayerData = new List<DialogueData>();

    private void Awake()
    {
        GetTreeData();
    }

    private void GetTreeData()
    {
        dialogueTreeData = Resources.Load("Conversation") as DialogueTreeData; //loads the example conversation from resources
        Debug.Log(dialogueTreeData.dialogueData.Count);

        //first foreach loop to find what the root dialogue is
        foreach (var dialogueData in dialogueTreeData.dialogueData)
        {
            if (dialogueData.previousguids.Count == 0) { currentData = dialogueData; }
        }

        //update player options
        SetPlayerDialogueOptions();
    }

    public void GetNextDialogueData(DialogueData playerOption)
    {
        currentData = null;
        currentPlayerData = new List<DialogueData>();

        foreach (DialogueData dialogueData in dialogueTreeData.dialogueData)
        {
            if (dialogueData.previousguids.Contains(playerOption.guid) && !dialogueData.dialogueItem.IsPlayerTextOptionRO)
            {
                currentData = dialogueData;
            }
        }

        //update player options
        SetPlayerDialogueOptions();
    }

    private void SetPlayerDialogueOptions()
    {
        //if current item isnt null
        if (currentData != null)
        {
            //foreach loop to find which playeroptions are children of the current item
            foreach (DialogueData dialogueData in dialogueTreeData.dialogueData)
            {
                if (dialogueData.previousguids.Contains(currentData.guid) && dialogueData.dialogueItem.IsPlayerTextOptionRO)
                {
                    currentPlayerData.Add(dialogueData);
                }
            }
        }
    }
}
