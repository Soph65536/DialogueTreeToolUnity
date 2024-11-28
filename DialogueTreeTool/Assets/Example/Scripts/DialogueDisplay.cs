using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDisplay : MonoBehaviour
{
    private DialogueHandler dialogueHandler;

    [SerializeField] private TextMeshProUGUI NPCNameText;
    [SerializeField] private TextMeshProUGUI NPCSpeechText;
    [SerializeField] private Image NPCImage;

    private void Awake()
    {
        dialogueHandler = GetComponent<DialogueHandler>();
    }

    private void Update()
    {
        NPCNameText.text = dialogueHandler.currentData.dialogueItem.NameTextRO;
        NPCSpeechText.text = dialogueHandler.currentData.dialogueItem.DialogueText;
        NPCImage.sprite = dialogueHandler.currentData.dialogueItem.IconRO;
    }
}