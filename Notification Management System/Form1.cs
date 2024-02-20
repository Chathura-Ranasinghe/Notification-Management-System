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
    public partial class Form1 : Form
    {
        private List<string> subscribers = new List<string>();

        public Form1()
        {
            InitializeComponent();
            UpdatePublishButtonState();
        }

        private void manageSubscriptionBtn_Click(object sender, EventArgs e)
        {
            Form2 manageSubscriptionForm = new Form2(subscribers);
            if (manageSubscriptionForm.ShowDialog() == DialogResult.OK)
            {
                subscribers = manageSubscriptionForm.Subscribers;
                UpdatePublishButtonState();
            }
        }

        private void publishNotificationBtn_Click(object sender, EventArgs e)
        {
            if (subscribers.Any())
            {
                Form3 publishNotificationForm = new Form3(subscribers);
                publishNotificationForm.ShowDialog();
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdatePublishButtonState()
        {
            publishNotificationBtn.Enabled = subscribers.Any();
        }
    }
}

