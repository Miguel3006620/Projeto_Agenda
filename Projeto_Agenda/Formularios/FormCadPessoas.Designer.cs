namespace Projeto_Agenda.Formularios
{
    partial class FormCadPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadPessoas));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dataNascLabel;
            this.dataSet1 = new Projeto_Agenda.Dados.DataSet1();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter1 = new Projeto_Agenda.Dados.DataSet1TableAdapters.pessoaTableAdapter();
            this.tableAdapterManager1 = new Projeto_Agenda.Dados.DataSet1TableAdapters.TableAdapterManager();
            this.pessoaBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.pessoaBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            this.enderecoTextBox1 = new System.Windows.Forms.TextBox();
            this.cidadeTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.dataNascDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pessoaDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dataNascLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1BindingNavigator)).BeginInit();
            this.pessoaBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataMember = "pessoa";
            this.pessoaBindingSource1.DataSource = this.dataSet1;
            // 
            // pessoaTableAdapter1
            // 
            this.pessoaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.pessoaTableAdapter = this.pessoaTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Projeto_Agenda.Dados.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaBindingSource1BindingNavigator
            // 
            this.pessoaBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.pessoaBindingSource1BindingNavigator.BindingSource = this.pessoaBindingSource1;
            this.pessoaBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.pessoaBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.pessoaBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pessoaBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.pessoaBindingSource1BindingNavigatorSaveItem});
            this.pessoaBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.pessoaBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.pessoaBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.pessoaBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.pessoaBindingSource1BindingNavigator.Name = "pessoaBindingSource1BindingNavigator";
            this.pessoaBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.pessoaBindingSource1BindingNavigator.Size = new System.Drawing.Size(828, 33);
            this.pessoaBindingSource1BindingNavigator.TabIndex = 0;
            this.pessoaBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(34, 20);
            this.toolStripButton1.Text = "Mover primeiro";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(34, 20);
            this.toolStripButton2.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posição atual";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 25);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de itens";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "Mover próximo";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton4.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton5.Text = "Adicionar novo";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton6.Text = "Excluir";
            // 
            // pessoaBindingSource1BindingNavigatorSaveItem
            // 
            this.pessoaBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaBindingSource1BindingNavigatorSaveItem.Image")));
            this.pessoaBindingSource1BindingNavigatorSaveItem.Name = "pessoaBindingSource1BindingNavigatorSaveItem";
            this.pessoaBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pessoaBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pessoaBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(63, 91);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource1, "id", true));
            this.idTextBox1.Location = new System.Drawing.Point(154, 88);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(200, 26);
            this.idTextBox1.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(63, 123);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource1, "nome", true));
            this.nomeTextBox1.Location = new System.Drawing.Point(154, 120);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.Size = new System.Drawing.Size(200, 26);
            this.nomeTextBox1.TabIndex = 4;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(63, 155);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(80, 20);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "endereco:";
            // 
            // enderecoTextBox1
            // 
            this.enderecoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource1, "endereco", true));
            this.enderecoTextBox1.Location = new System.Drawing.Point(154, 152);
            this.enderecoTextBox1.Name = "enderecoTextBox1";
            this.enderecoTextBox1.Size = new System.Drawing.Size(200, 26);
            this.enderecoTextBox1.TabIndex = 6;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(63, 187);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(60, 20);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "cidade:";
            // 
            // cidadeTextBox1
            // 
            this.cidadeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource1, "cidade", true));
            this.cidadeTextBox1.Location = new System.Drawing.Point(154, 184);
            this.cidadeTextBox1.Name = "cidadeTextBox1";
            this.cidadeTextBox1.Size = new System.Drawing.Size(200, 26);
            this.cidadeTextBox1.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(63, 219);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 20);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "email:";
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource1, "email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(154, 216);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(200, 26);
            this.emailTextBox1.TabIndex = 10;
            // 
            // dataNascLabel
            // 
            dataNascLabel.AutoSize = true;
            dataNascLabel.Location = new System.Drawing.Point(63, 252);
            dataNascLabel.Name = "dataNascLabel";
            dataNascLabel.Size = new System.Drawing.Size(85, 20);
            dataNascLabel.TabIndex = 11;
            dataNascLabel.Text = "data Nasc:";
            // 
            // dataNascDateTimePicker1
            // 
            this.dataNascDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaBindingSource1, "dataNasc", true));
            this.dataNascDateTimePicker1.Location = new System.Drawing.Point(154, 248);
            this.dataNascDateTimePicker1.Name = "dataNascDateTimePicker1";
            this.dataNascDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dataNascDateTimePicker1.TabIndex = 12;
            // 
            // pessoaDataGridView1
            // 
            this.pessoaDataGridView1.AutoGenerateColumns = false;
            this.pessoaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pessoaDataGridView1.DataSource = this.pessoaBindingSource1;
            this.pessoaDataGridView1.Location = new System.Drawing.Point(21, 305);
            this.pessoaDataGridView1.Name = "pessoaDataGridView1";
            this.pessoaDataGridView1.RowHeadersWidth = 62;
            this.pessoaDataGridView1.RowTemplate.Height = 28;
            this.pessoaDataGridView1.Size = new System.Drawing.Size(795, 300);
            this.pessoaDataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataNasc";
            this.dataGridViewTextBoxColumn6.HeaderText = "dataNasc";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // FormCadPessoas
            // 
            this.ClientSize = new System.Drawing.Size(828, 617);
            this.Controls.Add(this.pessoaDataGridView1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox1);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox1);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(dataNascLabel);
            this.Controls.Add(this.dataNascDateTimePicker1);
            this.Controls.Add(this.pessoaBindingSource1BindingNavigator);
            this.Name = "FormCadPessoas";
            this.Load += new System.EventHandler(this.FormCadPessoas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1BindingNavigator)).EndInit();
            this.pessoaBindingSource1BindingNavigator.ResumeLayout(false);
            this.pessoaBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private Dados.DataSet_AgendaTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private Dados.DataSet_AgendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker dataNascDateTimePicker;
        private System.Windows.Forms.DataGridView pessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private Dados.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private Dados.DataSet1TableAdapters.pessoaTableAdapter pessoaTableAdapter1;
        private Dados.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator pessoaBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton pessoaBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nomeTextBox1;
        private System.Windows.Forms.TextBox enderecoTextBox1;
        private System.Windows.Forms.TextBox cidadeTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.DateTimePicker dataNascDateTimePicker1;
        private System.Windows.Forms.DataGridView pessoaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}