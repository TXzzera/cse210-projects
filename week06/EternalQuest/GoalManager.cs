using System;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private double _score = 0;
    private int _level = 1;
    private double _nextLevelTarget = 100;
    private ChecklistOfGoals _checklist = new ChecklistOfGoals();

    public void Start()
    {
        string option;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest Program!");
            Console.WriteLine($"Score: {_score} | Level: {_level} (Next: {_nextLevelTarget} points)");
            _checklist.DisplayProgress();
            Console.WriteLine("\n1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Mark goal as completed");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": CompleteGoal(); break;
                case "4": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid option."); break;
            }

            if (option != "4")
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }

        } while (option != "4");
    }

    private void CreateGoal()
    {
        Console.Clear();
        Console.Write("Enter goal title: ");
        string title = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Choose goal type: 1 - Simple | 2 - Eternal");
        string type = Console.ReadLine();

        Goal goal;
        if (type == "1")
        {
            Console.Write("Enter due date (e.g., 2025-05-01): ");
            string dueDate = Console.ReadLine();

            Console.Write("Enter difficulty (easy / medium / hard): ");
            string difficulty = Console.ReadLine();

            goal = new SimpleGoal(title, description, dueDate, difficulty);
        }
        else if (type == "2")
        {
            goal = new EternalGoal(title, description);
        }
        else
        {
            Console.WriteLine("Invalid type. Goal not created.");
            return;
        }

        _goals.Add(goal);
        _checklist.RegisterNewGoal();

        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals registered yet.");
            return;
        }

        Console.WriteLine("Your goals:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.Display()}");
            i++;
        }
    }

    private void CompleteGoal()
    {
        Console.Clear();
        ListGoals();
        if (_goals.Count == 0) return;

        Console.Write("Enter the number of the goal to complete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            Goal goal = _goals[index - 1];
            goal.IsCompleted();
            double earned = goal.GetPoints();
            _score += earned;

            _checklist.RegisterCompletedGoal();
            _score += _checklist.GetBonus();

            UpdateLevel();
            Console.WriteLine($"✅ Goal completed! You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    private void UpdateLevel()
    {
        while (_score >= _nextLevelTarget)
        {
            _level++;
            _nextLevelTarget += _level * 100;
            Console.WriteLine($"🎯 You leveled up! Now you're Level {_level}!");
        }
    }
}