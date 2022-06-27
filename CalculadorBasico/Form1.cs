namespace CalculadorBasico
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }
        clases.cSUMA obj = new clases.cSUMA();
        clases.cRESTA obj2 = new clases.cRESTA();
        clases.cDIVIDIR obj3 = new clases.cDIVIDIR();
        clases.cMULTIPLICAR obj4 = new clases.cMULTIPLICAR();
        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(resultsBOX.Text);
            resultsBOX.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(resultsBOX.Text);

            double Suma;
            double Resta;
            double Div;
            double Mult;

            switch (operador)

            {
                case "+":
                    Suma = obj.sumar((primero), (segundo));
                    resultsBOX.Text = Suma.ToString();
                    break;
                case "-":
                    Resta = obj2.restar((primero), (segundo));
                    resultsBOX.Text = Resta.ToString();
                    break;
                case "/":
                    Div = obj3.dividir((primero), (segundo));
                    resultsBOX.Text = Div.ToString();
                    break;
                case "*":
                    Mult = obj4.multiplicar((primero), (segundo));
                    resultsBOX.Text = Mult.ToString();
                    break;
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (resultsBOX.Text.Length <= 1)
                resultsBOX.Text = "0";
            else
                resultsBOX.Text = resultsBOX.Text.Substring(0, resultsBOX.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultsBOX.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(resultsBOX.Text);
            resultsBOX.Clear();
        }

        private void DOT_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + ".";
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "0";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "3";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "6";
        }

        private void resultsBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(resultsBOX.Text);
            resultsBOX.Clear();
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "2";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "5";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "9";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "1";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "4";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            resultsBOX.Text = resultsBOX.Text + "7";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(resultsBOX.Text);
            resultsBOX.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}