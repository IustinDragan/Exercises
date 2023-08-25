namespace GenericsExercises.Ex4;

public static class MainEx4
{
    //Write a C# program that uses the async and await keywords to fetch multiple URLs concurrently,
    //and then prints out the content of the first URL to complete.

    public static async Task ExecuteEx4()
    {
        var myAsynkClass = new MyAsynkClass();

        Task<string> task1 = MyAsynkClass.openFirstCompletedTask("https://www.google.com");
        Task<string> task2 = MyAsynkClass.openFirstCompletedTask("https://www.youtube.com");
        Task<string> task3 = MyAsynkClass.openFirstCompletedTask("https://www.facebook.com");

        Task<Task<string>> anyCompleted = Task.WhenAny(task1, task2, task3);

        Task<string> completedTask = await anyCompleted;
        string results = await completedTask;
        
        Console.WriteLine(results);
        
        
        
        //varianta initiala: 
        
        // List<string> urlList = new List<string>()
        // {
        //     "www.google.ro",
        //     "www.youtube.com",
        //     "www.endava.com"
        // };
        // var myAsynkClass = new MyAsynkClass();
        //
        // Task<string> firstCompletedTask = await myAsynkClass.GetFirstCompletedTask(urlList);
        //
        // string result = await firstCompletedTask;
        // Console.WriteLine(result);
    }
}