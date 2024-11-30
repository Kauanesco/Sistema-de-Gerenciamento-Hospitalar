using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    public class Pessoa
    {
       public string Nome {  get; set; }

       public string CPF {  get; set; }

       public Pessoa(string nome, string cPF)
        {
            Nome=nome;
            CPF=cPF;
       }
        public Pessoa()
        {
        }
    }
}
