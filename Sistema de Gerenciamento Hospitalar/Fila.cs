﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    public partial class Fila : Form
    {
        public Fila()
        {
            InitializeComponent();
        }

        public void ExcluirAtual(string id)// método de exclusão do paciente atual
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            SqlCommand cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = "DELETE FROM tbl_Fila where Id = @id";
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("O primeiro lugar da fila de atendimento foi excluído.", "Retirado da Fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public bool Consultar()
        {

            Administrador administrador = new Administrador();
            bool admin = administrador.VerificaLogin();
            Médico medico = new Médico();
            bool permissao = medico.VerificaLogin();
            if (permissao != false || admin != false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ExcluirSelecionado()// método de exclusão do paciente atual
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            SqlCommand cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = "DELETE FROM tbl_Fila where CPF_Paciente = @cpf";
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = Selecionado.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("O paciente com o CPF "+Selecionado.Text+" foi retirado da fila.", "Retirado da Fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void AtenderAtual()// método de atendimento do paciente atual
        {
            bool permitir = Consultar();
            if(permitir == true)
            {
                var consulta = new Consulta();
                consulta.Show();
                consulta.AtendimentoDaFila();
            }
            else
            {
                MessageBox.Show("Seu usuário não tem permissão para acessar a esta funcionalidade.\nCaso necessite de acesso, procure a Administração", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }

        private void Fila_Shown(object sender, EventArgs e) //método para exibir os pacientes que estão na fila
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            SqlCommand cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = "SELECT * FROM tbl_Fila ORDER BY Prioridade, Id ASC";
            cmd.Connection = conn;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DTG.DataSource = dt;
            DTG.Columns["Id"].Visible = false;
            conn.Close();

            ID.Text = DTG.SelectedRows[0].Cells["Id"].Value.ToString();
            CarregaExcluir();

            Nome_CPF.Text = DTG.SelectedRows[0].Cells[2].Value.ToString()+", "+DTG.SelectedRows[0].Cells[1].Value.ToString();
            CPaciente proximo = new CPaciente();
        }

        private void Atendimento1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void CarregaExcluir()
        {
            Selecionado.Text = DTG.SelectedRows[0].Cells["CPF_Paciente"].Value.ToString();

        }
        private void Gravar_Click(object sender, EventArgs e)
        {
           
        }

        private void DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//botão para retirar paciente da fila de atendimento
        {
            DialogResult escolha = MessageBox.Show("Deseja realmente retirar o(a) paciente "+Nome_CPF.Text+" da fila de atendimento?", "Retirar da Fila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (escolha == DialogResult.Yes)
            {
                ExcluirAtual(ID.Text);
            }
        }

        private void AtenderFIla_Click(object sender, EventArgs e)//botão para atender novo paciente
        {
            
            AtenderAtual();
        }

        private void DTG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaExcluir();
        }

        private void ExcluiSelecionado_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja realmente retirar o(a) paciente " +DTG.SelectedRows[0].Cells["Nome"].Value.ToString()+" da fila de atendimento?", "Retirar da Fila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (escolha == DialogResult.Yes)
            {
                ExcluirSelecionado();
            }
        }
    }
    }

