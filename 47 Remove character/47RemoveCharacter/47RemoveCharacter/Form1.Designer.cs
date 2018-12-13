namespace _47RemoveCharacter
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
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.lblLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(71, 38);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(248, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(28, 41);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 1;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbUitvoer
            // 
            this.tbUitvoer.Location = new System.Drawing.Point(71, 119);
            this.tbUitvoer.Name = "tbUitvoer";
            this.tbUitvoer.Size = new System.Drawing.Size(248, 20);
            this.tbUitvoer.TabIndex = 2;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(71, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 3;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(71, 64);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(39, 20);
            this.tbLetter.TabIndex = 4;
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(31, 67);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(34, 13);
            this.lblLetter.TabIndex = 5;
            this.lblLetter.Text = "Letter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.btnAntwoord);
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
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Label lblLetter;
    }
}

