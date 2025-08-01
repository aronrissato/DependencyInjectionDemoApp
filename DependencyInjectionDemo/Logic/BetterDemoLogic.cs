namespace DependencyInjectionDemo.Logic;

public class BetterDemoLogic : IDemoLogic
{
    public BetterDemoLogic()
    {
        Value1 = 25;
        Value2 = 50;
    }
    
    public int Value1 { get; private set; }
    public int Value2 { get; private set; }

}