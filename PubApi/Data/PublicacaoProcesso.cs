using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApi.Data
{
    public class PublicacaoProcesso
    {
        public int Id { get; set; }
        public int IdStatusPublicacaoProcesso { get; set; }
        public long IdProcessoSim { get; set; }
        public long NumeroEdital { get; set; }
        public int AnoPublicacao { get; set; }
        public string CodigoProcesso { get; set; }
        public long CodigoModalidade { get; set; }
        public string Modalidade { get; set; }
        public string DescricaoObjeto { get; set; }
        public string DataAbertura { get; set; }
        public string DataPublicacao { get; set; }
        public string DataHoraCriacao { get; set; }
        public string DataHoraAlteracao { get; set; }
        public StatusPublicacaoProcesso StatusPublicacaoProcesso { get; set; }
    }
}
