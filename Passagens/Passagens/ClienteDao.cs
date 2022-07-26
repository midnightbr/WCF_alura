using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDao
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public void Add(Cliente c)
        {
            ClienteDao.clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            var result = ClienteDao.clientes.Where(x => x.Nome.Equals(nome)).FirstOrDefault();
            return (Cliente) result;
        }
    }
}
