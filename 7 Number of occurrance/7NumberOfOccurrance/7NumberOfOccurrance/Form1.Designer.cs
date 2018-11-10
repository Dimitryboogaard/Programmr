namespace _7NumberOfOccurrance
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
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.tbGezochtNummer = new System.Windows.Forms.TextBox();
            this.lblGezochtNummer = new System.Windows.Forms.Label();
            this.tbAantal = new System.Windows.Forms.TextBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(140, 58);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(95, 65);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 1;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbGezochtNummer
            // 
            this.tbGezochtNummer.Location = new System.Drawing.Point(140, 84);
            this.tbGezochtNummer.Name = "tbGezochtNummer";
            this.tbGezochtNummer.Size = new System.Drawing.Size(100, 20);
            this.tbGezochtNummer.TabIndex = 2;
            // 
            // lblGezochtNummer
            // 
            this.lblGezochtNummer.AutoSize = true;
            this.lblGezochtNummer.Location = new System.Drawing.Point(47, 91);
            this.lblGezochtNummer.Name = "lblGezochtNummer";
            this.lblGezochtNummer.Size = new System.Drawing.Size(87, 13);
            this.lblGezochtNummer.TabIndex = 3;
            this.lblGezochtNummer.Text = "Gezocht nummer";
            // 
            // tbAantal
            // 
            this.tbAantal.Location = new System.Drawing.Point(138, 139);
            this.tbAantal.Name = "tbAantal";
            this.tbAantal.Size = new System.Drawing.Size(100, 20);
            this.tbAantal.TabIndex = 4;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(95, 142);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 5;
            this.lblAantal.Text = "Aantal";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(140, 110);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 307);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.tbAantal);
            this.Controls.Add(this.lblGezochtNummer);
            this.Controls.Add(this.tbGezochtNummer);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox tbGezochtNummer;
        private System.Windows.Forms.Label lblGezochtNummer;
        private System.Windows.Forms.TextBox tbAantal;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

