namespace GenericsExercises.Ex6;

public class MyGetAsyncResponseClass
{
    public async Task<string> performHttpGet(string url)
    {
        using (var httpClient = new HttpClient())
        {
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
            responseMessage.EnsureSuccessStatusCode();
            return await responseMessage.Content.ReadAsStringAsync();
        }
    }
}