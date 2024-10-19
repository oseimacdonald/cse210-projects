public class BreathingActivity : Activity
{
    protected override string GetStartingMessage()
    {
        return "Breathing Activity\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int halfDuration = duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(4);
            Console.WriteLine("Breathe out...");
            Pause(4);
        }
    }
}

