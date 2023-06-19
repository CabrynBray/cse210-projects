
class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator ()
    {
        prompts = new List<string>
        {
            "what happened today?",
            "What brings you joy?",
            "Write a letter to someone that you care about to tell them how you feel.",
            "What is something that you would like to change about yourself? How can you change it?",
            "What was your greatest fear, and how did you conquer it?",
            "Where's one place that you'd like to visit, and how do you imagine your time there?",
            "If you are granted a wish, what would you wish for and why?",
            "If you are a superhero, what superpower would you like to have and how would you use it?",
            "List down a bucket list with the things that you have always wanted to do.",
            "What is something that you would like to achieve? How do you plan on reaching your goal(s)?",
            "Where do you see yourself in the next 1, 3, 5, 10 years from now?",
            "When did you feel the Holy Gost today?",
            "What did you learn today?",
            "What is one thing from today you always want to remember?"
        };
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
}

