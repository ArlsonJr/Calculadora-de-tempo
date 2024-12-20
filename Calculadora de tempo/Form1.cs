using System.DirectoryServices.ActiveDirectory;

namespace Calculadora_de_tempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            var hora = 0;

            if (nH1.Text != "")
                hora += Convert.ToInt32(nH1.Text);

            if (nH2.Text != "")
                hora += Convert.ToInt32(nH2.Text);

            var minuto = 0;

            if (nM1.Text != "")
                minuto += Convert.ToInt32(nM1.Text);

            if (nM2.Text != "")
                minuto += Convert.ToInt32(nM2.Text);

            var segundo = 0;

            if (nS1.Text != "")
                segundo = Convert.ToInt32(nS1.Text);

            if (nS2.Text != "")
                segundo += Convert.ToInt32(nS2.Text);

            var resultado = new TimeSpan(hora, minuto, segundo);

            txtHResult.Text = resultado.Hours.ToString();
            txtMResult.Text = resultado.Minutes.ToString().PadLeft(2, '0');
            txtSResult.Text = resultado.Seconds.ToString().PadLeft(2, '0');
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            nH1.Focus();
        }

        private void LimpaCampos()
        {
            nH1.Value = 0;
            nH2.Value = 0;
            nM1.Value = 0;
            nM2.Value = 0;
            nS1.Value = 0;
            nS2.Value = 0;
            txtHResult.Clear();
            txtMResult.Clear();
            txtSResult.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int hora = 0, minuto = 0, segundo = 0;

            if (txtHResult.Text != "")
                hora = Convert.ToInt32(txtHResult.Text);

            if (txtMResult.Text != "")
                minuto = Convert.ToInt32(txtMResult.Text);

            if (txtSResult.Text != "")
                segundo = Convert.ToInt32(txtSResult.Text);

            LimpaCampos();

            if (hora > 0)
                nH1.Text = hora.ToString();

            if (minuto > 0)
                nM1.Text = minuto.ToString().PadLeft(2, '0');

            if (segundo > 0)
                nS1.Text = segundo.ToString().PadLeft(2, '0');
        }
    }
}
