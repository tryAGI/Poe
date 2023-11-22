// using System.Text.RegularExpressions;
//
// namespace Poe;
//
// /// <summary>
// /// Class providing methods for API access.
// /// </summary>
// public partial class PoeApi
// {
//         string gqlUrl = "https://poe.com/api/gql_POST";
//         string gqlRecvUrl = "https://poe.com/api/receive_POST";
//         string homeUrl = "https://poe.com";
//         string settingsUrl = "https://poe.com/api/settings";
//         bool wsConnecting = false;
//         bool wsConnected = false;
//         bool wsError = false;
//         int connectCount = 0;
//         int setupCount = 0;
//         string token;
//         string deviceId;
//         string proxy;
//         string clientIdentifier;
//         Dictionary<string, object> activeMessages = new Dictionary<string, object>();
//         Dictionary<string, Queue<object>> messageQueues = new Dictionary<string, Queue<object>>();
//         Dictionary<string, Action<object>> suggestionCallbacks = new Dictionary<string, Action<object>>();
//         Dictionary<string, string> headers = new Dictionary<string, string>()
//         {
//             {"User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"},
//             {"Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7"},
//             {"Accept-Encoding", "gzip, deflate, br"},
//             {"Accept-Language", "en-US,en;q=0.9"},
//             {"Sec-Ch-Ua", "\"Not.A/Brand\";v=\"8\", \"Chromium\";v=\"112\""},
//             {"Sec-Ch-Ua-Mobile", "?0"},
//             {"Sec-Ch-Ua-Platform", "\"Linux\""},
//             {"Upgrade-Insecure-Requests", "1"}
//         };
//         string formkeySalt = null;
//         string formkey = null;        
//         
//         //... other fields
//
//         public Client(string token, string proxy = null, string deviceId = null, string clientIdentifier = "chrome112", string formkey = null){
//             this.token = token;
//             this.deviceId = deviceId;
//             this.proxy = proxy;
//             this.clientIdentifier = clientIdentifier;
//             this.formkey = formkey;
//             ConnectWs();
//         }
//
//         public void SetupSession(){
//             Console.WriteLine("Setting up session...");
//             // Here you would create a new instance of HttpClient and set its headers and cookies
//
//             // Please note, you will need a separate library in order to handle proxies with HttpClient, such as HttpClientFactory
//         }
//
//         public async Task<JObject> RequestWithRetries(HttpMethod method, string requestUri, HttpContent content = null, int attempts = 10){
//             for (int i = 0; i < attempts; i++){
//                 // Here would be the logic to execute the request and check its response status
//
//                 // When handling exceptions for failed requests, you will throw the appropriate HttpExceptions instead of RuntimeError
//             }
//             throw new Exception($"Failed to download {requestUri} too many times.");
//         }
//
//         public async Task<JObject> SendMessage(string chatbot, string message, bool withChatBreak = false,
//                                                 int timeout = 20, bool asyncRecv = true, Action<object> suggestCallback = null)  {
//             // Same concept and logic applies here with adjustments made for C# syntax and functionality
//
//             // Note: C# has an async/await pattern that can replace many of the threading things going on in the Python version.
//         }
//         
//         public (string, string) ExtractFormKey(string html, string appScript)
//         {
//             Regex scriptRegex = new Regex("<script>(.+?)</script>");
//             Regex varsRegex = new Regex("window\\._([a-zA-Z0-9]{10})=\"([a-zA-Z0-9]{10})\"");
//
//             Match match = varsRegex.Match(appScript);
//             string key = match.Groups[1].Value;
//             string value = match.Groups[2].Value;
//
//             string scriptText = @"
//       let QuickJS = undefined, process = undefined;
//       let window = {
//         document: {a:1},
//         navigator: {
//           userAgent: ""a""
//         }
//       };
//     ";
//             scriptText += $"window._{key} = '{value}';";
//             foreach (Match m in scriptRegex.Matches(html))
//             {
//                 scriptText += m.Groups[1].Value;
//             }
//
//             Regex functionRegex = new Regex("(window\\.[a-zA-Z0-9]{17})=function");
//             string functionText = functionRegex.Match(scriptText).Groups[1].Value;
//             scriptText += $"{functionText}();";
//
//             // C# does not include an embedded JavaScript parser/interpreter.
//             // The line QuickJSCore context = new QuickJSCore();
//             // assumes the existence of a class QuickJSCore that provides the necessary JavaScript handling.
//             // You'd need to use a library like Jint, ClearScript, or similar, or design your own handler.
//             //QuickJSCore context = new QuickJSCore();
//             string formkey = string.Empty;//context.Eval(scriptText);
//
//             string salt = null;
//             try
//             {
//                 Regex saltFunctionRegex = new Regex("function (.)\\(_0x[0-9a-f]{6},_0x[0-9a-f]{6},_0x[0-9a-f]{6}\\)");
//                 string saltFunction = saltFunctionRegex.Match(scriptText).Groups[1].Value;
//                 string saltScript = $"{saltFunction}(a=>a, '', '');";
//                 salt = string.Empty;// context.Eval(saltScript);
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine($"Failed to obtain poe-tag-id salt: {e.Message}");
//             }
//
//             return (formkey, salt);
//         }
// }
