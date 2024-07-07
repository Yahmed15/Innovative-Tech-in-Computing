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
    public partial class conclusion : Form
    {
        public conclusion()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            // Show the current form (Form1) and hide the intro form
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnnextconclusion_Click(object sender, EventArgs e)
        {
            // Instantiate the reference form
            reference referenceForm = new reference();

            // Show the reference form
            referenceForm.Show();

            // Hide the current form
            this.Hide();
        }
    }
}
