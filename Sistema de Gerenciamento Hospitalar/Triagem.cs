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
    public partial class Triagem : Form
    {
        public Triagem()
        {
            InitializeComponent();
        }

        private void Pesquisa_Dados_Click(object sender, EventArgs e)
        {
            //comando para que não seja pesquisados valores vazios
            if (!string.IsNullOrWhiteSpace(CPF_Pesquisar.Text) && CPF_Pesquisar.Text.Length == 14)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
                SqlCommand cmd = conn.CreateCommand();
                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM tbl_Paciente WHERE CPF_Paciente = @CPF";
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = CPF_Pesquisar.Text;
                    cmd.Connection = conn;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    DTG.DataSource = dt;


                    conn.Close();

                    try
                    {
                        Nome.Text= DTG.SelectedRows[0].Cells["Nome_Pac"].Value.ToString();
                        Gravar.Enabled = true;
                        Altura.Enabled = true;
                        Pressao.Enabled = true;
                        Temperatura.Enabled = true;
                        label7.Enabled = true;
                        Resumo.Enabled = true;
                        Prioridade.Enabled = true;
                        Peso.Enabled = true;
                        Limpa_Dados.Enabled = true;
                
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("O CPF inserido não foi encontrado em nosso cadastro. \nCertifique-se se o CPF está correto e tente novamente.", "Valor não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("O CPF que você está procurando não está correto\nCorriga e insira os dados novamente","Atenção",MessageBoxButtons.OK);
            }
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            
            CPaciente paciente = new CPaciente();
            paciente.Triagem(Nome.Text,CPF_Pesquisar.Text,Peso.Text, Altura.Text,Temperatura.Text, Pressao.Text, Resumo.Text, Prioridade.Text);

        }

        private void Peso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Limpa_Dados_Click(object sender, EventArgs e)
        {
            CPF_Pesquisar.Enabled = true;
            Nome.Text = String.Empty;
            Gravar.Text = String.Empty;
            Altura.Text = String.Empty;
            Pressao.Text = String.Empty;
            Temperatura.Text = String.Empty;
            Resumo.Text = String.Empty;
            Prioridade.Text = String.Empty;
            Peso.Text = String.Empty;
        }
    }
}
