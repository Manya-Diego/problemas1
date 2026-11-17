using System;
using System.Windows;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            string n1 = txtNombre1.Text;
            string n2 = txtNombre2.Text;
            string pat = txtPaterno.Text;
            string mat = txtMaterno.Text;
            string anio = txtAnio.Text;

            string letra1 = n1.Substring(0, 1);
            string letra2 = n2.Substring(0, 1);
            string letraMat = mat.Substring(0, 1);
            string dosCifras = anio.Substring(anio.Length - 2, 2);

            Random aleatorio = new Random();
            int numero = aleatorio.Next(1, 6);

            string correo = $"{letra1}{letra2}{pat}{letraMat}{dosCifras}_{numero}@gmail.com".ToLower();

            lblCorreo.Text = correo;
        }
    }
}