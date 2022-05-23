﻿namespace WinForms.App
{
    partial class Calculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(72, 54);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(436, 87);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(72, 503);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(97, 93);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(184, 503);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(97, 93);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(298, 503);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(97, 93);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(298, 395);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(97, 93);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(184, 395);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(97, 93);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(72, 395);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(97, 93);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(298, 284);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(97, 93);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(184, 284);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(97, 93);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(72, 284);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(97, 93);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(298, 611);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(97, 93);
            this.btnEquals.TabIndex = 12;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(184, 611);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(97, 93);
            this.btnPeriod.TabIndex = 11;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(72, 611);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(97, 93);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(411, 611);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(97, 93);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(411, 284);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(97, 93);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(411, 395);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(97, 93);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(411, 503);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(97, 93);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 93);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDisplay;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnEquals;
        private Button btnPeriod;
        private Button btnZero;
        private Button btnDivide;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button button1;
    }
}