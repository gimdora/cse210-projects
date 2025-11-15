using System;
using System.Collections.Generic;   
class PromptGenerator
{
    private readonly List<string> _prompts =
    [
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "What is one small thing you are grateful for today?",
        "What did you learn today that you want to remember?"
    ];

    private readonly Random _random = new();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
