using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;
    const string saveFile = "goals.json";

    static void Main()
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine("\n=== Eternal Quest Menu ===");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save & Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": SaveGoals(); return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();
        Console.Write("Name: "); string name = Console.ReadLine();
        Console.Write("Description: "); string desc = Console.ReadLine();
        Console.Write("Points: "); int pts = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, desc, pts));
                break;
            case "2":
                goals.Add(new EternalGoal(name, desc, pts));
                break;
            case "3":
                Console.Write("Target completions: "); int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: "); int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
                break;
            default: Console.WriteLine("Invalid type."); break;
        }
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Enter goal number to record event: ");
        if(int.TryParse(Console.ReadLine(), out int idx) && idx > 0 && idx <= goals.Count)
        {
            goals[idx - 1].RecordEvent(ref totalPoints);
        }
        else Console.WriteLine("Invalid goal number.");
    }

    static void ShowGoals()
    {
        Console.WriteLine("\n=== Your Goals ===");
        for(int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goals[i].DisplayStatus()}");
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    static void SaveGoals()
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(goals, options);
            File.WriteAllText(saveFile, json);
            Console.WriteLine("Goals saved successfully!");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals()
    {
        if (!File.Exists(saveFile)) return;
        try
        {
            string json = File.ReadAllText(saveFile);
            // For simplicity, we will not deserialize polymorphic objects here
            // You can improve with a custom converter if desired
            Console.WriteLine("Goals loaded (manual recreation required).");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}