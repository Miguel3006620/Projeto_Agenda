namespace Projeto_Agenda.Formularios
{
    partial class Consultar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet_Agenda = new Projeto_Agenda.Dados.DataSet_Agenda();
            this.dataSetAgendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.pessoaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buscar = new System.Windows.Forms.ComboBox();
            this.Valor = new System.Windows.Forms.TextBox();
            this.Filtrar = new System.Windows.Forms.Button();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(966, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAgendaBindingSource
            // 
            this.dataSetAgendaBindingSource.DataSource = this.dataSet_Agenda;
            this.dataSetAgendaBindingSource.Position = 0;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.dataSetAgendaBindingSource;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "dataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "dataNasc";
            this.dataNascDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            this.dataNascDataGridViewTextBoxColumn.Width = 150;
            // 
            // Buscar
            // 
            this.Buscar.FormattingEnabled = true;
            this.Buscar.Location = new System.Drawing.Point(270, 44);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(160, 28);
            this.Buscar.TabIndex = 2;
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(532, 46);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(160, 26);
            this.Valor.TabIndex = 3;
            // 
            // Filtrar
            // 
            this.Filtrar.Location = new System.Drawing.Point(801, 44);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(94, 28);
            this.Filtrar.TabIndex = 4;
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.UseVisualStyleBackColor = true;
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataMember = "pessoa";
            this.pessoaBindingSource1.DataSource = this.dataSet_Agenda;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pessoaTableAdapter = this.pessoaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "nome",
            "endereco",
            "cidade",
            "email",
            "datanasc"});
            this.comboBox1.Location = new System.Drawing.Point(12, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // sla
            // 
            this.sla.AutoSize = true;
            this.sla.Location = new System.Drawing.Point(12, 18);
            this.sla.Name = "sla";
            this.sla.Size = new System.Drawing.Size(110, 20);
            this.sla.TabIndex = 6;
            this.sla.Text = "Pesquisar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor:";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetAgendaBindingSource;
        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private Dados.DataSet_AgendaTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox Buscar;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private Dados.DataSet_AgendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label sla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}