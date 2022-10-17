namespace KarakterDekodoloGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKara = new System.Windows.Forms.Label();
            this.tbKara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKara
            // 
            this.lblKara.AutoSize = true;
            this.lblKara.Location = new System.Drawing.Point(12, 15);
            this.lblKara.Name = "lblKara";
            this.lblKara.Size = new System.Drawing.Size(50, 15);
            this.lblKara.TabIndex = 0;
            this.lblKara.Text = "Karakter";
            // 
            // tbKara
            // 
            this.tbKara.Location = new System.Drawing.Point(68, 12);
            this.tbKara.MaxLength = 1;
            this.tbKara.Name = "tbKara";
            this.tbKara.Size = new System.Drawing.Size(23, 23);
            this.tbKara.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 262);
            this.Controls.Add(this.tbKara);
            this.Controls.Add(this.lblKara);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKara;
        private TextBox tbKara;
    }
}