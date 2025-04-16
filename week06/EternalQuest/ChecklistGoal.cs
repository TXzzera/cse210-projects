using System;

public class ChecklistOfGoals
{
    private int _completedGoals = 0;
    private int _incompleteGoals = 0;
    private int _bonusToApply = 0;

    public void RegisterNewGoal()
    {
        _incompleteGoals++;
    }

    public void RegisterCompletedGoal()
    {
        if (_incompleteGoals > 0)
            _incompleteGoals--;

        _completedGoals++;

        if (_completedGoals % 5 == 0)
        {
            _bonusToApply += 200;
            Console.WriteLine("🎉 BONUS: You've completed 5 goals! +200 bonus points!");
        }
    }

    public int GetCompletedGoals() => _completedGoals;
    public int GetIncompleteGoals() => _incompleteGoals;

    public int GetBonus()
    {
        int bonus = _bonusToApply;
        _bonusToApply = 0;
        return bonus;
    }

    public void DisplayProgress()
    {
        Console.WriteLine($"✅ Completed Goals: {_completedGoals}");
        Console.WriteLine($"❌ Incomplete Goals: {_incompleteGoals}");
    }
}
