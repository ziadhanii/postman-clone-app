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
            ResponseTextBox = new TextBox();
            StatusStrip = new StatusStrip();
            SystemStatus = new ToolStripStatusLabel();
            ResponseLabel = new Label();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FormHeader
            // 
            FormHeader.AutoSize = true;
            FormHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormHeader.Location = new Point(40, 29);
            FormHeader.Name = "FormHeader";
            FormHeader.Size = new Size(317, 60);
            FormHeader.TabIndex = 0;
            FormHeader.Text = "Postman Clone";
            // 
            // EnterAPILabel
            // 
            EnterAPILabel.AutoSize = true;
            EnterAPILabel.Location = new Point(46, 135);
            EnterAPILabel.Name = "EnterAPILabel";
            EnterAPILabel.Size = new Size(77, 41);
            EnterAPILabel.TabIndex = 1;
            EnterAPILabel.Text = "API :";
            // 
            // APITextBox
            // 
            APITextBox.Location = new Point(137, 133);
            APITextBox.Name = "APITextBox";
            APITextBox.Size = new Size(1192, 47);
            APITextBox.TabIndex = 2;
            // 
            // CallAPIButton
            // 
            CallAPIButton.Location = new Point(1355, 132);
            CallAPIButton.Margin = new Padding(0);
            CallAPIButton.Name = "CallAPIButton";
            CallAPIButton.Size = new Size(106, 51);
            CallAPIButton.TabIndex = 3;
            CallAPIButton.Text = "Send";
            CallAPIButton.UseVisualStyleBackColor = true;
            CallAPIButton.Click += CallAPIButton_Click;
            // 
            // ResponseTextBox
            // 
            ResponseTextBox.BackColor = Color.White;
            ResponseTextBox.BorderStyle = BorderStyle.FixedSingle;
            ResponseTextBox.Location = new Point(54, 271);
            ResponseTextBox.Multiline = true;
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.ReadOnly = true;
            ResponseTextBox.ScrollBars = ScrollBars.Both;
            ResponseTextBox.Size = new Size(1407, 540);
            ResponseTextBox.TabIndex = 4;
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
            // ResponseLabel
            // 
            ResponseLabel.AutoSize = true;
            ResponseLabel.Location = new Point(46, 216);
            ResponseLabel.Name = "ResponseLabel";
            ResponseLabel.Size = new Size(161, 41);
            ResponseLabel.TabIndex = 6;
            ResponseLabel.Text = "Response :";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1511, 879);
            Controls.Add(ResponseLabel);
            Controls.Add(StatusStrip);
            Controls.Add(ResponseTextBox);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormHeader;
        private Label EnterAPILabel;
        private TextBox APITextBox;
        private Button CallAPIButton;
        private TextBox ResponseTextBox;
        private StatusStrip StatusStrip;
        private Label ResponseLabel;
        private ToolStripStatusLabel SystemStatus;
    }
}
