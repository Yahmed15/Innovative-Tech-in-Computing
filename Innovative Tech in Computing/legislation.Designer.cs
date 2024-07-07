namespace Innovative_Tech_in_Computing
{
    partial class legislation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(legislation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollleg = new System.Windows.Forms.VScrollBar();
            this.btnnextlegislation = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legislation and Regulations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(750, 580);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // scrollleg
            // 
            this.scrollleg.Location = new System.Drawing.Point(899, 45);
            this.scrollleg.Name = "scrollleg";
            this.scrollleg.Size = new System.Drawing.Size(24, 662);
            this.scrollleg.TabIndex = 3;
            this.scrollleg.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollleg_Scroll);
            // 
            // btnnextlegislation
            // 
            this.btnnextlegislation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnextlegislation.Location = new System.Drawing.Point(586, 748);
            this.btnnextlegislation.Name = "btnnextlegislation";
            this.btnnextlegislation.Size = new System.Drawing.Size(200, 39);
            this.btnnextlegislation.TabIndex = 6;
            this.btnnextlegislation.Text = "Next";
            this.btnnextlegislation.UseVisualStyleBackColor = true;
            this.btnnextlegislation.Click += new System.EventHandler(this.btnnextlegislation_Click);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(16, 748);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(200, 39);
            this.btnhome.TabIndex = 8;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // legislation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 903);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnnextlegislation);
            this.Controls.Add(this.scrollleg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "legislation";
            this.Text = "legislation";
            this.Load += new System.EventHandler(this.legislation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar scrollleg;
        private System.Windows.Forms.Button btnnextlegislation;
        private System.Windows.Forms.Button btnhome;
    }
}