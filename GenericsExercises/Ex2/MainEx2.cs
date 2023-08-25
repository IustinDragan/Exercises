namespace GenericsExercises.Ex2;

//Create a generic method that takes in a list of any type and applies
//a specific action to each element using a lambda expression.

public static class MainEx2
{
    public static void ExecuteEx2_forInt()
    {
        List<int> intList = new List<int>{ 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Before:");
        foreach (var item in intList)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("After: ");
        intList.ActionMethode( x => Console.WriteLine((object?)$"Squared: {x * x}"));
    }
    
    public static void ExecuteEx2_forString()
    {
        List<string> intList = new List<string>{ "user1", "user2","user3","user4","user5","user6"};
        
        Console.WriteLine("Before:");
        foreach (var item in intList)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("After: ");
        intList.ActionMethode( x => Console.WriteLine($"Uppercase: {x.ToUpper()}"));
    }
}