using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    internal class Enfermeiro
    {
        //Variaveis e conexão do banco de dados
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
        Pessoa pessoa = new Pessoa();
        public string Senha { get; set; }


        public Enfermeiro(string senha)
        {
            Senha = senha;
        }

        public Enfermeiro()
        {
        }

        public int VerificaCadastro(string cpf)            //verifica se o CPF que está sendo inserido não esta cadastrado no banco de dados
        {
            string verificaDB = "SELECT COUNT(*) FROM tbl_Enfermeiro WHERE CPF_Enf = @CPF AND IsActive = 1";
            SqlCommand cmdV = new SqlCommand(verificaDB, conn);
            cmdV.Parameters.AddWithValue("@CPF", cpf);
            conn.Open();
            int count = (int)cmdV.ExecuteScalar();
            conn.Close();
            return count;

        }
        public void SalvarDados(string cpf, string nome, string senha)        //Grava os dados cadastrais de um enfermeiro em um banco de dados

        {
            pessoa.Nome=nome;
            pessoa.CPF=cpf;
            this.Senha = senha;

            try
            {
               int count = VerificaCadastro(cpf);
                if (count > 0)//caso estiver cadastrado, é exibido a mensagem de erro.
                {
                    MessageBox.Show("Este CPF já está cadastrado, não é possível fazer um novo cadastro no mesmo CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else                    //caso o CPF inserido não estiver cadastrado, o cadastro é gravado.
                {
                    string sql = "INSERT into tbl_Enfermeiro(CPF_Enf, Nome, Senha) values (@ncpf, @nome, @senha)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
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

        public void SalvarAlter(string cpf, string nome, string senha)        //salvar alterações de dados de um usuário enfermeiro

        {

            pessoa.Nome= nome;
            pessoa.CPF= cpf;
            this.Senha = senha;


            try
            {
                string sql = "UPDATE tbl_Enfermeiro SET Nome = @nome, Senha = @senha WHERE CPF_Enf = @ncpf AND IsActive = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados inseridos foram Alterados", "Alteração Completa", MessageBoxButtons.OK);
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

        public void DeletarDados(string cpf)        //Exclusão dos dados cadastrais de um enfermeiro

        {
            try
            {
                conn.Open();
                string sql = "UPDATE tbl_Enfermeiro SET IsActive = 0 where CPF_Enf = @cpf AND IsActive = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados do CPF "+ cpf +" foram excluidos permanentemente.", "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool Login(string cpf, string senha)        //Método para conferir os dados do usuário enfermeiro em comparação as informações do banco de dados

        {
            pessoa.CPF = cpf;
            this.Senha= senha;
            bool LoginOk = false;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM tbl_Enfermeiro WHERE CPF_Enf = @cpf AND Senha = @senha AND IsActive = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);
                

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    LoginOk = true;
                }
                else
                {
                    LoginOk = false;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conn.Close();
            }
            return LoginOk;
        }


    }
}
