namespace Poe.Models;

/// <summary>
/// 
/// </summary>
public class Payload
{
    /// <summary>
    /// 
    /// </summary>
    public IReadOnlyDictionary<string, string> Extensions { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// 
    /// </summary>
    public string QueryName { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public IReadOnlyDictionary<string, object> Variables { get; set; } = new Dictionary<string, object>();
}