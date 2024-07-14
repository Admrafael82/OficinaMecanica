using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oficinamecanica
{
    class Pessoa

    {
        private string nome;
        private string telefone;


        public Pessoa()
        {
            System.Windows.Forms.MessageBox.Show("Cadastrado com sucesso!");
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Telefone
        {
            get => telefone;
            set => telefone = value;
        }
        public virtual string Exibir1()
        {
            return "";
        }

        public virtual string Exibir2()
        {
            return "";
        }

    }
}
    




	

