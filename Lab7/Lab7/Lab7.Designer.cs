namespace Lab7
{
    partial class Lab7
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
            this.valueLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.outputValue = new System.Windows.Forms.Label();
            this.futureValueBox = new System.Windows.Forms.TextBox();
            this.interestBox = new System.Windows.Forms.TextBox();
            this.yearsBox = new System.Windows.Forms.TextBox();
            this.presentValueBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(12, 31);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(113, 20);
            this.valueLabel.TabIndex = 0;
            this.valueLabel.Text = "Future Value:";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(12, 60);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(171, 20);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Annual Interest Rate:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(12, 90);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(94, 20);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "No. of Year:";
            // 
            // outputValue
            // 
            this.outputValue.AutoSize = true;
            this.outputValue.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputValue.Location = new System.Drawing.Point(12, 153);
            this.outputValue.Name = "outputValue";
            this.outputValue.Size = new System.Drawing.Size(118, 20);
            this.outputValue.TabIndex = 3;
            this.outputValue.Text = "Present Value:";
            // 
            // futureValueBox
            // 
            this.futureValueBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureValueBox.Location = new System.Drawing.Point(217, 31);
            this.futureValueBox.Name = "futureValueBox";
            this.futureValueBox.Size = new System.Drawing.Size(100, 23);
            this.futureValueBox.TabIndex = 4;
            // 
            // interestBox
            // 
            this.interestBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestBox.Location = new System.Drawing.Point(217, 60);
            this.interestBox.Name = "interestBox";
            this.interestBox.Size = new System.Drawing.Size(100, 23);
            this.interestBox.TabIndex = 5;
            // 
            // yearsBox
            // 
            this.yearsBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsBox.Location = new System.Drawing.Point(217, 90);
            this.yearsBox.Name = "yearsBox";
            this.yearsBox.Size = new System.Drawing.Size(100, 23);
            this.yearsBox.TabIndex = 6;
            // 
            // presentValueBox
            // 
            this.presentValueBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentValueBox.Location = new System.Drawing.Point(217, 153);
            this.presentValueBox.Name = "presentValueBox";
            this.presentValueBox.Size = new System.Drawing.Size(100, 23);
            this.presentValueBox.TabIndex = 7;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.White;
            this.calcButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(117, 221);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 40);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Lab7
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(332, 273);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.presentValueBox);
            this.Controls.Add(this.yearsBox);
            this.Controls.Add(this.interestBox);
            this.Controls.Add(this.futureValueBox);
            this.Controls.Add(this.outputValue);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.valueLabel);
            this.Name = "Lab7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label outputValue;
        private System.Windows.Forms.TextBox futureValueBox;
        private System.Windows.Forms.TextBox interestBox;
        private System.Windows.Forms.TextBox yearsBox;
        private System.Windows.Forms.TextBox presentValueBox;
        private System.Windows.Forms.Button calcButton;
    }
}

