namespace GenericsExercises.Ex6;

public static class MainEx6
{
    public static async Task ExecuteEx6()
    {
        //Create an asynchronous method that performs an HTTP GET request to a specified URL,
        //and returns the contents of the response as a string.
        //The method should use the HttpClient class to perform the request.

        string url = "www.google.com";

        MyGetAsyncResponseClass myGetAsyncResponseClass = new MyGetAsyncResponseClass();

        string response = await myGetAsyncResponseClass.performHttpGet(url);
        Console.WriteLine(response);


    }
}