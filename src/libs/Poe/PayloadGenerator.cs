using Poe.Models;

namespace Poe;

/// <summary>
/// 
/// </summary>
public class PayloadGenerator
{
    private readonly Dictionary<string, string> _queries =
        JsonSerializer.Deserialize<Dictionary<string, string>>(H.Resources.queries_json.AsString()) ??
        throw new InvalidOperationException("Failed to deserialize queries.json");
    
    private readonly Random _random = new();
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="queryName"></param>
    /// <param name="variables"></param>
    /// <returns></returns>
    public object GeneratePayload(string queryName, Dictionary<string, object> variables)
    {
        if (queryName == "recv")
        {
            return GenerateRecvPayload(variables);
        }

        return new Payload
        {
            Extensions = new Dictionary<string, string>
            {
                ["hash"] = _queries[queryName],
            },
            QueryName = queryName,
            Variables = variables,
        };
    }

    private IReadOnlyCollection<PayloadItem> GenerateRecvPayload(IReadOnlyDictionary<string, object> variables)
    {
        var payloads = new List<PayloadItem>
        {
            new()
            {
                Category = "poe/bot_response_speed",
                Data = variables,
            },
        };

        if (_random.NextDouble() > 0.9)
        {
            payloads.Add(new PayloadItem
            {
                Category = "poe/statsd_event",
                Data = new Dictionary<string, object>
                {
                    { "key", "poe.speed.web_vitals.INP" },
                    { "value", _random.Next(100, 126) },
                    { "category", "time" },
                    { "path", "/[handle]" },
                    { "extra_data", new Dictionary<string, object>() },
                }
            });
        }

        return payloads;
    }
}