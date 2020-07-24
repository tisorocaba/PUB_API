using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PubApi.Data
{
    public class RequestData
    {
        public string Exercicios { get; set; }
        public string DataAberturaInicial { get; set; }
        public string DataAberturaFinal { get; set; }
        public string CnpjFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string DescricaoItem { get; set; }
        public string CodigoModalidade { get; set; }
        public string AnoProcesso { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroEdital { get; set; }
        public string DescricaoObjeto { get; set; }
        public string IdStatusPublicacao { get; set; }
    }
}