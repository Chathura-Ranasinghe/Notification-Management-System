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
    public partial class Form2 : Form
    {
        private List<string> subscribers;

        public List<string> Subscribers
        {
            get { return subscribers; }
        }

        public Form2(List<string> existingSubscribers)
        {
            InitializeComponent();
            subscribers = existingSubscribers;
        }

        private void subscribeBtn_Click(object sender, EventArgs e)
        {
            string email = mailBox.Text.Trim();

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Wrong email format!");
                return;
            }

            if (subscribers.Contains(email))
            {
                MessageBox.Show("Duplicate email!");
                return;
            }

            subscribers.Add(email);
            DialogResult = DialogResult.OK;
        }

        private void unsubscribeBtn_Click(object sender, EventArgs e)
        {
            string email = mailBox.Text.Trim();

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Wrong email format!");
                return;
            }

            if (!subscribers.Contains(email))
            {
                MessageBox.Show("Email not found!");
                return;
            }

            subscribers.Remove(email);
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
