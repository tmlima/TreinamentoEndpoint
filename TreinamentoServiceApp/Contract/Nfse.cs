using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TreinamentoServiceApp.Contract
{

    [DataContract]
    public class NfseReponse
    {
        [DataMember]
        public Nfse Nfse { get; set; }
    }

    [DataContract]
    public class Nfse
    {
        [DataMember]
        public string Numero { get; set; }

        [DataMember]
        public string CodigoVerificacao { get; set; }

        [DataMember]
        public DateTime DataEmissao { get; set; }

        [DataMember]
        public Servico Servico { get; set; }
    }

    [DataContract]
    public class Servico
    {
        [DataMember]
        public Valores Valores { get; set; }

        [DataMember]
        public string Discriminacao { get; set; }
    }

    [DataContract]
    public class Valores
    {
        [DataMember]
        public decimal ValorServicos { get; set; }

        [DataMember]
        public decimal ValorLiquidoNfse { get; set; }

    }
}