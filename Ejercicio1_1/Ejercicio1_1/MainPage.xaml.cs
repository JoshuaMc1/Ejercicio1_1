using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private bool campoVacio(string campo)
        {
            return String.IsNullOrEmpty(campo);
        }

        private async void msg(string titulo, string msg)
        {
            await DisplayAlert(titulo, msg, "Ok");
        }

        private async void btnSumar_Clicked(object sender, EventArgs e)
        {
            if (!campoVacio(txtNumber1.Text))
            {
                if (!campoVacio(txtNumber2.Text))
                {
                    var operacion = new Clases.Funciones(n1: double.Parse(txtNumber1.Text), n2: double.Parse(txtNumber2.Text));
                    operacion.resultado = "El resultado de la suma es: " + operacion.sumar();
                    var secondPage = new Vistas.Resultado();
                    secondPage.BindingContext = operacion;
                    await Navigation.PushAsync(secondPage);
                } else msg("Error", "Debe ingresar el segundo numero");
            } else msg("Error", "Debe ingresar el primer numero");
        }

        private async void btnRestar_Clicked(object sender, EventArgs e)
        {
            if (!campoVacio(txtNumber1.Text))
            {
                if (!campoVacio(txtNumber2.Text))
                {
                    var operacion = new Clases.Funciones(n1: double.Parse(txtNumber1.Text), n2: double.Parse(txtNumber2.Text));
                    operacion.resultado = "El resultado de la resta es: " + operacion.restar();
                    var secondPage = new Vistas.Resultado();
                    secondPage.BindingContext = operacion;
                    await Navigation.PushAsync(secondPage);
                } else msg("Error", "Debe ingresar el segundo numero");
            } else msg("Error", "Debe ingresar el primer numero");
        }

        private async void btnDividir_Clicked(object sender, EventArgs e)
        {
            if (!campoVacio(txtNumber1.Text))
            {
                if (!campoVacio(txtNumber2.Text))
                {
                    var operacion = new Clases.Funciones(n1: double.Parse(txtNumber1.Text), n2: double.Parse(txtNumber2.Text));
                    operacion.resultado = "El resultado de la division es: " + operacion.dividir();
                    var secondPage = new Vistas.Resultado();
                    secondPage.BindingContext = operacion;
                    await Navigation.PushAsync(secondPage);
                } else msg("Error", "Debe ingresar el segundo numero");
            } else msg("Error", "Debe ingresar el primer numero");
        }

        private async void btnMulti_Clicked(object sender, EventArgs e)
        {
            if (!campoVacio(txtNumber1.Text))
            {
                if (!campoVacio(txtNumber2.Text))
                {
                    var operacion = new Clases.Funciones(n1: double.Parse(txtNumber1.Text), n2: double.Parse(txtNumber2.Text));
                    operacion.resultado = "El resultado de la multiplicacion es: " + operacion.multiplicar();
                    var secondPage = new Vistas.Resultado();
                    secondPage.BindingContext = operacion;
                    await Navigation.PushAsync(secondPage);
                } else msg("Error", "Debe ingresar el segundo numero");
            } else msg("Error", "Debe ingresar el primer numero");
        }
    }
}
