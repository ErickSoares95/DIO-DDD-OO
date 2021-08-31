using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Endereco endereco = new Endereco("Casa", "54120-250", "Recife", "PE");
                Cliente c1 = new Cliente("erick", "11111111111", "540045", endereco);

                ContaCorrente conta = new ContaCorrente(c1, 100);
                Console.WriteLine("Conta: " + conta.Situacao + "-" + conta.NumeroConta + conta.DigitoVerificador);
                string senha = "acd12378";
                conta.Abrir(senha);

                Console.WriteLine("Conta: " + conta.Situacao + "-" + conta.NumeroConta + conta.DigitoVerificador);

                conta.Sacar(20, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
