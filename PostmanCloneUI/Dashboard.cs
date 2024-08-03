using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess _api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
        HttpVerbSelection.SelectedItem = "GET";
    }

    private async void CallAPIButton_Click(object sender, EventArgs e)
    {
        SystemStatus.Text = "Calling API...";
        ResponseTextBox.Text = "";
        // Validate the API URL  


        if (_api.IsValidUrl(APITextBox.Text) == false)
        {
            SystemStatus.Text = "Invalid URL";
            return;
        }

        HttpAction action;
        if (Enum.TryParse(HttpVerbSelection.SelectedItem!.ToString(), out action) == false)
        {
            SystemStatus.Text = "Invalid HTTP Verb";
            return;
        }
        
        try
        {
            // Sample code - replace with the actual API call 
            ResponseTextBox.Text = await _api.CallApiAsync(APITextBox.Text, BodyTextBox.Text, action, true);
            CallDataTabControl.SelectedTab = ResponseTab;
            ResponseTab.Focus();

            SystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = "Error: " + ex.Message;
            SystemStatus.Text = "Error";
        }
    }
}