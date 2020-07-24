using System;
using System.Collections.Generic;

namespace PubApi.Data
{
    public class ItemProcesso
    {
        public string Cpl { get; set; }
        public string Lote { get; set; }
        public string CodigoReduzido { get; set; }
        public string SequenciaItem { get; set; }
        public string DescricaoItem { get; set; }
        public string CpfCnpjFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeFantasia { get; set; }
        public decimal? Quantidade { get; set; }
        public string ValorUnitarioEstimado { get; set; }
        public string ValorUnitarioContratado { get; set; }
        public string DataInicioContrato { get; set; }
        public string DataFimContrato { get; set; }
        public string FundamentoLegal { get; set; }
    }
}
