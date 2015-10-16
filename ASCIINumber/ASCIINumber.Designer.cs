namespace ASCIINumber
{
    partial class frmASCIINumber
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblDescripe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(152, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 49);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(15, 67);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(257, 134);
            this.lstNumbers.TabIndex = 1;
            // 
            // lblDescripe
            // 
            this.lblDescripe.AutoSize = true;
            this.lblDescripe.Location = new System.Drawing.Point(12, 12);
            this.lblDescripe.Name = "lblDescripe";
            this.lblDescripe.Size = new System.Drawing.Size(115, 52);
            this.lblDescripe.TabIndex = 2;
            this.lblDescripe.Text = "Press search to see all\r\nof the ASCII numbers \r\nand their coresponding\r\nletter.";
            // 
            // frmASCIINumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.lblDescripe);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmASCIINumber";
            this.Text = "ASCII convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblDescripe;
    }
}

