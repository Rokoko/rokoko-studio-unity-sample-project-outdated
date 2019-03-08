using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Rokoko.Smartsuit;
using UnityEngine;

/// <summary>
/// This component provides access to Studio's Command API.
/// </summary>
public class StudioCommandAPI : MonoBehaviour
{
    public Smartsuit smartsuit;

    [Tooltip("The api key as defined in Studio. Settings->Command API->API key")]
    public string apiKey;

    [Tooltip("The port number as defined in Studio. Settings->Command API->Listen port")]
    public int port;

    [Space(10)] public bool debug;
    
    [ContextMenu("Restart Smartsuit")]
    public async void RestartSmartsuit()
        => await SendRequest("Restart", new RequestData {smartsuit = smartsuit.HubID}.ToJson());

    [ContextMenu("Start Recording")]
    public async void StartRecording() =>
        await SendRequest("recording/start", new RequestData { }.ToJson());

    [ContextMenu("Stop Recording")]
    public async void StopRecording() =>
        await SendRequest("recording/stop", new RequestData { }.ToJson());

    [ContextMenu("Calibrate all")]
    public async void CalibrateAll() =>
        await SendRequest("calibrate", new RequestData { }.ToJson());

    [ContextMenu("Unicast")]
    public async void Unicast() =>
        await SendRequest("unicast", new RequestData { }.ToJson());

    [ContextMenu("Broadcast")]
    public async void Broadcast() =>
        await SendRequest("broadcast", new RequestData { }.ToJson());

    public async Task<string> SendRequest(string endpoint, string json)
    {
        HttpClient client = new HttpClient();
        var url = $"http://{smartsuit.IpAddress()}:{port}/v1/{apiKey}/{endpoint}";

        if (debug)
        {
            Debug.Log("URL: " + url);
            Debug.Log("Data: " + json);
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Content =
            new StringContent("{\"name\":\"John Doe\",\"age\":33}", Encoding.UTF8, "application/json");

        var response = await client.SendAsync(requestMessage);
        var responseMessage = await response.Content.ReadAsStringAsync();
        if (debug)
        {
            Debug.Log("Response: " + responseMessage);
        }
        return responseMessage;
    }
}