namespace calcualtor
{
    public partial class Form1 : Form
    {
        double numb1 = 0;
        double numb2 = 0;
        string opt = "";
        bool isFirstNumber = true;
        bool isFirstopt = true;
        bool shouldResetDisplay = false; // افزودن این متغیر برای مدیریت ریست نمایشگر

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            //better appearance for buttons:
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
                //else if ( c is Label)
                //{
                //    Label lbl = (Label)c;
                //}
            }
        }

        void setToNumber(string number)
        {
            if (!double.TryParse(number, out double value))
                value = 0;

            if (shouldResetDisplay)
                numb2 = value;
            else if (isFirstNumber)
                numb1 = value;
            else
                numb2 = value;
        }

        private void handleNumberClick(object sender, EventArgs e)
        {
            if (shouldResetDisplay)
            {
                display.Text = "";
                shouldResetDisplay = false;
            }

            Button button = (Button)sender;
            string newChar = button.Text;

            // مدیریت نقطه اعشار
            if (newChar == ".")
            {
                if (display.Text.Contains("."))
                    return;
                if (string.IsNullOrEmpty(display.Text))
                    display.Text = "0";
            }

            display.Text += newChar;
            setToNumber(display.Text);
            this.ActiveControl = display;
        }


        private void backspace_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                string currentText = display.Text;
                currentText = currentText.Remove(currentText.Length - 1);
                display.Text = currentText;
                setToNumber(currentText);
            }
            this.ActiveControl = display;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            numb1 = 0;
            numb2 = 0;
            opt = "";
            isFirstNumber = true;
            shouldResetDisplay = false;
            this.ActiveControl = display;
            //this.ActiveControl.Focus();
        }

        private void handleOpt(object sender, EventArgs e)
        {
            Button optButton = (Button)sender;
            string newOpt = optButton.Text;

            if (!isFirstNumber && !shouldResetDisplay)
            {
                // اگر عملیات قبلی وجود داشت، آن را محاسبه کن
                equal.PerformClick();
            }

            opt = newOpt;
            isFirstNumber = false;
            shouldResetDisplay = true;
            this.ActiveControl = display;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (opt == "" || isFirstNumber)
                return;

            try
            {
                double result = 0;
                switch (opt)
                {
                    case "+": result = numb1 + numb2; break;
                    case "-": result = numb1 - numb2; break;
                    case "×": result = numb1 * numb2; break;
                    case "÷":
                        if (numb2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clear_Click(sender, e);
                            return;
                        }
                        result = numb1 / numb2;
                        break;
                }

                display.Text = result.ToString("0.####"); // نمایش حداکثر 4 رقم اعشار
                numb1 = result;
                opt = "";
                isFirstNumber = true;
                shouldResetDisplay = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear_Click(sender, e);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // اعداد
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                handleKeyNumber((e.KeyCode - Keys.NumPad0).ToString());
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                handleKeyNumber((e.KeyCode - Keys.D0).ToString());
            }
            // نقطه اعشار
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                if (!display.Text.Contains("."))
                    handleKeyNumber(".");
            }
            // عملیات
            else if (e.KeyCode == Keys.Add) { handleKeyOperator("+"); }
            else if (e.KeyCode == Keys.Subtract) { handleKeyOperator("-"); }
            else if (e.KeyCode == Keys.Multiply) { handleKeyOperator("×"); }
            else if (e.KeyCode == Keys.Divide) { handleKeyOperator("÷"); }
            // سایر کلیدها
            else if (e.KeyCode == Keys.Enter) { equal.PerformClick(); }
            else if (e.KeyCode == Keys.Back) { backspace.PerformClick(); }
            else if (e.KeyCode == Keys.Escape) { clear.PerformClick(); }
        }

        private void handleKeyNumber(string number)
        {
            if (shouldResetDisplay)
            {
                display.Text = "";
                shouldResetDisplay = false;
            }

            if (number == ".")
            {
                if (display.Text.Contains("."))
                    return;
                if (string.IsNullOrEmpty(display.Text))
                    display.Text = "0";
            }

            display.Text += number;
            setToNumber(display.Text);
        }

        private void handleKeyOperator(string operatorStr)
        {
            if (!isFirstNumber && !shouldResetDisplay)
            {
                equal.PerformClick();
            }
            opt = operatorStr;
            isFirstNumber = false;
            shouldResetDisplay = true;
        }
        private void changeSign(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(display.Text))
            {
                display.Text = "-0";
                setToNumber(display.Text);
                return;
            }

            if (double.TryParse(display.Text, out double currentNumber))
            {
                currentNumber *= -1;
                display.Text = currentNumber.ToString("0.####");

                if (isFirstNumber || string.IsNullOrEmpty(opt))
                    numb1 = currentNumber;
                else
                    numb2 = currentNumber;
            }
            else
            {
                MessageBox.Show("Invalid number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActiveControl = display;
        }
        
    }
}