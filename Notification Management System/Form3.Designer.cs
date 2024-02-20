namespace Notification_Management_System
{
    partial class Form3
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
            notificationCont = new TextBox();
            publishBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // notificationCont
            // 
            notificationCont.Location = new Point(53, 86);
            notificationCont.Name = "notificationCont";
            notificationCont.Size = new Size(476, 27);
            notificationCont.TabIndex = 0;
            // 
            // publishBtn
            // 
            publishBtn.Location = new Point(53, 183);
            publishBtn.Name = "publishBtn";
            publishBtn.Size = new Size(94, 29);
            publishBtn.TabIndex = 1;
            publishBtn.Text = "Publish";
            publishBtn.UseVisualStyleBackColor = true;
            publishBtn.Click += publishBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(435, 183);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Cancel";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(exitBtn);
            Controls.Add(publishBtn);
            Controls.Add(notificationCont);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form3";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Publish Notification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox notificationCont;
        private Button publishBtn;
        private Button exitBtn;
    }
}