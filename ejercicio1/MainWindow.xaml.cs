using System;
using System.Windows;
using System.Windows.Media;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txtNota1.Text);
            double n2 = double.Parse(txtNota2.Text);
            double n3 = double.Parse(txtNota3.Text);
            double n4 = double.Parse(txtNota4.Text);

            double menor = Math.Min(n1, Math.Min(n2, Math.Min(n3, n4)));
            double promedio = (n1 + n2 + n3 + n4 - menor) / 3;

            lblPromedio.Text = $"Promedio: {promedio:F2}";

            if (promedio >= 10.5)
            {
                lblEstado.Text = "Aprobado";
                lblPromedio.Foreground = Brushes.Blue;
            }
            else
            {
                lblEstado.Text = "Desaprobado";
                lblPromedio.Foreground = Brushes.Red;
            }
        }
    }
}