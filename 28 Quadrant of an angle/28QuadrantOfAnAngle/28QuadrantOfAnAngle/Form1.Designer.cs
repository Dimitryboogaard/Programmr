namespace _28QuadrantOfAnAngle
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
            this.lblHoekInGraden = new System.Windows.Forms.Label();
            this.lblQuadrant = new System.Windows.Forms.Label();
            this.tbHoekInGraden = new System.Windows.Forms.TextBox();
            this.tbQuadrant = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoekInGraden
            // 
            this.lblHoekInGraden.AutoSize = true;
            this.lblHoekInGraden.Location = new System.Drawing.Point(25, 33);
            this.lblHoekInGraden.Name = "lblHoekInGraden";
            this.lblHoekInGraden.Size = new System.Drawing.Size(80, 13);
            this.lblHoekInGraden.TabIndex = 0;
            this.lblHoekInGraden.Text = "Hoek in graden";
            // 
            // lblQuadrant
            // 
            this.lblQuadrant.AutoSize = true;
            this.lblQuadrant.Location = new System.Drawing.Point(54, 59);
            this.lblQuadrant.Name = "lblQuadrant";
            this.lblQuadrant.Size = new System.Drawing.Size(51, 13);
            this.lblQuadrant.TabIndex = 1;
            this.lblQuadrant.Text = "Quadrant";
            // 
            // tbHoekInGraden
            // 
            this.tbHoekInGraden.Location = new System.Drawing.Point(111, 30);
            this.tbHoekInGraden.Name = "tbHoekInGraden";
            this.tbHoekInGraden.Size = new System.Drawing.Size(100, 20);
            this.tbHoekInGraden.TabIndex = 2;
            // 
            // tbQuadrant
            // 
            this.tbQuadrant.Location = new System.Drawing.Point(111, 56);
            this.tbQuadrant.Name = "tbQuadrant";
            this.tbQuadrant.Size = new System.Drawing.Size(100, 20);
            this.tbQuadrant.TabIndex = 3;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(111, 82);
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
            this.ClientSize = new System.Drawing.Size(349, 256);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbQuadrant);
            this.Controls.Add(this.tbHoekInGraden);
            this.Controls.Add(this.lblQuadrant);
            this.Controls.Add(this.lblHoekInGraden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoekInGraden;
        private System.Windows.Forms.Label lblQuadrant;
        private System.Windows.Forms.TextBox tbHoekInGraden;
        private System.Windows.Forms.TextBox tbQuadrant;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

