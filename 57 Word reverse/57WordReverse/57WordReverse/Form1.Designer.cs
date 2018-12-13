namespace _57WordReverse
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
            this.tbUitvoer = new System.Windows.Forms.TextBox();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(75, 28);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(263, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(32, 31);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 1;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbUitvoer
            // 
            this.tbUitvoer.Location = new System.Drawing.Point(75, 83);
            this.tbUitvoer.Name = "tbUitvoer";
            this.tbUitvoer.Size = new System.Drawing.Size(263, 20);
            this.tbUitvoer.TabIndex = 2;
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.AutoSize = true;
            this.lblUitvoer.Location = new System.Drawing.Point(28, 86);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(41, 13);
            this.lblUitvoer.TabIndex = 3;
            this.lblUitvoer.Text = "Uitvoer";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(75, 54);
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
            this.ClientSize = new System.Drawing.Size(436, 287);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.tbUitvoer);
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
        private System.Windows.Forms.TextBox tbUitvoer;
        private System.Windows.Forms.Label lblUitvoer;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

