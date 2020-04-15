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

            if (IsValidCep(cep))
            {
                try
                {
                    Endereco endereco = ViaCepServico.BuscarEnderecoViaCep(cep);
                    if (endereco != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {0} , {1} , {2}/{3}", endereco.logradouro, endereco.bairro, endereco.localidade, endereco.uf);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o cep informado: " + cep, "OK");
                    }
                }
                catch (Exception ex)
                {
                    DisplayAlert("ERRO CRÍTICO", ex.Message, "OK");
                }
            }
        }

        private bool IsValidCep(string cep)
        {
            bool valido = true;

            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP Inválido!", "OK");
                valido = false;
            }
            int NovoCep = 0;
            if(!int.TryParse(cep, out NovoCep))
            {
                DisplayAlert("ERRO", "CEP Inválido!", "OK");
                valido = false;
            }
            return valido;
        }
    }
}
