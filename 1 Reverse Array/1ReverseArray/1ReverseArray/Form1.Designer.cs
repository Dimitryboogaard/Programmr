namespace _1ReverseArray
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
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblTeller = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnArrayReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(28, 83);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(83, 26);
            this.btnAntwoord.TabIndex = 0;
            this.btnAntwoord.Text = "button1";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(12, 43);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(175, 20);
            this.tbAntwoord.TabIndex = 1;
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(12, 17);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(175, 20);
            this.tbInvoer.TabIndex = 2;
            // 
            // lblTeller
            // 
            this.lblTeller.AutoSize = true;
            this.lblTeller.Location = new System.Drawing.Point(215, 17);
            this.lblTeller.Name = "lblTeller";
            this.lblTeller.Size = new System.Drawing.Size(35, 13);
            this.lblTeller.TabIndex = 3;
            this.lblTeller.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(200, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(101, 138);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnArrayReverse
            // 
            this.btnArrayReverse.Location = new System.Drawing.Point(28, 126);
            this.btnArrayReverse.Name = "btnArrayReverse";
            this.btnArrayReverse.Size = new System.Drawing.Size(75, 23);
            this.btnArrayReverse.TabIndex = 5;
            this.btnArrayReverse.Text = "button1";
            this.btnArrayReverse.UseVisualStyleBackColor = true;
            this.btnArrayReverse.Click += new System.EventHandler(this.btnArrayReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 252);
            this.Controls.Add(this.btnArrayReverse);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTeller);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.tbAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbAntwoord;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblTeller;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnArrayReverse;
    }
}

