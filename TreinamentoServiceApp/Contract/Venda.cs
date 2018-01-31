using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TreinamentoServiceApp.Contract
{
    [DataContract]
    public class Venda
    {
        [DataMember]
        public string Cliente { get; set; }

        [DataMember]
        public string Nfse { get; set; }
    }
}