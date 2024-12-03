using System;
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

        public void AtenderAtual()// método de atendimento do paciente atual
        {
            var consulta = new Consulta();
            consulta.Show();
            consulta.AtendimentoDaFila();
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


            Nome_CPF.Text = DTG.SelectedRows[0].Cells[2].Value.ToString()+", "+DTG.SelectedRows[0].Cells[1].Value.ToString();
            CPaciente proximo = new CPaciente();
        }

        private void Atendimento1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Gravar_Click(object sender, EventArgs e)
        {
           
        }

        private void DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//botão para retirar paciente da fila de atendimento
        {
            ExcluirAtual(ID.Text);
        }

        private void AtenderFIla_Click(object sender, EventArgs e)//botão para atender novo paciente
        {
            
            AtenderAtual();

        }
    }
    }

