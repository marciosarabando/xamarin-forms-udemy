using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        private int valor = 1;
        public MainPage()
        {
            InitializeComponent();
            lbl_quantidade.Text = formataMoeda(valor);
        }

        private void btnMais_Clicked(object sender, EventArgs e)
        {
            valor++;
            lbl_quantidade.Text = formataMoeda(valor);
        }

        private void btnMenos_Clicked(object sender, EventArgs e)
        {
            if(valor <= 1)
            {
                DisplayAlert("Valor Mínimo", "O valor mínimo de investimento neste produto é de R$ 1,00", "FECHAR");
            }
            else
            {
                valor--;
                lbl_quantidade.Text = formataMoeda(valor);
            }
        }

        private string formataMoeda(int valor)
        {
            return valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}
