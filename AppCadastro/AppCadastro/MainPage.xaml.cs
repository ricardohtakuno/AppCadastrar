using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadastro
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();
        }
        private void btnCadastrar(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            DisplayAlert("SUCESSO", string.Format("O cliente ABC foi cadastrado com o e-mail E-mail@", veiculo.Nome, veiculo.PrecoFormatado), "ok");
        }
	}
}
