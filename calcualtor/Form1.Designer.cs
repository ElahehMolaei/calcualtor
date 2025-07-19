namespace calcualtor
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
            number1 = new Button();
            number2 = new Button();
            number3 = new Button();
            number4 = new Button();
            number5 = new Button();
            number6 = new Button();
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            plus = new Button();
            minus = new Button();
            multiply = new Button();
            devide = new Button();
            equal = new Button();
            backspace = new Button();
            clear = new Button();
            number0 = new Button();
            display = new Label();
            changeSignBtn = new Button();
            btnPoint = new Button();
            SuspendLayout();
            // 
            // number1
            // 
            number1.BackColor = Color.White;
            number1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number1.Location = new Point(12, 357);
            number1.Name = "number1";
            number1.Size = new Size(58, 40);
            number1.TabIndex = 0;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = false;
            number1.Click += handleNumberClick;
            // 
            // number2
            // 
            number2.BackColor = Color.White;
            number2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number2.Location = new Point(76, 357);
            number2.Name = "number2";
            number2.Size = new Size(58, 40);
            number2.TabIndex = 1;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = false;
            number2.Click += handleNumberClick;
            // 
            // number3
            // 
            number3.BackColor = Color.White;
            number3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number3.Location = new Point(140, 357);
            number3.Name = "number3";
            number3.Size = new Size(58, 40);
            number3.TabIndex = 2;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = false;
            number3.Click += handleNumberClick;
            // 
            // number4
            // 
            number4.BackColor = Color.White;
            number4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number4.Location = new Point(12, 311);
            number4.Name = "number4";
            number4.Size = new Size(58, 40);
            number4.TabIndex = 3;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = false;
            number4.Click += handleNumberClick;
            // 
            // number5
            // 
            number5.BackColor = Color.White;
            number5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number5.Location = new Point(76, 311);
            number5.Name = "number5";
            number5.Size = new Size(58, 40);
            number5.TabIndex = 4;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = false;
            number5.Click += handleNumberClick;
            // 
            // number6
            // 
            number6.BackColor = Color.White;
            number6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number6.Location = new Point(140, 311);
            number6.Name = "number6";
            number6.Size = new Size(58, 40);
            number6.TabIndex = 5;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = false;
            number6.Click += handleNumberClick;
            // 
            // number7
            // 
            number7.BackColor = Color.White;
            number7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number7.Location = new Point(12, 265);
            number7.Name = "number7";
            number7.Size = new Size(58, 40);
            number7.TabIndex = 6;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = false;
            number7.Click += handleNumberClick;
            // 
            // number8
            // 
            number8.BackColor = Color.White;
            number8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number8.Location = new Point(76, 265);
            number8.Name = "number8";
            number8.Size = new Size(58, 40);
            number8.TabIndex = 7;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = false;
            number8.Click += handleNumberClick;
            // 
            // number9
            // 
            number9.BackColor = Color.White;
            number9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number9.Location = new Point(140, 265);
            number9.Name = "number9";
            number9.Size = new Size(58, 40);
            number9.TabIndex = 8;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = false;
            number9.Click += handleNumberClick;
            // 
            // plus
            // 
            plus.BackColor = Color.White;
            plus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(204, 357);
            plus.Name = "plus";
            plus.Size = new Size(58, 40);
            plus.TabIndex = 9;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += handleOpt;
            // 
            // minus
            // 
            minus.BackColor = Color.White;
            minus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minus.Location = new Point(204, 311);
            minus.Name = "minus";
            minus.Size = new Size(58, 40);
            minus.TabIndex = 10;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += handleOpt;
            // 
            // multiply
            // 
            multiply.BackColor = Color.White;
            multiply.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiply.Location = new Point(204, 265);
            multiply.Name = "multiply";
            multiply.Size = new Size(58, 40);
            multiply.TabIndex = 11;
            multiply.Text = "×";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += handleOpt;
            // 
            // devide
            // 
            devide.BackColor = Color.White;
            devide.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            devide.Location = new Point(204, 219);
            devide.Name = "devide";
            devide.Size = new Size(58, 40);
            devide.TabIndex = 12;
            devide.Text = "÷";
            devide.UseVisualStyleBackColor = false;
            devide.Click += handleOpt;
            // 
            // equal
            // 
            equal.BackColor = Color.White;
            equal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equal.Location = new Point(204, 403);
            equal.Name = "equal";
            equal.Size = new Size(58, 40);
            equal.TabIndex = 13;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // backspace
            // 
            backspace.BackColor = Color.White;
            backspace.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backspace.Location = new Point(140, 219);
            backspace.Name = "backspace";
            backspace.Size = new Size(58, 40);
            backspace.TabIndex = 14;
            backspace.Text = "⌫";
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += backspace_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.White;
            clear.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.Location = new Point(76, 219);
            clear.Name = "clear";
            clear.Size = new Size(58, 40);
            clear.TabIndex = 15;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // number0
            // 
            number0.BackColor = Color.White;
            number0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number0.Location = new Point(76, 403);
            number0.Name = "number0";
            number0.Size = new Size(58, 40);
            number0.TabIndex = 16;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = false;
            number0.Click += handleNumberClick;
            // 
            // display
            // 
            display.AutoSize = true;
            display.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            display.Location = new Point(12, 162);
            display.Name = "display";
            display.Size = new Size(42, 50);
            display.TabIndex = 17;
            display.Text = "0";
            // 
            // changeSignBtn
            // 
            changeSignBtn.BackColor = Color.White;
            changeSignBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeSignBtn.Location = new Point(12, 403);
            changeSignBtn.Name = "changeSignBtn";
            changeSignBtn.Size = new Size(58, 40);
            changeSignBtn.TabIndex = 18;
            changeSignBtn.Text = "+/-";
            changeSignBtn.UseVisualStyleBackColor = false;
            changeSignBtn.Click += changeSign;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.White;
            btnPoint.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPoint.Location = new Point(140, 403);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(58, 40);
            btnPoint.TabIndex = 19;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            btnPoint.Click += handleNumberClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 450);
            Controls.Add(btnPoint);
            Controls.Add(changeSignBtn);
            Controls.Add(display);
            Controls.Add(number0);
            Controls.Add(clear);
            Controls.Add(backspace);
            Controls.Add(equal);
            Controls.Add(devide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(number9);
            Controls.Add(number8);
            Controls.Add(number7);
            Controls.Add(number6);
            Controls.Add(number5);
            Controls.Add(number4);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button number1;
        private Button number2;
        private Button number3;
        private Button number4;
        private Button number5;
        private Button number6;
        private Button number7;
        private Button number8;
        private Button number9;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button devide;
        private Button equal;
        private Button backspace;
        private Button clear;
        private Button number0;
        private Label display;
        private Button changeSignBtn;
        private Button btnPoint;
    }
}
