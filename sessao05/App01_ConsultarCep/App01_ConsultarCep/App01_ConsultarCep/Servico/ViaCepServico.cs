using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCep.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCep.Servico
{
    public class ViaCepServico
    {
        private static string EnderecoUrl = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            string NovoEnderecoUrl = string.Format(EnderecoUrl, cep);

            WebClient wc = new WebClient();
            string resultado = wc.DownloadString(NovoEnderecoUrl);

            return JsonConvert.DeserializeObject<Endereco>(resultado);
        }
    }
}
