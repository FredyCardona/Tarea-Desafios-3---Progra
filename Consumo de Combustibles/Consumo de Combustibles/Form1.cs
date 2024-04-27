using System;
using System.Windows.Forms;

namespace Consumo_de_Combustibles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtdistancia.Text, out double distancia) ||
                 !double.TryParse(txtrendimiento.Text, out double rendimiento))
            {
                MessageBox.Show("Los datos son erróneos");
                return;
            }

            // Se divide los litros de la gasolina entre los kilómetros
            // para poder calcular el consumo total
            double Galones_Consumidos = distancia / rendimiento;

            MessageBox.Show("La cantidad de galones que consumió es de: " + Galones_Consumidos.ToString());
        }
    }
}
