namespace Sistema_de_Gerenciamento_Hospitalar
{
    partial class Triagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triagem));
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CPF_Pesquisar = new System.Windows.Forms.MaskedTextBox();
            this.Pesquisa_Dados = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Pressao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prioridade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Resumo = new System.Windows.Forms.TextBox();
            this.Gravar = new System.Windows.Forms.Button();
            this.Limpa_Dados = new System.Windows.Forms.Button();
            this.DTG = new System.Windows.Forms.DataGridView();
            this.Peso = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label13.Location = new System.Drawing.Point(344, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 63);
            this.label13.TabIndex = 16;
            this.label13.Text = "Triagem";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label16.Location = new System.Drawing.Point(67, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "Digite o CPF do paciente";
            // 
            // CPF_Pesquisar
            // 
            this.CPF_Pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPF_Pesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPF_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF_Pesquisar.Location = new System.Drawing.Point(70, 127);
            this.CPF_Pesquisar.Mask = "000.000.000-00";
            this.CPF_Pesquisar.Name = "CPF_Pesquisar";
            this.CPF_Pesquisar.Size = new System.Drawing.Size(151, 26);
            this.CPF_Pesquisar.TabIndex = 0;
            // 
            // Pesquisa_Dados
            // 
            this.Pesquisa_Dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pesquisa_Dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pesquisa_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_Dados.Location = new System.Drawing.Point(227, 126);
            this.Pesquisa_Dados.Name = "Pesquisa_Dados";
            this.Pesquisa_Dados.Size = new System.Drawing.Size(67, 30);
            this.Pesquisa_Dados.TabIndex = 1;
            this.Pesquisa_Dados.Text = "Pesquisar";
            this.Pesquisa_Dados.UseVisualStyleBackColor = false;
            this.Pesquisa_Dados.Click += new System.EventHandler(this.Pesquisa_Dados_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Enabled = false;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.Nome.Location = new System.Drawing.Point(64, 179);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(0, 31);
            this.Nome.TabIndex = 58;
            // 
            // Altura
            // 
            this.Altura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Altura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Altura.Enabled = false;
            this.Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura.Location = new System.Drawing.Point(133, 313);
            this.Altura.Mask = "000cm";
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(110, 26);
            this.Altura.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label14.Location = new System.Drawing.Point(66, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 22);
            this.label14.TabIndex = 60;
            this.label14.Text = "Altura";
            // 
            // Pressao
            // 
            this.Pressao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pressao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pressao.Enabled = false;
            this.Pressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressao.Location = new System.Drawing.Point(155, 279);
            this.Pressao.Mask = "00x00";
            this.Pressao.Name = "Pressao";
            this.Pressao.Size = new System.Drawing.Size(88, 26);
            this.Pressao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(66, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Pressão";
            // 
            // Temperatura
            // 
            this.Temperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Temperatura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Temperatura.Enabled = false;
            this.Temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperatura.Location = new System.Drawing.Point(189, 242);
            this.Temperatura.Mask = "00,0ºc";
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(54, 26);
            this.Temperatura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(66, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(66, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "Prioridade";
            // 
            // Prioridade
            // 
            this.Prioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Prioridade.Enabled = false;
            this.Prioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prioridade.FormattingEnabled = true;
            this.Prioridade.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.Prioridade.Location = new System.Drawing.Point(170, 535);
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.Size = new System.Drawing.Size(73, 21);
            this.Prioridade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label4.Location = new System.Drawing.Point(66, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Descrição do Paciente";
            // 
            // Resumo
            // 
            this.Resumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resumo.Enabled = false;
            this.Resumo.Location = new System.Drawing.Point(70, 409);
            this.Resumo.Multiline = true;
            this.Resumo.Name = "Resumo";
            this.Resumo.Size = new System.Drawing.Size(396, 113);
            this.Resumo.TabIndex = 6;
            // 
            // Gravar
            // 
            this.Gravar.BackColor = System.Drawing.Color.White;
            this.Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gravar.Enabled = false;
            this.Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gravar.Image = ((System.Drawing.Image)(resources.GetObject("Gravar.Image")));
            this.Gravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gravar.Location = new System.Drawing.Point(501, 464);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(93, 92);
            this.Gravar.TabIndex = 9;
            this.Gravar.Text = "Gravar Dados";
            this.Gravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gravar.UseVisualStyleBackColor = false;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // Limpa_Dados
            // 
            this.Limpa_Dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Limpa_Dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpa_Dados.Enabled = false;
            this.Limpa_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpa_Dados.Location = new System.Drawing.Point(303, 524);
            this.Limpa_Dados.Name = "Limpa_Dados";
            this.Limpa_Dados.Size = new System.Drawing.Size(163, 33);
            this.Limpa_Dados.TabIndex = 8;
            this.Limpa_Dados.Text = "Limpar Dados";
            this.Limpa_Dados.UseVisualStyleBackColor = false;
            this.Limpa_Dados.Click += new System.EventHandler(this.Limpa_Dados_Click);
            // 
            // DTG
            // 
            this.DTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG.Location = new System.Drawing.Point(521, 484);
            this.DTG.Name = "DTG";
            this.DTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG.Size = new System.Drawing.Size(38, 47);
            this.DTG.TabIndex = 71;
            // 
            // Peso
            // 
            this.Peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Peso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Peso.Enabled = false;
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(133, 349);
            this.Peso.Mask = "000KG";
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(110, 26);
            this.Peso.TabIndex = 5;
            this.Peso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Peso_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label7.Location = new System.Drawing.Point(66, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 73;
            this.label7.Text = "Peso";
            // 
            // Triagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(920, 682);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Limpa_Dados);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.Resumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prioridade);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pressao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Pesquisa_Dados);
            this.Controls.Add(this.CPF_Pesquisar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DTG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Triagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Triagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox CPF_Pesquisar;
        private System.Windows.Forms.Button Pesquisa_Dados;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.MaskedTextBox Altura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox Pressao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Temperatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Prioridade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Resumo;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button Limpa_Dados;
        private System.Windows.Forms.DataGridView DTG;
        private System.Windows.Forms.MaskedTextBox Peso;
        private System.Windows.Forms.Label label7;
    }
}