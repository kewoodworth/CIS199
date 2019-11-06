namespace Lab_3
{
    partial class Lab3
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
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.radiusLbl = new System.Windows.Forms.Label();
            this.radiusTextbox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.surfaceAreaLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.diameterTxt = new System.Windows.Forms.Label();
            this.surfaceAreaTxt = new System.Windows.Forms.Label();
            this.volumeTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.Image = global::Lab_3.Properties.Resources.Sphere_and_Ball;
            this.picture1.Location = new System.Drawing.Point(13, 13);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(150, 150);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // radiusLbl
            // 
            this.radiusLbl.AutoSize = true;
            this.radiusLbl.Font = new System.Drawing.Font("Albany AMT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLbl.Location = new System.Drawing.Point(169, 53);
            this.radiusLbl.Name = "radiusLbl";
            this.radiusLbl.Size = new System.Drawing.Size(108, 15);
            this.radiusLbl.TabIndex = 1;
            this.radiusLbl.Text = "Radius of sphere: ";
            // 
            // radiusTextbox
            // 
            this.radiusTextbox.BackColor = System.Drawing.Color.White;
            this.radiusTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radiusTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusTextbox.ForeColor = System.Drawing.Color.Black;
            this.radiusTextbox.Location = new System.Drawing.Point(282, 52);
            this.radiusTextbox.Name = "radiusTextbox";
            this.radiusTextbox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextbox.TabIndex = 2;
            this.radiusTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radiusTextbox.UseWaitCursor = true;
            // 
            // calcButton
            // 
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calcButton.Font = new System.Drawing.Font("Albany AMT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(282, 90);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Font = new System.Drawing.Font("Albany AMT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diameterLbl.Location = new System.Drawing.Point(31, 207);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(58, 15);
            this.diameterLbl.TabIndex = 4;
            this.diameterLbl.Text = "Diameter";
            this.diameterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surfaceAreaLbl
            // 
            this.surfaceAreaLbl.AutoSize = true;
            this.surfaceAreaLbl.Font = new System.Drawing.Font("Albany AMT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceAreaLbl.Location = new System.Drawing.Point(12, 258);
            this.surfaceAreaLbl.Name = "surfaceAreaLbl";
            this.surfaceAreaLbl.Size = new System.Drawing.Size(77, 15);
            this.surfaceAreaLbl.TabIndex = 5;
            this.surfaceAreaLbl.Text = "Surface Area";
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Font = new System.Drawing.Font("Albany AMT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLbl.Location = new System.Drawing.Point(40, 311);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(49, 15);
            this.volumeLbl.TabIndex = 6;
            this.volumeLbl.Text = "Volume";
            // 
            // diameterTxt
            // 
            this.diameterTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterTxt.Font = new System.Drawing.Font("Monotype Sans WT J", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diameterTxt.Location = new System.Drawing.Point(95, 207);
            this.diameterTxt.Name = "diameterTxt";
            this.diameterTxt.Size = new System.Drawing.Size(100, 23);
            this.diameterTxt.TabIndex = 7;
            // 
            // surfaceAreaTxt
            // 
            this.surfaceAreaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaTxt.Font = new System.Drawing.Font("Monotype Sans WT J", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceAreaTxt.Location = new System.Drawing.Point(95, 258);
            this.surfaceAreaTxt.Name = "surfaceAreaTxt";
            this.surfaceAreaTxt.Size = new System.Drawing.Size(100, 23);
            this.surfaceAreaTxt.TabIndex = 8;
            // 
            // volumeTxt
            // 
            this.volumeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeTxt.Font = new System.Drawing.Font("Monotype Sans WT J", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeTxt.Location = new System.Drawing.Point(95, 311);
            this.volumeTxt.Name = "volumeTxt";
            this.volumeTxt.Size = new System.Drawing.Size(100, 23);
            this.volumeTxt.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_3.Properties.Resources.Sphere_and_Ball;
            this.pictureBox1.Location = new System.Drawing.Point(226, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Lab3
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.volumeTxt);
            this.Controls.Add(this.surfaceAreaTxt);
            this.Controls.Add(this.diameterTxt);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.surfaceAreaLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.radiusTextbox);
            this.Controls.Add(this.radiusLbl);
            this.Controls.Add(this.picture1);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label radiusLbl;
        private System.Windows.Forms.TextBox radiusTextbox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label surfaceAreaLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label diameterTxt;
        private System.Windows.Forms.Label surfaceAreaTxt;
        private System.Windows.Forms.Label volumeTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

