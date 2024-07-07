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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnintro_Click(object sender, EventArgs e)
        {
            // Instantiate the intro form
            intro introForm = new intro();

            // Show the intro form
            introForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void btnlegislation_Click(object sender, EventArgs e)
        {
            // Instantiate the legislation form
            legislation legislationForm = new legislation();

            // Show the legislation form
            legislationForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void btncase_Click(object sender, EventArgs e)
        {
            // Instantiate the case studies form
            casestudies caseStudiesForm = new casestudies();

            // Show the case studies form
            caseStudiesForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void btnevaluation_Click(object sender, EventArgs e)
        {
            // Instantiate the evaluation form
            evaluation evaluationForm = new evaluation();

            // Show the evaluation form
            evaluationForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void btnconclusion_Click(object sender, EventArgs e)
        {
            // Instantiate the conclusion form
            conclusion conclusionForm = new conclusion();

            // Show the conclusion form
            conclusionForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void btnreference_Click(object sender, EventArgs e)
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