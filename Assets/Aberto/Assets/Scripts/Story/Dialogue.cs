using System;
using UnityEngine;

[Serializable]
public class Dialogue
{
    public string[] lines;

    // Constructor to initialize dialogue lines
    public Dialogue(string[] predefinedLines)
    {
        lines = predefinedLines;
    }

    // Example dialogue for Level 1
    public static Dialogue Level01Dialogue => new Dialogue(new string[]
    {
        "Welcome to Level 1!",
        "Your mission is to explore the area.",
        "Avoid traps and collect items to succeed.",
        "Use WASD to move and Space to jump.",
        "Look for hidden keys to unlock doors.",
        "Be mindful of the timer!",
        "Good luck, adventurer!"
    });

    // Example dialogue for Level 2
    public static Dialogue Level02Dialogue => new Dialogue(new string[]
    {
        "Welcome to Level 2!",
        "This level is more challenging.",
        "You'll encounter enemies and obstacles.",
        "Find the hidden treasure before time runs out.",
        "Use your skills wisely to navigate the terrain.",
        "Defeat the boss to proceed.",
        "Brace yourself for an epic adventure!"
    });
}
