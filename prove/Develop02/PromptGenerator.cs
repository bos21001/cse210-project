namespace Develop02;

using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Random random = new Random();
        
        int index = random.Next(_prompts.Count);
        
        return _prompts[index];
    }
}