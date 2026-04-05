class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you did something difficult.",
        "Think of a time you helped someone.",
        "Think of a time you showed courage."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made it successful?"
    };

    public ReflectionActivity()
        : base("Reflection", "Reflect on your strengths and experiences.") {}

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("Think about it...");
        ShowSpinner(5);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(4);
        }

        EndMessage();
    }
}