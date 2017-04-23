namespace UdpChat
{
    partial class FormChat
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
            System.Windows.Forms.GroupBox groupBox1;
            this.sendButton = new System.Windows.Forms.Button();
            this.messageText = new System.Windows.Forms.RichTextBox();
            this.chatTextBox = new System.Windows.Forms.RichTextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.sendButton);
            groupBox1.Controls.Add(this.messageText);
            groupBox1.Location = new System.Drawing.Point(13, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(757, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Write Your Message";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(605, 21);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(146, 73);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(7, 22);
            this.messageText.MaxLength = 64;
            this.messageText.Multiline = false;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(592, 72);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "";
            this.messageText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageText_KeyUp);
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(13, 13);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.Size = new System.Drawing.Size(757, 310);
            this.chatTextBox.TabIndex = 2;
            this.chatTextBox.Text = "";
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.chatTextBox);
            this.MaximizeBox = false;
            this.Name = "FormChat";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChat_FormClosed);
            groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox messageText;
    }
}