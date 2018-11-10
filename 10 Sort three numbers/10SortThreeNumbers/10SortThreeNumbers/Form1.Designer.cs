namespace _10SortThreeNumbers
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
            this.tbNummer1 = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbNummer2 = new System.Windows.Forms.TextBox();
            this.tbNummer3 = new System.Windows.Forms.TextBox();
            this.rtAntwoord = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbNummer1
            // 
            this.tbNummer1.Location = new System.Drawing.Point(53, 37);
            this.tbNummer1.Name = "tbNummer1";
            this.tbNummer1.Size = new System.Drawing.Size(100, 20);
            this.tbNummer1.TabIndex = 0;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(53, 131);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 1;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbNummer2
            // 
            this.tbNummer2.Location = new System.Drawing.Point(53, 63);
            this.tbNummer2.Name = "tbNummer2";
            this.tbNummer2.Size = new System.Drawing.Size(100, 20);
            this.tbNummer2.TabIndex = 2;
            // 
            // tbNummer3
            // 
            this.tbNummer3.Location = new System.Drawing.Point(53, 89);
            this.tbNummer3.Name = "tbNummer3";
            this.tbNummer3.Size = new System.Drawing.Size(100, 20);
            this.tbNummer3.TabIndex = 3;
            // 
            // rtAntwoord
            // 
            this.rtAntwoord.Location = new System.Drawing.Point(53, 174);
            this.rtAntwoord.Name = "rtAntwoord";
            this.rtAntwoord.Size = new System.Drawing.Size(100, 96);
            this.rtAntwoord.TabIndex = 4;
            this.rtAntwoord.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 282);
            this.Controls.Add(this.rtAntwoord);
            this.Controls.Add(this.tbNummer3);
            this.Controls.Add(this.tbNummer2);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbNummer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNummer1;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbNummer2;
        private System.Windows.Forms.TextBox tbNummer3;
        private System.Windows.Forms.RichTextBox rtAntwoord;
    }
}

