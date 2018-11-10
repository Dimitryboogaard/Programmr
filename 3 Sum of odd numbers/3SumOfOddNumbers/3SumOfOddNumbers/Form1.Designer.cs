namespace _3SumOfOddNumbers
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
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(74, 114);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 0;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(74, 62);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 1;
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(74, 88);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(100, 20);
            this.tbAntwoord.TabIndex = 2;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(31, 65);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 3;
            this.lblInvoer.Text = "Invoer";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(16, 95);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 4;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 240);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbAntwoord);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.TextBox tbAntwoord;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

