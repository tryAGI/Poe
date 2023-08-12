namespace Poe;

/// <summary>
/// Class providing methods for API access.
/// </summary>
public partial class PoeApi
{
    /// <summary>
    /// Sets the selected apiKey as a default header for the HttpClient.
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="httpClient"></param>
    public PoeApi(string apiKey, HttpClient httpClient)
    {
        ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
    }
}
