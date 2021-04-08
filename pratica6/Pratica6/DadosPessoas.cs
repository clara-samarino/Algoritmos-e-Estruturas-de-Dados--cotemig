using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica6
{
    public class DadosPessoas
    {
        
        public string nomePessoa;
        public string matricula;
        public DadosPessoas(string nomePessoaR, string matriculaR)
        {
            nomePessoa = nomePessoaR.ToUpper();
            matricula = matriculaR.ToUpper();
        }
        public DadosPessoas() { }

    }

}
