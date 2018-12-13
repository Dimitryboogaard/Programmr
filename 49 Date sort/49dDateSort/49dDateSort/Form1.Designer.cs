namespace _49dDateSort
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
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.tbDatum1 = new System.Windows.Forms.TextBox();
            this.tbDatum2 = new System.Windows.Forms.TextBox();
            this.lblDatum1 = new System.Windows.Forms.Label();
            this.lblDatum2 = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(232, 40);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(144, 182);
            this.rtUitvoer.TabIndex = 0;
            this.rtUitvoer.Text = "";
            // 
            // tbDatum1
            // 
            this.tbDatum1.Location = new System.Drawing.Point(86, 40);
            this.tbDatum1.Name = "tbDatum1";
            this.tbDatum1.Size = new System.Drawing.Size(100, 20);
            this.tbDatum1.TabIndex = 1;
            // 
            // tbDatum2
            // 
            this.tbDatum2.Location = new System.Drawing.Point(86, 66);
            this.tbDatum2.Name = "tbDatum2";
            this.tbDatum2.Size = new System.Drawing.Size(100, 20);
            this.tbDatum2.TabIndex = 2;
            // 
            // lblDatum1
            // 
            this.lblDatum1.AutoSize = true;
            this.lblDatum1.Location = new System.Drawing.Point(33, 43);
            this.lblDatum1.Name = "lblDatum1";
            this.lblDatum1.Size = new System.Drawing.Size(47, 13);
            this.lblDatum1.TabIndex = 3;
            this.lblDatum1.Text = "Datum 1";
            // 
            // lblDatum2
            // 
            this.lblDatum2.AutoSize = true;
            this.lblDatum2.Location = new System.Drawing.Point(33, 69);
            this.lblDatum2.Name = "lblDatum2";
            this.lblDatum2.Size = new System.Drawing.Size(47, 13);
            this.lblDatum2.TabIndex = 4;
            this.lblDatum2.Text = "Datum 2";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(86, 92);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 5;
            this.btnAntwoord.Text = "button1";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 274);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblDatum2);
            this.Controls.Add(this.lblDatum1);
            this.Controls.Add(this.tbDatum2);
            this.Controls.Add(this.tbDatum1);
            this.Controls.Add(this.rtUitvoer);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtUitvoer;
        private System.Windows.Forms.TextBox tbDatum1;
        private System.Windows.Forms.TextBox tbDatum2;
        private System.Windows.Forms.Label lblDatum1;
        private System.Windows.Forms.Label lblDatum2;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

