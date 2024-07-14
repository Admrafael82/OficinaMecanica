using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oficinamecanica
{
    class Carro : Veiculo
    {
        private int  qt_portas, tipo;




        public Carro()
        {

            
        }

       
        public int Qt_portas { get; set; }

        public string Tipo { get; set; }


        public override string Exibir1()
        {
            return "\n Portas: " + Qt_portas + "\n Tipo: " + Tipo;
        }



    }
}

