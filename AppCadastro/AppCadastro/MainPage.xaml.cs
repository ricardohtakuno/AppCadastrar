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
        public string Nome { get; set; }
        public string Email { get; set; }
        public MainPage()
		{
			InitializeComponent();
        }
        void btnCadastrar(object sender, System.EventArgs e)
        {
            var nome = txtNome.Text;
            var email = txtEmail.Text;

            DisplayAlert("Sucesso", string.Format("O cliente '{0}' foi cadastrado com o e-mail '{1}'", nome, email), "ok");
        }
	}
}
