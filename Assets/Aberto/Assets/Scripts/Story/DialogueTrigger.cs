using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public int sceneNumber;

    void Start()
    {
        if (dialogueManager == null)
        {
            Debug.LogError("DialogueManager is not assigned in DialogueTrigger!");
            return;
        }
        
        switch (sceneNumber)
        {
            case 1:
                dialogueManager.StartDialogue(Dialogue.Level01Dialogue);
                break;
            case 2:
                dialogueManager.StartDialogue(Dialogue.Level02Dialogue);
                break;
            case 3:
                dialogueManager.StartDialogue(Dialogue.Level03Dialogue);
                break;
            default:
                Debug.LogError("Invalid level number! No dialogue available.");
                break;
        }   // dialogueManager.StartDialogue(Dialogue.Level02Dialogue);
    }
}
