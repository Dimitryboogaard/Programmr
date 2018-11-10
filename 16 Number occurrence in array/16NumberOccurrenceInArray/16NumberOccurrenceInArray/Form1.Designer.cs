namespace _16NumberOccurrenceInArray
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.tbUitvoer = new System.Windows.Forms.TextBox();
            this.lblOccurrence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(80, 38);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(37, 41);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 2;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbUitvoer
            // 
            this.tbUitvoer.Location = new System.Drawing.Point(80, 93);
            this.tbUitvoer.Name = "tbUitvoer";
            this.tbUitvoer.Size = new System.Drawing.Size(100, 20);
            this.tbUitvoer.TabIndex = 3;
            // 
            // lblOccurrence
            // 
            this.lblOccurrence.AutoSize = true;
            this.lblOccurrence.Location = new System.Drawing.Point(12, 96);
            this.lblOccurrence.Name = "lblOccurrence";
            this.lblOccurrence.Size = new System.Drawing.Size(63, 13);
            this.lblOccurrence.TabIndex = 4;
            this.lblOccurrence.Text = "Occurrence";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 274);
            this.Controls.Add(this.lblOccurrence);
            this.Controls.Add(this.tbUitvoer);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox tbUitvoer;
        private System.Windows.Forms.Label lblOccurrence;
    }
}

