namespace MultithreadingClasses;

public class ApiService
{
    private static readonly HttpClient _httpClient = new HttpClient
    {
        Timeout = TimeSpan.FromSeconds(5) 
    };

    public async Task<List<string>> FetchDataFromApisAsync(List<string> urls)
    {
        var tasks = new List<Task<string>>();

        foreach (var url in urls)
        {
            tasks.Add(FetchUrlAsync(url));
        }

        // En paralelo, asincrono:, espera sin bloquear el hilo
        var results = await Task.WhenAll(tasks);

        //Bloquea el hilo, si ocurre una execption, lanza un Agregatte execption, sin await
        //Task.WaitAll(tasks.ToArray());

        return new List<string>(results);
    }

    private async Task<string> FetchUrlAsync(string url)
    {
        try
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Lanza excepción si no es OK
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
}
