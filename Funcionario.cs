using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oficinamecanica
{
    class Funcionario : Pessoa
    {
        //private int salario;
        //private string cargo;




        public Funcionario()
        {

            

        }

        public string Cargo { get; set; }
        public int Salario { get; set; }


        public override string Exibir1()
        {
            return "Cargo: " + Cargo + "\nSalário " + Salario ;
        }



    }
}
