using System;
using System.Windows.Forms;

namespace Innovative_Tech_in_Computing
{
    partial class evaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evaluation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollevaluation = new System.Windows.Forms.VScrollBar();
            this.btnnextevaluation = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Evaluation and Analysis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(771, 440);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // scrollevaluation
            // 
            this.scrollevaluation.Location = new System.Drawing.Point(890, 73);
            this.scrollevaluation.Name = "scrollevaluation";
            this.scrollevaluation.Size = new System.Drawing.Size(22, 514);
            this.scrollevaluation.TabIndex = 7;
            this.scrollevaluation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollleg_Scroll);
            // 
            // btnnextevaluation
            // 
            this.btnnextevaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnextevaluation.Location = new System.Drawing.Point(583, 651);
            this.btnnextevaluation.Name = "btnnextevaluation";
            this.btnnextevaluation.Size = new System.Drawing.Size(200, 39);
            this.btnnextevaluation.TabIndex = 10;
            this.btnnextevaluation.Text = "Next";
            this.btnnextevaluation.UseVisualStyleBackColor = true;
            this.btnnextevaluation.Click += new System.EventHandler(this.btnnextevaluation_Click);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(31, 651);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(200, 39);
            this.btnhome.TabIndex = 9;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 903);
            this.Controls.Add(this.btnnextevaluation);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.scrollevaluation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "evaluation";
            this.Text = "evaluation";
            this.Load += new System.EventHandler(this.evaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void scrollleg_Scroll(object sender, ScrollEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar scrollevaluation;
        private System.Windows.Forms.Button btnnextevaluation;
        private System.Windows.Forms.Button btnhome;
    }
}