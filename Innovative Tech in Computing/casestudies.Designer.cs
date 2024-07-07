namespace Innovative_Tech_in_Computing
{
    partial class casestudies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(casestudies));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollcase = new System.Windows.Forms.VScrollBar();
            this.btnnextcase = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Case Studies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(821, 640);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // scrollcase
            // 
            this.scrollcase.Location = new System.Drawing.Point(913, 63);
            this.scrollcase.Name = "scrollcase";
            this.scrollcase.Size = new System.Drawing.Size(24, 738);
            this.scrollcase.TabIndex = 4;
            this.scrollcase.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollcase_Scroll);
            // 
            // btnnextcase
            // 
            this.btnnextcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnextcase.Location = new System.Drawing.Point(578, 790);
            this.btnnextcase.Name = "btnnextcase";
            this.btnnextcase.Size = new System.Drawing.Size(200, 39);
            this.btnnextcase.TabIndex = 8;
            this.btnnextcase.Text = "Next";
            this.btnnextcase.UseVisualStyleBackColor = true;
            this.btnnextcase.Click += new System.EventHandler(this.btnnextcase_Click);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(26, 790);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(200, 39);
            this.btnhome.TabIndex = 7;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // casestudies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 903);
            this.Controls.Add(this.btnnextcase);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.scrollcase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "casestudies";
            this.Text = "casestudies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar scrollcase;
        private System.Windows.Forms.Button btnnextcase;
        private System.Windows.Forms.Button btnhome;
    }
}