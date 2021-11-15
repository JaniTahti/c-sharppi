
namespace DateTimePicker
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
            this.Nappi = new System.Windows.Forms.Button();
            this.Vuosi = new System.Windows.Forms.Label();
            this.KK = new System.Windows.Forms.Label();
            this.PV = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Nappi
            // 
            this.Nappi.Location = new System.Drawing.Point(463, 101);
            this.Nappi.Name = "Nappi";
            this.Nappi.Size = new System.Drawing.Size(75, 23);
            this.Nappi.TabIndex = 6;
            this.Nappi.Text = "Laske";
            this.Nappi.UseVisualStyleBackColor = true;
            this.Nappi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vuosi
            // 
            this.Vuosi.AutoSize = true;
            this.Vuosi.Location = new System.Drawing.Point(199, 144);
            this.Vuosi.Name = "Vuosi";
            this.Vuosi.Size = new System.Drawing.Size(0, 13);
            this.Vuosi.TabIndex = 8;
            this.Vuosi.Click += new System.EventHandler(this.label1_Click);
            // 
            // KK
            // 
            this.KK.AutoSize = true;
            this.KK.Location = new System.Drawing.Point(199, 188);
            this.KK.Name = "KK";
            this.KK.Size = new System.Drawing.Size(0, 13);
            this.KK.TabIndex = 12;
            // 
            // PV
            // 
            this.PV.AutoSize = true;
            this.PV.Location = new System.Drawing.Point(199, 240);
            this.PV.Name = "PV";
            this.PV.Size = new System.Drawing.Size(0, 13);
            this.PV.TabIndex = 13;
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(391, 144);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(0, 13);
            this.H.TabIndex = 14;
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(391, 188);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(0, 13);
            this.Min.TabIndex = 15;
            // 
            // Sec
            // 
            this.Sec.AutoSize = true;
            this.Sec.Location = new System.Drawing.Point(391, 240);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(0, 13);
            this.Sec.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(257, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.H);
            this.Controls.Add(this.PV);
            this.Controls.Add(this.KK);
            this.Controls.Add(this.Vuosi);
            this.Controls.Add(this.Nappi);
            this.Name = "Form1";
            this.Text = "IkäLaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Nappi;
        private System.Windows.Forms.Label Vuosi;
        private System.Windows.Forms.Label KK;
        private System.Windows.Forms.Label PV;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Sec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

