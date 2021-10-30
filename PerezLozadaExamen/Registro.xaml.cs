using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PerezLozadaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario Conectado:   " + usuario;

        }

        private void btnCalcularPago_Clicked(object sender, EventArgs e)
        {
            try
            {
                double montoInicio = Convert.ToDouble(txtMontoInicial.Text);
                double porcentaje = 90;
                double cuota = 1800 - montoInicio;

                double pagoMensual = (cuota / 3) + porcentaje;

                txtPagoMensual.Text = Convert.ToString(pagoMensual);

            }
            catch(Exception ex)
            {

            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string usuario = lblUsuario.Text;

            double cuota_inicio = Convert.ToDouble(txtMontoInicial.Text);
            double mensual = Convert.ToDouble(txtPagoMensual.Text);
            double total_cuota = mensual * 3;
            double total = total_cuota + cuota_inicio; 

            string totalPago = Convert.ToString(total);

            DisplayAlert("Notificacion", "Elemento guardado con exito", "OK");

            await Navigation.PushAsync(new Resumen(nombre, usuario, totalPago));
        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (double.Parse(txtMontoInicial.Text) > 1800 | double.Parse(txtMontoInicial.Text) < 0)
                {
                    DisplayAlert("Mensaje de advertencia", "Necesita ingresar un número entre 1 y 1800", "OK");
                    txtMontoInicial.Text = null;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}