namespace _39ConvertInSeconds
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
            this.tbInvoerUren = new System.Windows.Forms.TextBox();
            this.tbInvoerMinuten = new System.Windows.Forms.TextBox();
            this.tbInvoerSeconden = new System.Windows.Forms.TextBox();
            this.lblInvoerUren = new System.Windows.Forms.Label();
            this.lblInvoerMinuten = new System.Windows.Forms.Label();
            this.lblInvoerSeconden = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInvoerUren
            // 
            this.tbInvoerUren.Location = new System.Drawing.Point(105, 25);
            this.tbInvoerUren.Name = "tbInvoerUren";
            this.tbInvoerUren.Size = new System.Drawing.Size(100, 20);
            this.tbInvoerUren.TabIndex = 0;
            // 
            // tbInvoerMinuten
            // 
            this.tbInvoerMinuten.Location = new System.Drawing.Point(105, 51);
            this.tbInvoerMinuten.Name = "tbInvoerMinuten";
            this.tbInvoerMinuten.Size = new System.Drawing.Size(100, 20);
            this.tbInvoerMinuten.TabIndex = 1;
            // 
            // tbInvoerSeconden
            // 
            this.tbInvoerSeconden.Location = new System.Drawing.Point(105, 77);
            this.tbInvoerSeconden.Name = "tbInvoerSeconden";
            this.tbInvoerSeconden.Size = new System.Drawing.Size(100, 20);
            this.tbInvoerSeconden.TabIndex = 2;
            // 
            // lblInvoerUren
            // 
            this.lblInvoerUren.AutoSize = true;
            this.lblInvoerUren.Location = new System.Drawing.Point(38, 28);
            this.lblInvoerUren.Name = "lblInvoerUren";
            this.lblInvoerUren.Size = new System.Drawing.Size(61, 13);
            this.lblInvoerUren.TabIndex = 3;
            this.lblInvoerUren.Text = "Invoer uren";
            // 
            // lblInvoerMinuten
            // 
            this.lblInvoerMinuten.AutoSize = true;
            this.lblInvoerMinuten.Location = new System.Drawing.Point(22, 54);
            this.lblInvoerMinuten.Name = "lblInvoerMinuten";
            this.lblInvoerMinuten.Size = new System.Drawing.Size(77, 13);
            this.lblInvoerMinuten.TabIndex = 4;
            this.lblInvoerMinuten.Text = "Invoer minuten";
            // 
            // lblInvoerSeconden
            // 
            this.lblInvoerSeconden.AutoSize = true;
            this.lblInvoerSeconden.Location = new System.Drawing.Point(12, 80);
            this.lblInvoerSeconden.Name = "lblInvoerSeconden";
            this.lblInvoerSeconden.Size = new System.Drawing.Size(87, 13);
            this.lblInvoerSeconden.TabIndex = 5;
            this.lblInvoerSeconden.Text = "Invoer seconden";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(105, 103);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(105, 132);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(100, 20);
            this.tbAntwoord.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 296);
            this.Controls.Add(this.tbAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblInvoerSeconden);
            this.Controls.Add(this.lblInvoerMinuten);
            this.Controls.Add(this.lblInvoerUren);
            this.Controls.Add(this.tbInvoerSeconden);
            this.Controls.Add(this.tbInvoerMinuten);
            this.Controls.Add(this.tbInvoerUren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoerUren;
        private System.Windows.Forms.TextBox tbInvoerMinuten;
        private System.Windows.Forms.TextBox tbInvoerSeconden;
        private System.Windows.Forms.Label lblInvoerUren;
        private System.Windows.Forms.Label lblInvoerMinuten;
        private System.Windows.Forms.Label lblInvoerSeconden;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbAntwoord;
    }
}

