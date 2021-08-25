using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;

        //digitar prop+tab+tab
        //enter+enter depois para finalizar
        public string Nome { get; set; }
        public string CPF 
        { 
            get
            {
                return _cpf;
            }
            set
            {
                //escrevo minha lógica de validação de cpf
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
