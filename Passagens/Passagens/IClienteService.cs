using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [ServiceContract] // Obrigatorio, para informar que se trata de um contrato
    public interface IClienteService
    {
        [OperationContract] // -> Obrigatorio para informar que é uma operação do contrato
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "searchCliente/{nome}")]
        Cliente Buscar(string nome);

        [OperationContract] // -> Obrigatorio para informar que é uma operação do contrato
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "addCliente/{nome};{cpf}")] // -> disponibilizando para web
        bool Add(string nome, string cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getClientes/")] // -> disponibilizando para web
        List<Cliente> getClientes();
    }
}
