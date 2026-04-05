class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity helps you relax by guiding your breathing.") {}

    public void Run()
    {
        StartMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
            Console.WriteLine();
        }

        EndMessage();
    }
}