namespace Sistema_de_Gerenciamento_Hospitalar
{
    partial class Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PainelDr = new System.Windows.Forms.Panel();
            this.CRM = new System.Windows.Forms.Label();
            this.NomeMedico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resumo = new System.Windows.Forms.TextBox();
            this.Diagnostico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tratamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Exames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gravar = new System.Windows.Forms.Button();
            this.dbHospitalDataSet1 = new Sistema_de_Gerenciamento_Hospitalar.DBHospitalDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DTG = new System.Windows.Forms.DataGridView();
            this.AtenderFIla = new System.Windows.Forms.Button();
            this.DTGM = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.TextBox();
            this.DadosPac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.PainelDr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGM)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label13.Location = new System.Drawing.Point(336, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 63);
            this.label13.TabIndex = 16;
            this.label13.Text = "Consulta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label15.Location = new System.Drawing.Point(41, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "Dados do Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(608, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Dados do Médico Responsável";
            // 
            // PainelDr
            // 
            this.PainelDr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PainelDr.Controls.Add(this.CRM);
            this.PainelDr.Controls.Add(this.NomeMedico);
            this.PainelDr.Enabled = false;
            this.PainelDr.Location = new System.Drawing.Point(611, 133);
            this.PainelDr.Name = "PainelDr";
            this.PainelDr.Size = new System.Drawing.Size(261, 60);
            this.PainelDr.TabIndex = 44;
            this.PainelDr.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelDr_Paint);
            // 
            // CRM
            // 
            this.CRM.AutoSize = true;
            this.CRM.Enabled = false;
            this.CRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.CRM.Location = new System.Drawing.Point(3, 28);
            this.CRM.Name = "CRM";
            this.CRM.Size = new System.Drawing.Size(0, 17);
            this.CRM.TabIndex = 61;
            // 
            // NomeMedico
            // 
            this.NomeMedico.AutoSize = true;
            this.NomeMedico.Enabled = false;
            this.NomeMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.NomeMedico.Location = new System.Drawing.Point(3, 5);
            this.NomeMedico.Name = "NomeMedico";
            this.NomeMedico.Size = new System.Drawing.Size(0, 17);
            this.NomeMedico.TabIndex = 60;
            this.NomeMedico.Click += new System.EventHandler(this.NomeMedico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(323, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Relato do Paciente";
            // 
            // Resumo
            // 
            this.Resumo.Enabled = false;
            this.Resumo.Location = new System.Drawing.Point(323, 183);
            this.Resumo.Multiline = true;
            this.Resumo.Name = "Resumo";
            this.Resumo.Size = new System.Drawing.Size(227, 52);
            this.Resumo.TabIndex = 3;
            // 
            // Diagnostico
            // 
            this.Diagnostico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Diagnostico.Enabled = false;
            this.Diagnostico.Location = new System.Drawing.Point(38, 318);
            this.Diagnostico.Multiline = true;
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.Size = new System.Drawing.Size(501, 79);
            this.Diagnostico.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(35, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Diagnóstico Médico";
            // 
            // Tratamento
            // 
            this.Tratamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tratamento.Enabled = false;
            this.Tratamento.Location = new System.Drawing.Point(38, 429);
            this.Tratamento.Multiline = true;
            this.Tratamento.Name = "Tratamento";
            this.Tratamento.Size = new System.Drawing.Size(501, 79);
            this.Tratamento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(35, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Plano de Tratamento";
            // 
            // Exames
            // 
            this.Exames.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Exames.Enabled = false;
            this.Exames.Location = new System.Drawing.Point(38, 541);
            this.Exames.Multiline = true;
            this.Exames.Name = "Exames";
            this.Exames.Size = new System.Drawing.Size(501, 44);
            this.Exames.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label6.Location = new System.Drawing.Point(35, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Exames Necessários";
            // 
            // Gravar
            // 
            this.Gravar.BackColor = System.Drawing.Color.White;
            this.Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gravar.Image = ((System.Drawing.Image)(resources.GetObject("Gravar.Image")));
            this.Gravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gravar.Location = new System.Drawing.Point(687, 578);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(93, 92);
            this.Gravar.TabIndex = 7;
            this.Gravar.Text = "Gravar Dados";
            this.Gravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gravar.UseVisualStyleBackColor = false;
            this.Gravar.Visible = false;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // dbHospitalDataSet1
            // 
            this.dbHospitalDataSet1.DataSetName = "DBHospitalDataSet";
            this.dbHospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label4.Location = new System.Drawing.Point(608, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Data:";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.Data.Location = new System.Drawing.Point(655, 97);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(0, 15);
            this.Data.TabIndex = 62;
            this.Data.Visible = false;
            this.Data.Layout += new System.Windows.Forms.LayoutEventHandler(this.Data_Layout);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label10.Location = new System.Drawing.Point(32, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label11.Location = new System.Drawing.Point(41, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "CPF";
            // 
            // DTG
            // 
            this.DTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DTG.Enabled = false;
            this.DTG.Location = new System.Drawing.Point(366, 334);
            this.DTG.Name = "DTG";
            this.DTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG.Size = new System.Drawing.Size(107, 52);
            this.DTG.TabIndex = 64;
            // 
            // AtenderFIla
            // 
            this.AtenderFIla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtenderFIla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtenderFIla.Image = ((System.Drawing.Image)(resources.GetObject("AtenderFIla.Image")));
            this.AtenderFIla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtenderFIla.Location = new System.Drawing.Point(641, 600);
            this.AtenderFIla.Name = "AtenderFIla";
            this.AtenderFIla.Padding = new System.Windows.Forms.Padding(14, 0, 5, 0);
            this.AtenderFIla.Size = new System.Drawing.Size(267, 70);
            this.AtenderFIla.TabIndex = 8;
            this.AtenderFIla.Text = "Atender Próximo da Fila";
            this.AtenderFIla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtenderFIla.UseVisualStyleBackColor = true;
            this.AtenderFIla.Click += new System.EventHandler(this.AtenderFIla_Click);
            // 
            // DTGM
            // 
            this.DTGM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGM.Enabled = false;
            this.DTGM.Location = new System.Drawing.Point(395, 183);
            this.DTGM.Name = "DTGM";
            this.DTGM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGM.Size = new System.Drawing.Size(107, 32);
            this.DTGM.TabIndex = 66;
            // 
            // Nome
            // 
            this.Nome.Enabled = false;
            this.Nome.Location = new System.Drawing.Point(79, 115);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(239, 20);
            this.Nome.TabIndex = 0;
            // 
            // CPF
            // 
            this.CPF.Enabled = false;
            this.CPF.Location = new System.Drawing.Point(78, 140);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(239, 20);
            this.CPF.TabIndex = 1;
            // 
            // DadosPac
            // 
            this.DadosPac.Enabled = false;
            this.DadosPac.Location = new System.Drawing.Point(78, 183);
            this.DadosPac.Multiline = true;
            this.DadosPac.Name = "DadosPac";
            this.DadosPac.Size = new System.Drawing.Size(239, 52);
            this.DadosPac.TabIndex = 2;
            this.DadosPac.TextChanged += new System.EventHandler(this.DadosPac_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label7.Location = new System.Drawing.Point(76, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 72;
            this.label7.Text = "Dados da Triagem";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.Enabled = false;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Location = new System.Drawing.Point(796, 578);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(94, 92);
            this.Cancelar.TabIndex = 73;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(920, 682);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DadosPac);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.AtenderFIla);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.Exames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Tratamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Diagnostico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PainelDr);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DTG);
            this.Controls.Add(this.DTGM);
            this.Controls.Add(this.Cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.PainelDr.ResumeLayout(false);
            this.PainelDr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PainelDr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Resumo;
        private System.Windows.Forms.TextBox Diagnostico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tratamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Exames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Gravar;
        private DBHospitalDataSet dbHospitalDataSet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DTG;
        private System.Windows.Forms.Button AtenderFIla;
        private System.Windows.Forms.Label CRM;
        private System.Windows.Forms.Label NomeMedico;
        private System.Windows.Forms.DataGridView DTGM;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.TextBox DadosPac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cancelar;
    }
}