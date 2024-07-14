using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oficinamecanica
{
    class Cliente : Pessoa
    {
        //private int qt_compras, desconto;
               
           

        public Cliente()
        {
           

          

        }

        public int Qt_compras { get; set; }
        public int Desconto { get; set; }


        public override string Exibir1()
        {
            return "O total de compras foi " + Qt_compras + "\nO desconto foi de " + Desconto + "%";
        }



    }
}

