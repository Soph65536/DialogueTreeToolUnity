using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class DialogueNode : Node
{
    //internal is only accessible within the assembly/DLL file
    internal DialogueItem dialogueItem;

    public DialogueNode(Vector2 position)
    {
        SetPosition(new Rect(position, Vector2.zero));
    }

    public DialogueNode(Vector2 position, DialogueItem dialogueItemParam)
    {
        SetPosition(new Rect(position, Vector2.zero));
        dialogueItem = dialogueItemParam;
    }

    private void SetDialogueItem(DialogueItem dialogueItemParam)
    {
        dialogueItem = dialogueItemParam;
    }

    private void UpdateDialogueNode()
    {
        //update title container to be the person speaking field
        titleContainer.Clear();
        //create new textfield depending on if there is a dialogue item
        TextField nodeName = new TextField()
        {
            value = dialogueItem != null ? dialogueItem.NameTextRO : "Empty",
            isReadOnly = true,
        };
        //set title container to the text field we made
        titleContainer.Insert(0, nodeName);

        //add input/output ports

        if(dialogueItem == null)
        {
            //create object field
        }
    }
}
