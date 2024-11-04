using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DialogueItem", order = 1)]
public class DialogueItem : ScriptableObject
{
    //inspector editable variables
    [SerializeField] private String NameText;
    [SerializeField] private String DialogueText;
    [SerializeField] private Sprite Icon;

    //for each variable create a public variable that is always set to the private one
    //which results in readonly data
    public string NameTextRO { get { return NameText; } }
    public string DialogueTextRO { get { return DialogueText; } }
    public Sprite IconRO { get { return Icon; } }
}
