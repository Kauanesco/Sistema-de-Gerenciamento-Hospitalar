namespace Sistema_de_Gerenciamento_Hospitalar
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Cargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Visualizar = new System.Windows.Forms.Button();
            this.Entrar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(54, 86);
            this.Senha.MaxLength = 8;
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(100, 26);
            this.Senha.TabIndex = 1;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            this.Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Senha_KeyPress);
            // 
            // Cargo
            // 
            this.Cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cargo.FormattingEnabled = true;
            this.Cargo.Items.AddRange(new object[] {
            "Médico",
            "Enfermeiro",
            "Administrador"});
            this.Cargo.Location = new System.Drawing.Point(54, 128);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(138, 28);
            this.Cargo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Função";
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(54, 47);
            this.CPF.Mask = "000.000.000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(138, 26);
            this.CPF.TabIndex = 0;
            this.CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPF_MaskInputRejected);
            this.CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPF_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(289, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 393);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Visualizar);
            this.groupBox1.Controls.Add(this.CPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cargo);
            this.groupBox1.Controls.Add(this.Senha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 177);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira seus Dados";
            // 
            // Visualizar
            // 
            this.Visualizar.BackColor = System.Drawing.Color.White;
            this.Visualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizar.Image = ((System.Drawing.Image)(resources.GetObject("Visualizar.Image")));
            this.Visualizar.Location = new System.Drawing.Point(160, 86);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(32, 26);
            this.Visualizar.TabIndex = 59;
            this.Visualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Visualizar.UseVisualStyleBackColor = false;
            this.Visualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Visualizar_MouseDown);
            this.Visualizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Visualizar_MouseMove);
            this.Visualizar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Visualizar_MouseUp);
            // 
            // Entrar
            // 
            this.Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.Location = new System.Drawing.Point(30, 292);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(99, 23);
            this.Entrar.TabIndex = 18;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Sair
            // 
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(167, 292);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(99, 23);
            this.Sair.TabIndex = 19;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Exibir senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(512, 393);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.ComboBox Cargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Visualizar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}