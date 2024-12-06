using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Sistema_de_Gerenciamento_Hospitalar
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //Métodos de controle de exibição do sistema
        public void Consultar()
        {
            var consulta = new Consulta();
            consulta.MdiParent = this;

            Administrador administrador = new Administrador();
            bool admin = administrador.VerificaLogin();
            Médico medico = new Médico();
            bool permissao = medico.VerificaLogin();
            if (permissao != false || admin != false)
            {
                Form form = Application.OpenForms.OfType<Consulta>().FirstOrDefault();
                if (form != null)
                {
                    DialogResult resultado = MessageBox.Show("Esta janela está sendo executada, deseja abrir uma nova janela?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        // Se estiver aberta, trazê-la para frente
                        form.BringToFront(); form.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        consulta.Show();
                    }
                }
                else
                {
                    consulta.Show();
                }
            }
            else
            {
                MessageBox.Show("Seu usuário não tem permissão para acessar a esta funcionalidade.\nCaso necessite de acesso, procure a Administração", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Prontuário()
        {
            var prontuarios = new Prontuários();
            prontuarios.MdiParent = this;
            Administrador administrador = new Administrador();
            bool admin = administrador.VerificaLogin();
            Médico medico = new Médico();
            bool permissao = medico.VerificaLogin();
            if (permissao != false || admin != false)
            {

                Form form = Application.OpenForms.OfType<Prontuários>().FirstOrDefault();
                if (form != null)
                {
                    DialogResult resultado = MessageBox.Show("Esta janela está sendo executada, deseja abrir uma nova janela?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        // Se estiver aberta, trazê-la para frente
                        form.BringToFront(); form.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        prontuarios.Show();
                    }
                }
                else
                {
                    prontuarios.Show();
                }
            }
            else
            {
                MessageBox.Show("Seu usuário não tem permissão para acessar a esta funcionalidade.\nCaso necessite de acesso, procure a Administração", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Pacientes()
        {
            var paciente = new Paciente();
            paciente.MdiParent = this;


            Form form = Application.OpenForms.OfType<Paciente>().FirstOrDefault();
            if (form != null)
            {
                DialogResult resultado = MessageBox.Show("Esta janela está sendo executada, deseja abrir uma nova janela?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    // Se estiver aberta, trazê-la para frente
                    form.BringToFront(); form.WindowState = FormWindowState.Normal;
                }
                else
                {
                    paciente.Show();
                }
            }
            else
            {
                paciente.Show();
            }

        }
        public void Funcionario()
        {
            var funcionario = new Funcionários();
            funcionario.MdiParent = this;

            Administrador administrador = new Administrador();
            bool admin = administrador.VerificaLogin();
            if (admin != false)
            {
                Form form = Application.OpenForms.OfType<Funcionários>().FirstOrDefault();
                if (form != null)
                {
                    DialogResult resultado = MessageBox.Show("Esta janela está sendo executada, deseja abrir uma nova janela?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        // Se estiver aberta, trazê-la para frente
                        form.BringToFront(); form.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        funcionario.Show();
                    }
                }
                else
                {
                    funcionario.Show();
                }
            }
            else
            {
                MessageBox.Show("Seu usuário não tem permissão para acessar a esta funcionalidade.\nCaso necessite de acesso, procure a Administração", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Triagens()
        {
            var triagem = new Triagem();
            triagem.MdiParent = this;


            Form form = Application.OpenForms.OfType<Triagem>().FirstOrDefault();
            if (form != null)
            {
                DialogResult resultado = MessageBox.Show("Esta janela está sendo executada, deseja abrir uma nova janela?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    // Se estiver aberta, trazê-la para frente
                    form.BringToFront(); form.WindowState = FormWindowState.Normal;
                }
                else
                {
                    triagem.Show();
                }
            }
            else
            {
                triagem.Show();
            }
        }
        public void Filas()
        {
            var fila = new Fila();
            fila.MdiParent = this;


            Form form = Application.OpenForms.OfType<Fila>().FirstOrDefault();
            if (form != null)
            {
                DialogResult resultado = MessageBox.Show("Esta janela está sendo executada, deseja abrir uma nova janela?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    // Se estiver aberta, trazê-la para frente
                    form.BringToFront(); form.WindowState = FormWindowState.Normal;
                }
                else
                {
                    fila.Show();
                }
            }
            else
            {
                fila.Show();
            }
        }
        public void fecharsistema()
        {
            Médico medico = new Médico();
            medico.Sair();
            Administrador administrador = new Administrador();
            administrador.Sair();
        }

        // fecha sistema
        private void Fechar_Programa_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //verificar se o usuário deseja realmente fechar o sistema.
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Você realmente deseja fechar o programa?", "Fechar Execução", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                fecharsistema();
                Application.Exit();

            }
            else
            {
                e.Cancel = true;
            }
        }
        private void Form_Paciente_Click(object sender, EventArgs e)
        {
            Pacientes();

        }

        public void Form_Funcionários_Click(object sender, EventArgs e)
        {
            Funcionario();
        }

        internal void Form_Funcionários_Click()
        {
            throw new NotImplementedException();
        }

        private void Form_Triagem_Click(object sender, EventArgs e)
        {
            Triagens();
        }

        private void Form_Fila_Click(object sender, EventArgs e)
        {
            Filas();
        }

        private void Form_Consulta_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Form_Prontuários_Click(object sender, EventArgs e)
        {
            Prontuário();
        }

    }

}



