namespace _17WindChill
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
            this.tbTemperatuur = new System.Windows.Forms.TextBox();
            this.tbWindSnelheid = new System.Windows.Forms.TextBox();
            this.lblTemperatuur = new System.Windows.Forms.Label();
            this.lblWindSnelheid = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbWindChill = new System.Windows.Forms.TextBox();
            this.lblWindChill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTemperatuur
            // 
            this.tbTemperatuur.Location = new System.Drawing.Point(101, 55);
            this.tbTemperatuur.Name = "tbTemperatuur";
            this.tbTemperatuur.Size = new System.Drawing.Size(100, 20);
            this.tbTemperatuur.TabIndex = 0;
            // 
            // tbWindSnelheid
            // 
            this.tbWindSnelheid.Location = new System.Drawing.Point(101, 81);
            this.tbWindSnelheid.Name = "tbWindSnelheid";
            this.tbWindSnelheid.Size = new System.Drawing.Size(100, 20);
            this.tbWindSnelheid.TabIndex = 1;
            // 
            // lblTemperatuur
            // 
            this.lblTemperatuur.AutoSize = true;
            this.lblTemperatuur.Location = new System.Drawing.Point(28, 58);
            this.lblTemperatuur.Name = "lblTemperatuur";
            this.lblTemperatuur.Size = new System.Drawing.Size(67, 13);
            this.lblTemperatuur.TabIndex = 2;
            this.lblTemperatuur.Text = "Temperatuur";
            // 
            // lblWindSnelheid
            // 
            this.lblWindSnelheid.AutoSize = true;
            this.lblWindSnelheid.Location = new System.Drawing.Point(24, 84);
            this.lblWindSnelheid.Name = "lblWindSnelheid";
            this.lblWindSnelheid.Size = new System.Drawing.Size(71, 13);
            this.lblWindSnelheid.TabIndex = 3;
            this.lblWindSnelheid.Text = "Windsnelheid";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(101, 107);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbWindChill
            // 
            this.tbWindChill.Location = new System.Drawing.Point(101, 136);
            this.tbWindChill.Name = "tbWindChill";
            this.tbWindChill.Size = new System.Drawing.Size(100, 20);
            this.tbWindChill.TabIndex = 5;
            // 
            // lblWindChill
            // 
            this.lblWindChill.AutoSize = true;
            this.lblWindChill.Location = new System.Drawing.Point(42, 139);
            this.lblWindChill.Name = "lblWindChill";
            this.lblWindChill.Size = new System.Drawing.Size(53, 13);
            this.lblWindChill.TabIndex = 6;
            this.lblWindChill.Text = "Wind chill";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 285);
            this.Controls.Add(this.lblWindChill);
            this.Controls.Add(this.tbWindChill);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblWindSnelheid);
            this.Controls.Add(this.lblTemperatuur);
            this.Controls.Add(this.tbWindSnelheid);
            this.Controls.Add(this.tbTemperatuur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTemperatuur;
        private System.Windows.Forms.TextBox tbWindSnelheid;
        private System.Windows.Forms.Label lblTemperatuur;
        private System.Windows.Forms.Label lblWindSnelheid;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbWindChill;
        private System.Windows.Forms.Label lblWindChill;
    }
}

