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
            HttpVerbSelection = new ComboBox();
            CallDataTabControl = new TabControl();
            BodyTab = new TabPage();
            BodyTextBox = new TextBox();
            ResponseTab = new TabPage();
            ResponseTextBox = new TextBox();
            StatusStrip.SuspendLayout();
            CallDataTabControl.SuspendLayout();
            BodyTab.SuspendLayout();
            ResponseTab.SuspendLayout();
            SuspendLayout();
            // 
            // FormHeader
            // 
            FormHeader.AutoSize = true;
            FormHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormHeader.Location = new Point(42, 29);
            FormHeader.Name = "FormHeader";
            FormHeader.Size = new Size(317, 60);
            FormHeader.TabIndex = 0;
            FormHeader.Text = "Postman Clone";
            // 
            // EnterAPILabel
            // 
            EnterAPILabel.AutoSize = true;
            EnterAPILabel.Location = new Point(45, 113);
            EnterAPILabel.Name = "EnterAPILabel";
            EnterAPILabel.Size = new Size(214, 41);
            EnterAPILabel.TabIndex = 1;
            EnterAPILabel.Text = "Enter API URL :";
            // 
            // APITextBox
            // 
            APITextBox.Location = new Point(202, 166);
            APITextBox.Name = "APITextBox";
            APITextBox.Size = new Size(1127, 47);
            APITextBox.TabIndex = 2;
            // 
            // CallAPIButton
            // 
            CallAPIButton.Location = new Point(1355, 165);
            CallAPIButton.Margin = new Padding(0);
            CallAPIButton.Name = "CallAPIButton";
            CallAPIButton.Size = new Size(106, 51);
            CallAPIButton.TabIndex = 3;
            CallAPIButton.Text = "Send";
            CallAPIButton.UseVisualStyleBackColor = true;
            CallAPIButton.Click += CallAPIButton_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.BackColor = Color.White;
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { SystemStatus });
            StatusStrip.Location = new Point(0, 842);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(1511, 37);
            StatusStrip.TabIndex = 5;
            StatusStrip.Text = "statusStrip1";
            // 
            // SystemStatus
            // 
            SystemStatus.BackColor = Color.White;
            SystemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SystemStatus.Name = "SystemStatus";
            SystemStatus.Size = new Size(76, 31);
            SystemStatus.Text = "Ready";
            // 
            // HttpVerbSelection
            // 
            HttpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            HttpVerbSelection.FormattingEnabled = true;
            HttpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            HttpVerbSelection.Location = new Point(54, 165);
            HttpVerbSelection.Name = "HttpVerbSelection";
            HttpVerbSelection.Size = new Size(127, 49);
            HttpVerbSelection.TabIndex = 7;
            // 
            // CallDataTabControl
            // 
            CallDataTabControl.Controls.Add(BodyTab);
            CallDataTabControl.Controls.Add(ResponseTab);
            CallDataTabControl.Location = new Point(54, 245);
            CallDataTabControl.Name = "CallDataTabControl";
            CallDataTabControl.SelectedIndex = 0;
            CallDataTabControl.Size = new Size(1407, 573);
            CallDataTabControl.TabIndex = 8;
            // 
            // BodyTab
            // 
            BodyTab.Controls.Add(BodyTextBox);
            BodyTab.Location = new Point(4, 50);
            BodyTab.Name = "BodyTab";
            BodyTab.Padding = new Padding(3);
            BodyTab.Size = new Size(1399, 519);
            BodyTab.TabIndex = 0;
            BodyTab.Text = "Body";
            BodyTab.UseVisualStyleBackColor = true;
            // 
            // BodyTextBox
            // 
            BodyTextBox.BackColor = Color.White;
            BodyTextBox.BorderStyle = BorderStyle.FixedSingle;
            BodyTextBox.Dock = DockStyle.Fill;
            BodyTextBox.Location = new Point(3, 3);
            BodyTextBox.Multiline = true;
            BodyTextBox.Name = "BodyTextBox";
            BodyTextBox.ScrollBars = ScrollBars.Both;
            BodyTextBox.Size = new Size(1393, 513);
            BodyTextBox.TabIndex = 5;
            // 
            // ResponseTab
            // 
            ResponseTab.Controls.Add(ResponseTextBox);
            ResponseTab.Location = new Point(4, 30);
            ResponseTab.Name = "ResponseTab";
            ResponseTab.Padding = new Padding(3);
            ResponseTab.Size = new Size(1399, 539);
            ResponseTab.TabIndex = 1;
            ResponseTab.Text = "Response";
            ResponseTab.UseVisualStyleBackColor = true;
            // 
            // ResponseTextBox
            // 
            ResponseTextBox.BackColor = Color.White;
            ResponseTextBox.BorderStyle = BorderStyle.FixedSingle;
            ResponseTextBox.Dock = DockStyle.Fill;
            ResponseTextBox.Location = new Point(3, 3);
            ResponseTextBox.Multiline = true;
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.ReadOnly = true;
            ResponseTextBox.ScrollBars = ScrollBars.Both;
            ResponseTextBox.Size = new Size(1393, 533);
            ResponseTextBox.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1511, 879);
            Controls.Add(CallDataTabControl);
            Controls.Add(HttpVerbSelection);
            Controls.Add(StatusStrip);
            Controls.Add(CallAPIButton);
            Controls.Add(APITextBox);
            Controls.Add(EnterAPILabel);
            Controls.Add(FormHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Postman Clone by Ziad Hany";
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
    }
}
