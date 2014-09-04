using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDigital.Dominio
{
    class Escola
    {
        public int CodigoInep{get; set;}
        public int SituacaoFuncionamento { get; set; }
        public AnoLetivo Ano { get; set; }
        public string NomeEscola { get; set; }        
    }
}
