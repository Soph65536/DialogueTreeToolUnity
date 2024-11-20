using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DialogueItem", order = 1)]
public class DialogueItem : ScriptableObject
{
    //inspector editable variables
    [SerializeField] private String NameText;
    [SerializeField] private Sprite Icon;

    //for each variable create a public variable that is always set to the private one
    //which results in readonly data
    public string NameTextRO { get { return NameText; } }
    public Sprite IconRO { get { return Icon; } }

    //dialogue text is modifiable
    public string DialogueText = "You can modify this text within the Dialogue Item or in the Dialogue Tree Graph!";
}
