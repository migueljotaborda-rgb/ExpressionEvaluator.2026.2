using Backend;

namespace Frontend.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "1";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textDisplay.Text += ".";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "/";
        }

        private void btnMultiplay_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "*";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "-";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            textDisplay.Text = string.Empty;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "(";

        }
        private void btnCloseParenthsis_Click(object sender, EventArgs e)
        {
            textDisplay.Text += ")";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "^";

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            textDisplay.Text += $"={MyEvaluator.Evaluate(textDisplay)}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
 