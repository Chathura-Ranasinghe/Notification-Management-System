namespace Notification_Management_System
{
    partial class Form1
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
            manageSubscriptionBtn = new Button();
            publishNotificationBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // manageSubscriptionBtn
            // 
            manageSubscriptionBtn.Location = new Point(23, 42);
            manageSubscriptionBtn.Name = "manageSubscriptionBtn";
            manageSubscriptionBtn.Size = new Size(201, 29);
            manageSubscriptionBtn.TabIndex = 0;
            manageSubscriptionBtn.Text = "Manage Subscriptions";
            manageSubscriptionBtn.UseVisualStyleBackColor = true;
            manageSubscriptionBtn.Click += manageSubscriptionBtn_Click;
            // 
            // publishNotificationBtn
            // 
            publishNotificationBtn.Location = new Point(246, 42);
            publishNotificationBtn.Name = "publishNotificationBtn";
            publishNotificationBtn.Size = new Size(196, 29);
            publishNotificationBtn.TabIndex = 1;
            publishNotificationBtn.Text = "Publish Notification";
            publishNotificationBtn.UseVisualStyleBackColor = true;
            publishNotificationBtn.Click += publishNotificationBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(465, 42);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 103);
            Controls.Add(exitBtn);
            Controls.Add(publishNotificationBtn);
            Controls.Add(manageSubscriptionBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notification Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button manageSubscriptionBtn;
        private Button publishNotificationBtn;
        private Button exitBtn;
    }
}
