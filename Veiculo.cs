using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oficinamecanica
{
    class Veiculo

    {
        private string marca;
        private string modelo;
        private string cor;


        public Veiculo()
        {
            System.Windows.Forms.MessageBox.Show("Vecículo cadastrado com sucesso!");
        }

        public string Marca
        {
            get => marca;
            set => marca = value;
        }

        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }

        public string Cor
        {
            get => cor;
            set => cor = value;
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
