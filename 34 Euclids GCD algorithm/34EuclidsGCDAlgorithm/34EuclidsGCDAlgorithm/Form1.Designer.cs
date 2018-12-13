namespace _34EuclidsGCDAlgorithm
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
            this.tbInvoer1 = new System.Windows.Forms.TextBox();
            this.tbInvoer2 = new System.Windows.Forms.TextBox();
            this.tbUitvoer = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblInvoer1 = new System.Windows.Forms.Label();
            this.lblInvoer2 = new System.Windows.Forms.Label();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.rtTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbInvoer1
            // 
            this.tbInvoer1.Location = new System.Drawing.Point(114, 51);
            this.tbInvoer1.Name = "tbInvoer1";
            this.tbInvoer1.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer1.TabIndex = 0;
            // 
            // tbInvoer2
            // 
            this.tbInvoer2.Location = new System.Drawing.Point(114, 77);
            this.tbInvoer2.Name = "tbInvoer2";
            this.tbInvoer2.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer2.TabIndex = 1;
            // 
            // tbUitvoer
            // 
            this.tbUitvoer.Location = new System.Drawing.Point(114, 132);
            this.tbUitvoer.Name = "tbUitvoer";
            this.tbUitvoer.Size = new System.Drawing.Size(100, 20);
            this.tbUitvoer.TabIndex = 2;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(114, 103);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 3;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblInvoer1
            // 
            this.lblInvoer1.AutoSize = true;
            this.lblInvoer1.Location = new System.Drawing.Point(62, 54);
            this.lblInvoer1.Name = "lblInvoer1";
            this.lblInvoer1.Size = new System.Drawing.Size(46, 13);
            this.lblInvoer1.TabIndex = 4;
            this.lblInvoer1.Text = "Invoer 1";
            // 
            // lblInvoer2
            // 
            this.lblInvoer2.AutoSize = true;
            this.lblInvoer2.Location = new System.Drawing.Point(62, 80);
            this.lblInvoer2.Name = "lblInvoer2";
            this.lblInvoer2.Size = new System.Drawing.Size(46, 13);
            this.lblInvoer2.TabIndex = 5;
            this.lblInvoer2.Text = "Invoer 2";
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.AutoSize = true;
            this.lblUitvoer.Location = new System.Drawing.Point(67, 135);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(41, 13);
            this.lblUitvoer.TabIndex = 6;
            this.lblUitvoer.Text = "Uitvoer";
            // 
            // rtTest
            // 
            this.rtTest.Location = new System.Drawing.Point(270, 57);
            this.rtTest.Name = "rtTest";
            this.rtTest.Size = new System.Drawing.Size(91, 156);
            this.rtTest.TabIndex = 7;
            this.rtTest.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 289);
            this.Controls.Add(this.rtTest);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.lblInvoer2);
            this.Controls.Add(this.lblInvoer1);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbUitvoer);
            this.Controls.Add(this.tbInvoer2);
            this.Controls.Add(this.tbInvoer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer1;
        private System.Windows.Forms.TextBox tbInvoer2;
        private System.Windows.Forms.TextBox tbUitvoer;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblInvoer1;
        private System.Windows.Forms.Label lblInvoer2;
        private System.Windows.Forms.Label lblUitvoer;
        private System.Windows.Forms.RichTextBox rtTest;
    }
}

