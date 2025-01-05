using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager;

    void Start()
    {
        // Example: Start Level 1 Dialogue
        dialogueManager.StartDialogue(Dialogue.Level01Dialogue);

        // For Level 2, you can switch to Dialogue.Level02Dialogue
        // dialogueManager.StartDialogue(Dialogue.Level02Dialogue);
    }
}
