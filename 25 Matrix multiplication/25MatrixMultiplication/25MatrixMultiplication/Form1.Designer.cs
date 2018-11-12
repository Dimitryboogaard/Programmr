namespace _25MatrixMultiplication
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
            this.rtAntwoord = new System.Windows.Forms.RichTextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtAntwoord
            // 
            this.rtAntwoord.Location = new System.Drawing.Point(40, 27);
            this.rtAntwoord.Name = "rtAntwoord";
            this.rtAntwoord.Size = new System.Drawing.Size(100, 96);
            this.rtAntwoord.TabIndex = 0;
            this.rtAntwoord.Text = "";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(40, 129);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 1;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 206);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.rtAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtAntwoord;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

