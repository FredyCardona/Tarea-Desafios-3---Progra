using System;
using System.Windows.Forms;

namespace Contador_de_viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double velocidad;
            string origen = txtPtoInicio.Text;
            string destino = txtPtoFinal.Text;

            if (!double.TryParse(txtvmedia.Text, out velocidad))
            {
                MessageBox.Show("La velocidad no es válida");
                return;
            }

            double distancia = 100;
            double tiempo = distancia / velocidad;

            MessageBox.Show($"El tiempo de viaje es desde el punto A {origen} al punto B {destino} es de: {tiempo} horas");
        }
    }
}

