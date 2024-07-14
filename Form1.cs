using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficinamecanica
{
    public partial class Form1 : Form
    {
        Cliente c1;
        Funcionario f1;
        Carro c2;
        Moto m1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1 = new Cliente();
            c1.Nome = txt_nome.Text;
            c1.Telefone = txt_telefone.Text;
            c1.Qt_compras = int.Parse(txt_compras.Text);
            c1.Desconto = int.Parse(txt_desconto.Text);
            lst_registros.Items.Add("Cliente: " + txt_nome.Text + " \nTelefone: " + txt_telefone.Text + " \nCompras: " + txt_compras.Text
                + " Desconto: " + txt_desconto.Text + " %");

            // Exibir informações do Cliente
            MessageBox.Show("Cliente: " + c1.Nome
                + "\nTelefone: " + c1.Telefone
                + "\n" + c1.Exibir1());

            

           

            txt_nome.Clear();
            txt_telefone.Clear();
            txt_compras.Clear();
            txt_desconto.Clear();
            
            
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_exibir_Click(object sender, EventArgs e)
        {
            if (c1 != null)
            {
                MessageBox.Show("Cliente: " + c1.Nome
                    + "\nTelefone: " + c1.Telefone
                    + "\n" + c1.Exibir1());
            }

           

           
        }

        private void btn_cadastrar2_Click(object sender, EventArgs e)
        {
            f1 = new Funcionario();
            f1.Nome = txt_nome2.Text;
            f1.Telefone = txt_telefone2.Text;
            f1.Cargo = txt_cargo.Text;
            f1.Salario = int.Parse(txt_salario.Text);
            lst_registros.Items.Add("Funcionário: " + txt_nome2.Text + " \nTelefone: " + txt_telefone2.Text + " \nCargo: "
                + txt_cargo.Text
                + " Salário R$: " + txt_salario.Text);

            // Exibir informações do Funcionario
            MessageBox.Show("Funcionário: " + f1.Nome
                + "\nTelefone: " + f1.Telefone
                + "\n" + f1.Exibir1());

            txt_nome2.Clear();
            txt_telefone2.Clear();
            txt_cargo.Clear();
            txt_salario.Clear();
        }

        private void btn_exibir2_Click(object sender, EventArgs e)
        {
            if (f1 != null)
            {
                MessageBox.Show("Funcionário: " + f1.Nome
                    + "\nTelefone: " + f1.Telefone
                    + "\n" + f1.Exibir1());
            }
        }

        private void txt_cilindradas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_marchas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar3_Click(object sender, EventArgs e)
        {
            c2 = new Carro();
            c2.Marca = txt_marca.Text;
            c2.Modelo = txt_modelo.Text;
            c2.Cor = txt_cor.Text;
            c2.Qt_portas = int.Parse(txt_portas.Text);
            c2.Tipo = txt_tipo.Text;
            lst_registros.Items.Add(
                "Marca: " + txt_marca.Text
                + " \nModelo: " + txt_modelo.Text
                + " \nCor: " + txt_cor.Text
                + " \nPortas: " + txt_portas.Text
                + " \nTipo: " + txt_tipo.Text);

            // Exibir informações do Carro
            MessageBox.Show("Veículo: " + c2.Marca
                + "\nModelo: " + c2.Modelo
                + "\nCor: " + c2.Cor
                + "\n" + c2.Exibir1());

            txt_marca.Clear();
            txt_modelo.Clear();
            txt_cor.Clear();
            txt_portas.Clear();
            txt_tipo.Clear();
        }

        private void btn_exibir3_Click(object sender, EventArgs e)
        {
            if (c2 != null)
            {
                MessageBox.Show("Marca: " + c2.Marca
                    + "\nModelo: " + c2.Modelo
                    + "\nCor: " + c2.Cor
                    + "\n" + c2.Exibir1());
            }
        }

        private void btn_cadastrar4_Click(object sender, EventArgs e)
        {
            m1 = new Moto();
            m1.Marca = txt_marca2.Text;
            m1.Modelo = txt_modelo2.Text;
            m1.Cor = txt_cor2.Text;
            m1.Cilindradas = int.Parse(txt_cilindradas.Text);
            m1.Qt_marchas = int.Parse(txt_marchas.Text);
            lst_registros.Items.Add(
                "Marca: " + txt_marca.Text
                + " \nModelo: " + txt_modelo.Text
                + " \nCor: " + txt_cor.Text
                + " \nCilindradas: " + txt_cilindradas.Text
                + " \nMarchas: " + txt_marchas.Text
               );

            // Exibir informações da moto
            MessageBox.Show("Veículo: " + m1.Marca
                + "\nModelo: " + m1.Modelo
                + "\nCor: " + m1.Cor
                + "\n" + m1.Exibir1());

            txt_marca2.Clear();
            txt_modelo2.Clear();
            txt_cor2.Clear();
            txt_cilindradas.Clear();
            txt_marchas.Clear();

            
        }

        private void btn_exibir4_Click(object sender, EventArgs e)
        {
            if (m1 != null)
            {
                MessageBox.Show("Marca: " + m1.Marca
                    + "\nModelo: " + m1.Modelo
                    + "\nCor: " + m1.Cor
                    + "\n" + m1.Exibir1());
            }
        }
    }
}
