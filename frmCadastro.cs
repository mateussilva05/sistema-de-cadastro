using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        public class Pessoa
        {
            private string nome, idade, cpf, rg, celular;

            public void registroNome(string nome)
            {
                this.nome = nome;
            }

            public string mostraNome()
            {
                return nome;
            }

            public void registroIdade(string idade)
            {
                this.idade = idade;
            }

            public string mostraIdade()
            {
                return idade;
            }

            public void registroCpf(string cpf)
            {
                this.cpf = cpf;
            }

            public string mostraCpf()
            {
                return cpf;
            }

            public void registroRg(string rg)
            {
                this.rg = rg;
            }

            public string mostraRg()
            {
                return rg;
            }

            public void registroCelular(string celular)
            {
                this.celular = celular;
            }

            public string mostraCelular()
            {
                return celular;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.registroNome(txtNome.Text);
            pessoa.registroIdade(txtIdade.Text);
            pessoa.registroCpf(txtCpf.Text);
            pessoa.registroRg(txtRg.Text);
            pessoa.registroCelular(txtCelular.Text);

            txtRegistro.Text += pessoa.mostraNome() + "\t";
            txtRegistro.Text += pessoa.mostraIdade() + "\t";
            txtRegistro.Text += pessoa.mostraCpf() + "\t";
            txtRegistro.Text += pessoa.mostraRg() + "\t" ;
            txtRegistro.Text += pessoa.mostraCelular() + "\r\n";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtCelular.Text = "";
        }
    }
}
