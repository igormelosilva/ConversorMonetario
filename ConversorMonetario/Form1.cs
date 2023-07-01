using Microsoft.VisualBasic.Logging;

namespace ConversorMonetario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Log.Add(LogType.success, LogSave.file, "Aplicação iniciada com sucesso");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Não pode ser em branco");
                Log.Add(LogType.error, LogSave.database, "Valor a ser convertido em branco");
            }
            else
            {
                Log.Add(LogType.success, LogSave.file, "Valor " + txtValor.Text + " informado com sucesso");
                try
                {
                    //float teste = Convert.ToInt32(txtValor.Text);
                    float valor = float.Parse(txtValor.Text);
                    float dolar = 4.79f;
                    float libra = 6.06f;
                    float euro = 5.23f;
                    txtDolar.Text = (valor / dolar).ToString("n2");
                    txtEuro.Text = (valor / euro).ToString("n2");
                    txtLibras.Text = (valor / libra).ToString("n2");
                    Log.Add(LogType.success, LogSave.database, "Valor convertido corretamente");
                }
                catch (Exception ex)
                {

                    Log.Add(LogType.error, LogSave.database, ex.Message);


                    MessageBox.Show("Erro");




                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtDolar.Clear();
            txtLibras.Clear();
            txtEuro.Clear();
        }
    }
}