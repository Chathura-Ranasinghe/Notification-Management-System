using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification_Management_System
{
    public partial class Form3 : Form
    {
        private List<string> subscribers;

        public Form3(List<string> subscribers)
        {
            InitializeComponent();
            this.subscribers = subscribers;
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            string notificationContent = notificationCont.Text.Trim();

            if (string.IsNullOrWhiteSpace(notificationContent))
            {
                MessageBox.Show("Please enter notification content.");
                return;
            }

            // Here you can implement the logic to send notification to all subscribers
            MessageBox.Show("Notification Published Successfully!");
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
