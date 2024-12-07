using Microsoft.AspNetCore.Mvc;

namespace OnlineCalculator.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }
    
    private static Dictionary<int, SavedAction> Story = new Dictionary<int, SavedAction>();

    private static int currentId = 0;

    [HttpPost]
    public SavedAction AddAction([FromBody] NewAction _action)
    {
        SavedAction action = new SavedAction();
        action.Num1 = _action.Num1;
        action.Num2 = _action.Num2;
        action.Action = _action.Action;
        
        if (action.Id == 0)
        { 
            action.Id = ++currentId;
        }
        action.Res = action.GiveResult(action.Action);
        Story.Add(action.Id, action);
        return action;
    }

    [HttpGet]
    [Route("{actionId}")]
    public SavedAction GetAction(int actionId)
    {
        return Story[actionId];
    }

    [HttpGet]
    public IEnumerable<SavedAction> GetAllActions()
    {
        return Story.Values;
    }

    [HttpDelete]
    [Route("{id:int}")]
    public IEnumerable<SavedAction> DeleteAction(int id)
    {
        Story.Remove(id);
        return Story.Values;
    }
}

public class NewAction
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    public char Action { get; set; }
}

public class SavedAction
{
    public int Id { get; set; }
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    public char Action { get; set; }
    public double Res { get; set;}

    public double GiveResult(char action)
    {
        switch (action)
        {
            case '+': return Res = Num1 + Num2;
            case '-': return Res = Num1 - Num2;
            case '/' : return Res = Num1 / Num2;
            case '*': return Res = Num1 * Num2;
        }

        return 0;
    }
}