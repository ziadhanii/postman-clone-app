namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            FormHeader = new Label();
            EnterAPILabel = new Label();
            APITextBox = new TextBox();
            CallAPIButton = new Button();
            StatusStrip = new StatusStrip();
            SystemStatus = new ToolStripStatusLabel();
            DisplayStatusCodeLabel = new ToolStripStatusLabel();
            HttpVerbSelection = new ComboBox();
            CallDataTabControl = new TabControl();
            BodyTab = new TabPage();
            BodyTextBox = new TextBox();
            ResponseTab = new TabPage();
            ResponseTextBox = new TextBox();
            OutputFormat = new CheckBox();
            StatusStrip.SuspendLayout();
            CallDataTabControl.SuspendLayout();
            BodyTab.SuspendLayout();
            ResponseTab.SuspendLayout();
            SuspendLayout();
            // 
            // FormHeader
            // 
            resources.ApplyResources(FormHeader, "FormHeader");
            FormHeader.Name = "FormHeader";
            // 
            // EnterAPILabel
            // 
            resources.ApplyResources(EnterAPILabel, "EnterAPILabel");
            EnterAPILabel.Name = "EnterAPILabel";
            // 
            // APITextBox
            // 
            resources.ApplyResources(APITextBox, "APITextBox");
            APITextBox.Name = "APITextBox";
            // 
            // CallAPIButton
            // 
            resources.ApplyResources(CallAPIButton, "CallAPIButton");
            CallAPIButton.Name = "CallAPIButton";
            CallAPIButton.UseVisualStyleBackColor = true;
            CallAPIButton.Click += CallAPIButton_Click;
            // 
            // StatusStrip
            // 
            resources.ApplyResources(StatusStrip, "StatusStrip");
            StatusStrip.BackColor = Color.White;
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { SystemStatus, DisplayStatusCodeLabel });
            StatusStrip.Name = "StatusStrip";
            // 
            // SystemStatus
            // 
            resources.ApplyResources(SystemStatus, "SystemStatus");
            SystemStatus.BackColor = Color.White;
            SystemStatus.Name = "SystemStatus";
            // 
            // DisplayStatusCodeLabel
            // 
            resources.ApplyResources(DisplayStatusCodeLabel, "DisplayStatusCodeLabel");
            DisplayStatusCodeLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            DisplayStatusCodeLabel.Name = "DisplayStatusCodeLabel";
            DisplayStatusCodeLabel.Spring = true;
            // 
            // HttpVerbSelection
            // 
            resources.ApplyResources(HttpVerbSelection, "HttpVerbSelection");
            HttpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            HttpVerbSelection.FormattingEnabled = true;
            HttpVerbSelection.Items.AddRange(new object[] { resources.GetString("HttpVerbSelection.Items"), resources.GetString("HttpVerbSelection.Items1"), resources.GetString("HttpVerbSelection.Items2"), resources.GetString("HttpVerbSelection.Items3"), resources.GetString("HttpVerbSelection.Items4") });
            HttpVerbSelection.Name = "HttpVerbSelection";
            // 
            // CallDataTabControl
            // 
            resources.ApplyResources(CallDataTabControl, "CallDataTabControl");
            CallDataTabControl.Controls.Add(BodyTab);
            CallDataTabControl.Controls.Add(ResponseTab);
            CallDataTabControl.Name = "CallDataTabControl";
            CallDataTabControl.SelectedIndex = 0;
            // 
            // BodyTab
            // 
            resources.ApplyResources(BodyTab, "BodyTab");
            BodyTab.Controls.Add(BodyTextBox);
            BodyTab.Name = "BodyTab";
            BodyTab.UseVisualStyleBackColor = true;
            // 
            // BodyTextBox
            // 
            resources.ApplyResources(BodyTextBox, "BodyTextBox");
            BodyTextBox.BackColor = Color.White;
            BodyTextBox.BorderStyle = BorderStyle.FixedSingle;
            BodyTextBox.Name = "BodyTextBox";
            // 
            // ResponseTab
            // 
            resources.ApplyResources(ResponseTab, "ResponseTab");
            ResponseTab.Controls.Add(ResponseTextBox);
            ResponseTab.Name = "ResponseTab";
            ResponseTab.UseVisualStyleBackColor = true;
            // 
            // ResponseTextBox
            // 
            resources.ApplyResources(ResponseTextBox, "ResponseTextBox");
            ResponseTextBox.BackColor = Color.White;
            ResponseTextBox.BorderStyle = BorderStyle.FixedSingle;
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.ReadOnly = true;
            // 
            // OutputFormat
            // 
            resources.ApplyResources(OutputFormat, "OutputFormat");
            OutputFormat.BackColor = Color.White;
            OutputFormat.CausesValidation = false;
            OutputFormat.Checked = true;
            OutputFormat.CheckState = CheckState.Checked;
            OutputFormat.Name = "OutputFormat";
            OutputFormat.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(OutputFormat);
            Controls.Add(CallDataTabControl);
            Controls.Add(HttpVerbSelection);
            Controls.Add(StatusStrip);
            Controls.Add(CallAPIButton);
            Controls.Add(APITextBox);
            Controls.Add(EnterAPILabel);
            Controls.Add(FormHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            SizeGripStyle = SizeGripStyle.Hide;
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            CallDataTabControl.ResumeLayout(false);
            BodyTab.ResumeLayout(false);
            BodyTab.PerformLayout();
            ResponseTab.ResumeLayout(false);
            ResponseTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormHeader;
        private Label EnterAPILabel;
        private TextBox APITextBox;
        private Button CallAPIButton;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel SystemStatus;
        private ComboBox HttpVerbSelection;
        private TabControl CallDataTabControl;
        private TabPage BodyTab;
        private TabPage ResponseTab;
        private TextBox ResponseTextBox;
        private TextBox BodyTextBox;
        private ToolStripStatusLabel DisplayStatusCodeLabel;
        private CheckBox OutputFormat;
    }
}
