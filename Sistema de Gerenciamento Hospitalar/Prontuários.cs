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

namespace Sistema_de_Gerenciamento_Hospitalar
{
    public partial class Prontuários : Form
    {
        public Prontuários()
        {
            InitializeComponent();
        }

        //Método para pesquisar os dados do prontuário
        public void Pesquisando()
        {  //comando para que não seja pesquisados valores vazios
            if (!string.IsNullOrWhiteSpace(CPF_Pesquisar.Text) && CPF_Pesquisar.Text.Length == 14)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
                SqlCommand cmd = conn.CreateCommand();
                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM tbl_Prontuario WHERE CPF_Paciente = @CPF";
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = CPF_Pesquisar.Text;
                    cmd.Connection = conn;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    DTG.DataSource = dt;


                    conn.Close();
                    carregadados();

                }
                catch (Exception)
                {
                    MessageBox.Show("CPF não encontrado. Tente Novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //Método para exibir os dados dos pacientes
        public void carregadados()
        {
            Nome.Text = DTG.SelectedRows[0].Cells["Nome_Paciente"].Value.ToString();
            Prontuario.Text = "Número do Prontuário: "+DTG.SelectedRows[0].Cells["ID"].Value.ToString();
            Data_Atendimento.Text = "Data de Atendimento: "+DTG.SelectedRows[0].Cells["DataHora"].Value.ToString();
            Diagnóstico.Text = DTG.SelectedRows[0].Cells["Diagnostico"].Value.ToString();
            Tratamento.Text = DTG.SelectedRows[0].Cells["Tratamento"].Value.ToString();
            Exames.Text = DTG.SelectedRows[0].Cells["Exames"].Value.ToString();
            Triagem.Text = DTG.SelectedRows[0].Cells["Triagem"].Value.ToString();
            Dados_Doutor.Text = DTG.SelectedRows[0].Cells["Medico"].Value.ToString();
        }

        private void Prontuários_Load(object sender, EventArgs e)
        {

        }

        private void DTG_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregadados();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            Pesquisando();
        }

        private void DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
