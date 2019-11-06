namespace Lab_2
{
    partial class Lab2
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
            this.mealPriceLbl = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.lowTipLbl = new System.Windows.Forms.Label();
            this.medTipLbl = new System.Windows.Forms.Label();
            this.highTipLbl = new System.Windows.Forms.Label();
            this.lowTip = new System.Windows.Forms.Label();
            this.medTip = new System.Windows.Forms.Label();
            this.highTip = new System.Windows.Forms.Label();
            this.calcTip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealPriceLbl
            // 
            this.mealPriceLbl.AutoSize = true;
            this.mealPriceLbl.Location = new System.Drawing.Point(12, 9);
            this.mealPriceLbl.Name = "mealPriceLbl";
            this.mealPriceLbl.Size = new System.Drawing.Size(101, 13);
            this.mealPriceLbl.TabIndex = 0;
            this.mealPriceLbl.Text = "Enter price of meal: ";
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(119, 6);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(100, 20);
            this.priceTextbox.TabIndex = 1;
            // 
            // lowTipLbl
            // 
            this.lowTipLbl.AutoSize = true;
            this.lowTipLbl.Location = new System.Drawing.Point(69, 49);
            this.lowTipLbl.Name = "lowTipLbl";
            this.lowTipLbl.Size = new System.Drawing.Size(30, 13);
            this.lowTipLbl.TabIndex = 2;
            this.lowTipLbl.Text = "15 %";
            // 
            // medTipLbl
            // 
            this.medTipLbl.AutoSize = true;
            this.medTipLbl.Location = new System.Drawing.Point(69, 84);
            this.medTipLbl.Name = "medTipLbl";
            this.medTipLbl.Size = new System.Drawing.Size(30, 13);
            this.medTipLbl.TabIndex = 3;
            this.medTipLbl.Text = "18 %";
            // 
            // highTipLbl
            // 
            this.highTipLbl.AutoSize = true;
            this.highTipLbl.Location = new System.Drawing.Point(69, 120);
            this.highTipLbl.Name = "highTipLbl";
            this.highTipLbl.Size = new System.Drawing.Size(30, 13);
            this.highTipLbl.TabIndex = 4;
            this.highTipLbl.Text = "20 %";
            // 
            // lowTip
            // 
            this.lowTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTip.Location = new System.Drawing.Point(119, 48);
            this.lowTip.Name = "lowTip";
            this.lowTip.Size = new System.Drawing.Size(100, 23);
            this.lowTip.TabIndex = 5;
            // 
            // medTip
            // 
            this.medTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medTip.Location = new System.Drawing.Point(119, 83);
            this.medTip.Name = "medTip";
            this.medTip.Size = new System.Drawing.Size(100, 23);
            this.medTip.TabIndex = 6;
            // 
            // highTip
            // 
            this.highTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTip.Location = new System.Drawing.Point(119, 119);
            this.highTip.Name = "highTip";
            this.highTip.Size = new System.Drawing.Size(100, 23);
            this.highTip.TabIndex = 7;
            // 
            // calcTip
            // 
            this.calcTip.Location = new System.Drawing.Point(72, 162);
            this.calcTip.Name = "calcTip";
            this.calcTip.Size = new System.Drawing.Size(92, 23);
            this.calcTip.TabIndex = 8;
            this.calcTip.Text = "Calculate Tip";
            this.calcTip.UseVisualStyleBackColor = true;
            this.calcTip.Click += new System.EventHandler(this.calcTip_Click);
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 222);
            this.Controls.Add(this.calcTip);
            this.Controls.Add(this.highTip);
            this.Controls.Add(this.medTip);
            this.Controls.Add(this.lowTip);
            this.Controls.Add(this.highTipLbl);
            this.Controls.Add(this.medTipLbl);
            this.Controls.Add(this.lowTipLbl);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.mealPriceLbl);
            this.Name = "Lab2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPriceLbl;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Label lowTipLbl;
        private System.Windows.Forms.Label medTipLbl;
        private System.Windows.Forms.Label highTipLbl;
        private System.Windows.Forms.Label lowTip;
        private System.Windows.Forms.Label medTip;
        private System.Windows.Forms.Label highTip;
        private System.Windows.Forms.Button calcTip;
    }
}

