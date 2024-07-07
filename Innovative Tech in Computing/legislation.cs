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
    public partial class legislation : Form
    {
        public legislation()
        {
            InitializeComponent();

            // Enable the scrollbar
            scrollleg.Enabled = true;
        }

        private void legislation_Load(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            // Show the current form (Form1) and hide the intro form
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnnextlegislation_Click(object sender, EventArgs e)
        {
            // Instantiate the case studies form
            casestudies caseStudiesForm = new casestudies();

            // Show the case studies form
            caseStudiesForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void scrollleg_Scroll(object sender, ScrollEventArgs e)
        {
            // Check if the scroll event is due to the user changing the scroll value
            if (e.Type == ScrollEventType.EndScroll)
            {
                // Update your UI or perform any other actions based on the new scroll value
                int newValue = scrollleg.Value;
                // Example: Update a label with the new scroll value
                label2.Text = newValue.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
