using System.Net;

namespace PostmanCloneLibrary;

public interface IApiAccess
{
    Task<(string Content, HttpStatusCode StatusCode)> CallApiAsync(
        string url,
        string content,
        HttpAction action = HttpAction.GET,
        bool formatOutput = true
    );

    Task<(string Content, HttpStatusCode StatusCode)> CallApiAsync(
        string url,
        HttpContent? content = null,
        HttpAction action = HttpAction.GET,
        bool formatOutput = true);

    bool IsValidUrl(string url);
}