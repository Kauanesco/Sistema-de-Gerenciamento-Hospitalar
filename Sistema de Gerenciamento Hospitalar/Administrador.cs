using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento_Hospitalar
{

    public class Administrador : Pessoa
    {

        //Variáveis e acesso ao banco de dados
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
        public string Senha { get; set; }

        //Autenticação de Login
         public virtual int Autentica(string cpf, string senha)
        {
            conn.Open();
            string sql = "SELECT COUNT(*) FROM Administrador WHERE CPF = @cpf AND Senha = @senha";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);

            string ativo = "UPDATE Administrador SET Ativo = 1 WHERE CPF = @cpf";
            SqlCommand cmdi = new SqlCommand(ativo, conn);
            cmdi.Parameters.AddWithValue("@cpf", cpf);
            cmdi.ExecuteNonQuery();
            int count = (int)cmd.ExecuteScalar();
            return count;

        }

        //Garante acesso ao sistema pelo usuário administrador
        public bool Login(string cpf, string senha)
        {
            int count = Autentica(cpf, senha);

                conn.Close();
                if (count > 0)
                {
                bool LoginOk = true;
                    return LoginOk;
                }
                else
                {
                bool LoginOk = false;
                    return LoginOk;
                }

        }

        //Verifica se o usuário está logado, auxiliando no controle de permissão
        public bool VerificaLogin()
        {
          SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");

            bool User = false;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Administrador WHERE Ativo = '1'";

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
        //Garante que o usuário administrador fique com seu status inativo após a saída do sistema
        public void Sair()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            try
            {
                string ativo = "UPDATE Administrador SET Ativo = 0";
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

    public bool Ola(int a)
        {
            bool resultado;
            if(a > 0)
            {
                return resultado = true;

            }
            else
            {
                return resultado = false;
            }
        }
    }
}
