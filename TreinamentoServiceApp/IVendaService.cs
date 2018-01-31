using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TreinamentoServiceApp.Contract;

namespace TreinamentoServiceApp
{
    [ServiceContract]
    public interface IVendaService
    {
        [OperationContract]
        NfseReponse GetNfse( string numero );

        [OperationContract]
        Venda GetVenda( int id );
    }
}
