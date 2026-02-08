using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // - Added a GratitudeActivity as an extra mindfulness activity
        // - Improved user experience by reusing shared behavior through inheritance
        // - All activities inherit from the base Activity class

        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity (Extra)");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    new GratitudeActivity().Run();
                    break;
                case "5":
                    quit = true;
                    break;
            }
        }
    }
}
