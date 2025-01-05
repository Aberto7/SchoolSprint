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
        "It's a sunny morning in the vibrant city of Karachi, and Janica, a spirited young girl with big dreams, \nhas a big problem —she's overslept!",
        "The clock is ticking, and the school bell is about to ring. But Janica is determined to make it to school on time, no matter what!",
        "In this thrilling race against time, you will guide Janica on her journey through bustling streets, winding alleyways, and busy streets.",
        "But it will not be easy, as her path is filled with challenges and surprises.",
        "As Janica runs: \nWatch out for obstacles!\nLook for Stamina bolt!",
        "Every Stamina bolt Janica grabs adds +10 to her Stamina bar, keeping her energized to keep sprinting.",
        "Grab time boosters! Collect the time pickups to extend the time Janica has to reach school.",
        "The stakes are high, and the adventure is fast-paced. Can you help Janica dodge obstacles, collect power-ups, and make it to her classroom before the final bell rings?",
        "Get ready to sprint, jump, and dodge your way through the city in this exciting, action-packed journey!"
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

    public static Dialogue Level03Dialogue => new Dialogue(new string[]
    {
        "Welcome to Level 3!",
        "This level is more challenging.",
        "You'll encounter enemies and obstacles.",
        "Find the hidden treasure before time runs out.",
        "Use your skills wisely to navigate the terrain.",
        "Defeat the boss to proceed.",
        "Brace yourself for an epic adventure!"
    });
}
