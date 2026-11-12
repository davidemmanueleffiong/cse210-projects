using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who did I enjoy talking with today?",
        "What is something new I learned today?",
        "What made me laugh today?",
        "What is one thing I want to remember about today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}