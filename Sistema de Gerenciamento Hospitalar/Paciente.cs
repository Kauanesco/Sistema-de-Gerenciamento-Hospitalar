using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    public partial class Paciente : Form
    {


        public Paciente()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBHospitalDataSet.tbl_Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_PacienteTableAdapter.Fill(this.dBHospitalDataSet.tbl_Paciente);

        }
        //Método para cancelar alterações
        public void Cancela()
        {
            Nome_Pac.Enabled = false;
            CPF_Pesquisar.Text = string.Empty;
            CPF_Pac.Enabled = false;
            Nasc_Pac.Enabled = false;
            Tel_Pac.Enabled = false;
            Sexo.Enabled = false;
            Tipo_Sangue.Enabled = false;
            GroupEnder.Visible = false;
            Rua.Enabled = false;
            Bairro.Enabled = false;
            Cidade.Enabled = false;
            CEP.Enabled = false;
            UF.Enabled = false;
            Numero.Enabled = false;
            Excluir.Enabled = false;
            Gravar.Enabled=false;
            Alterar.Enabled = false;
            Novo_Pac.Enabled = true;
            SalvarAlteração.SendToBack();
        }
        //Método para exibir os dados do paciente em um datagrid
        public void PesquisaPaciente()
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
                DTG.Columns["Pressao"].Visible = false;
                DTG.Columns["Peso"].Visible = false;
                DTG.Columns["Altura"].Visible = false;
                DTG.Columns["Resumo"].Visible = false;
                DTG.Columns["Prioridade"].Visible = false;


                conn.Close();

                try
                {
                    CPF_Pac.Text = DTG.SelectedRows[0].Cells["CPF_Paciente"].Value.ToString();
                    Nome_Pac.Text = DTG.SelectedRows[0].Cells[1].Value.ToString();
                    Nasc_Pac.Text = DTG.SelectedRows[0].Cells[2].Value.ToString();
                    Tipo_Sangue.Text = DTG.SelectedRows[0].Cells[3].Value.ToString();
                    Sexo.Text = DTG.SelectedRows[0].Cells[4].Value.ToString();
                    Endereco.Text = DTG.SelectedRows[0].Cells[11].Value.ToString();
                    Tel_Pac.Text = DTG.SelectedRows[0].Cells[5].Value.ToString();
                    Alterar.Enabled = true;
                    Excluir.Enabled = true;
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
        //Método para padronizar a forme para receber novos dados
        public void Novo()
        {
            Nome_Pac.Enabled = true;
            CPF_Pesquisar.Text = string.Empty;
            CPF_Pac.Enabled = true;
            Nasc_Pac.Enabled = true;
            Tel_Pac.Enabled = true;
            Sexo.Enabled = true;
            Endereco.Enabled = true;
            Tipo_Sangue.Enabled = true;
            Rua.Enabled = true;
            Bairro.Enabled = true;
            Cidade.Enabled = true;
            CEP.Enabled = true;
            UF.Enabled = true;
            Numero.Enabled = true;
            Gravar.Enabled = true;
            Cancelar.Enabled = true;
        }
        //Método para limpar os dados inseridos
        public void Limpa()
        {
            Nome_Pac.Text = string.Empty;
            CPF_Pesquisar.Text = string.Empty;
            CPF_Pac.Text = string.Empty;
            Nasc_Pac.Text = string.Empty;
            Tel_Pac.Text = string.Empty;
            Sexo.Text = string.Empty;
            Tipo_Sangue.Text = string.Empty;
            Rua.Text = string.Empty;
            Numero.Text = string.Empty;
            Bairro.Text = string.Empty;
            Cidade.Text = string.Empty;
            CEP.Text = string.Empty;
            UF.Text = string.Empty;
            Endereco.Text = string.Empty;

        }
        //Botão para habilitar a alteração na form
        public void Altera()
        {
            Novo_Pac.Enabled = false;
            Gravar.Enabled = true;
            Nome_Pac.Enabled = true;
            CPF_Pesquisar.Text = string.Empty;
            CPF_Pac.Enabled = false;
            Nasc_Pac.Enabled = true;
            Tel_Pac.Enabled = true;
            Rua.Enabled = true;
            Bairro.Enabled = true;
            Cidade.Enabled = true;
            CEP.Enabled = true;
            UF.Enabled = true;
            Numero.Enabled = true;
            Sexo.Enabled = true;
            Tipo_Sangue.Enabled = true;
            Endereco.Enabled = true;
            Rua.Enabled = true;
            SalvarAlteração.Enabled = true;
            Cancelar.Enabled = true;
            SalvarAlteração.BringToFront();

        }
        //Método para enviar os dados do paciente a classe paciente para se comunicar com a inserção no banco de dados
        public void GravarDados()
        {
            //Controle para que não haja a incrementação com dados em branco.
            if (!string.IsNullOrWhiteSpace(Nome_Pac.Text) && !string.IsNullOrWhiteSpace(CPF_Pac.Text) && !string.IsNullOrWhiteSpace(Nasc_Pac.Text) &&!string.IsNullOrWhiteSpace(Tel_Pac.Text) && !string.IsNullOrWhiteSpace(Sexo.Text) && !string.IsNullOrWhiteSpace(CEP.Text) && !string.IsNullOrWhiteSpace(Rua.Text) && !string.IsNullOrWhiteSpace(Numero.Text) && !string.IsNullOrWhiteSpace(Bairro.Text) && !string.IsNullOrWhiteSpace(Cidade.Text) && !string.IsNullOrWhiteSpace(UF.Text) && !string.IsNullOrWhiteSpace(Tipo_Sangue.Text))
            {



                CPaciente paciente = new CPaciente();
                paciente.SalvaDados(Nasc_Pac.Text, Nome_Pac.Text, CPF_Pac.Text, Tel_Pac.Text, Sexo.Text, Tipo_Sangue.Text, CEP.Text, Rua.Text, Bairro.Text, Cidade.Text, Numero.Text, UF.Text);

            }
            else
            {
                MessageBox.Show("Existe espaços em branco, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //Método para enviar os dados do paciente a classe paciente para se comunicar com a Exclusão no banco de dados
        public void ExcluirDados() {
            DialogResult delete = MessageBox.Show("Você realmente deseja excluir estes dados? \n Os dados serão excluidos permanentemente", "Excluir Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                CPaciente paciente = new CPaciente();
                paciente.DeletarDados(CPF_Pac.Text);
            }
        }


        //Método para enviar os dados do paciente a classe paciente para se comunicar com a inserção no banco de dados
        private void SalvarAlteração_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Nome_Pac.Text) && !string.IsNullOrWhiteSpace(CPF_Pac.Text) && !string.IsNullOrWhiteSpace(Nasc_Pac.Text) &&!string.IsNullOrWhiteSpace(Tel_Pac.Text) && !string.IsNullOrWhiteSpace(Sexo.Text) && !string.IsNullOrWhiteSpace(Endereco.Text) && !string.IsNullOrWhiteSpace(Tipo_Sangue.Text))
            {
                CPaciente paciente = new CPaciente();
                paciente.SalvarAlter(Nasc_Pac.Text, Nome_Pac.Text, CPF_Pac.Text, Tel_Pac.Text, Sexo.Text, Tipo_Sangue.Text, Endereco.Text);
            }
        }
        private void Nome_Pac_TextChanged(object sender, EventArgs e)
        {
        }

        private void CPF_Pac_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Tel_Pac_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Nasc_Pac_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Tipo_Sangue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void CEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void UF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Limpa_Dados_Click(object sender, EventArgs e)
        {
            Limpa();

        }
        private void Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Altera();

        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            GravarDados();

        }

        private void Tel_Pac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //inserção de apenas numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //inserção de apenas numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CPF_Pac_KeyPress(object sender, KeyPressEventArgs e)
        {
            //inserção de apenas numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CPF_Pesquisar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void CPF_Pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //inserção de apenas numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Pesquisa_Dados_Click(object sender, EventArgs e)
        {
            //comando para que não seja pesquisados valores vazios
            if (!string.IsNullOrWhiteSpace(CPF_Pesquisar.Text) && CPF_Pesquisar.Text.Length == 14)
            {
                PesquisaPaciente();

            }
            else
            {
                MessageBox.Show("Insira o CPF que deseja pesquisar, corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Controls.Add(DTG);


        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {
            bindingNavigator1 = BindingSource.ReferenceEquals(bindingNavigator1, null) ? null : bindingNavigator1;
            Controls.Add(bindingNavigator1);
            bindingNavigator1.Visible= false;
        }

        private void tblPacienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void DTG_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Excluir_Click(object sender, EventArgs e)
        {

            ExcluirDados();
        }

        private void GroupEnder_Enter(object sender, EventArgs e)
        {
        }
        private void Endereco_TextChanged(object sender, EventArgs e)
        {

        }
            //Passa os valores inseridos no groupbox endereço para uma textbox concatenados.
        private void GroupEnder_Leave(object sender, EventArgs e)
        {
            Endereco.Text = "Rua " + Rua.Text  + ", Nº" + Numero.Text + ", bairro "+ Bairro.Text + ", "+Cidade.Text+ " - "+UF.Text +", CEP " + CEP.Text;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Cancela();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupEnder.Visible=false;
        }

        private void Endereco_DoubleClick(object sender, EventArgs e)
        {
            GroupEnder.Visible=true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

