using System.Net;
using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess _api = new ApiAccess(new HttpClient());

    public Dashboard()
    {
        InitializeComponent();
        HttpVerbSelection.SelectedItem = "GET";
        DisplayStatusCodeLabel.Text = "";
    }

    private async void CallAPIButton_Click(object sender, EventArgs e)
    {
        SystemStatus.Text = "Calling API...";
        ResponseTextBox.Text = "";


        if (_api.IsValidUrl(APITextBox.Text) == false)
        {
            SystemStatus.Text = "Invalid URL";
            SystemStatus.ForeColor = Color.Red;
            return;
        }

        HttpAction action;
        if (Enum.TryParse(HttpVerbSelection.SelectedItem!.ToString(), out action) == false)
        {
            SystemStatus.Text = "Invalid HTTP Verb";
            SystemStatus.ForeColor = Color.Red;
            return;
        }

        try
        {
            var (content, statusCode) =
                await _api.CallApiAsync(APITextBox.Text, BodyTextBox.Text, action, OutputFormat.Checked);
            // Switch Expression 

            DisplayStatusCodeLabel.ForeColor = statusCode switch
            {
                >= HttpStatusCode.OK and < HttpStatusCode.Ambiguous => Color.Green,
                >= HttpStatusCode.Ambiguous and < HttpStatusCode.BadRequest => Color.Yellow,
                >= HttpStatusCode.BadRequest and < HttpStatusCode.InternalServerError => Color.Red,
                >= HttpStatusCode.InternalServerError => Color.Orange,
                _ => Color.Blue
            };

            DisplayStatusCodeLabel.Text = $@"{(int)statusCode} {statusCode}";
            ResponseTextBox.Text = content;
            if (content == String.Empty)
            {
                ResponseTextBox.Text = statusCode.ToString();
            }

            CallDataTabControl.SelectedTab = ResponseTab;
            ResponseTab.Focus();

            SystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = "Error : " + ex.Message;
            SystemStatus.Text = "Error";
            SystemStatus.ForeColor = Color.Red;
        }
    }
}