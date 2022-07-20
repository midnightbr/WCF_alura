using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [ServiceContract] // Obrigatorio, para informar que se trata de um contrato
    internal interface IClienteService
    {
        [OperationContract] // -> Obrigatorio para informar que é uma operação do contrato
        Cliente Buscar(string nome);

        [OperationContract] // -> Obrigatorio para informar que é uma operação do contrato
        void Add(Cliente c);
    }
}
