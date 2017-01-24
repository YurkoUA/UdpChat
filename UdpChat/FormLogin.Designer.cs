namespace UdpChat
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.nameText = new System.Windows.Forms.TextBox();
            this.multicastText = new System.Windows.Forms.TextBox();
            this.localPortText = new System.Windows.Forms.TextBox();
            this.remotePortText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.checkNetTimer = new System.Windows.Forms.Timer(this.components);
            this.localIpText = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 17);
            label2.TabIndex = 2;
            label2.Text = "Multicast address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 17);
            label3.TabIndex = 4;
            label3.Text = "Local port:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 88);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 17);
            label4.TabIndex = 5;
            label4.Text = "Remote port:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(132, 10);
            this.nameText.MaxLength = 32;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(218, 22);
            this.nameText.TabIndex = 1;
            // 
            // multicastText
            // 
            this.multicastText.Location = new System.Drawing.Point(132, 35);
            this.multicastText.MaxLength = 15;
            this.multicastText.Name = "multicastText";
            this.multicastText.Size = new System.Drawing.Size(218, 22);
            this.multicastText.TabIndex = 3;
            this.multicastText.Text = "224.0.0.0";
            // 
            // localPortText
            // 
            this.localPortText.Location = new System.Drawing.Point(132, 60);
            this.localPortText.MaxLength = 5;
            this.localPortText.Name = "localPortText";
            this.localPortText.Size = new System.Drawing.Size(218, 22);
            this.localPortText.TabIndex = 6;
            this.localPortText.Text = "8001";
            // 
            // remotePortText
            // 
            this.remotePortText.Location = new System.Drawing.Point(132, 85);
            this.remotePortText.MaxLength = 5;
            this.remotePortText.Name = "remotePortText";
            this.remotePortText.Size = new System.Drawing.Size(218, 22);
            this.remotePortText.TabIndex = 7;
            this.remotePortText.Text = "8001";
            // 
            // loginButton
            // 
            this.loginButton.Enabled = false;
            this.loginButton.Location = new System.Drawing.Point(132, 113);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(104, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkNetTimer
            // 
            this.checkNetTimer.Enabled = true;
            this.checkNetTimer.Interval = 3000;
            this.checkNetTimer.Tick += new System.EventHandler(this.checkNetTimer_Tick);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 140);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 17);
            label5.TabIndex = 9;
            label5.Text = "IP address:";
            // 
            // localIpText
            // 
            this.localIpText.AutoSize = true;
            this.localIpText.Location = new System.Drawing.Point(98, 140);
            this.localIpText.Name = "localIpText";
            this.localIpText.Size = new System.Drawing.Size(0, 17);
            this.localIpText.TabIndex = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(362, 169);
            this.Controls.Add(this.localIpText);
            this.Controls.Add(label5);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.remotePortText);
            this.Controls.Add(this.localPortText);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.multicastText);
            this.Controls.Add(label2);
            this.Controls.Add(this.nameText);
            this.Controls.Add(label1);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Chat - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox multicastText;
        private System.Windows.Forms.TextBox localPortText;
        private System.Windows.Forms.TextBox remotePortText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Timer checkNetTimer;
        private System.Windows.Forms.Label localIpText;
    }
}

