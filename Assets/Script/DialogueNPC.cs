using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNPC : MonoBehaviour
{
    public string[] sentences;

    private void OnMouseDown()
    {
        if(DialogueManager.instance.dialogueGroup.alpha == 0)
            DialogueManager.instance.Ondialogue(sentences);
    }
}
