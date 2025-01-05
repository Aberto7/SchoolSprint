using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; // Reference to the TextMeshPro UI component
    public GameObject dialoguePanel;    // Reference to the dialogue panel
    private Queue<string> dialogueQueue; // Queue to manage dialogue lines
    public float typingSpeed = 0.05f;   // Speed of the typing animation
    private Coroutine typingCoroutine;  // Store reference to the current typing coroutine

    void Start()
    {
        dialogueQueue = new Queue<string>();
    }

    // Start the dialogue system with a Dialogue object
    public void StartDialogue(Dialogue dialogue)
    {
        dialogueQueue.Clear(); // Clear any existing dialogue

        foreach (string line in dialogue.lines)
        {
            dialogueQueue.Enqueue(line); // Add lines to the queue
        }

        dialoguePanel.SetActive(true); // Show the dialogue panel
        ShowNextLine(); // Display the first line
    }

    // Show the next line in the dialogue
    public void ShowNextLine()
    {
        if (dialogueQueue.Count == 0)
        {
            EndDialogue();
            return;
        }

        
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            dialogueText.text = dialogueQueue.Peek();
            dialogueQueue.Dequeue();
            typingCoroutine = null;
            return;
        }

        
        string currentLine = dialogueQueue.Dequeue();
        typingCoroutine = StartCoroutine(TypeText(currentLine));
    }


    
    IEnumerator TypeText(string line)
    {
        dialogueText.text = ""; // Clear the text initially
        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter; // Add each character one by one
            yield return new WaitForSeconds(typingSpeed); // Wait between each character
        }

        // Ensure the coroutine reference is cleared when done
        typingCoroutine = null;
    }

    // End the dialogue and hide the panel
    public void EndDialogue()
    {
        dialoguePanel.SetActive(false); // Hide the dialogue panel
        // Implement logic to continue the game (e.g., start gameplay)
    }
}
