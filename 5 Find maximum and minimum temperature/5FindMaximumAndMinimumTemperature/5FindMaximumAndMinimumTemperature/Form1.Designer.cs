namespace _5FindMaximumAndMinimumTemperature
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
            this.tbMinimumTemperatuur = new System.Windows.Forms.TextBox();
            this.tbMaximumTemperatuur = new System.Windows.Forms.TextBox();
            this.lblMinimumTemperatuur = new System.Windows.Forms.Label();
            this.lblMaximumTemperatuur = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMinimumTemperatuur
            // 
            this.tbMinimumTemperatuur.Location = new System.Drawing.Point(152, 58);
            this.tbMinimumTemperatuur.Name = "tbMinimumTemperatuur";
            this.tbMinimumTemperatuur.Size = new System.Drawing.Size(100, 20);
            this.tbMinimumTemperatuur.TabIndex = 0;
            // 
            // tbMaximumTemperatuur
            // 
            this.tbMaximumTemperatuur.Location = new System.Drawing.Point(152, 84);
            this.tbMaximumTemperatuur.Name = "tbMaximumTemperatuur";
            this.tbMaximumTemperatuur.Size = new System.Drawing.Size(100, 20);
            this.tbMaximumTemperatuur.TabIndex = 1;
            // 
            // lblMinimumTemperatuur
            // 
            this.lblMinimumTemperatuur.AutoSize = true;
            this.lblMinimumTemperatuur.Location = new System.Drawing.Point(44, 61);
            this.lblMinimumTemperatuur.Name = "lblMinimumTemperatuur";
            this.lblMinimumTemperatuur.Size = new System.Drawing.Size(104, 13);
            this.lblMinimumTemperatuur.TabIndex = 2;
            this.lblMinimumTemperatuur.Text = "Minimumtemperatuur";
            // 
            // lblMaximumTemperatuur
            // 
            this.lblMaximumTemperatuur.AutoSize = true;
            this.lblMaximumTemperatuur.Location = new System.Drawing.Point(41, 87);
            this.lblMaximumTemperatuur.Name = "lblMaximumTemperatuur";
            this.lblMaximumTemperatuur.Size = new System.Drawing.Size(107, 13);
            this.lblMaximumTemperatuur.TabIndex = 3;
            this.lblMaximumTemperatuur.Text = "Maximumtemperatuur";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(120, 155);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 271);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblMaximumTemperatuur);
            this.Controls.Add(this.lblMinimumTemperatuur);
            this.Controls.Add(this.tbMaximumTemperatuur);
            this.Controls.Add(this.tbMinimumTemperatuur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMinimumTemperatuur;
        private System.Windows.Forms.TextBox tbMaximumTemperatuur;
        private System.Windows.Forms.Label lblMinimumTemperatuur;
        private System.Windows.Forms.Label lblMaximumTemperatuur;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

