namespace Poe.Models;

/// <summary>
/// 
/// </summary>
public class PayloadItem
{
    /// <summary>
    /// 
    /// </summary>
    public string Category { get; set; } = String.Empty;

    /// <summary>
    /// 
    /// </summary>
    public IReadOnlyDictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
}