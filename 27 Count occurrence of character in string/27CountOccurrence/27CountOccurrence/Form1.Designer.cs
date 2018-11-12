namespace _27CountOccurrence
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
            this.rtInvoer = new System.Windows.Forms.RichTextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.lblVoorkomen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtInvoer
            // 
            this.rtInvoer.Location = new System.Drawing.Point(39, 28);
            this.rtInvoer.Name = "rtInvoer";
            this.rtInvoer.Size = new System.Drawing.Size(179, 83);
            this.rtInvoer.TabIndex = 0;
            this.rtInvoer.Text = "";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(39, 143);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 1;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(39, 117);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(100, 20);
            this.tbLetter.TabIndex = 2;
            // 
            // lblVoorkomen
            // 
            this.lblVoorkomen.AutoSize = true;
            this.lblVoorkomen.Location = new System.Drawing.Point(44, 195);
            this.lblVoorkomen.Name = "lblVoorkomen";
            this.lblVoorkomen.Size = new System.Drawing.Size(61, 13);
            this.lblVoorkomen.TabIndex = 3;
            this.lblVoorkomen.Text = "Voorkomen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 242);
            this.Controls.Add(this.lblVoorkomen);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.rtInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtInvoer;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Label lblVoorkomen;
    }
}

