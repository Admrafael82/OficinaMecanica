using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oficinamecanica
{
    class Moto : Veiculo
    {
        private int cilindradas, qt_marchas;




        public Moto()
        {

            

        }

        public int Cilindradas { get; set; }
        public int Qt_marchas { get; set; }
        


        public override string Exibir1()
        {
            return "Cilindradas: " + Cilindradas + "\n Marchas: " + Qt_marchas ;
        }
    }
}