namespace GenericsExercises.Ex8;


public static class MainEx7
{        
    //Create an asynchronous method that writes a string to a file.
    //The method should use the StreamWriter classes to perform the file write.
    //private static string filePath = "C:\\Users\\idragan\\OneDrive - ENDAVA\\Desktop\\Materials\\Test.txt";
    private static string filePath = "C:\\Users\\idragan\\RiderProjects\\Generics\\GenericsExercises\\Ex8\\Test.txt";
    
    public static async Task ExecuteEx7()
    {
        await WriteMethod();
    }
    
    public static async Task WriteMethod()
    {
        string userText = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            await writer.WriteLineAsync(userText);
        }
    }
}