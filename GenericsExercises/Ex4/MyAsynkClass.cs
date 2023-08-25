namespace GenericsExercises.Ex4;

public class MyAsynkClass
{
    public static async Task<string> openFirstCompletedTask(string url)
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }

    // public async Task<Task<string>> GetFirstCompletedTask(List<string> urls)
    // {
    //     List<Task<string>> openTask = new List<Task<string>>();
    //
    //     foreach (string url in urls)
    //     {
    //         openTask.Add(openFirstCompletedTask(url));
    //     }
    //
    //     return await Task.WhenAny(openTask);
    // }
}