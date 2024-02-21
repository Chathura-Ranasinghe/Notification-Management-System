namespace Notification_Management_System
{
    partial class Form2
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
            mailBox = new TextBox();
            subscribeBtn = new Button();
            unsubscribeBtn = new Button();
            cancelBtn = new Button();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // mailBox
            // 
            mailBox.Location = new Point(53, 57);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(476, 27);
            mailBox.TabIndex = 0;
            // 
            // subscribeBtn
            // 
            subscribeBtn.Location = new Point(53, 184);
            subscribeBtn.Name = "subscribeBtn";
            subscribeBtn.Size = new Size(94, 29);
            subscribeBtn.TabIndex = 1;
            subscribeBtn.Text = "Subscribe";
            subscribeBtn.UseVisualStyleBackColor = true;
            subscribeBtn.Click += subscribeBtn_Click;
            // 
            // unsubscribeBtn
            // 
            unsubscribeBtn.Location = new Point(244, 184);
            unsubscribeBtn.Name = "unsubscribeBtn";
            unsubscribeBtn.Size = new Size(94, 29);
            unsubscribeBtn.TabIndex = 2;
            unsubscribeBtn.Text = "Unsubscribe";
            unsubscribeBtn.UseVisualStyleBackColor = true;
            unsubscribeBtn.Click += unsubscribeBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(435, 184);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageLabel.ForeColor = Color.Red;
            messageLabel.Location = new Point(53, 114);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(476, 24);
            messageLabel.TabIndex = 4;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.Click += messageLabel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(messageLabel);
            Controls.Add(cancelBtn);
            Controls.Add(unsubscribeBtn);
            Controls.Add(subscribeBtn);
            Controls.Add(mailBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Subscription ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mailBox;
        private Button subscribeBtn;
        private Button unsubscribeBtn;
        private Button cancelBtn;
        private Label messageLabel;
    }
}