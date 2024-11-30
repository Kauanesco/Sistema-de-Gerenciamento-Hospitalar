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



      

   

        private void DTG_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Fila_Shown(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIH0C4I\\SQLEXPRESS01;integrated security=SSPI;Initial Catalog=DBHospital");
            SqlCommand cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = "SELECT * FROM tbl_Fila ORDER BY Prioridade";
            cmd.Connection = conn;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DTG.DataSource = dt;
            DTG.Columns["Id"].Visible = false;
            conn.Close();

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
    }
    }

