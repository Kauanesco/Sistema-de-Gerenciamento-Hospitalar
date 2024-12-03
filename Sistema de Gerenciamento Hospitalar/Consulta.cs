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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        //grava o horário de atendimento
        public void Horario()
        {
            DateTime dataHoraAtual = DateTime.Now;
            Data.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public void AtendimentoDaFila()
        {
            AtenderFIla.PerformClick();
        }

        //Exibe os dados do médico
        public void DadosDr()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
                SqlCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = "SELECT * FROM tbl_Médico WHERE Ativo = 1";
                cmd.Connection = conn;
                SqlDataAdapter adapt = new SqlDataAdapter();
                DataTable dt = new DataTable();

                adapt.SelectCommand = cmd;
                adapt.Fill(dt);
                DTGM.DataSource = dt;
                conn.Close();

                NomeMedico.Text = "DR(a). "+ DTGM.SelectedRows[0].Cells[1].Value.ToString();
                CRM.Text = "CRM: "+ DTGM.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(""+erro);
            }
        }

        //Atende o próximo da fila
        public string Proximo()
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT * FROM tbl_Fila ORDER BY Prioridade ASC";
            cmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DTG.DataSource = dt;
            conn.Close();

            string proximo = DTG.SelectedRows[0].Cells["CPF_Paciente"].Value.ToString();
            return proximo;


        }

        //Exibe os dados do paciente
        public void Dados()
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            SqlCommand cmd = conn.CreateCommand();
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM tbl_Paciente WHERE CPF_Paciente = @CPF";
                string CPF_Proximo = Proximo();
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = CPF_Proximo;
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                DTG.DataSource = dt;
                conn.Close();


                CPF.Text = DTG.SelectedRows[0].Cells["CPF_Paciente"].Value.ToString();
                Nome.Text = DTG.SelectedRows[0].Cells[1].Value.ToString();
                DadosPac.Text = "Sexo: "+ DTG.SelectedRows[0].Cells["Sexo"].Value.ToString()+"" +
                    "\nTipo Sanguineo: "+DTG.SelectedRows[0].Cells["TipoSanguineo"].Value.ToString()+
                    "\n Altura: "+DTG.SelectedRows[0].Cells["Altura"].Value.ToString()+
                    "\n Peso: "+DTG.SelectedRows[0].Cells["Peso"].Value.ToString()+
                    "\nTemperatura: "+DTG.SelectedRows[0].Cells["Temperatura"].Value.ToString()+
                    "\nPressão: "+DTG.SelectedRows[0].Cells["Pressao"].Value.ToString();
                Resumo.Text = DTG.SelectedRows[0].Cells["Resumo"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex, "Valor não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            finally
            {
                conn.Close();
            }
        }

        //Formata a form para receber dados
        public void ProximoFila()
        {
            Gravar.Enabled = true;
            Gravar.Visible = true;
            Cancelar.Enabled = true;
            Diagnostico.Enabled = true;
            Exames.Enabled = true;
            Tratamento.Enabled = true;
            AtenderFIla.Visible = false;
            Data.Visible = true;
            PainelDr.Visible=true;
            Cancelar.Visible = true;
        }

        public void Cancela()
        {
            Diagnostico.Enabled=false;
            Diagnostico.Text = string.Empty;
            Tratamento.Enabled=false;
            Tratamento.Text = string.Empty;
            Exames.Enabled=false;
            Exames.Text = string.Empty;
            Gravar.Enabled=false;
            Gravar.Visible=false;
            Cancelar.Visible = false;
            AtenderFIla.Visible=true;
            Nome.Text = string.Empty;
            CPF.Text = string.Empty;
            Diagnostico.Text= string.Empty;
            Tratamento.Text= string.Empty;
            Exames.Text= string.Empty;
            Data.Text = string.Empty;
            PainelDr.Visible=false;
            DadosPac.Text= string.Empty;
            Resumo.Text = string.Empty;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            Horario();
        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void Data_Layout(object sender, LayoutEventArgs e)
        {

        }

        //Formata a form para atendimento, liberando as textbox
        private void AtenderFIla_Click(object sender, EventArgs e)
        {
            ProximoFila();
            Dados();
            DadosDr();
        }

        private void PainelDados_Paint(object sender, PaintEventArgs e)
        {

        }

        //Grava os dados inseridos
        private void Gravar_Click(object sender, EventArgs e)
        {
            string medico = NomeMedico.Text+ ", "+CRM.Text;
            CPaciente paciente = new CPaciente();
            paciente.SalvarProntuário(Nome.Text, CPF.Text, Data.Text, Diagnostico.Text, Tratamento.Text, Exames.Text, DadosPac.Text, medico);
            paciente.RetiraFila(CPF.Text);
        }


        private void NomeMedico_Click(object sender, EventArgs e)
        {

        }

        private void DadosPac_TextChanged(object sender, EventArgs e)
        {

        }

        private void PainelDr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Cancela();
        }

        private void Resumo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
