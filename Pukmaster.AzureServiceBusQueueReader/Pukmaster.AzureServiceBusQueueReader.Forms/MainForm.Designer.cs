namespace Pukmaster.AzureServiceBusQueueReader.Forms
{
    partial class MainForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.messageIdColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.queuedSinceColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            this.messagesLabel = new System.Windows.Forms.Label();
            this.payloadLabel = new System.Windows.Forms.Label();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.valueColumnHeader = new System.Windows.Forms.ColumnHeader();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.messageIdColumnHeader,
            this.queuedSinceColumnHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1113, 241);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // messageIdColumnHeader
            // 
            this.messageIdColumnHeader.Name = "messageIdColumnHeader";
            this.messageIdColumnHeader.Text = "Message ID";
            this.messageIdColumnHeader.Width = 350;
            // 
            // queuedSinceColumnHeader
            // 
            this.queuedSinceColumnHeader.Name = "queuedSinceColumnHeader";
            this.queuedSinceColumnHeader.Text = "Queued since";
            this.queuedSinceColumnHeader.Width = 210;
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payloadTextBox.Location = new System.Drawing.Point(8, 336);
            this.payloadTextBox.Multiline = true;
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.payloadTextBox.Size = new System.Drawing.Size(629, 214);
            this.payloadTextBox.TabIndex = 1;
            // 
            // messagesLabel
            // 
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Location = new System.Drawing.Point(8, 15);
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(61, 15);
            this.messagesLabel.TabIndex = 2;
            this.messagesLabel.Text = "Messages:";
            // 
            // payloadLabel
            // 
            this.payloadLabel.AutoSize = true;
            this.payloadLabel.Location = new System.Drawing.Point(8, 308);
            this.payloadLabel.Name = "payloadLabel";
            this.payloadLabel.Size = new System.Drawing.Size(52, 15);
            this.payloadLabel.TabIndex = 3;
            this.payloadLabel.Text = "Payload:";
            // 
            // connectedLabel
            // 
            this.connectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(8, 562);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(79, 15);
            this.connectedLabel.TabIndex = 4;
            this.connectedLabel.Text = "Disconnected";
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.Location = new System.Drawing.Point(8, 590);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(133, 40);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect...";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesLabel.AutoSize = true;
            this.propertiesLabel.Location = new System.Drawing.Point(643, 308);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(63, 15);
            this.propertiesLabel.TabIndex = 7;
            this.propertiesLabel.Text = "Properties:";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextBox.Location = new System.Drawing.Point(8, 636);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextBox.Size = new System.Drawing.Size(1113, 149);
            this.consoleTextBox.TabIndex = 8;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.valueColumnHeader});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(643, 336);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(478, 214);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Name = "nameColumnHeader";
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 150;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Name = "valueColumnHeader";
            this.valueColumnHeader.Text = "Value";
            this.valueColumnHeader.Width = 290;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1129, 799);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.propertiesLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.payloadLabel);
            this.Controls.Add(this.messagesLabel);
            this.Controls.Add(this.payloadTextBox);
            this.Controls.Add(this.listView1);
            this.Name = "MainForm";
            this.Text = "Azure Service Bus Queue Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);

        }

        #endregion

        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader messageIdColumnHeader;
        private System.Windows.Forms.ColumnHeader queuedSinceColumnHeader;
        private System.Windows.Forms.TextBox payloadTextBox;
        private System.Windows.Forms.Label messagesLabel;
        private System.Windows.Forms.Label payloadLabel;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label propertiesLabel;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
    }
}

