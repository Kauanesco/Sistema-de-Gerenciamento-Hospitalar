namespace Sistema_de_Gerenciamento_Hospitalar
{
    partial class Fila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fila));
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nome_CPF = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.dbHospitalDataSet1 = new Sistema_de_Gerenciamento_Hospitalar.DBHospitalDataSet();
            this.dbHospitalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.AtenderFIla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.label13.Location = new System.Drawing.Point(400, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 63);
            this.label13.TabIndex = 15;
            this.label13.Text = "Fila";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nome_CPF);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Próximo a ser Atendido";
            // 
            // Nome_CPF
            // 
            this.Nome_CPF.AutoSize = true;
            this.Nome_CPF.Enabled = false;
            this.Nome_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.Nome_CPF.Location = new System.Drawing.Point(6, 67);
            this.Nome_CPF.Name = "Nome_CPF";
            this.Nome_CPF.Size = new System.Drawing.Size(0, 22);
            this.Nome_CPF.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTG);
            this.groupBox2.Controls.Add(this.ID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 258);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fila Atualmente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DTG
            // 
            this.DTG.AllowUserToAddRows = false;
            this.DTG.AllowUserToDeleteRows = false;
            this.DTG.AllowUserToOrderColumns = true;
            this.DTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTG.Location = new System.Drawing.Point(3, 19);
            this.DTG.Name = "DTG";
            this.DTG.ReadOnly = true;
            this.DTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG.Size = new System.Drawing.Size(575, 236);
            this.DTG.TabIndex = 0;
            this.DTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_CellContentClick);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(351, 100);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(59, 23);
            this.ID.TabIndex = 18;
            this.ID.Visible = false;
            // 
            // dbHospitalDataSet1
            // 
            this.dbHospitalDataSet1.DataSetName = "DBHospitalDataSet";
            this.dbHospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbHospitalDataSet1BindingSource
            // 
            this.dbHospitalDataSet1BindingSource.DataSource = this.dbHospitalDataSet1;
            this.dbHospitalDataSet1BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(647, 601);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(14, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(267, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "Retirar Próximo da Fila";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AtenderFIla
            // 
            this.AtenderFIla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtenderFIla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtenderFIla.Image = ((System.Drawing.Image)(resources.GetObject("AtenderFIla.Image")));
            this.AtenderFIla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtenderFIla.Location = new System.Drawing.Point(647, 516);
            this.AtenderFIla.Name = "AtenderFIla";
            this.AtenderFIla.Padding = new System.Windows.Forms.Padding(14, 0, 5, 0);
            this.AtenderFIla.Size = new System.Drawing.Size(267, 70);
            this.AtenderFIla.TabIndex = 20;
            this.AtenderFIla.Text = "Atender Próximo da Fila";
            this.AtenderFIla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtenderFIla.UseVisualStyleBackColor = true;
            this.AtenderFIla.Click += new System.EventHandler(this.AtenderFIla_Click);
            // 
            // Fila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(920, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AtenderFIla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fila";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Fila_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHospitalDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Nome_CPF;
        private DBHospitalDataSet dbHospitalDataSet1;
        private System.Windows.Forms.DataGridView DTG;
        private System.Windows.Forms.BindingSource dbHospitalDataSet1BindingSource;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AtenderFIla;
    }
}