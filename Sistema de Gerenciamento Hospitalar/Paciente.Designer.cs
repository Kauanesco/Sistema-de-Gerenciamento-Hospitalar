namespace Sistema_de_Gerenciamento_Hospitalar
{
    partial class Paciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Nome_Pac = new System.Windows.Forms.TextBox();
            this.dBHospitalDataSet = new Sistema_de_Gerenciamento_Hospitalar.DBHospitalDataSet();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.UF = new System.Windows.Forms.ComboBox();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.Tipo_Sangue = new System.Windows.Forms.ComboBox();
            this.CPF_Pesquisar = new System.Windows.Forms.MaskedTextBox();
            this.Nasc_Pac = new System.Windows.Forms.MaskedTextBox();
            this.Tel_Pac = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.MaskedTextBox();
            this.Pesquisa_Dados = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Novo_Pac = new System.Windows.Forms.Button();
            this.CPF_Pac = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Gravar = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpa_Dados = new System.Windows.Forms.Button();
            this.DTG = new System.Windows.Forms.DataGridView();
            this.tblPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PacienteTableAdapter = new Sistema_de_Gerenciamento_Hospitalar.DBHospitalDataSetTableAdapters.tbl_PacienteTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Rua = new System.Windows.Forms.TextBox();
            this.SalvarAlteração = new System.Windows.Forms.Button();
            this.GroupEnder = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBHospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.GroupEnder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(48, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label4.Location = new System.Drawing.Point(47, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Sanguíneo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(432, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label6.Location = new System.Drawing.Point(48, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label7.Location = new System.Drawing.Point(352, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data de Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label8.Location = new System.Drawing.Point(48, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "CPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label9.Location = new System.Drawing.Point(8, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label10.Location = new System.Drawing.Point(449, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "N°";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label11.Location = new System.Drawing.Point(371, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Estado";
            // 
            // Nome_Pac
            // 
            this.Nome_Pac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nome_Pac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nome_Pac.Enabled = false;
            this.Nome_Pac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Pac.Location = new System.Drawing.Point(115, 293);
            this.Nome_Pac.Name = "Nome_Pac";
            this.Nome_Pac.Size = new System.Drawing.Size(533, 20);
            this.Nome_Pac.TabIndex = 2;
            this.Nome_Pac.TextChanged += new System.EventHandler(this.Nome_Pac_TextChanged);
            // 
            // dBHospitalDataSet
            // 
            this.dBHospitalDataSet.DataSetName = "DBHospitalDataSet";
            this.dBHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Numero
            // 
            this.Numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Numero.Enabled = false;
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(487, 25);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(121, 20);
            this.Numero.TabIndex = 9;
            this.Numero.TextChanged += new System.EventHandler(this.Numero_TextChanged);
            this.Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // Bairro
            // 
            this.Bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Bairro.Enabled = false;
            this.Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro.Location = new System.Drawing.Point(75, 51);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(368, 20);
            this.Bairro.TabIndex = 10;
            this.Bairro.TextChanged += new System.EventHandler(this.Bairro_TextChanged);
            // 
            // Cidade
            // 
            this.Cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cidade.Enabled = false;
            this.Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.Location = new System.Drawing.Point(87, 77);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(278, 20);
            this.Cidade.TabIndex = 12;
            this.Cidade.TextChanged += new System.EventHandler(this.Cidade_TextChanged);
            // 
            // UF
            // 
            this.UF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UF.Enabled = false;
            this.UF.FormattingEnabled = true;
            this.UF.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia - BA",
            "Ceará - CE",
            "Distrito Federal - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE"});
            this.UF.Location = new System.Drawing.Point(450, 77);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(158, 21);
            this.UF.TabIndex = 13;
            this.UF.SelectedIndexChanged += new System.EventHandler(this.UF_SelectedIndexChanged);
            // 
            // Sexo
            // 
            this.Sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexo.Enabled = false;
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.Sexo.Location = new System.Drawing.Point(493, 347);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(155, 21);
            this.Sexo.TabIndex = 6;
            this.Sexo.SelectedIndexChanged += new System.EventHandler(this.Sexo_SelectedIndexChanged);
            // 
            // Tipo_Sangue
            // 
            this.Tipo_Sangue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tipo_Sangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_Sangue.Enabled = false;
            this.Tipo_Sangue.FormattingEnabled = true;
            this.Tipo_Sangue.Items.AddRange(new object[] {
            "",
            "A+ ",
            "A- ",
            "B+ ",
            "B- ",
            "AB+ ",
            "AB- ",
            "O+ ",
            "O-"});
            this.Tipo_Sangue.Location = new System.Drawing.Point(204, 374);
            this.Tipo_Sangue.Name = "Tipo_Sangue";
            this.Tipo_Sangue.Size = new System.Drawing.Size(161, 21);
            this.Tipo_Sangue.TabIndex = 7;
            this.Tipo_Sangue.SelectedIndexChanged += new System.EventHandler(this.Tipo_Sangue_SelectedIndexChanged);
            // 
            // CPF_Pesquisar
            // 
            this.CPF_Pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPF_Pesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPF_Pesquisar.Location = new System.Drawing.Point(115, 198);
            this.CPF_Pesquisar.Mask = "000.000.000-00";
            this.CPF_Pesquisar.Name = "CPF_Pesquisar";
            this.CPF_Pesquisar.Size = new System.Drawing.Size(100, 20);
            this.CPF_Pesquisar.TabIndex = 0;
            this.CPF_Pesquisar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPF_Pesquisar_MaskInputRejected);
            this.CPF_Pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPF_Pesquisar_KeyPress);
            // 
            // Nasc_Pac
            // 
            this.Nasc_Pac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nasc_Pac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nasc_Pac.Enabled = false;
            this.Nasc_Pac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nasc_Pac.Location = new System.Drawing.Point(548, 323);
            this.Nasc_Pac.Mask = "00/00/0000 ";
            this.Nasc_Pac.Name = "Nasc_Pac";
            this.Nasc_Pac.Size = new System.Drawing.Size(100, 20);
            this.Nasc_Pac.TabIndex = 4;
            this.Nasc_Pac.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Nasc_Pac_MaskInputRejected);
            // 
            // Tel_Pac
            // 
            this.Tel_Pac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tel_Pac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tel_Pac.Enabled = false;
            this.Tel_Pac.Location = new System.Drawing.Point(143, 349);
            this.Tel_Pac.Mask = "(00) 00000-0000";
            this.Tel_Pac.Name = "Tel_Pac";
            this.Tel_Pac.Size = new System.Drawing.Size(100, 20);
            this.Tel_Pac.TabIndex = 5;
            this.Tel_Pac.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Tel_Pac_MaskInputRejected);
            this.Tel_Pac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tel_Pac_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label12.Location = new System.Drawing.Point(449, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "CEP";
            // 
            // CEP
            // 
            this.CEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CEP.Enabled = false;
            this.CEP.Location = new System.Drawing.Point(505, 51);
            this.CEP.Mask = "00000-000";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(103, 20);
            this.CEP.TabIndex = 11;
            this.CEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CEP_MaskInputRejected);
            this.CEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CEP_KeyPress);
            // 
            // Pesquisa_Dados
            // 
            this.Pesquisa_Dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pesquisa_Dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pesquisa_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_Dados.Location = new System.Drawing.Point(52, 224);
            this.Pesquisa_Dados.Name = "Pesquisa_Dados";
            this.Pesquisa_Dados.Size = new System.Drawing.Size(163, 33);
            this.Pesquisa_Dados.TabIndex = 1;
            this.Pesquisa_Dados.Text = "Pesquisar";
            this.Pesquisa_Dados.UseVisualStyleBackColor = false;
            this.Pesquisa_Dados.Click += new System.EventHandler(this.Pesquisa_Dados_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label13.Location = new System.Drawing.Point(337, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(246, 63);
            this.label13.TabIndex = 14;
            this.label13.Text = "Paciente";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Novo_Pac
            // 
            this.Novo_Pac.BackColor = System.Drawing.Color.White;
            this.Novo_Pac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Novo_Pac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo_Pac.Image = ((System.Drawing.Image)(resources.GetObject("Novo_Pac.Image")));
            this.Novo_Pac.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Novo_Pac.Location = new System.Drawing.Point(780, 145);
            this.Novo_Pac.Name = "Novo_Pac";
            this.Novo_Pac.Size = new System.Drawing.Size(93, 92);
            this.Novo_Pac.TabIndex = 15;
            this.Novo_Pac.Text = "Novo";
            this.Novo_Pac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Novo_Pac.UseVisualStyleBackColor = false;
            this.Novo_Pac.Click += new System.EventHandler(this.Novo_Click);
            // 
            // CPF_Pac
            // 
            this.CPF_Pac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPF_Pac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPF_Pac.Enabled = false;
            this.CPF_Pac.Location = new System.Drawing.Point(115, 323);
            this.CPF_Pac.Mask = "000.000.000-00";
            this.CPF_Pac.Name = "CPF_Pac";
            this.CPF_Pac.Size = new System.Drawing.Size(100, 20);
            this.CPF_Pac.TabIndex = 3;
            this.CPF_Pac.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPF_Pac_MaskInputRejected);
            this.CPF_Pac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPF_Pac_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label14.Location = new System.Drawing.Point(48, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = "CPF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label15.Location = new System.Drawing.Point(56, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Pesquisar por Paciente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label16.Location = new System.Drawing.Point(56, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Cadastro de um Paciente";
            // 
            // Gravar
            // 
            this.Gravar.BackColor = System.Drawing.Color.White;
            this.Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gravar.Enabled = false;
            this.Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gravar.Image = ((System.Drawing.Image)(resources.GetObject("Gravar.Image")));
            this.Gravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gravar.Location = new System.Drawing.Point(780, 243);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(93, 92);
            this.Gravar.TabIndex = 16;
            this.Gravar.Text = "Gravar Dados";
            this.Gravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gravar.UseVisualStyleBackColor = false;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // Alterar
            // 
            this.Alterar.BackColor = System.Drawing.Color.White;
            this.Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Alterar.Enabled = false;
            this.Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alterar.Image = ((System.Drawing.Image)(resources.GetObject("Alterar.Image")));
            this.Alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Alterar.Location = new System.Drawing.Point(780, 341);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(93, 92);
            this.Alterar.TabIndex = 17;
            this.Alterar.Text = "Alterar Dados";
            this.Alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Alterar.UseVisualStyleBackColor = false;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.White;
            this.Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excluir.Enabled = false;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Excluir.Location = new System.Drawing.Point(780, 439);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(93, 92);
            this.Excluir.TabIndex = 18;
            this.Excluir.Text = "Excluir Dados";
            this.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Limpa_Dados
            // 
            this.Limpa_Dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Limpa_Dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpa_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpa_Dados.Location = new System.Drawing.Point(52, 458);
            this.Limpa_Dados.Name = "Limpa_Dados";
            this.Limpa_Dados.Size = new System.Drawing.Size(163, 33);
            this.Limpa_Dados.TabIndex = 14;
            this.Limpa_Dados.Text = "Limpar Dados";
            this.Limpa_Dados.UseVisualStyleBackColor = false;
            this.Limpa_Dados.Click += new System.EventHandler(this.Limpa_Dados_Click);
            // 
            // DTG
            // 
            this.DTG.AllowUserToAddRows = false;
            this.DTG.AllowUserToDeleteRows = false;
            this.DTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG.Location = new System.Drawing.Point(799, 458);
            this.DTG.Name = "DTG";
            this.DTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG.Size = new System.Drawing.Size(50, 52);
            this.DTG.TabIndex = 24;
            this.DTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_CellContentClick);
            this.DTG.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DTG_MouseDoubleClick);
            // 
            // tblPacienteBindingSource
            // 
            this.tblPacienteBindingSource.DataMember = "tbl_Paciente";
            this.tblPacienteBindingSource.DataSource = this.dBHospitalDataSet;
            this.tblPacienteBindingSource.CurrentChanged += new System.EventHandler(this.tblPacienteBindingSource_CurrentChanged);
            // 
            // tbl_PacienteTableAdapter
            // 
            this.tbl_PacienteTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.tblPacienteBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(920, 25);
            this.bindingNavigator1.TabIndex = 25;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems_1);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Rua
            // 
            this.Rua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rua.Enabled = false;
            this.Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rua.Location = new System.Drawing.Point(60, 25);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(383, 20);
            this.Rua.TabIndex = 8;
            this.Rua.TextChanged += new System.EventHandler(this.Rua_TextChanged);
            // 
            // SalvarAlteração
            // 
            this.SalvarAlteração.BackColor = System.Drawing.Color.White;
            this.SalvarAlteração.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarAlteração.Enabled = false;
            this.SalvarAlteração.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarAlteração.Image = ((System.Drawing.Image)(resources.GetObject("SalvarAlteração.Image")));
            this.SalvarAlteração.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalvarAlteração.Location = new System.Drawing.Point(780, 243);
            this.SalvarAlteração.Name = "SalvarAlteração";
            this.SalvarAlteração.Size = new System.Drawing.Size(93, 92);
            this.SalvarAlteração.TabIndex = 28;
            this.SalvarAlteração.Text = "Salvar ";
            this.SalvarAlteração.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalvarAlteração.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalvarAlteração.UseVisualStyleBackColor = false;
            this.SalvarAlteração.Click += new System.EventHandler(this.SalvarAlteração_Click);
            // 
            // GroupEnder
            // 
            this.GroupEnder.Controls.Add(this.button1);
            this.GroupEnder.Controls.Add(this.label2);
            this.GroupEnder.Controls.Add(this.label3);
            this.GroupEnder.Controls.Add(this.label9);
            this.GroupEnder.Controls.Add(this.label10);
            this.GroupEnder.Controls.Add(this.label11);
            this.GroupEnder.Controls.Add(this.Rua);
            this.GroupEnder.Controls.Add(this.Numero);
            this.GroupEnder.Controls.Add(this.Bairro);
            this.GroupEnder.Controls.Add(this.Cidade);
            this.GroupEnder.Controls.Add(this.UF);
            this.GroupEnder.Controls.Add(this.label12);
            this.GroupEnder.Controls.Add(this.CEP);
            this.GroupEnder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupEnder.Location = new System.Drawing.Point(52, 491);
            this.GroupEnder.Name = "GroupEnder";
            this.GroupEnder.Size = new System.Drawing.Size(627, 138);
            this.GroupEnder.TabIndex = 29;
            this.GroupEnder.TabStop = false;
            this.GroupEnder.Text = "Cadastre seu Endereço";
            this.GroupEnder.Visible = false;
            this.GroupEnder.Enter += new System.EventHandler(this.GroupEnder_Enter);
            this.GroupEnder.Leave += new System.EventHandler(this.GroupEnder_Leave);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(530, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Concluido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Endereco
            // 
            this.Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Endereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Endereco.Enabled = false;
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(149, 401);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(499, 20);
            this.Endereco.TabIndex = 30;
            this.Endereco.Click += new System.EventHandler(this.Endereco_Click);
            this.Endereco.TextChanged += new System.EventHandler(this.Endereco_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label18.Location = new System.Drawing.Point(48, 398);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 22);
            this.label18.TabIndex = 31;
            this.label18.Text = "Endereço";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.Enabled = false;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Location = new System.Drawing.Point(779, 537);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(94, 83);
            this.Cancelar.TabIndex = 32;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(920, 682);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.GroupEnder);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.Limpa_Dados);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CPF_Pac);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Novo_Pac);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Pesquisa_Dados);
            this.Controls.Add(this.Tel_Pac);
            this.Controls.Add(this.Nasc_Pac);
            this.Controls.Add(this.CPF_Pesquisar);
            this.Controls.Add(this.Tipo_Sangue);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Nome_Pac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTG);
            this.Controls.Add(this.SalvarAlteração);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paciente";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBHospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.GroupEnder.ResumeLayout(false);
            this.GroupEnder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Nome_Pac;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.ComboBox UF;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.ComboBox Tipo_Sangue;
        private System.Windows.Forms.MaskedTextBox CPF_Pesquisar;
        private System.Windows.Forms.MaskedTextBox Nasc_Pac;
        private System.Windows.Forms.MaskedTextBox Tel_Pac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox CEP;
        private System.Windows.Forms.Button Pesquisa_Dados;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Novo_Pac;
        private System.Windows.Forms.MaskedTextBox CPF_Pac;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpa_Dados;
        private System.Windows.Forms.DataGridView DTG;
        private DBHospitalDataSet dBHospitalDataSet;
        private System.Windows.Forms.BindingSource tblPacienteBindingSource;
        private DBHospitalDataSetTableAdapters.tbl_PacienteTableAdapter tbl_PacienteTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox Rua;
        private System.Windows.Forms.Button SalvarAlteração;
        private System.Windows.Forms.GroupBox GroupEnder;
        private System.Windows.Forms.TextBox Endereco;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button button1;
    }
}