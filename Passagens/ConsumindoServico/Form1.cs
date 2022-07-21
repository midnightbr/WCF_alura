using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ServiceReference1;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Recebendo os dados do front-end
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                // Instanciando o servico e o cliente
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clienteCadastro = new Cliente();
                
                // Atribuindo valores ao cliente
                clienteCadastro.Nome = nome;
                clienteCadastro.Cpf = cpf;
                
                // Inserindo valor na lista
                servico.Add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.Buscar(nome);
                txtCpf.Text = resultado.Cpf;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }
    }
}
