namespace Calculator
{
    public partial class Calculator : Form
    {
        public decimal MathResult { get; set; }
        public decimal MathValue { get; set; }

        private Maths SelectedMath { get; set; }
        private enum Maths
        {
            Sum,
            Subtract,
            Multiply,
            Divide
        }
        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += "9";
        }
        private void decimalButton_Click(object sender, EventArgs e)
        {
            typedBox.Text += ",";
        }

        private void signalButton_Click(object sender, EventArgs e)
        {
            typedBox.Text = ($"-{typedBox.Text}");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            typedBox.Text = string.Empty;
            previewBox.Text = string.Empty;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            SelectedMath = Maths.Divide;
            MathValue = Convert.ToDecimal(typedBox.Text);
            previewBox.Text = ($"{typedBox.Text} ÷");
            typedBox.Text = string.Empty;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            SelectedMath = Maths.Multiply;
            MathValue = Convert.ToDecimal(typedBox.Text);
            previewBox.Text = ($"{typedBox.Text} ×");
            typedBox.Text = string.Empty;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            SelectedMath = Maths.Subtract;
            MathValue = Convert.ToDecimal(typedBox.Text);
            previewBox.Text = ($"{typedBox.Text} -");
            typedBox.Text = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectedMath = Maths.Sum;
            MathValue = Convert.ToDecimal(typedBox.Text);
            previewBox.Text = ($"{typedBox.Text} +");
            typedBox.Text = string.Empty;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            switch (SelectedMath)
            {
                case Maths.Divide:
                    MathResult = (MathValue / Convert.ToDecimal(typedBox.Text));
                    previewBox.Text = ($"{MathValue} ÷ {typedBox.Text} =");
                    typedBox.Text = Convert.ToString(MathResult);
                    break;
                case Maths.Multiply:
                    MathResult = (MathValue * Convert.ToDecimal(typedBox.Text));
                    previewBox.Text = ($"{MathValue} × {typedBox.Text} =");
                    typedBox.Text = Convert.ToString(MathResult);
                    break;
                case Maths.Subtract:
                    MathResult = (MathValue - Convert.ToDecimal(typedBox.Text));
                    previewBox.Text = ($"{MathValue} - {typedBox.Text} =");
                    typedBox.Text = Convert.ToString(MathResult);
                    break;
                case Maths.Sum:
                    MathResult = (MathValue + Convert.ToDecimal(typedBox.Text));
                    previewBox.Text = ($"{MathValue} + {typedBox.Text} =");
                    typedBox.Text = Convert.ToString(MathResult);
                    break;
                default:
                    previewBox.Text = ($"{typedBox.Text} =");
                    break;

            }

        }
    }
}
