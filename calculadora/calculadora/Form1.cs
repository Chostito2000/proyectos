using System.Data;

namespace calculadora
{
    public partial class btnBorrar : Form
    {
        public btnBorrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "9";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "+";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text = " ";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var resultado = dt.Compute(txtVerResultado.Text, "");

                txtVerResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                txtVerResultado.Text = "Error";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtVerResultado.Text += "-";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVerResultado.Text.Length > 0)
            {
                txtVerResultado.Text = txtVerResultado.Text.Substring(0, txtVerResultado.Text.Length - 1);
            }
        }
    }
}



