namespace _4LastSamplesOfANumber
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
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbInvoer1 = new System.Windows.Forms.TextBox();
            this.tbInvoer2 = new System.Windows.Forms.TextBox();
            this.lblInvoer1 = new System.Windows.Forms.Label();
            this.lblInvoer2 = new System.Windows.Forms.Label();
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(90, 120);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 0;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbInvoer1
            // 
            this.tbInvoer1.Location = new System.Drawing.Point(90, 42);
            this.tbInvoer1.Name = "tbInvoer1";
            this.tbInvoer1.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer1.TabIndex = 1;
            // 
            // tbInvoer2
            // 
            this.tbInvoer2.Location = new System.Drawing.Point(90, 68);
            this.tbInvoer2.Name = "tbInvoer2";
            this.tbInvoer2.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer2.TabIndex = 2;
            // 
            // lblInvoer1
            // 
            this.lblInvoer1.AutoSize = true;
            this.lblInvoer1.Location = new System.Drawing.Point(41, 45);
            this.lblInvoer1.Name = "lblInvoer1";
            this.lblInvoer1.Size = new System.Drawing.Size(43, 13);
            this.lblInvoer1.TabIndex = 3;
            this.lblInvoer1.Text = "Invoer1";
            // 
            // lblInvoer2
            // 
            this.lblInvoer2.AutoSize = true;
            this.lblInvoer2.Location = new System.Drawing.Point(41, 71);
            this.lblInvoer2.Name = "lblInvoer2";
            this.lblInvoer2.Size = new System.Drawing.Size(43, 13);
            this.lblInvoer2.TabIndex = 4;
            this.lblInvoer2.Text = "Invoer2";
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(90, 94);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(100, 20);
            this.tbAntwoord.TabIndex = 5;
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(32, 97);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 6;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 319);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.tbAntwoord);
            this.Controls.Add(this.lblInvoer2);
            this.Controls.Add(this.lblInvoer1);
            this.Controls.Add(this.tbInvoer2);
            this.Controls.Add(this.tbInvoer1);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbInvoer1;
        private System.Windows.Forms.TextBox tbInvoer2;
        private System.Windows.Forms.Label lblInvoer1;
        private System.Windows.Forms.Label lblInvoer2;
        private System.Windows.Forms.TextBox tbAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

