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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    public partial class Funcionários : Form
    {
        public Funcionários()
        {
            InitializeComponent();
        }

         //Método para enviar os dados do paciente a classe paciente para se comunicar com a seleção no banco de dados
        public void ExibeDados()
        {  //comando para que não seja pesquisados valores vazios
            if (Cargo_Pesquisar.Text == "Médico" && CPF_Pesquisar.Text.Length == 14)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
                SqlCommand cmd = conn.CreateCommand();
                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM tbl_Médico WHERE CPF_Medico = @CPF AND IsActive = 1";
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
                        CPF_Fun.Text = DTG.SelectedRows[0].Cells["CPF_Medico"].Value.ToString();
                        Nome_Fun.Text = DTG.SelectedRows[0].Cells[1].Value.ToString();
                        CRMnum.Text = DTG.SelectedRows[0].Cells[2].Value.ToString();
                        Senha.Text = DTG.SelectedRows[0].Cells[3].Value.ToString();
                        Cargo.Text = "Médico";
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
            else
            {
                //comando para que não seja pesquisados valores vazios
                if (Cargo_Pesquisar.Text == "Enfermeiro" && CPF_Pesquisar.Text.Length == 14)
                {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
                    SqlCommand cmd = conn.CreateCommand();
                    try
                    {
                        conn.Open();
                        cmd.CommandText = "SELECT * FROM tbl_Enfermeiro WHERE CPF_Enf = @CPF AND IsActive = 1";
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
                            CPF_Fun.Text = DTG.SelectedRows[0].Cells["CPF_Enf"].Value.ToString();
                            Nome_Fun.Text = DTG.SelectedRows[0].Cells[1].Value.ToString();
                            Senha.Text = DTG.SelectedRows[0].Cells[2].Value.ToString();

                            Cargo.Text = "Enfermeiro";

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
                else
                {
                    MessageBox.Show("Insira o CPF que deseja pesquisar, corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }
        //Padroniza a form para inserir novos dados
        public void Novo()
        {
            Nome_Fun.Enabled = true;
            CPF_Fun.Enabled = true;
            CRMnum.Enabled = true;
            CRMestado.Enabled = true;
            Senha.Enabled = true;
            Senha.Visible = true;
            label3.Visible = true;
            Cargo.Enabled = true;
            label_confirm.Visible = true;
            ConfirmaSenha.Visible = true;
            ConfirmaSenha.Enabled = true;
            Gravar.Enabled = true;
            Cancelar.Enabled = true;
            Visualizar.Visible = true;
            label3.Visible=true;

        }
        //Padroniza a form para alterar os dados
        public void Altera()
        {
            Nome_Fun.Enabled = true;
            CRMnum.Enabled = true;
            CRMestado.Enabled = true;
            Senha.Enabled = true;
            Senha.Visible = true;
            label_confirm.Visible = true;
            SalvarAlteração.Enabled = true;
            Cancelar.Enabled= true;
            SalvarAlteração.BringToFront();
            label_confirm.Visible=false;
            Visualizar.Visible = true;
            label3.Visible=true;

        }
        //Limpa os dados que estão nas textbox
        public void Limpa()
        {
            Nome_Fun.Text = string.Empty;
            CPF_Fun.Text= string.Empty;
            CRMnum.Text= string.Empty;
            CRMestado.Text= string.Empty;
            Senha.Text= string.Empty;
            ConfirmaSenha.Text = string.Empty;
            Cargo.Text= string.Empty;
        }
        //Padroniza a form para o que era no inicio
        public void Cancela()
        {
            Nome_Fun.Enabled = false;
            CPF_Fun.Enabled = false;
            CRMnum.Enabled = false;
            CRMestado.Enabled = false;
            Senha.Enabled = false;
            Senha.Visible = false;
            label3.Visible = false;
            Cargo.Enabled = false;
            label_confirm.Visible = false;
            ConfirmaSenha.Visible = false;
            ConfirmaSenha.Enabled = false;
            Gravar.Enabled = false;
            Alterar.Enabled = false;
            SalvarAlteração.Enabled = false;
            Cancelar.Enabled = false;
            SalvarAlteração.SendToBack();
            Excluir.Enabled = false;
            Visualizar.Visible = false;
            label3.Visible=false;


        }

        //Método para enviar os dados do paciente a classe paciente para se comunicar com a Exclusão no banco de dados
        private void ExcluirFuncionário()
        {
            DialogResult delete = MessageBox.Show("Você realmente deseja excluir estes dados? \n Os dados serão excluidos permanentemente", "Excluir Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                if (Cargo.Text == "Médico")
                {
                    Médico deletar = new Médico();
                    deletar.DeletarDados(CPF_Fun.Text);
                }
                else if (Cargo.Text == "Enfermeiro")
                {
                    Enfermeiro deletar = new Enfermeiro();
                    deletar.DeletarDados(CPF_Fun.Text);
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar os dados\n verifique a informações e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Método para enviar os dados do paciente a classe paciente para se comunicar com a atualização no banco de dados
        private void Alteração()
        {
            if (Cargo.Text == "Médico" && !string.IsNullOrWhiteSpace(CPF_Fun.Text) && !string.IsNullOrWhiteSpace(Nome_Fun.Text) && !string.IsNullOrWhiteSpace(CRMnum.Text) && !string.IsNullOrWhiteSpace(Senha.Text) && !string.IsNullOrWhiteSpace(CRMestado.Text))
            {
                Médico alterar = new Médico();
                string crm = ""+CRMnum.Text+"/"+CRMestado.Text;
                alterar.SalvarAlter(CPF_Fun.Text, Nome_Fun.Text, Senha.Text, crm);
            }
            else if (Cargo.Text == "Enfermeiro" && !string.IsNullOrWhiteSpace(CPF_Fun.Text) && !string.IsNullOrWhiteSpace(Nome_Fun.Text) &&  !string.IsNullOrWhiteSpace(Senha.Text))
            {
                Enfermeiro alterar = new Enfermeiro();
                alterar.SalvarAlter(CPF_Fun.Text, Nome_Fun.Text, Senha.Text);
            }
            else
            {
                MessageBox.Show("Não foi possível salvar seus dados\n verifique a informações e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Método para enviar os dados do paciente a classe paciente para se comunicar com a inserção no banco de dados

        private void Gravar_Click(object sender, EventArgs e)
        {

            if (Cargo.Text == "Médico" && Senha.Text.Length == 8 && CRMnum.Text.Length == 6 && !string.IsNullOrWhiteSpace(CPF_Fun.Text) && !string.IsNullOrWhiteSpace(Nome_Fun.Text) && !string.IsNullOrWhiteSpace(CRMnum.Text) && !string.IsNullOrWhiteSpace(Senha.Text) && !string.IsNullOrWhiteSpace(CRMestado.Text) && Senha.Text == ConfirmaSenha.Text)
            {
                string CRM = ""+CRMnum.Text+"/"+CRMestado.Text;
                Médico medico = new Médico();
                medico.SalvarDados(CPF_Fun.Text, Nome_Fun.Text, CRM, Senha.Text);
              



            }
            else
            {
                if (Cargo.Text == "Enfermeiro" && Senha.Text.Length == 8 && !string.IsNullOrWhiteSpace(CPF_Fun.Text) && !string.IsNullOrWhiteSpace(Nome_Fun.Text) && !string.IsNullOrWhiteSpace(Senha.Text) && Senha.Text == ConfirmaSenha.Text)
                {
                    Enfermeiro enfermeiro = new Enfermeiro();
                    enfermeiro.SalvarDados(CPF_Fun.Text, Nome_Fun.Text, Senha.Text);
                  
                }
                else
                {
                    MessageBox.Show("Os dados estão incorretos ou com informações faltando\nFaça a correção e tente novamente.", "Erro nos dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }





        }

        private void Novo_Fun_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Limpa_Dados_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void CRMnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {
            Senha.UseSystemPasswordChar = true;
        }

        private void Senha_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.SetToolTip(Senha, "As senhas devem conter oito dígitos.");
        }

        private void tooltip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            ConfirmaSenha.UseSystemPasswordChar=true;

        }

        private void CRMnum_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.SetToolTip(CRMnum, "O CRM deve conter seis dígitos");
        }

        private void ConfirmaSenha_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.SetToolTip(ConfirmaSenha, "Você deve inserir a mesma senha novamente.");
        }

        private void CRMnum_Leave(object sender, EventArgs e)
        {
            if (CRMnum.Text.Length != 6)
            {
                MessageBox.Show("O CRM está imcompleto.\nTente novamente com os dados completos.", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void Senha_Leave(object sender, EventArgs e)
        {

            if (Senha.Text.Length != 8)
            {
                MessageBox.Show("A senha está imcompleta.\nInsira os oito digitos necessários e tente novamente", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cargo.SelectedItem == "Enfermeiro")
            {
                label2.Visible = false;
                CRMnum.Visible = false;
                CRMestado.Visible = false;
            }
            else
            {
                label2.Visible = true;
                CRMnum.Visible = true;
                if (Gravar.Enabled == true)
                {
                    CRMestado.Visible = true;
                }
            }

        }

        private void DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Controls.Add(DTG);
        }

        private void Pesquisa_Dados_Click(object sender, EventArgs e)
        {
            ExibeDados();
        }

        private void Cargo_Pesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Altera();

        }

        private void SalvarAlteração_Click(object sender, EventArgs e)
        {
            Alteração();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            ExcluirFuncionário();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Cancela();
        }

        private void CRMestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CRMnum_Click(object sender, EventArgs e)
        {
            CRMestado.Visible = true;
        }

        private void Visualizar_MouseDown(object sender, MouseEventArgs e)
        {
            Senha.UseSystemPasswordChar = false;
            ConfirmaSenha.UseSystemPasswordChar=false;
        }

        private void Visualizar_MouseUp(object sender, MouseEventArgs e)
        {
            Senha.UseSystemPasswordChar = true;
            ConfirmaSenha.UseSystemPasswordChar=true;
        }

        private void Visualizar_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.SetToolTip(Visualizar, "Exibir as Senhas.");
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
