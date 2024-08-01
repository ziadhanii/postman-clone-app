namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void CallAPIButton_Click(object sender, EventArgs e)
        {
            // Validate the API URL  
            try
            {
                SystemStatus.Text = "Calling API...";
                // Sample code - replace with the actual API call 

                await Task.Delay(2000);

                SystemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                ResponseTextBox.Text = "Error: " + ex.Message;
                SystemStatus.Text = "Error";
            }
        }

    }
}