using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [DataContract] // Informando ao que a classe Cliente vai trafegar no serviço ClienteService
    public class Cliente
    {
        [DataMember] // Informando que esse dado ira trafegar no serviço
        public string Nome { get; set; }

        [DataMember] // Informando que esse dado ira trafegar no serviço
        public string Cpf { get; set; }
    }
}
