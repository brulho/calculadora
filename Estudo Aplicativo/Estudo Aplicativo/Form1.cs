namespace Estudo_Aplicativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = Convert.ToInt16(textBox1.Text);

            num2 = Convert.ToInt16(textBox2.Text);

            resultado = num1 * num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = Convert.ToInt16(textBox1.Text);

            num2 = Convert.ToInt16(textBox2.Text);

            resultado = num1 + num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal num1, num2, resultado;
            num1 = Convert.ToDecimal(textBox1.Text);

            num2 = Convert.ToDecimal(textBox2.Text);

            resultado = num1 / num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString("0");
        }
    }
}