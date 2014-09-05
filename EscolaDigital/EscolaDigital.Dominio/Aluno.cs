using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDigital.Dominio
{
    class Aluno
    {
		public string tipoRegistro {get; set;}
		public int codigoEscolaInep {get; set;}
		public int codigoAlunoInep {get; set;}
		public int codigoAluno {get; set;}
		public string nomeCompletoAluno {get; set;}
		public string identificacaoSocialNIS {get; set;}
        public DateTime dataNascimento { get; set; }
        public int sexo { get; set; }
        public int corRaca { get; set; }
        public int tipoFiliacao { get; set; }
        public string nomeMae { get; set; }
        public string nomePai { get; set; }
        public int nacionalidadeAluno { get; set; }
        public string paisOrigem  {get; set;}
        public string ufNascimento { get; set; }

    }
}
