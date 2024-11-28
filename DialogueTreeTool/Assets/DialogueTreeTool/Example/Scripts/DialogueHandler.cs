using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHandler : MonoBehaviour
{
    private DialogueTreeSaveData dialogueTreeData;

    public DialogueSaveData currentData = null;

    [SerializeField] private GameObject PlayerTextPrefab;
    [SerializeField] private GameObject PlayerTextContainer;

    private void Awake()
    {
        GetTreeData();
    }

    private void GetTreeData()
    {
        dialogueTreeData = Resources.Load("Conversation") as DialogueTreeSaveData; //loads the example conversation from resources

        //first foreach loop to find what the root dialogue is
        foreach (DialogueSaveData dialogueData in dialogueTreeData.dialogueData)
        {
            if (dialogueData.previousguids.Count == 0) { currentData = dialogueData; }
        }

        //update player options
        SetPlayerDialogueOptions();
    }

    public void GetNextDialogueData(DialogueSaveData playerOption)
    {
        currentData = null; //set currentdata to empty
        foreach(Transform child in PlayerTextContainer.transform) { Destroy(child.gameObject); } //remove all children within player text

        foreach (DialogueSaveData dialogueData in dialogueTreeData.dialogueData)
        {
            if (dialogueData.previousguids.Contains(playerOption.guid) && !dialogueData.dialogueItem.IsPlayerTextOptionRO)
            {
                currentData = dialogueData;
            }
        }

        //stop game if no more data
        if(currentData == null) { Application.Quit(); }

        //update player options
        SetPlayerDialogueOptions();
    }

    private void SetPlayerDialogueOptions()
    {
        //if current item isnt null
        if (currentData != null)
        {
            //foreach loop to find which playeroptions are children of the current item
            foreach (DialogueSaveData dialogueData in dialogueTreeData.dialogueData)
            {
                if (dialogueData.previousguids.Contains(currentData.guid) && dialogueData.dialogueItem.IsPlayerTextOptionRO)
                {
                    GameObject playeroption = Instantiate(PlayerTextPrefab, PlayerTextContainer.transform);
                    playeroption.GetComponent<PlayerOptionDisplay>().PlayerOption = dialogueData;
                }
            }
        }
    }
}
