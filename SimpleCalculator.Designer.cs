namespace Simple_Calculator
{
    partial class SimpleCalculator
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
            this.CalculatorControls = new System.Windows.Forms.GroupBox();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.MainDisplay = new System.Windows.Forms.TextBox();
            this.UtilityDisplay = new System.Windows.Forms.Label();
            this.CalculatorControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorControls
            // 
            this.CalculatorControls.Controls.Add(this.SubtractButton);
            this.CalculatorControls.Controls.Add(this.MultiplyButton);
            this.CalculatorControls.Controls.Add(this.DivideButton);
            this.CalculatorControls.Controls.Add(this.ClearButton);
            this.CalculatorControls.Controls.Add(this.AdditionButton);
            this.CalculatorControls.Controls.Add(this.EnterButton);
            this.CalculatorControls.Controls.Add(this.DecimalButton);
            this.CalculatorControls.Controls.Add(this.Number0);
            this.CalculatorControls.Controls.Add(this.Number3);
            this.CalculatorControls.Controls.Add(this.Number2);
            this.CalculatorControls.Controls.Add(this.Number1);
            this.CalculatorControls.Controls.Add(this.Number6);
            this.CalculatorControls.Controls.Add(this.Number5);
            this.CalculatorControls.Controls.Add(this.Number4);
            this.CalculatorControls.Controls.Add(this.Number9);
            this.CalculatorControls.Controls.Add(this.Number8);
            this.CalculatorControls.Controls.Add(this.Number7);
            this.CalculatorControls.Location = new System.Drawing.Point(12, 103);
            this.CalculatorControls.Name = "CalculatorControls";
            this.CalculatorControls.Size = new System.Drawing.Size(306, 327);
            this.CalculatorControls.TabIndex = 0;
            this.CalculatorControls.TabStop = false;
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(231, 19);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(69, 55);
            this.SubtractButton.TabIndex = 17;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(156, 19);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(69, 55);
            this.MultiplyButton.TabIndex = 16;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(81, 19);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(69, 55);
            this.DivideButton.TabIndex = 15;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(6, 19);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(69, 55);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.Location = new System.Drawing.Point(231, 80);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(69, 116);
            this.AdditionButton.TabIndex = 13;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(231, 202);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(69, 119);
            this.EnterButton.TabIndex = 12;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(156, 266);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(69, 55);
            this.DecimalButton.TabIndex = 11;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // Number0
            // 
            this.Number0.Location = new System.Drawing.Point(6, 266);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(144, 55);
            this.Number0.TabIndex = 9;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Number0_Click);
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(156, 202);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(69, 55);
            this.Number3.TabIndex = 8;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Number3_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(81, 202);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(69, 55);
            this.Number2.TabIndex = 7;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Number2_Click);
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(6, 202);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(69, 55);
            this.Number1.TabIndex = 6;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number6
            // 
            this.Number6.Location = new System.Drawing.Point(156, 141);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(69, 55);
            this.Number6.TabIndex = 5;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Number6_Click);
            // 
            // Number5
            // 
            this.Number5.Location = new System.Drawing.Point(81, 141);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(69, 55);
            this.Number5.TabIndex = 4;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Number5_Click);
            // 
            // Number4
            // 
            this.Number4.Location = new System.Drawing.Point(6, 141);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(69, 55);
            this.Number4.TabIndex = 3;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // Number9
            // 
            this.Number9.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number9.Location = new System.Drawing.Point(156, 80);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(69, 55);
            this.Number9.TabIndex = 2;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Number9_Click);
            // 
            // Number8
            // 
            this.Number8.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number8.Location = new System.Drawing.Point(81, 80);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(69, 55);
            this.Number8.TabIndex = 1;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Number8_Click);
            // 
            // Number7
            // 
            this.Number7.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number7.Location = new System.Drawing.Point(6, 80);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(69, 55);
            this.Number7.TabIndex = 0;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Number7_Click);
            // 
            // MainDisplay
            // 
            this.MainDisplay.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDisplay.Location = new System.Drawing.Point(19, 44);
            this.MainDisplay.MaxLength = 16;
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(294, 44);
            this.MainDisplay.TabIndex = 2;
            this.MainDisplay.Text = "0";
            this.MainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainDisplay_KeyDown);
            this.MainDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainDisplay_KeyPress);
            // 
            // UtilityDisplay
            // 
            this.UtilityDisplay.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilityDisplay.Location = new System.Drawing.Point(19, 26);
            this.UtilityDisplay.Name = "UtilityDisplay";
            this.UtilityDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UtilityDisplay.Size = new System.Drawing.Size(293, 15);
            this.UtilityDisplay.TabIndex = 3;
            this.UtilityDisplay.Text = "label1";
            this.UtilityDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UtilityDisplay.Click += new System.EventHandler(this.UtilityDisplay_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 433);
            this.Controls.Add(this.UtilityDisplay);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.CalculatorControls);
            this.Name = "SimpleCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.SimpleCalculator_Load);
            this.CalculatorControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CalculatorControls;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.TextBox MainDisplay;
        private System.Windows.Forms.Label UtilityDisplay;
    }
}

