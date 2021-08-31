using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string cep, string cidade, string estado)
        {
            Logradouro = logradouro.ValidarStringVazia();
            Cep = cep.ValidarStringVazia();
            Cidade = cidade.ValidarStringVazia();
            Estado = estado.ValidarStringVazia();
        }
        public string Logradouro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        
    }
}
