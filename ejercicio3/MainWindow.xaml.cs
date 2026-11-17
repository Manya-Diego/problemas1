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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double sueldoMinimo = 1025;
            double horasExtras = double.Parse(txtHorasExtras.Text);
            double tarifa = double.Parse(txtTarifa.Text);
            double inasistencias = double.Parse(txtInasistencias.Text);

            double montoHorasExtras = horasExtras * tarifa;
            double sueldoBruto = sueldoMinimo + montoHorasExtras;

            double bonificacion;
            if (sueldoBruto > 2000)
            {
                bonificacion = sueldoBruto * 0.05;
            }
            else
            {
                bonificacion = sueldoBruto * 0.10;
            }

            double costoDia = sueldoMinimo / 30;
            double descuento = inasistencias * costoDia;
            double sueldoNeto = sueldoBruto + bonificacion - descuento;

            lblHorasExtras.Text = $"Monto por horas extras: S/ {montoHorasExtras:F2}";
            lblBonificacion.Text = $"Bonificación: S/ {bonificacion:F2}";
            lblDescuento.Text = $"Descuento por inasistencias: S/ {descuento:F2}";
            lblSueldoNeto.Text = $"Sueldo neto: S/ {sueldoNeto:F2}";
        }
    }
}