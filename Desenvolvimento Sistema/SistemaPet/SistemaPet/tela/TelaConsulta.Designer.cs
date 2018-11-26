namespace SistemaPet.tela
{
    partial class TelaConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbcConsultas = new MetroFramework.Controls.MetroTabControl();
            this.tbpConsultaDono = new MetroFramework.Controls.MetroTabPage();
            this.dgvDonos = new System.Windows.Forms.DataGridView();
            this.iddonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomedonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonedonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaildonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruadonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCasadonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairrodonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadedonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadodonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemapetDataSet1 = new SistemaPet.db_sistemapetDataSet1();
            this.lblCadastroAdestrador = new System.Windows.Forms.Label();
            this.tbpConsultaAdestradores = new MetroFramework.Controls.MetroTabPage();
            this.dgvAdestradores = new System.Windows.Forms.DataGridView();
            this.idadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCasaadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoadestradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adestradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemapetDataSet2 = new SistemaPet.db_sistemapetDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpConsultaPets = new MetroFramework.Controls.MetroTabPage();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.idpetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddonoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadestradorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomepetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racapetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generopetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemapetDataSet3 = new SistemaPet.db_sistemapetDataSet3();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpConsultaFuncionarios = new MetroFramework.Controls.MetroTabPage();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.idfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargofuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonefuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruafuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCasafuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairrofuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadefuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadofuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemapetDataSet4 = new SistemaPet.db_sistemapetDataSet4();
            this.label4 = new System.Windows.Forms.Label();
            this.donoTableAdapter = new SistemaPet.db_sistemapetDataSet1TableAdapters.DonoTableAdapter();
            this.adestradorTableAdapter = new SistemaPet.db_sistemapetDataSet2TableAdapters.AdestradorTableAdapter();
            this.petTableAdapter = new SistemaPet.db_sistemapetDataSet3TableAdapters.PetTableAdapter();
            this.funcionarioTableAdapter = new SistemaPet.db_sistemapetDataSet4TableAdapters.FuncionarioTableAdapter();
            this.tbcConsultas.SuspendLayout();
            this.tbpConsultaDono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet1)).BeginInit();
            this.tbpConsultaAdestradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdestradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adestradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet2)).BeginInit();
            this.tbpConsultaPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet3)).BeginInit();
            this.tbpConsultaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 35);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cadastro Adestradores";
            // 
            // tbcConsultas
            // 
            this.tbcConsultas.Controls.Add(this.tbpConsultaDono);
            this.tbcConsultas.Controls.Add(this.tbpConsultaAdestradores);
            this.tbcConsultas.Controls.Add(this.tbpConsultaPets);
            this.tbcConsultas.Controls.Add(this.tbpConsultaFuncionarios);
            this.tbcConsultas.Location = new System.Drawing.Point(15, 14);
            this.tbcConsultas.Name = "tbcConsultas";
            this.tbcConsultas.SelectedIndex = 3;
            this.tbcConsultas.Size = new System.Drawing.Size(1096, 560);
            this.tbcConsultas.TabIndex = 0;
            this.tbcConsultas.UseSelectable = true;
            // 
            // tbpConsultaDono
            // 
            this.tbpConsultaDono.Controls.Add(this.dgvDonos);
            this.tbpConsultaDono.Controls.Add(this.lblCadastroAdestrador);
            this.tbpConsultaDono.HorizontalScrollbarBarColor = true;
            this.tbpConsultaDono.HorizontalScrollbarHighlightOnWheel = false;
            this.tbpConsultaDono.HorizontalScrollbarSize = 10;
            this.tbpConsultaDono.Location = new System.Drawing.Point(4, 38);
            this.tbpConsultaDono.Name = "tbpConsultaDono";
            this.tbpConsultaDono.Size = new System.Drawing.Size(1088, 518);
            this.tbpConsultaDono.TabIndex = 0;
            this.tbpConsultaDono.Text = "Donos";
            this.tbpConsultaDono.VerticalScrollbarBarColor = true;
            this.tbpConsultaDono.VerticalScrollbarHighlightOnWheel = false;
            this.tbpConsultaDono.VerticalScrollbarSize = 10;
            // 
            // dgvDonos
            // 
            this.dgvDonos.AutoGenerateColumns = false;
            this.dgvDonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddonoDataGridViewTextBoxColumn,
            this.nomedonoDataGridViewTextBoxColumn,
            this.telefonedonoDataGridViewTextBoxColumn,
            this.emaildonoDataGridViewTextBoxColumn,
            this.ruadonoDataGridViewTextBoxColumn,
            this.numCasadonoDataGridViewTextBoxColumn,
            this.bairrodonoDataGridViewTextBoxColumn,
            this.cidadedonoDataGridViewTextBoxColumn,
            this.estadodonoDataGridViewTextBoxColumn});
            this.dgvDonos.DataSource = this.donoBindingSource;
            this.dgvDonos.Location = new System.Drawing.Point(3, 62);
            this.dgvDonos.Name = "dgvDonos";
            this.dgvDonos.RowTemplate.Height = 24;
            this.dgvDonos.Size = new System.Drawing.Size(1082, 453);
            this.dgvDonos.TabIndex = 76;
            // 
            // iddonoDataGridViewTextBoxColumn
            // 
            this.iddonoDataGridViewTextBoxColumn.DataPropertyName = "id_dono";
            this.iddonoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iddonoDataGridViewTextBoxColumn.Name = "iddonoDataGridViewTextBoxColumn";
            this.iddonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomedonoDataGridViewTextBoxColumn
            // 
            this.nomedonoDataGridViewTextBoxColumn.DataPropertyName = "nome_dono";
            this.nomedonoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomedonoDataGridViewTextBoxColumn.Name = "nomedonoDataGridViewTextBoxColumn";
            // 
            // telefonedonoDataGridViewTextBoxColumn
            // 
            this.telefonedonoDataGridViewTextBoxColumn.DataPropertyName = "telefone_dono";
            this.telefonedonoDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefonedonoDataGridViewTextBoxColumn.Name = "telefonedonoDataGridViewTextBoxColumn";
            // 
            // emaildonoDataGridViewTextBoxColumn
            // 
            this.emaildonoDataGridViewTextBoxColumn.DataPropertyName = "email_dono";
            this.emaildonoDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emaildonoDataGridViewTextBoxColumn.Name = "emaildonoDataGridViewTextBoxColumn";
            // 
            // ruadonoDataGridViewTextBoxColumn
            // 
            this.ruadonoDataGridViewTextBoxColumn.DataPropertyName = "rua_dono";
            this.ruadonoDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruadonoDataGridViewTextBoxColumn.Name = "ruadonoDataGridViewTextBoxColumn";
            // 
            // numCasadonoDataGridViewTextBoxColumn
            // 
            this.numCasadonoDataGridViewTextBoxColumn.DataPropertyName = "numCasa_dono";
            this.numCasadonoDataGridViewTextBoxColumn.HeaderText = "Num. Casa";
            this.numCasadonoDataGridViewTextBoxColumn.Name = "numCasadonoDataGridViewTextBoxColumn";
            // 
            // bairrodonoDataGridViewTextBoxColumn
            // 
            this.bairrodonoDataGridViewTextBoxColumn.DataPropertyName = "bairro_dono";
            this.bairrodonoDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairrodonoDataGridViewTextBoxColumn.Name = "bairrodonoDataGridViewTextBoxColumn";
            // 
            // cidadedonoDataGridViewTextBoxColumn
            // 
            this.cidadedonoDataGridViewTextBoxColumn.DataPropertyName = "cidade_dono";
            this.cidadedonoDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadedonoDataGridViewTextBoxColumn.Name = "cidadedonoDataGridViewTextBoxColumn";
            // 
            // estadodonoDataGridViewTextBoxColumn
            // 
            this.estadodonoDataGridViewTextBoxColumn.DataPropertyName = "estado_dono";
            this.estadodonoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadodonoDataGridViewTextBoxColumn.Name = "estadodonoDataGridViewTextBoxColumn";
            // 
            // donoBindingSource
            // 
            this.donoBindingSource.DataMember = "Dono";
            this.donoBindingSource.DataSource = this.db_sistemapetDataSet1;
            // 
            // db_sistemapetDataSet1
            // 
            this.db_sistemapetDataSet1.DataSetName = "db_sistemapetDataSet1";
            this.db_sistemapetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCadastroAdestrador
            // 
            this.lblCadastroAdestrador.AutoSize = true;
            this.lblCadastroAdestrador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCadastroAdestrador.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroAdestrador.Location = new System.Drawing.Point(4, 10);
            this.lblCadastroAdestrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroAdestrador.Name = "lblCadastroAdestrador";
            this.lblCadastroAdestrador.Size = new System.Drawing.Size(242, 35);
            this.lblCadastroAdestrador.TabIndex = 75;
            this.lblCadastroAdestrador.Text = "Donos Cadastrados:";
            // 
            // tbpConsultaAdestradores
            // 
            this.tbpConsultaAdestradores.Controls.Add(this.dgvAdestradores);
            this.tbpConsultaAdestradores.Controls.Add(this.label2);
            this.tbpConsultaAdestradores.HorizontalScrollbarBarColor = true;
            this.tbpConsultaAdestradores.HorizontalScrollbarHighlightOnWheel = false;
            this.tbpConsultaAdestradores.HorizontalScrollbarSize = 10;
            this.tbpConsultaAdestradores.Location = new System.Drawing.Point(4, 38);
            this.tbpConsultaAdestradores.Name = "tbpConsultaAdestradores";
            this.tbpConsultaAdestradores.Size = new System.Drawing.Size(1088, 518);
            this.tbpConsultaAdestradores.TabIndex = 1;
            this.tbpConsultaAdestradores.Text = "Adestradores";
            this.tbpConsultaAdestradores.VerticalScrollbarBarColor = true;
            this.tbpConsultaAdestradores.VerticalScrollbarHighlightOnWheel = false;
            this.tbpConsultaAdestradores.VerticalScrollbarSize = 10;
            // 
            // dgvAdestradores
            // 
            this.dgvAdestradores.AutoGenerateColumns = false;
            this.dgvAdestradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdestradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idadestradorDataGridViewTextBoxColumn,
            this.nomeadestradorDataGridViewTextBoxColumn,
            this.telefoneadestradorDataGridViewTextBoxColumn,
            this.emailadestradorDataGridViewTextBoxColumn,
            this.ruaadestradorDataGridViewTextBoxColumn,
            this.numCasaadestradorDataGridViewTextBoxColumn,
            this.bairroadestradorDataGridViewTextBoxColumn,
            this.cidadeadestradorDataGridViewTextBoxColumn,
            this.estadoadestradorDataGridViewTextBoxColumn});
            this.dgvAdestradores.DataSource = this.adestradorBindingSource;
            this.dgvAdestradores.Location = new System.Drawing.Point(3, 59);
            this.dgvAdestradores.Name = "dgvAdestradores";
            this.dgvAdestradores.RowTemplate.Height = 24;
            this.dgvAdestradores.Size = new System.Drawing.Size(1082, 453);
            this.dgvAdestradores.TabIndex = 78;
            // 
            // idadestradorDataGridViewTextBoxColumn
            // 
            this.idadestradorDataGridViewTextBoxColumn.DataPropertyName = "id_adestrador";
            this.idadestradorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idadestradorDataGridViewTextBoxColumn.Name = "idadestradorDataGridViewTextBoxColumn";
            this.idadestradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeadestradorDataGridViewTextBoxColumn
            // 
            this.nomeadestradorDataGridViewTextBoxColumn.DataPropertyName = "nome_adestrador";
            this.nomeadestradorDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeadestradorDataGridViewTextBoxColumn.Name = "nomeadestradorDataGridViewTextBoxColumn";
            // 
            // telefoneadestradorDataGridViewTextBoxColumn
            // 
            this.telefoneadestradorDataGridViewTextBoxColumn.DataPropertyName = "telefone_adestrador";
            this.telefoneadestradorDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneadestradorDataGridViewTextBoxColumn.Name = "telefoneadestradorDataGridViewTextBoxColumn";
            // 
            // emailadestradorDataGridViewTextBoxColumn
            // 
            this.emailadestradorDataGridViewTextBoxColumn.DataPropertyName = "email_adestrador";
            this.emailadestradorDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailadestradorDataGridViewTextBoxColumn.Name = "emailadestradorDataGridViewTextBoxColumn";
            // 
            // ruaadestradorDataGridViewTextBoxColumn
            // 
            this.ruaadestradorDataGridViewTextBoxColumn.DataPropertyName = "rua_adestrador";
            this.ruaadestradorDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaadestradorDataGridViewTextBoxColumn.Name = "ruaadestradorDataGridViewTextBoxColumn";
            // 
            // numCasaadestradorDataGridViewTextBoxColumn
            // 
            this.numCasaadestradorDataGridViewTextBoxColumn.DataPropertyName = "numCasa_adestrador";
            this.numCasaadestradorDataGridViewTextBoxColumn.HeaderText = "Num. Casa";
            this.numCasaadestradorDataGridViewTextBoxColumn.Name = "numCasaadestradorDataGridViewTextBoxColumn";
            // 
            // bairroadestradorDataGridViewTextBoxColumn
            // 
            this.bairroadestradorDataGridViewTextBoxColumn.DataPropertyName = "bairro_adestrador";
            this.bairroadestradorDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroadestradorDataGridViewTextBoxColumn.Name = "bairroadestradorDataGridViewTextBoxColumn";
            // 
            // cidadeadestradorDataGridViewTextBoxColumn
            // 
            this.cidadeadestradorDataGridViewTextBoxColumn.DataPropertyName = "cidade_adestrador";
            this.cidadeadestradorDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeadestradorDataGridViewTextBoxColumn.Name = "cidadeadestradorDataGridViewTextBoxColumn";
            // 
            // estadoadestradorDataGridViewTextBoxColumn
            // 
            this.estadoadestradorDataGridViewTextBoxColumn.DataPropertyName = "estado_adestrador";
            this.estadoadestradorDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoadestradorDataGridViewTextBoxColumn.Name = "estadoadestradorDataGridViewTextBoxColumn";
            // 
            // adestradorBindingSource
            // 
            this.adestradorBindingSource.DataMember = "Adestrador";
            this.adestradorBindingSource.DataSource = this.db_sistemapetDataSet2;
            // 
            // db_sistemapetDataSet2
            // 
            this.db_sistemapetDataSet2.DataSetName = "db_sistemapetDataSet2";
            this.db_sistemapetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 35);
            this.label2.TabIndex = 77;
            this.label2.Text = "Adestradores Cadastrados:";
            // 
            // tbpConsultaPets
            // 
            this.tbpConsultaPets.Controls.Add(this.dgvPets);
            this.tbpConsultaPets.Controls.Add(this.label3);
            this.tbpConsultaPets.HorizontalScrollbarBarColor = true;
            this.tbpConsultaPets.HorizontalScrollbarHighlightOnWheel = false;
            this.tbpConsultaPets.HorizontalScrollbarSize = 10;
            this.tbpConsultaPets.Location = new System.Drawing.Point(4, 38);
            this.tbpConsultaPets.Name = "tbpConsultaPets";
            this.tbpConsultaPets.Size = new System.Drawing.Size(1088, 518);
            this.tbpConsultaPets.TabIndex = 2;
            this.tbpConsultaPets.Text = "Pets";
            this.tbpConsultaPets.VerticalScrollbarBarColor = true;
            this.tbpConsultaPets.VerticalScrollbarHighlightOnWheel = false;
            this.tbpConsultaPets.VerticalScrollbarSize = 10;
            // 
            // dgvPets
            // 
            this.dgvPets.AutoGenerateColumns = false;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpetDataGridViewTextBoxColumn,
            this.iddonoDataGridViewTextBoxColumn1,
            this.idadestradorDataGridViewTextBoxColumn1,
            this.nomepetDataGridViewTextBoxColumn,
            this.tipopetDataGridViewTextBoxColumn,
            this.racapetDataGridViewTextBoxColumn,
            this.generopetDataGridViewTextBoxColumn,
            this.avaliacaoDataGridViewTextBoxColumn});
            this.dgvPets.DataSource = this.petBindingSource;
            this.dgvPets.Location = new System.Drawing.Point(3, 59);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.RowTemplate.Height = 24;
            this.dgvPets.Size = new System.Drawing.Size(1082, 453);
            this.dgvPets.TabIndex = 80;
            // 
            // idpetDataGridViewTextBoxColumn
            // 
            this.idpetDataGridViewTextBoxColumn.DataPropertyName = "id_pet";
            this.idpetDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idpetDataGridViewTextBoxColumn.Name = "idpetDataGridViewTextBoxColumn";
            this.idpetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddonoDataGridViewTextBoxColumn1
            // 
            this.iddonoDataGridViewTextBoxColumn1.DataPropertyName = "id_dono";
            this.iddonoDataGridViewTextBoxColumn1.HeaderText = "ID Dono";
            this.iddonoDataGridViewTextBoxColumn1.Name = "iddonoDataGridViewTextBoxColumn1";
            // 
            // idadestradorDataGridViewTextBoxColumn1
            // 
            this.idadestradorDataGridViewTextBoxColumn1.DataPropertyName = "id_adestrador";
            this.idadestradorDataGridViewTextBoxColumn1.HeaderText = "ID Adestrador";
            this.idadestradorDataGridViewTextBoxColumn1.Name = "idadestradorDataGridViewTextBoxColumn1";
            // 
            // nomepetDataGridViewTextBoxColumn
            // 
            this.nomepetDataGridViewTextBoxColumn.DataPropertyName = "nome_pet";
            this.nomepetDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomepetDataGridViewTextBoxColumn.Name = "nomepetDataGridViewTextBoxColumn";
            // 
            // tipopetDataGridViewTextBoxColumn
            // 
            this.tipopetDataGridViewTextBoxColumn.DataPropertyName = "tipo_pet";
            this.tipopetDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipopetDataGridViewTextBoxColumn.Name = "tipopetDataGridViewTextBoxColumn";
            // 
            // racapetDataGridViewTextBoxColumn
            // 
            this.racapetDataGridViewTextBoxColumn.DataPropertyName = "raca_pet";
            this.racapetDataGridViewTextBoxColumn.HeaderText = "Raça";
            this.racapetDataGridViewTextBoxColumn.Name = "racapetDataGridViewTextBoxColumn";
            // 
            // generopetDataGridViewTextBoxColumn
            // 
            this.generopetDataGridViewTextBoxColumn.DataPropertyName = "genero_pet";
            this.generopetDataGridViewTextBoxColumn.HeaderText = "Gênero";
            this.generopetDataGridViewTextBoxColumn.Name = "generopetDataGridViewTextBoxColumn";
            // 
            // avaliacaoDataGridViewTextBoxColumn
            // 
            this.avaliacaoDataGridViewTextBoxColumn.DataPropertyName = "avaliacao";
            this.avaliacaoDataGridViewTextBoxColumn.HeaderText = "Avaliação";
            this.avaliacaoDataGridViewTextBoxColumn.Name = "avaliacaoDataGridViewTextBoxColumn";
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.db_sistemapetDataSet3;
            // 
            // db_sistemapetDataSet3
            // 
            this.db_sistemapetDataSet3.DataSetName = "db_sistemapetDataSet3";
            this.db_sistemapetDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 35);
            this.label3.TabIndex = 79;
            this.label3.Text = "Pets Cadastrados:";
            // 
            // tbpConsultaFuncionarios
            // 
            this.tbpConsultaFuncionarios.Controls.Add(this.dgvFuncionarios);
            this.tbpConsultaFuncionarios.Controls.Add(this.label4);
            this.tbpConsultaFuncionarios.HorizontalScrollbarBarColor = true;
            this.tbpConsultaFuncionarios.HorizontalScrollbarHighlightOnWheel = false;
            this.tbpConsultaFuncionarios.HorizontalScrollbarSize = 10;
            this.tbpConsultaFuncionarios.Location = new System.Drawing.Point(4, 38);
            this.tbpConsultaFuncionarios.Name = "tbpConsultaFuncionarios";
            this.tbpConsultaFuncionarios.Size = new System.Drawing.Size(1088, 518);
            this.tbpConsultaFuncionarios.TabIndex = 3;
            this.tbpConsultaFuncionarios.Text = "Funcionarios";
            this.tbpConsultaFuncionarios.VerticalScrollbarBarColor = true;
            this.tbpConsultaFuncionarios.VerticalScrollbarHighlightOnWheel = false;
            this.tbpConsultaFuncionarios.VerticalScrollbarSize = 10;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AutoGenerateColumns = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfuncDataGridViewTextBoxColumn,
            this.nomefuncDataGridViewTextBoxColumn,
            this.cargofuncDataGridViewTextBoxColumn,
            this.telefonefuncDataGridViewTextBoxColumn,
            this.emailfuncDataGridViewTextBoxColumn,
            this.ruafuncDataGridViewTextBoxColumn,
            this.numCasafuncDataGridViewTextBoxColumn,
            this.bairrofuncDataGridViewTextBoxColumn,
            this.cidadefuncDataGridViewTextBoxColumn,
            this.estadofuncDataGridViewTextBoxColumn});
            this.dgvFuncionarios.DataSource = this.funcionarioBindingSource;
            this.dgvFuncionarios.Location = new System.Drawing.Point(3, 59);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowTemplate.Height = 24;
            this.dgvFuncionarios.Size = new System.Drawing.Size(1082, 453);
            this.dgvFuncionarios.TabIndex = 80;
            // 
            // idfuncDataGridViewTextBoxColumn
            // 
            this.idfuncDataGridViewTextBoxColumn.DataPropertyName = "id_func";
            this.idfuncDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idfuncDataGridViewTextBoxColumn.Name = "idfuncDataGridViewTextBoxColumn";
            this.idfuncDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefuncDataGridViewTextBoxColumn
            // 
            this.nomefuncDataGridViewTextBoxColumn.DataPropertyName = "nome_func";
            this.nomefuncDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomefuncDataGridViewTextBoxColumn.Name = "nomefuncDataGridViewTextBoxColumn";
            // 
            // cargofuncDataGridViewTextBoxColumn
            // 
            this.cargofuncDataGridViewTextBoxColumn.DataPropertyName = "cargo_func";
            this.cargofuncDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargofuncDataGridViewTextBoxColumn.Name = "cargofuncDataGridViewTextBoxColumn";
            // 
            // telefonefuncDataGridViewTextBoxColumn
            // 
            this.telefonefuncDataGridViewTextBoxColumn.DataPropertyName = "telefone_func";
            this.telefonefuncDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefonefuncDataGridViewTextBoxColumn.Name = "telefonefuncDataGridViewTextBoxColumn";
            // 
            // emailfuncDataGridViewTextBoxColumn
            // 
            this.emailfuncDataGridViewTextBoxColumn.DataPropertyName = "email_func";
            this.emailfuncDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailfuncDataGridViewTextBoxColumn.Name = "emailfuncDataGridViewTextBoxColumn";
            // 
            // ruafuncDataGridViewTextBoxColumn
            // 
            this.ruafuncDataGridViewTextBoxColumn.DataPropertyName = "rua_func";
            this.ruafuncDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruafuncDataGridViewTextBoxColumn.Name = "ruafuncDataGridViewTextBoxColumn";
            // 
            // numCasafuncDataGridViewTextBoxColumn
            // 
            this.numCasafuncDataGridViewTextBoxColumn.DataPropertyName = "numCasa_func";
            this.numCasafuncDataGridViewTextBoxColumn.HeaderText = "Num. Casa";
            this.numCasafuncDataGridViewTextBoxColumn.Name = "numCasafuncDataGridViewTextBoxColumn";
            // 
            // bairrofuncDataGridViewTextBoxColumn
            // 
            this.bairrofuncDataGridViewTextBoxColumn.DataPropertyName = "bairro_func";
            this.bairrofuncDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairrofuncDataGridViewTextBoxColumn.Name = "bairrofuncDataGridViewTextBoxColumn";
            // 
            // cidadefuncDataGridViewTextBoxColumn
            // 
            this.cidadefuncDataGridViewTextBoxColumn.DataPropertyName = "cidade_func";
            this.cidadefuncDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadefuncDataGridViewTextBoxColumn.Name = "cidadefuncDataGridViewTextBoxColumn";
            // 
            // estadofuncDataGridViewTextBoxColumn
            // 
            this.estadofuncDataGridViewTextBoxColumn.DataPropertyName = "estado_func";
            this.estadofuncDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadofuncDataGridViewTextBoxColumn.Name = "estadofuncDataGridViewTextBoxColumn";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.db_sistemapetDataSet4;
            // 
            // db_sistemapetDataSet4
            // 
            this.db_sistemapetDataSet4.DataSetName = "db_sistemapetDataSet4";
            this.db_sistemapetDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 35);
            this.label4.TabIndex = 79;
            this.label4.Text = "Funcionarios Cadastrados:";
            // 
            // donoTableAdapter
            // 
            this.donoTableAdapter.ClearBeforeFill = true;
            // 
            // adestradorTableAdapter
            // 
            this.adestradorTableAdapter.ClearBeforeFill = true;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 581);
            this.Controls.Add(this.tbcConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaConsulta";
            this.Load += new System.EventHandler(this.TelaConsulta_Load);
            this.tbcConsultas.ResumeLayout(false);
            this.tbpConsultaDono.ResumeLayout(false);
            this.tbpConsultaDono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet1)).EndInit();
            this.tbpConsultaAdestradores.ResumeLayout(false);
            this.tbpConsultaAdestradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdestradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adestradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet2)).EndInit();
            this.tbpConsultaPets.ResumeLayout(false);
            this.tbpConsultaPets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet3)).EndInit();
            this.tbpConsultaFuncionarios.ResumeLayout(false);
            this.tbpConsultaFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemapetDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tbcConsultas;
        private MetroFramework.Controls.MetroTabPage tbpConsultaDono;
        private MetroFramework.Controls.MetroTabPage tbpConsultaAdestradores;
        private MetroFramework.Controls.MetroTabPage tbpConsultaPets;
        private MetroFramework.Controls.MetroTabPage tbpConsultaFuncionarios;
        private System.Windows.Forms.DataGridView dgvDonos;
        private System.Windows.Forms.Label lblCadastroAdestrador;
        private System.Windows.Forms.DataGridView dgvAdestradores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Label label4;
        private db_sistemapetDataSet1 db_sistemapetDataSet1;
        private System.Windows.Forms.BindingSource donoBindingSource;
        private db_sistemapetDataSet1TableAdapters.DonoTableAdapter donoTableAdapter;
        private db_sistemapetDataSet2 db_sistemapetDataSet2;
        private System.Windows.Forms.BindingSource adestradorBindingSource;
        private db_sistemapetDataSet2TableAdapters.AdestradorTableAdapter adestradorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonedonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaildonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruadonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCasadonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairrodonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadedonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadodonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCasaadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeadestradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoadestradorDataGridViewTextBoxColumn;
        private db_sistemapetDataSet3 db_sistemapetDataSet3;
        private System.Windows.Forms.BindingSource petBindingSource;
        private db_sistemapetDataSet3TableAdapters.PetTableAdapter petTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddonoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadestradorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racapetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generopetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliacaoDataGridViewTextBoxColumn;
        private db_sistemapetDataSet4 db_sistemapetDataSet4;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private db_sistemapetDataSet4TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargofuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonefuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruafuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCasafuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairrofuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadefuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadofuncDataGridViewTextBoxColumn;
    }
}