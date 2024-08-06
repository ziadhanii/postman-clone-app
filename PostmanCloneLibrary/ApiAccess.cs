using System.Net;
using System.Text.Json;
using System.Text;

namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _httpClient;

        public ApiAccess(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<(string Content, HttpStatusCode StatusCode)> CallApiAsync(
            string url, string? content = null,
            HttpAction action = HttpAction.GET, bool formatOutput = true)
        {
            var httpContent =
                content is not null ? new StringContent(content, Encoding.UTF8, "application/json") : null;

            return await CallApiAsync(url, httpContent, action, formatOutput);
        }

        public async Task<(string Content, HttpStatusCode StatusCode)> CallApiAsync(
            string url, HttpContent? content = null,
            HttpAction action = HttpAction.GET, bool formatOutput = true)
        {
            HttpResponseMessage response;
            try
            {
                response = action switch
                {
                    HttpAction.GET => await _httpClient.GetAsync(url),
                    HttpAction.POST => await _httpClient.PostAsync(url, content),
                    HttpAction.PUT => await _httpClient.PutAsync(url, content),
                    HttpAction.PATCH => await _httpClient.PatchAsync(url, content),
                    HttpAction.DELETE => await _httpClient.DeleteAsync(url),
                    _ => throw new ArgumentOutOfRangeException(nameof(action), action, "Invalid HTTP action")
                };
            }
            catch (HttpRequestException ex)
            {
                return ($"Request failed: {ex.Message}", HttpStatusCode.BadRequest);
            }

            return await ProcessResponseAsync(response, formatOutput);
        }

        private async Task<(string Content, HttpStatusCode StatusCode)> ProcessResponseAsync(
            HttpResponseMessage response, bool formatOutput)
        {
            var statusCode = response.StatusCode;
            var responseContent = string.Empty;

            if (response.IsSuccessStatusCode)
            {
                responseContent = await response.Content.ReadAsStringAsync();

                if (formatOutput && !string.IsNullOrWhiteSpace(responseContent))
                {
                    responseContent = FormatJson(responseContent);
                }
            }
            else
            {
                responseContent = $"Error: {statusCode}";
            }

            return (responseContent, statusCode);
        }

        private string FormatJson(string jsonContent)
        {
            try
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(jsonContent);
                return JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }
            catch (JsonException)
            {
                return jsonContent;
            }
        }


        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }

            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) &&
                          (uriOutput.Scheme == Uri.UriSchemeHttps);
            return output;
        }
    }
}