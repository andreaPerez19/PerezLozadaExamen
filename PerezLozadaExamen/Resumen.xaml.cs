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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string usuario, string total)
        {
            InitializeComponent();

            lblNombre.Text = "Nombre:   " + nombre;
            lblUsuario.Text = usuario;
            lblTotal.Text = "Total a pagar " + total;
        }
    }
}