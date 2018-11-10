namespace _8PrintRectangle
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
            this.tbBreedte = new System.Windows.Forms.TextBox();
            this.tbHoogte = new System.Windows.Forms.TextBox();
            this.lblBreedte = new System.Windows.Forms.Label();
            this.lblHoogte = new System.Windows.Forms.Label();
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.btnMaakRechthoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBreedte
            // 
            this.tbBreedte.Location = new System.Drawing.Point(124, 28);
            this.tbBreedte.Name = "tbBreedte";
            this.tbBreedte.Size = new System.Drawing.Size(100, 20);
            this.tbBreedte.TabIndex = 0;
            // 
            // tbHoogte
            // 
            this.tbHoogte.Location = new System.Drawing.Point(124, 54);
            this.tbHoogte.Name = "tbHoogte";
            this.tbHoogte.Size = new System.Drawing.Size(100, 20);
            this.tbHoogte.TabIndex = 1;
            // 
            // lblBreedte
            // 
            this.lblBreedte.AutoSize = true;
            this.lblBreedte.Location = new System.Drawing.Point(74, 31);
            this.lblBreedte.Name = "lblBreedte";
            this.lblBreedte.Size = new System.Drawing.Size(44, 13);
            this.lblBreedte.TabIndex = 2;
            this.lblBreedte.Text = "Breedte";
            // 
            // lblHoogte
            // 
            this.lblHoogte.AutoSize = true;
            this.lblHoogte.Location = new System.Drawing.Point(76, 61);
            this.lblHoogte.Name = "lblHoogte";
            this.lblHoogte.Size = new System.Drawing.Size(42, 13);
            this.lblHoogte.TabIndex = 3;
            this.lblHoogte.Text = "Hoogte";
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(93, 121);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(204, 232);
            this.rtUitvoer.TabIndex = 4;
            this.rtUitvoer.Text = "";
            // 
            // btnMaakRechthoek
            // 
            this.btnMaakRechthoek.Location = new System.Drawing.Point(262, 31);
            this.btnMaakRechthoek.Name = "btnMaakRechthoek";
            this.btnMaakRechthoek.Size = new System.Drawing.Size(118, 23);
            this.btnMaakRechthoek.TabIndex = 5;
            this.btnMaakRechthoek.Text = "Maak rechthoek";
            this.btnMaakRechthoek.UseVisualStyleBackColor = true;
            this.btnMaakRechthoek.Click += new System.EventHandler(this.btnMaakRechthoek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 376);
            this.Controls.Add(this.btnMaakRechthoek);
            this.Controls.Add(this.rtUitvoer);
            this.Controls.Add(this.lblHoogte);
            this.Controls.Add(this.lblBreedte);
            this.Controls.Add(this.tbHoogte);
            this.Controls.Add(this.tbBreedte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBreedte;
        private System.Windows.Forms.TextBox tbHoogte;
        private System.Windows.Forms.Label lblBreedte;
        private System.Windows.Forms.Label lblHoogte;
        private System.Windows.Forms.RichTextBox rtUitvoer;
        private System.Windows.Forms.Button btnMaakRechthoek;
    }
}

