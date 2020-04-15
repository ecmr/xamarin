using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCep.Servico.Modelo;
using App01_ConsultarCep.Servico;

namespace App01_ConsultarCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();
            Endereco endereco = ViaCepServico.BuscarEnderecoViaCep(cep);
            RESULTADO.Text = string.Format("Endereço: {0} , {1} , {2}/{3}", endereco.logradouro, endereco.bairro, endereco.localidade, endereco.uf);
        }
    }
}
