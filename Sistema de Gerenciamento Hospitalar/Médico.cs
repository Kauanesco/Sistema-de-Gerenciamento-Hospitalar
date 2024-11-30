using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    internal class Médico
    {
        //Variaveis e conexão com banco de dados
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
        Pessoa pessoa = new Pessoa();
        public String CRM { get; set; }
        public string Senha { get; set; }

        public Médico(string cRM, string senha)
        {
            CRM=cRM;
            Senha=senha;
        }

        public Médico()
        {
        }
        //Gravação dos dados cadastrais do perfil médico
        public void SalvarDados(string cpf, string nome, string crm, string senha)
        {
            pessoa.Nome=nome;
            pessoa.CPF=cpf;
            this.CRM = crm;
            this.Senha = senha;

            try

            {   //verifica se o CPF que está sendo inserido não esta cadastrado no banco de dados
                string verificaDB = "SELECT COUNT(*) FROM tbl_Médico WHERE CPF_Medico = @CPF AND IsActive = 1";
                SqlCommand cmdV = new SqlCommand(verificaDB, conn);
                cmdV.Parameters.AddWithValue("@CPF", cpf);
                conn.Open();
                int count = (int)cmdV.ExecuteScalar();
                conn.Close();
                if (count > 0)//caso estiver cadastrado, é exibido a mensagem de erro.
                {
                    MessageBox.Show("Este CPF já está cadastrado, não é possível fazer um novo cadastro no mesmo CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    //caso o CPF inserido não estiver cadastrado, o cadastro é gravado.
                    string sql = "INSERT into tbl_Médico(CPF_Medico, Nome_Med, CRM, Senha, IsActive) values (@ncpf, @nome, @crm, @senha, @isactive)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@crm", SqlDbType.VarChar).Value = crm;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cmd.Parameters.Add("@isactive", SqlDbType.VarChar).Value = 1;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados inseridos foram Salvos", "Salvamento Completo", MessageBoxButtons.OK);

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
        //Alteração do cadastro médico
        public void SalvarAlter(string cpf, string nome, string senha, string crm)
        {

            pessoa.Nome= nome;
            pessoa.CPF= cpf;
            this.Senha = senha;
            this.CRM  =crm;


            try
            {
                string sql = "UPDATE tbl_Médico SET Nome_Med = @nome, Senha = @senha, CRM = @crm WHERE CPF_Medico = @ncpf AND IsActive = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                cmd.Parameters.Add("@crm", SqlDbType.VarChar).Value = crm;

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados inseridos foram Alterados", "Alteração Completa", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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
        //Exclusão do cadastro médico
        public void DeletarDados(string cpf)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE tbl_Médico SET IsActive = 0 where CPF_Medico = @cpf AND IsActive = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados do CPF "+ cpf +" foram inativados no sistema.", "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Este CPF já não está ativo no sistema, não há informações para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }
        //Método que faz a conferencia dos dados do médico com o cadastrado no banco de dados.
        public bool Login(string cpf, string senha)
        {
            pessoa.CPF = cpf;
            this.Senha= senha;
            bool LoginOk = false;

            conn.Open();
            string sql = "SELECT COUNT(*) FROM tbl_Médico WHERE CPF_Medico = @cpf AND Senha = @senha AND IsActive = 1";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            //Informa que o usuário está ativo.
            string ativo = "UPDATE tbl_Médico SET Ativo = 1 WHERE CPF_Medico = @cpf";
            SqlCommand cmdi = new SqlCommand(ativo, conn);
            cmdi.Parameters.AddWithValue("@cpf", cpf);
            cmdi.ExecuteNonQuery();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                LoginOk = true;
                return LoginOk;
            }
            else
            {
                LoginOk = false;
                return LoginOk;
            }
        }
        //Método que informa o grau de permissão do médico
        public bool VerificaLogin()
        {

            bool User = false;
            try
            {

                conn.Open ();
                string sql = "SELECT COUNT(*) FROM tbl_Médico WHERE Ativo = '1' AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        User = true;
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return User;
        }

        //Método para inativar o usuário para consultas.
        public void Sair()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            try
            {
                string ativo = "UPDATE tbl_Médico SET Ativo = 0";
                conn.Open();
                SqlCommand cmdi = new SqlCommand(ativo, conn);
                cmdi.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                conn.Close();

            }
            Application.Exit();
        }

    }

}
