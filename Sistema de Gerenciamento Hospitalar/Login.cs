using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //confirmação de dados do médico
        public void EntraMedico()
        {
            Médico medico = new Médico();
            bool retorno = medico.Login(CPF.Text, Senha.Text);
            if (retorno == true)
            {
                var menu = new Menu();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Senha incorreta.");
            }
        }

        //confirmação de dados do enfermeiro
        public void EntraEnfermeiro()
        {
            Enfermeiro enfermeiro = new Enfermeiro();
            bool retorno = enfermeiro.Login(CPF.Text, Senha.Text);
            if (retorno == true)
            {
                var menu = new Menu();
                menu.Show();
                this.Visible = false;


            }
            else
            {
                MessageBox.Show("Senha incorreta.");
            }
        }
        public void EntraAdministrador()
        {
            Administrador administrador = new Administrador();
            bool retorno = administrador.Login(CPF.Text, Senha.Text);
            if (retorno == true)
            {
                var menu = new Menu();
                menu.Show();
                this.Visible = false;


            }
            else
            {
                MessageBox.Show("Senha incorreta.");
            }
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CPF.Text) && !string.IsNullOrWhiteSpace(Senha.Text) && Cargo.Text == "Médico")
            {
                EntraMedico();

            }
            else if (!string.IsNullOrWhiteSpace(CPF.Text) && !string.IsNullOrWhiteSpace(Senha.Text) && Cargo.Text == "Enfermeiro")
            {
                EntraEnfermeiro();  
            }
            else if (!string.IsNullOrWhiteSpace(CPF.Text) && !string.IsNullOrWhiteSpace(Senha.Text) && Cargo.Text == "Administrador")
            {
                EntraAdministrador();

            }
            else
            {
                MessageBox.Show("Preencha todos os dados e tente novamente", "Valores Incorretos", MessageBoxButtons.OK);
            }
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Senha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
