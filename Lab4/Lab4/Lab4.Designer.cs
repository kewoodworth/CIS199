namespace Lab4
{
    partial class Lab4
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
            this.gpaLabel = new System.Windows.Forms.Label();
            this.admissionLabel = new System.Windows.Forms.Label();
            this.gpaBox = new System.Windows.Forms.TextBox();
            this.admissionBox = new System.Windows.Forms.TextBox();
            this.acceptLabel = new System.Windows.Forms.Label();
            this.rejectLabel = new System.Windows.Forms.Label();
            this.acceptTotal = new System.Windows.Forms.Label();
            this.rejectTotal = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.Label();
            this.submitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.Location = new System.Drawing.Point(66, 44);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(47, 23);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "GPA";
            // 
            // admissionLabel
            // 
            this.admissionLabel.AutoSize = true;
            this.admissionLabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionLabel.Location = new System.Drawing.Point(179, 44);
            this.admissionLabel.Name = "admissionLabel";
            this.admissionLabel.Size = new System.Drawing.Size(175, 23);
            this.admissionLabel.TabIndex = 1;
            this.admissionLabel.Text = "Admission Test Score";
            // 
            // gpaBox
            // 
            this.gpaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpaBox.Font = new System.Drawing.Font("Monotype Sans WT J", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaBox.Location = new System.Drawing.Point(41, 79);
            this.gpaBox.Name = "gpaBox";
            this.gpaBox.Size = new System.Drawing.Size(100, 35);
            this.gpaBox.TabIndex = 2;
            this.gpaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // admissionBox
            // 
            this.admissionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admissionBox.Font = new System.Drawing.Font("Monotype Sans WT J", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionBox.Location = new System.Drawing.Point(211, 79);
            this.admissionBox.Name = "admissionBox";
            this.admissionBox.Size = new System.Drawing.Size(100, 35);
            this.admissionBox.TabIndex = 3;
            this.admissionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // acceptLabel
            // 
            this.acceptLabel.AutoSize = true;
            this.acceptLabel.Location = new System.Drawing.Point(120, 303);
            this.acceptLabel.Name = "acceptLabel";
            this.acceptLabel.Size = new System.Drawing.Size(59, 13);
            this.acceptLabel.TabIndex = 4;
            this.acceptLabel.Text = "Accepted: ";
            this.acceptLabel.Click += new System.EventHandler(this.acceptLabel_Click);
            // 
            // rejectLabel
            // 
            this.rejectLabel.AutoSize = true;
            this.rejectLabel.Location = new System.Drawing.Point(211, 303);
            this.rejectLabel.Name = "rejectLabel";
            this.rejectLabel.Size = new System.Drawing.Size(56, 13);
            this.rejectLabel.TabIndex = 5;
            this.rejectLabel.Text = "Rejected: ";
            // 
            // acceptTotal
            // 
            this.acceptTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.acceptTotal.Location = new System.Drawing.Point(123, 333);
            this.acceptTotal.Name = "acceptTotal";
            this.acceptTotal.Size = new System.Drawing.Size(51, 30);
            this.acceptTotal.TabIndex = 6;
            this.acceptTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rejectTotal
            // 
            this.rejectTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rejectTotal.Location = new System.Drawing.Point(211, 333);
            this.rejectTotal.Name = "rejectTotal";
            this.rejectTotal.Size = new System.Drawing.Size(51, 31);
            this.rejectTotal.TabIndex = 7;
            this.rejectTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultBox.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultBox.Location = new System.Drawing.Point(41, 207);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(313, 53);
            this.resultBox.TabIndex = 8;
            this.resultBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.White;
            this.submitbutton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.Location = new System.Drawing.Point(139, 143);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(98, 35);
            this.submitbutton.TabIndex = 9;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // Lab4
            // 
            this.AcceptButton = this.submitbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.rejectTotal);
            this.Controls.Add(this.acceptTotal);
            this.Controls.Add(this.rejectLabel);
            this.Controls.Add(this.acceptLabel);
            this.Controls.Add(this.admissionBox);
            this.Controls.Add(this.gpaBox);
            this.Controls.Add(this.admissionLabel);
            this.Controls.Add(this.gpaLabel);
            this.Name = "Lab4";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label admissionLabel;
        private System.Windows.Forms.TextBox gpaBox;
        private System.Windows.Forms.TextBox admissionBox;
        private System.Windows.Forms.Label acceptLabel;
        private System.Windows.Forms.Label rejectLabel;
        private System.Windows.Forms.Label acceptTotal;
        private System.Windows.Forms.Label rejectTotal;
        private System.Windows.Forms.Label resultBox;
        private System.Windows.Forms.Button submitbutton;
    }
}

