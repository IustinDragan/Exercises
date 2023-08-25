namespace GenericsExercises.Ex1;

public static class MainEx1
{
    public static void ExecuteEx1_int()
    {
        List<int> testList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Before: ");
        foreach (var item in testList)
        {
            Console.WriteLine(item + "");
        }

        List<int> reverseElementsList = testList.ReverseElements().ToList();
        
        Console.WriteLine("After: ");
        foreach (var item in reverseElementsList)
        {
            Console.WriteLine( item + "");
        }
    }
    
    public static void ExecuteEx1_string()
    {
        List<string> testList = new List<string>() { "user1", "user2","user3","user4","user5","user6" };

        Console.WriteLine("Before: ");
        foreach (var item in testList)
        {
            Console.WriteLine(item + "");
        }

        List<string> reverseElementsList = testList.ReverseElements().ToList();
        
        Console.WriteLine("After: ");
        foreach (var item in reverseElementsList)
        {
            Console.WriteLine( item + "");
        }
    }
}
