using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in... ");
            Countdown(3);
            elapsed += 3;

            Console.Write("Breathe out... ");
            Countdown(3);
            elapsed += 3;
        }
        DisplayEndingMessage();
    }
}
