
namespace TokaGraaf
{
    partial class Form1
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.PainikeBT = new System.Windows.Forms.Button();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.OhjetekstiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(327, 220);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(0, 13);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // PainikeBT
            // 
            this.PainikeBT.AccessibleName = "";
            this.PainikeBT.Location = new System.Drawing.Point(330, 194);
            this.PainikeBT.Name = "PainikeBT";
            this.PainikeBT.Size = new System.Drawing.Size(293, 23);
            this.PainikeBT.TabIndex = 1;
            this.PainikeBT.Text = "Vaihda teksi";
            this.PainikeBT.UseVisualStyleBackColor = true;
            this.PainikeBT.Click += new System.EventHandler(this.PainikeBT_Click);
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(397, 168);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(226, 20);
            this.TekstiTB.TabIndex = 2;
            // 
            // OhjetekstiLB
            // 
            this.OhjetekstiLB.AutoSize = true;
            this.OhjetekstiLB.Location = new System.Drawing.Point(327, 171);
            this.OhjetekstiLB.Name = "OhjetekstiLB";
            this.OhjetekstiLB.Size = new System.Drawing.Size(64, 13);
            this.OhjetekstiLB.TabIndex = 3;
            this.OhjetekstiLB.Text = "Kirjota jotain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OhjetekstiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.PainikeBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button PainikeBT;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label OhjetekstiLB;
    }
}

