using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovative_Tech_in_Computing
{
    public partial class reference : Form
    {
        public reference()
        {
            InitializeComponent();

            // Enable the scrollbar
            scrollref.Enabled = true;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            // Show the current form (Form1) and hide the intro form
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnnextref_Click(object sender, EventArgs e)
        {
            // Show the current form (Form1) and hide the intro form
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void scrollref_Scroll(object sender, ScrollEventArgs e)
        {
            // Check if the scroll event is due to the user changing the scroll value
            if (e.Type == ScrollEventType.EndScroll)
            {
                // Update your UI or perform any other actions based on the new scroll value
                int newValue = scrollref.Value;
                // Example: Update a label with the new scroll value
                label2.Text = newValue.ToString();
            }
        }
    }
}
