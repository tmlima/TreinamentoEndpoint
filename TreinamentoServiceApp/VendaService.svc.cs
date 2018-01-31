using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TreinamentoServiceApp.Contract;

namespace TreinamentoServiceApp
{
    public class VendaService : IVendaService
    {
        public NfseReponse GetNfse(string numero)
        {
            if (numero == "2018")
                 return new NfseReponse() { Nfse = GenerateNfse() };

            throw new FaultException( "Nfse [" + numero + "] não encontrada" );
        }

        public Venda GetVenda(int id)
        {
            if (id == 1)
            {
                return new Venda()
                {
                    Cliente = "João da Silva",
                    Nfse = GenerateSerializedNfse()
                };
            }

            throw new FaultException( "Venda com Id [" + id + "] não encontrada" );
        }

        private Nfse GenerateNfse()
        {
            return new Nfse()
            {
                Numero = "2018",
                CodigoVerificacao = "da84",
                DataEmissao = new DateTime( 2018, 01, 31 ),
                Servico = new Servico()
                {
                    Valores = new Valores()
                    {
                        ValorServicos = 110,
                        ValorLiquidoNfse = 100
                    },
                    Discriminacao = "Teclado T2"
                }
            };
        }

        private string GenerateSerializedNfse()
        {
            return
                "< a:Nfse >" +
                "< a:CodigoVerificacao > ef847ad3 </ a:CodigoVerificacao >" +
                "< a:DataEmissao > 2018 - 01 - 31T00:00:00 </ a:DataEmissao >" +
                "< a:Numero > 201800560028562 </ a:Numero >" +
                "< a:Servico >" +
                "< a:Discriminacao > Teclado T2 </ a:Discriminacao >" +
                "< a:Valores >" +
                "< a:ValorLiquidoNfse > 100 </ a:ValorLiquidoNfse >" +
                "< a:ValorServicos > 110 </ a:ValorServicos >" +
                "</ a:Valores >" +
                "</ a:Servico >" +
                "</ a:Nfse >";
        }
    }
}
