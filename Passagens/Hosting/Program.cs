using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Passagens;

namespace Hosting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciando o serviço
            ServiceHost host = new ServiceHost(typeof(ClienteService));

            // EndPoint criado manualmente
            Uri endereco = new Uri("http://localhost:8080/cliente");
            // Uri endereco = new Uri("http://localhost:8080/clientes");
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);

            try
            {
                // Iniciando o host
                host.Open();

                ExibeInformacoesServico(host);

                Console.ReadLine(); // -> Para não encerrar o console imediatamente
                // Encerrando o host
                host.Close();
            }
            catch (Exception e)
            {
                // Abortando o serviço
                host.Abort();
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine($"{sh.Description.ServiceType} online");
            foreach (ServiceEndpoint se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}
