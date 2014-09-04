using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDigital.Dominio
{
    class Endereco
    {
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }        
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public byte UF { get; set; } // código do estado, de acordo com a "Tabela de UF"
        public int Municipio { get; set; } // código do município, de acordo com a "Tabela de Município"
        public byte Distrito { get; set; } // código do distrito, de acordo com a "Tabela de Distrito"        
    }
}
