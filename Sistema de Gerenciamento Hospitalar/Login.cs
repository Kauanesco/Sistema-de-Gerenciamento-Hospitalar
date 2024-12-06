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
                MessageBox.Show("Os dados inseridos estão incorretos.\nInsira corretamente e tente novamente.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Acesso Médico

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
                MessageBox.Show("Os dados inseridos estão incorretos.\nInsira corretamente e tente novamente.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Acesso Enfermeiro

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
                MessageBox.Show("Os dados inseridos estão incorretos.\nInsira corretamente e tente novamente.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Acesso Administrador

        private void Entrar_Click(object sender, EventArgs e)//verifica os perfis dos valores que estão inseridos e valida que não foi inserido nenhum valor em branco
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

        public void Senha_TextChanged(object sender, EventArgs e)//os valores inseridos estão com caracteres de proteção de senha
        {
            Senha.UseSystemPasswordChar = true;
        }

        private void CPF_KeyPress(object sender, KeyPressEventArgs e) //apenas números na inserção
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Senha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Sair_Click(object sender, EventArgs e)//Botão sair
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Visualizar_MouseDown(object sender, MouseEventArgs e)//visualizar senha com caracteres originais
        {
            Senha.UseSystemPasswordChar = false;
        }

        private void Visualizar_MouseUp(object sender, MouseEventArgs e)//os valores inseridos estão com caracteres de proteção de senha
        {
            Senha.UseSystemPasswordChar = true;

        }

        private void Visualizar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(Senha, "Exibe os valores contidos na senha"); //exibe senha
        }

        public void Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
