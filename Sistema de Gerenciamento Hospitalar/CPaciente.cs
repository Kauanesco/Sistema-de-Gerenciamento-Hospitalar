using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento_Hospitalar
{
    internal class CPaciente : Pessoa
    {
        //Variáveis e conexão com banco de dados
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");

        Pessoa pessoa = new Pessoa();
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string TipoSangue { get; set; }
        public string Nascimento { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }

        //informações que serão preenchidas na triagem
        public string Pressao { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Temperatura { get; set; }
        public string ResumoPac { get; set; }
        public int Prioridade { get; set; }


        public int VerificaCadastro(string cpf)            //verifica se o CPF que está sendo inserido não esta cadastrado no banco de dados

        {
            string verificaDB = "SELECT COUNT(*) FROM tbl_Paciente WHERE CPF_Paciente = @CPF";
            SqlCommand cmdV = new SqlCommand(verificaDB, conn);
            cmdV.Parameters.AddWithValue("@CPF", cpf);
            conn.Open();
            int count = (int)cmdV.ExecuteScalar();
            return count;
        }


        //método para salvar os dados de cadastro dos pacientes.
        public void SalvaDados(string nascimento, string nome, string cpf, string telefone, string sexo, string tiposangue, string cep, string rua, string bairro, string cidade, string numero, string estado)
        {

            pessoa.Nome= nome;
            pessoa.CPF = cpf;
            this.Nascimento = nascimento;
            this.Telefone = telefone;
            this.Sexo = sexo;
            this.TipoSangue = tiposangue;
            this.Cep = cep;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Numero = numero;
            this.Estado = estado;

            //montagem da variavel endereço com as informações colhidas no formulário
            string endereco = "Rua " + rua  + ", Nº" + numero + ", bairro "+ bairro + ", "+cidade+ " - "+estado +", CEP" +cep;



            try

            {
                int count = VerificaCadastro(cpf);
                conn.Close();
                if (count > 0)//caso estiver cadastrado, é exibido a mensagem de erro.
                {
                    MessageBox.Show("Este CPF já está cadastrado, não é possível fazer um novo cadastro no mesmo CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    //caso o CPF inserido não estiver cadastrado, o cadastro é gravado.
                    string sql = "INSERT into tbl_Paciente(CPF_Paciente, Nome_Pac, Nascimento, Endereco, Telefone, Sexo, TipoSanguineo) values (@ncpf, @nome, @nascimento, @endereco, @telefone, @sexo, @sangue)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
                    cmd.Parameters.Add("@nascimento", SqlDbType.VarChar).Value = nascimento;
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                    cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
                    cmd.Parameters.Add("@sangue", SqlDbType.VarChar).Value = tiposangue;
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
        
        //Salva as alterações cadastrais dos pacientes
        public void SalvarAlter(string nascimento, string nome, string cpf, string telefone, string sexo, string tiposangue, string endereco)
        {

            pessoa.Nome= nome;
            this.Nascimento = nascimento;
            this.Telefone = telefone;
            this.Sexo = sexo;
            this.TipoSangue = tiposangue;



            try
            {
                string sql = "UPDATE tbl_Paciente SET Nome_Pac = @nome, Nascimento = @nascimento, TipoSanguineo = @sangue, Sexo = @sexo, Endereco = @endereco, Telefone = @telefone WHERE CPF_Paciente = @ncpf";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
                cmd.Parameters.Add("@nascimento", SqlDbType.VarChar).Value = nascimento;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
                cmd.Parameters.Add("@sangue", SqlDbType.VarChar).Value = tiposangue;
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
        //Exclusão dos dados de um paciente
        public void DeletarDados(string cpf)
        {
            
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM tbl_Prontuario WHERE CPF_Paciente = @cpf";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                    cmd.ExecuteNonQuery();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Não é possível concluir a operação de exclusão.\nO paciente tem prontuários registrados.", "Operação Negada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();

                    }
                    else
                    {
                        try
                        {
                            string cm = "DELETE FROM tbl_Paciente WHERE CPF_Paciente = @ncpf";
                            SqlCommand cmdi = new SqlCommand(cm, conn);
                            cmdi.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                            cmdi.ExecuteNonQuery();
                            MessageBox.Show("Os dados do CPF "+ cpf +" foram excluidos permanentemente.", "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        }
                        catch (Exception erro) { MessageBox.Show("Não é possível concluir a operação de exclusão.\nO paciente está registrado na fila de atendimento no momento.", "Operação Negada", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

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
        //Gravação dos dados da triagem, armazenando as informações no banco de dados
        public void Triagem(string nome, string cpf, string peso, string altura, string temperatura, string pressao, string resumo, int prioridade)
        {
            pessoa.Nome = nome;
            pessoa.CPF = cpf;
            this.Peso = peso;
            this.Altura = altura;
            this.Temperatura = temperatura;
            this.Pressao = pressao;
            this.ResumoPac = resumo;
            this.Prioridade = prioridade;


            try
            {
               
                    string verificaDB = "SELECT COUNT(*) FROM tbl_Fila WHERE CPF_Paciente = @CPF";
                    SqlCommand cmdV = new SqlCommand(verificaDB, conn);
                    cmdV.Parameters.AddWithValue("@CPF", cpf);
                    conn.Open();
                    int count = (int)cmdV.ExecuteScalar();
                conn.Close();
                if (count > 0)
                {
                    MessageBox.Show("O paciente já está inserido na fila de atendimento.", "Paciente na fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string sql = "UPDATE tbl_Paciente SET Peso = @peso, Altura = @altura, Pressao = @pressao, Temperatura = @temperatura, Resumo = @resumo, Prioridade = @prioridade WHERE CPF_Paciente = @ncpf";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                    cmd.Parameters.Add("@peso", SqlDbType.VarChar).Value = peso;
                    cmd.Parameters.Add("@altura", SqlDbType.VarChar).Value = altura;
                    cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = temperatura;
                    cmd.Parameters.Add("@pressao", SqlDbType.VarChar).Value = pressao;
                    cmd.Parameters.Add("@resumo", SqlDbType.VarChar).Value = resumo;
                    cmd.Parameters.Add("@prioridade", SqlDbType.VarChar).Value = prioridade;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados inseridos foram Salvos", "Dados da triagem Salvos", MessageBoxButtons.OK);
                    conn.Close();

                    string fila = "INSERT INTO tbl_Fila (CPF_Paciente, Nome, Prioridade) values (@ncpf, @nome, @prioridade) "; 
                    SqlCommand cm = new SqlCommand(fila, conn);
                    conn.Open();
                    cm.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@prioridade", SqlDbType.VarChar).Value = prioridade;
                    cm.ExecuteNonQuery();
                    conn.Close();



                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro: "+erro);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }




        }

        //Método para que, após o atendimento ser concluido, o paciente ser retirado da fila de espera de atendimento.
        public void RetiraFila(string cpf)
        {
            
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM tbl_Fila WHERE CPF_Paciente = @cpf";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados do cpf"+cpf+"Foram retirados da fila", "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conn.Close();
                }
            
        }
        //Gravação dos dados da consulta, com os dados do paciente e da triagem
    public void SalvarProntuário(string nome, string cpf, string data, string diagnostico, string tratamento, string exames, string triagem, string dadosmedico) 
        {
            this.Nome = nome;
            this.CPF = cpf;
            string Hora = data;
            string Diagnostico = diagnostico;
            string Tratamento = tratamento;
            string Exames = exames;
            string Triagem = triagem;
            string DadosMedicos = dadosmedico;

            try

            {   
                
                    //caso o CPF inserido não estiver cadastrado, o cadastro é gravado.
                    string sql = "INSERT into tbl_Prontuario(CPF_Paciente, Nome_Paciente, DataHora, Diagnostico, Tratamento, Exames, Triagem, Medico) values (@ncpf, @nome, @data, @diagnostico, @tratamento, @exames, @triagem, @medico)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@ncpf", SqlDbType.VarChar).Value = cpf;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
                     cmd.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = diagnostico;
                    cmd.Parameters.Add("@tratamento", SqlDbType.VarChar).Value = tratamento;
                    cmd.Parameters.Add("@exames", SqlDbType.VarChar).Value = exames;
                    cmd.Parameters.Add("@triagem", SqlDbType.VarChar).Value = triagem;
                    cmd.Parameters.Add("@medico", SqlDbType.VarChar).Value = dadosmedico;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados inseridos foram Salvos", "Salvamento Completo", MessageBoxButtons.OK);

                
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
    }


}
