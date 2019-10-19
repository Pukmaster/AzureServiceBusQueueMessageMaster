namespace Pukmaster.AzureServiceBusQueueReader.Forms
{
    partial class AzureServiceBusSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.queueNameTextBox = new System.Windows.Forms.TextBox();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.queueNameLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            // 
            // queueNameTextBox
            // 
            this.queueNameTextBox.Location = new System.Drawing.Point(175, 61);
            this.queueNameTextBox.Name = "queueNameTextBox";
            this.queueNameTextBox.Size = new System.Drawing.Size(417, 31);
            this.queueNameTextBox.TabIndex = 0;
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Location = new System.Drawing.Point(175, 98);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(417, 31);
            this.connectionStringTextBox.TabIndex = 1;
            // 
            // queueNameLabel
            // 
            this.queueNameLabel.AutoSize = true;
            this.queueNameLabel.Location = new System.Drawing.Point(13, 61);
            this.queueNameLabel.Name = "queueNameLabel";
            this.queueNameLabel.Size = new System.Drawing.Size(117, 25);
            this.queueNameLabel.TabIndex = 2;
            this.queueNameLabel.Text = "Queue name:";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(13, 15);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(408, 25);
            this.settingsLabel.TabIndex = 3;
            this.settingsLabel.Text = "Please enter Azure Service Bus connection settings";
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Location = new System.Drawing.Point(13, 98);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(156, 25);
            this.connectionStringLabel.TabIndex = 4;
            this.connectionStringLabel.Text = "Connection string:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(459, 135);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(133, 40);
            this.saveSettingsButton.TabIndex = 5;
            this.saveSettingsButton.Text = "OK";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(320, 135);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 40);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AzureServiceBusSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 193);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.connectionStringLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.queueNameLabel);
            this.Controls.Add(this.connectionStringTextBox);
            this.Controls.Add(this.queueNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AzureServiceBusSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Settings";

        }

        #endregion

        private System.Windows.Forms.TextBox queueNameTextBox;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Label queueNameLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label connectionStringLabel;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button cancelButton;
    }
}