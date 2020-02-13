using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void Add(Cliente c);

        [OperationContract]
        Cliente Buscar(string nome);
    }
}
