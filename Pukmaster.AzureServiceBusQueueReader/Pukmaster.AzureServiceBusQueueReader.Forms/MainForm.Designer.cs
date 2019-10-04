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
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(868, 199);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payloadTextBox.Location = new System.Drawing.Point(8, 282);
            this.payloadTextBox.Multiline = true;
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.payloadTextBox.Size = new System.Drawing.Size(868, 122);
            this.payloadTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(884, 419);
            this.Controls.Add(this.payloadTextBox);
            this.Controls.Add(this.listView1);
            this.Name = "MainForm";
            this.Text = "Azure ServiceBus Queue Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);

        }

        #endregion

        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox payloadTextBox;
    }
}

