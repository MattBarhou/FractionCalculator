namespace FractionCalculator
{
    partial class frmFractionCalculator
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtFirstNumerator = new System.Windows.Forms.TextBox();
            this.txtSecondDenominator = new System.Windows.Forms.TextBox();
            this.txtSecondNumerator = new System.Windows.Forms.TextBox();
            this.txtFirstDenominator = new System.Windows.Forms.TextBox();
            this.txtResultNumerator = new System.Windows.Forms.TextBox();
            this.txtResultDenominator = new System.Windows.Forms.TextBox();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.btnPerformOperations = new System.Windows.Forms.Button();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblSeperator1 = new System.Windows.Forms.Label();
            this.lblSeperator2 = new System.Windows.Forms.Label();
            this.lblSeperator3 = new System.Windows.Forms.Label();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(33, 67);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(26, 13);
            this.lblFirst.TabIndex = 12;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(186, 67);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(44, 13);
            this.lblSecond.TabIndex = 13;
            this.lblSecond.Text = "Second";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(335, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Result";
            // 
            // txtFirstNumerator
            // 
            this.txtFirstNumerator.Location = new System.Drawing.Point(30, 97);
            this.txtFirstNumerator.Name = "txtFirstNumerator";
            this.txtFirstNumerator.Size = new System.Drawing.Size(37, 20);
            this.txtFirstNumerator.TabIndex = 0;
            this.txtFirstNumerator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNumerator_KeyPress);
            // 
            // txtSecondDenominator
            // 
            this.txtSecondDenominator.Location = new System.Drawing.Point(189, 148);
            this.txtSecondDenominator.Name = "txtSecondDenominator";
            this.txtSecondDenominator.Size = new System.Drawing.Size(37, 20);
            this.txtSecondDenominator.TabIndex = 8;
            this.txtSecondDenominator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondDenominator_KeyPress);
            // 
            // txtSecondNumerator
            // 
            this.txtSecondNumerator.Location = new System.Drawing.Point(189, 97);
            this.txtSecondNumerator.Name = "txtSecondNumerator";
            this.txtSecondNumerator.Size = new System.Drawing.Size(37, 20);
            this.txtSecondNumerator.TabIndex = 7;
            this.txtSecondNumerator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondNumerator_KeyPress);
            // 
            // txtFirstDenominator
            // 
            this.txtFirstDenominator.Location = new System.Drawing.Point(30, 148);
            this.txtFirstDenominator.Name = "txtFirstDenominator";
            this.txtFirstDenominator.Size = new System.Drawing.Size(37, 20);
            this.txtFirstDenominator.TabIndex = 1;
            this.txtFirstDenominator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstDenominator_KeyPress);
            // 
            // txtResultNumerator
            // 
            this.txtResultNumerator.Location = new System.Drawing.Point(338, 97);
            this.txtResultNumerator.Name = "txtResultNumerator";
            this.txtResultNumerator.ReadOnly = true;
            this.txtResultNumerator.Size = new System.Drawing.Size(37, 20);
            this.txtResultNumerator.TabIndex = 9;
            // 
            // txtResultDenominator
            // 
            this.txtResultDenominator.Location = new System.Drawing.Point(338, 148);
            this.txtResultDenominator.Name = "txtResultDenominator";
            this.txtResultDenominator.ReadOnly = true;
            this.txtResultDenominator.Size = new System.Drawing.Size(37, 20);
            this.txtResultDenominator.TabIndex = 10;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rbtnDivide);
            this.grpOperations.Controls.Add(this.rbtnMultiply);
            this.grpOperations.Controls.Add(this.rbtnSubtract);
            this.grpOperations.Controls.Add(this.rbtnAdd);
            this.grpOperations.Location = new System.Drawing.Point(90, 50);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(69, 152);
            this.grpOperations.TabIndex = 2;
            this.grpOperations.TabStop = false;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(23, 112);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(30, 17);
            this.rbtnDivide.TabIndex = 6;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "/";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Location = new System.Drawing.Point(24, 80);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(29, 17);
            this.rbtnMultiply.TabIndex = 5;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "*";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Location = new System.Drawing.Point(25, 48);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(28, 17);
            this.rbtnSubtract.TabIndex = 4;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "-";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(25, 15);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(31, 17);
            this.rbtnAdd.TabIndex = 3;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPerformOperations
            // 
            this.btnPerformOperations.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPerformOperations.Location = new System.Drawing.Point(50, 234);
            this.btnPerformOperations.Name = "btnPerformOperations";
            this.btnPerformOperations.Size = new System.Drawing.Size(310, 55);
            this.btnPerformOperations.TabIndex = 11;
            this.btnPerformOperations.Text = "Perform Operation";
            this.btnPerformOperations.UseVisualStyleBackColor = false;
            this.btnPerformOperations.Click += new System.EventHandler(this.btnPerformOperations_Click);
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(275, 130);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(13, 13);
            this.lblEquals.TabIndex = 15;
            this.lblEquals.Text = "=";
            // 
            // lblSeperator1
            // 
            this.lblSeperator1.AutoSize = true;
            this.lblSeperator1.Location = new System.Drawing.Point(30, 120);
            this.lblSeperator1.Name = "lblSeperator1";
            this.lblSeperator1.Size = new System.Drawing.Size(37, 13);
            this.lblSeperator1.TabIndex = 16;
            this.lblSeperator1.Text = "_____";
            // 
            // lblSeperator2
            // 
            this.lblSeperator2.AutoSize = true;
            this.lblSeperator2.Location = new System.Drawing.Point(189, 120);
            this.lblSeperator2.Name = "lblSeperator2";
            this.lblSeperator2.Size = new System.Drawing.Size(37, 13);
            this.lblSeperator2.TabIndex = 17;
            this.lblSeperator2.Text = "_____";
            // 
            // lblSeperator3
            // 
            this.lblSeperator3.AutoSize = true;
            this.lblSeperator3.Location = new System.Drawing.Point(338, 120);
            this.lblSeperator3.Name = "lblSeperator3";
            this.lblSeperator3.Size = new System.Drawing.Size(37, 13);
            this.lblSeperator3.TabIndex = 18;
            this.lblSeperator3.Text = "_____";
            // 
            // frmFractionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 301);
            this.Controls.Add(this.lblSeperator3);
            this.Controls.Add(this.lblSeperator2);
            this.Controls.Add(this.lblSeperator1);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.btnPerformOperations);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.txtResultDenominator);
            this.Controls.Add(this.txtResultNumerator);
            this.Controls.Add(this.txtFirstDenominator);
            this.Controls.Add(this.txtSecondNumerator);
            this.Controls.Add(this.txtSecondDenominator);
            this.Controls.Add(this.txtFirstNumerator);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Name = "frmFractionCalculator";
            this.Text = "Fraction Calculator";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtFirstNumerator;
        private System.Windows.Forms.TextBox txtSecondDenominator;
        private System.Windows.Forms.TextBox txtSecondNumerator;
        private System.Windows.Forms.TextBox txtFirstDenominator;
        private System.Windows.Forms.TextBox txtResultNumerator;
        private System.Windows.Forms.TextBox txtResultDenominator;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.Button btnPerformOperations;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblSeperator1;
        private System.Windows.Forms.Label lblSeperator2;
        private System.Windows.Forms.Label lblSeperator3;
    }
}

