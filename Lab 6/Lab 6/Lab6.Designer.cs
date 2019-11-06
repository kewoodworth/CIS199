namespace Lab_6
{
    partial class Lab6
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.wpmLabel = new System.Windows.Forms.Label();
            this.wpm = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(61, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(169, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nimble Fingers Typing School";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wpmLabel
            // 
            this.wpmLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpmLabel.Location = new System.Drawing.Point(33, 95);
            this.wpmLabel.Name = "wpmLabel";
            this.wpmLabel.Size = new System.Drawing.Size(122, 38);
            this.wpmLabel.TabIndex = 1;
            this.wpmLabel.Text = "Enter WPM";
            this.wpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wpm
            // 
            this.wpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wpm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wpm.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpm.Location = new System.Drawing.Point(173, 102);
            this.wpm.Name = "wpm";
            this.wpm.Size = new System.Drawing.Size(76, 24);
            this.wpm.TabIndex = 2;
            this.wpm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(96, 147);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(76, 30);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.ForeColor = System.Drawing.Color.Red;
            this.gradeLabel.Location = new System.Drawing.Point(97, 206);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(75, 75);
            this.gradeLabel.TabIndex = 4;
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab6
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 290);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.wpm);
            this.Controls.Add(this.wpmLabel);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Lab6";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label wpmLabel;
        private System.Windows.Forms.TextBox wpm;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label gradeLabel;
    }
}

