namespace _13IndianRupeesFormat
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
            this.tbIndianRupeesFormat = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblIndianRupeesFormat = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(121, 27);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // tbIndianRupeesFormat
            // 
            this.tbIndianRupeesFormat.Location = new System.Drawing.Point(121, 53);
            this.tbIndianRupeesFormat.Name = "tbIndianRupeesFormat";
            this.tbIndianRupeesFormat.Size = new System.Drawing.Size(185, 20);
            this.tbIndianRupeesFormat.TabIndex = 1;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(78, 30);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 2;
            this.lblInvoer.Text = "Invoer";
            // 
            // lblIndianRupeesFormat
            // 
            this.lblIndianRupeesFormat.AutoSize = true;
            this.lblIndianRupeesFormat.Location = new System.Drawing.Point(12, 56);
            this.lblIndianRupeesFormat.Name = "lblIndianRupeesFormat";
            this.lblIndianRupeesFormat.Size = new System.Drawing.Size(103, 13);
            this.lblIndianRupeesFormat.TabIndex = 3;
            this.lblIndianRupeesFormat.Text = "Indian rupees format";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(121, 79);
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
            this.ClientSize = new System.Drawing.Size(337, 138);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblIndianRupeesFormat);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbIndianRupeesFormat);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.TextBox tbIndianRupeesFormat;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblIndianRupeesFormat;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

