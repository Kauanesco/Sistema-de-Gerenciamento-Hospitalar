namespace Sistema_de_Gerenciamento_Hospitalar
{
    partial class Funcionários
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionários));
            this.label13 = new System.Windows.Forms.Label();
            this.Excluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Gravar = new System.Windows.Forms.Button();
            this.Novo_Fun = new System.Windows.Forms.Button();
            this.SalvarAlteração = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CPF_Fun = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Pesquisa_Dados = new System.Windows.Forms.Button();
            this.CPF_Pesquisar = new System.Windows.Forms.MaskedTextBox();
            this.Nome_Fun = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.ConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label_confirm = new System.Windows.Forms.Label();
            this.Limpa_Dados = new System.Windows.Forms.Button();
            this.Cargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CRMnum = new System.Windows.Forms.TextBox();
            this.CRMestado = new System.Windows.Forms.ComboBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.dbHospitalDataSet1 = new Sistema_de_Gerenciamento_Hospitalar.DBHospitalDataSet();
            this.DTG = new System.Windows.Forms.DataGridView();
            this.Cargo_Pesquisar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Visualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label13.Location = new System.Drawing.Point(285, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 63);
            this.label13.TabIndex = 15;
            this.label13.Text = "Funcionários";
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.White;
            this.Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excluir.Enabled = false;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Excluir.Location = new System.Drawing.Point(781, 442);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(93, 92);
            this.Excluir.TabIndex = 14;
            this.Excluir.Text = "Excluir Dados";
            this.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Alterar
            // 
            this.Alterar.BackColor = System.Drawing.Color.White;
            this.Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Alterar.Enabled = false;
            this.Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alterar.Image = ((System.Drawing.Image)(resources.GetObject("Alterar.Image")));
            this.Alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Alterar.Location = new System.Drawing.Point(781, 344);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(93, 92);
            this.Alterar.TabIndex = 13;
            this.Alterar.Text = "Alterar Dados";
            this.Alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Alterar.UseVisualStyleBackColor = false;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Gravar
            // 
            this.Gravar.BackColor = System.Drawing.Color.White;
            this.Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gravar.Enabled = false;
            this.Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gravar.Image = ((System.Drawing.Image)(resources.GetObject("Gravar.Image")));
            this.Gravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gravar.Location = new System.Drawing.Point(781, 247);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(93, 92);
            this.Gravar.TabIndex = 12;
            this.Gravar.Text = "Gravar Dados";
            this.Gravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gravar.UseVisualStyleBackColor = false;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // Novo_Fun
            // 
            this.Novo_Fun.BackColor = System.Drawing.Color.White;
            this.Novo_Fun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Novo_Fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo_Fun.Image = ((System.Drawing.Image)(resources.GetObject("Novo_Fun.Image")));
            this.Novo_Fun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Novo_Fun.Location = new System.Drawing.Point(781, 148);
            this.Novo_Fun.Name = "Novo_Fun";
            this.Novo_Fun.Size = new System.Drawing.Size(93, 92);
            this.Novo_Fun.TabIndex = 11;
            this.Novo_Fun.Text = "Novo";
            this.Novo_Fun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Novo_Fun.UseVisualStyleBackColor = false;
            this.Novo_Fun.Click += new System.EventHandler(this.Novo_Fun_Click);
            // 
            // SalvarAlteração
            // 
            this.SalvarAlteração.BackColor = System.Drawing.Color.White;
            this.SalvarAlteração.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarAlteração.Enabled = false;
            this.SalvarAlteração.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarAlteração.Image = ((System.Drawing.Image)(resources.GetObject("SalvarAlteração.Image")));
            this.SalvarAlteração.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalvarAlteração.Location = new System.Drawing.Point(781, 246);
            this.SalvarAlteração.Name = "SalvarAlteração";
            this.SalvarAlteração.Size = new System.Drawing.Size(93, 92);
            this.SalvarAlteração.TabIndex = 34;
            this.SalvarAlteração.Text = "Salvar ";
            this.SalvarAlteração.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalvarAlteração.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalvarAlteração.UseVisualStyleBackColor = false;
            this.SalvarAlteração.Click += new System.EventHandler(this.SalvarAlteração_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label16.Location = new System.Drawing.Point(60, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 15);
            this.label16.TabIndex = 43;
            this.label16.Text = "Cadastro do Funcionário";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label15.Location = new System.Drawing.Point(60, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Pesquisar por Funcionário";
            // 
            // CPF_Fun
            // 
            this.CPF_Fun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPF_Fun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPF_Fun.Enabled = false;
            this.CPF_Fun.Location = new System.Drawing.Point(119, 292);
            this.CPF_Fun.Mask = "000.000.000-00";
            this.CPF_Fun.Name = "CPF_Fun";
            this.CPF_Fun.Size = new System.Drawing.Size(88, 20);
            this.CPF_Fun.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label14.Location = new System.Drawing.Point(52, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 22);
            this.label14.TabIndex = 41;
            this.label14.Text = "CPF";
            // 
            // Pesquisa_Dados
            // 
            this.Pesquisa_Dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pesquisa_Dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pesquisa_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_Dados.Location = new System.Drawing.Point(56, 193);
            this.Pesquisa_Dados.Name = "Pesquisa_Dados";
            this.Pesquisa_Dados.Size = new System.Drawing.Size(163, 33);
            this.Pesquisa_Dados.TabIndex = 2;
            this.Pesquisa_Dados.Text = "Pesquisar";
            this.Pesquisa_Dados.UseVisualStyleBackColor = false;
            this.Pesquisa_Dados.Click += new System.EventHandler(this.Pesquisa_Dados_Click);
            // 
            // CPF_Pesquisar
            // 
            this.CPF_Pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPF_Pesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPF_Pesquisar.Location = new System.Drawing.Point(119, 167);
            this.CPF_Pesquisar.Mask = "000.000.000-00";
            this.CPF_Pesquisar.Name = "CPF_Pesquisar";
            this.CPF_Pesquisar.Size = new System.Drawing.Size(100, 20);
            this.CPF_Pesquisar.TabIndex = 0;
            // 
            // Nome_Fun
            // 
            this.Nome_Fun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nome_Fun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nome_Fun.Enabled = false;
            this.Nome_Fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Fun.Location = new System.Drawing.Point(119, 262);
            this.Nome_Fun.Name = "Nome_Fun";
            this.Nome_Fun.Size = new System.Drawing.Size(500, 20);
            this.Nome_Fun.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label8.Location = new System.Drawing.Point(52, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.TabIndex = 40;
            this.label8.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(52, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(462, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "CRM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(52, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Senha";
            this.label3.Visible = false;
            // 
            // Senha
            // 
            this.Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Senha.Enabled = false;
            this.Senha.Location = new System.Drawing.Point(119, 320);
            this.Senha.MaxLength = 8;
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(105, 20);
            this.Senha.TabIndex = 8;
            this.Senha.Visible = false;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            this.Senha.Leave += new System.EventHandler(this.Senha_Leave);
            this.Senha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Senha_MouseMove);
            // 
            // ConfirmaSenha
            // 
            this.ConfirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmaSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmaSenha.Enabled = false;
            this.ConfirmaSenha.Location = new System.Drawing.Point(422, 321);
            this.ConfirmaSenha.MaxLength = 8;
            this.ConfirmaSenha.Name = "ConfirmaSenha";
            this.ConfirmaSenha.Size = new System.Drawing.Size(105, 20);
            this.ConfirmaSenha.TabIndex = 9;
            this.ConfirmaSenha.Visible = false;
            this.ConfirmaSenha.TextChanged += new System.EventHandler(this.ConfirmaSenha_TextChanged);
            this.ConfirmaSenha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfirmaSenha_MouseMove);
            // 
            // label_confirm
            // 
            this.label_confirm.AutoSize = true;
            this.label_confirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_confirm.Enabled = false;
            this.label_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label_confirm.Location = new System.Drawing.Point(230, 318);
            this.label_confirm.Name = "label_confirm";
            this.label_confirm.Size = new System.Drawing.Size(191, 22);
            this.label_confirm.TabIndex = 48;
            this.label_confirm.Text = "Confirme sua Senha";
            this.label_confirm.Visible = false;
            // 
            // Limpa_Dados
            // 
            this.Limpa_Dados.BackColor = System.Drawing.Color.Bisque;
            this.Limpa_Dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpa_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpa_Dados.Location = new System.Drawing.Point(56, 346);
            this.Limpa_Dados.Name = "Limpa_Dados";
            this.Limpa_Dados.Size = new System.Drawing.Size(163, 33);
            this.Limpa_Dados.TabIndex = 10;
            this.Limpa_Dados.Text = "Limpar Dados";
            this.Limpa_Dados.UseVisualStyleBackColor = false;
            this.Limpa_Dados.Click += new System.EventHandler(this.Limpa_Dados_Click);
            // 
            // Cargo
            // 
            this.Cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cargo.Enabled = false;
            this.Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.FormattingEnabled = true;
            this.Cargo.Items.AddRange(new object[] {
            "Médico",
            "Enfermeiro"});
            this.Cargo.Location = new System.Drawing.Point(315, 291);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(121, 21);
            this.Cargo.TabIndex = 5;
            this.Cargo.SelectedIndexChanged += new System.EventHandler(this.Cargo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label4.Location = new System.Drawing.Point(245, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 52;
            this.label4.Text = "Cargo";
            // 
            // CRMnum
            // 
            this.CRMnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRMnum.Enabled = false;
            this.CRMnum.Location = new System.Drawing.Point(521, 294);
            this.CRMnum.MaxLength = 6;
            this.CRMnum.Name = "CRMnum";
            this.CRMnum.Size = new System.Drawing.Size(88, 20);
            this.CRMnum.TabIndex = 6;
            this.CRMnum.Click += new System.EventHandler(this.CRMnum_Click);
            this.CRMnum.TextChanged += new System.EventHandler(this.CRMnum_TextChanged);
            this.CRMnum.Leave += new System.EventHandler(this.CRMnum_Leave);
            this.CRMnum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CRMnum_MouseMove);
            // 
            // CRMestado
            // 
            this.CRMestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CRMestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CRMestado.Enabled = false;
            this.CRMestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRMestado.FormattingEnabled = true;
            this.CRMestado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CRMestado.Location = new System.Drawing.Point(615, 294);
            this.CRMestado.Name = "CRMestado";
            this.CRMestado.Size = new System.Drawing.Size(41, 21);
            this.CRMestado.TabIndex = 7;
            this.CRMestado.Visible = false;
            this.CRMestado.SelectedIndexChanged += new System.EventHandler(this.CRMestado_SelectedIndexChanged);
            // 
            // tooltip
            // 
            this.tooltip.ToolTipTitle = "Adicione seus Dados";
            this.tooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.tooltip_Popup);
            // 
            // dbHospitalDataSet1
            // 
            this.dbHospitalDataSet1.DataSetName = "DBHospitalDataSet";
            this.dbHospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTG
            // 
            this.DTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTG.Location = new System.Drawing.Point(826, 471);
            this.DTG.Name = "DTG";
            this.DTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG.Size = new System.Drawing.Size(24, 29);
            this.DTG.TabIndex = 55;
            this.DTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_CellContentClick);
            // 
            // Cargo_Pesquisar
            // 
            this.Cargo_Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cargo_Pesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cargo_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo_Pesquisar.FormattingEnabled = true;
            this.Cargo_Pesquisar.Items.AddRange(new object[] {
            "Médico",
            "Enfermeiro"});
            this.Cargo_Pesquisar.Location = new System.Drawing.Point(315, 167);
            this.Cargo_Pesquisar.Name = "Cargo_Pesquisar";
            this.Cargo_Pesquisar.Size = new System.Drawing.Size(73, 21);
            this.Cargo_Pesquisar.TabIndex = 1;
            this.Cargo_Pesquisar.SelectedIndexChanged += new System.EventHandler(this.Cargo_Pesquisar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(245, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "Cargo";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.Enabled = false;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Location = new System.Drawing.Point(781, 540);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(94, 83);
            this.Cancelar.TabIndex = 15;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Visualizar
            // 
            this.Visualizar.BackColor = System.Drawing.Color.White;
            this.Visualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizar.Image = ((System.Drawing.Image)(resources.GetObject("Visualizar.Image")));
            this.Visualizar.Location = new System.Drawing.Point(533, 322);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(32, 20);
            this.Visualizar.TabIndex = 58;
            this.Visualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Visualizar.UseVisualStyleBackColor = false;
            this.Visualizar.Visible = false;
            this.Visualizar.Click += new System.EventHandler(this.Visualizar_Click);
            this.Visualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Visualizar_MouseDown);
            this.Visualizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Visualizar_MouseMove);
            this.Visualizar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Visualizar_MouseUp);
            // 
            // Funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(920, 682);
            this.Controls.Add(this.Visualizar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cargo_Pesquisar);
            this.Controls.Add(this.CRMestado);
            this.Controls.Add(this.CRMnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.Limpa_Dados);
            this.Controls.Add(this.ConfirmaSenha);
            this.Controls.Add(this.label_confirm);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CPF_Fun);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Pesquisa_Dados);
            this.Controls.Add(this.CPF_Pesquisar);
            this.Controls.Add(this.Nome_Fun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.Novo_Fun);
            this.Controls.Add(this.SalvarAlteração);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DTG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionários";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button Novo_Fun;
        private System.Windows.Forms.Button SalvarAlteração;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox CPF_Fun;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Pesquisa_Dados;
        private System.Windows.Forms.MaskedTextBox CPF_Pesquisar;
        private System.Windows.Forms.TextBox Nome_Fun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox ConfirmaSenha;
        private System.Windows.Forms.Label label_confirm;
        private System.Windows.Forms.Button Limpa_Dados;
        private System.Windows.Forms.ComboBox Cargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CRMnum;
        private System.Windows.Forms.ComboBox CRMestado;
        private System.Windows.Forms.ToolTip tooltip;
        private DBHospitalDataSet dbHospitalDataSet1;
        private System.Windows.Forms.DataGridView DTG;
        private System.Windows.Forms.ComboBox Cargo_Pesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Visualizar;
    }
}