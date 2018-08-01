namespace RecepcaoApresentacao {
    partial class TelaVisitantes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRNE = new System.Windows.Forms.TextBox();
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.BtnNovaVisita = new System.Windows.Forms.Button();
            this.DgvVisitantes = new System.Windows.Forms.DataGridView();
            this.idVisitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estrangeiroDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recepcaoSistemaDataSet = new RecepcaoApresentacao.RecepcaoSistemaDataSet();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtUF = new System.Windows.Forms.TextBox();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.ChbEstrangeiro = new System.Windows.Forms.CheckBox();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.visitanteTableAdapter = new RecepcaoApresentacao.RecepcaoSistemaDataSetTableAdapters.VisitanteTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcaoSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRNE);
            this.groupBox1.Controls.Add(this.TxtRG);
            this.groupBox1.Controls.Add(this.BtnNovaVisita);
            this.groupBox1.Controls.Add(this.DgvVisitantes);
            this.groupBox1.Controls.Add(this.TxtCPF);
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnExcluir);
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.TxtUF);
            this.groupBox1.Controls.Add(this.TxtPais);
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.TxtBairro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtLogradouro);
            this.groupBox1.Controls.Add(this.ChbEstrangeiro);
            this.groupBox1.Controls.Add(this.TxtIdade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(542, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Visitantes";
            // 
            // TxtRNE
            // 
            this.TxtRNE.Location = new System.Drawing.Point(71, 97);
            this.TxtRNE.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRNE.Name = "TxtRNE";
            this.TxtRNE.Size = new System.Drawing.Size(193, 20);
            this.TxtRNE.TabIndex = 4;
            // 
            // TxtRG
            // 
            this.TxtRG.Location = new System.Drawing.Point(71, 73);
            this.TxtRG.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(193, 20);
            this.TxtRG.TabIndex = 3;
            // 
            // BtnNovaVisita
            // 
            this.BtnNovaVisita.Location = new System.Drawing.Point(380, 74);
            this.BtnNovaVisita.Name = "BtnNovaVisita";
            this.BtnNovaVisita.Size = new System.Drawing.Size(155, 46);
            this.BtnNovaVisita.TabIndex = 22;
            this.BtnNovaVisita.Text = "Cadastrar Nova Visita";
            this.BtnNovaVisita.UseVisualStyleBackColor = true;
            this.BtnNovaVisita.Click += new System.EventHandler(this.BtnNovaVisita_Click);
            // 
            // DgvVisitantes
            // 
            this.DgvVisitantes.AllowUserToAddRows = false;
            this.DgvVisitantes.AllowUserToOrderColumns = true;
            this.DgvVisitantes.AutoGenerateColumns = false;
            this.DgvVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVisitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisitanteDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.rNEDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.estrangeiroDataGridViewCheckBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.fotoDataGridViewTextBoxColumn});
            this.DgvVisitantes.DataSource = this.visitanteBindingSource;
            this.DgvVisitantes.Location = new System.Drawing.Point(4, 218);
            this.DgvVisitantes.Name = "DgvVisitantes";
            this.DgvVisitantes.ReadOnly = true;
            this.DgvVisitantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVisitantes.Size = new System.Drawing.Size(532, 154);
            this.DgvVisitantes.TabIndex = 21;
            this.DgvVisitantes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVisitantes_CellContentDoubleClick);
            // 
            // idVisitanteDataGridViewTextBoxColumn
            // 
            this.idVisitanteDataGridViewTextBoxColumn.DataPropertyName = "IdVisitante";
            this.idVisitanteDataGridViewTextBoxColumn.HeaderText = "IdVisitante";
            this.idVisitanteDataGridViewTextBoxColumn.Name = "idVisitanteDataGridViewTextBoxColumn";
            this.idVisitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rNEDataGridViewTextBoxColumn
            // 
            this.rNEDataGridViewTextBoxColumn.DataPropertyName = "RNE";
            this.rNEDataGridViewTextBoxColumn.HeaderText = "RNE";
            this.rNEDataGridViewTextBoxColumn.Name = "rNEDataGridViewTextBoxColumn";
            this.rNEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estrangeiroDataGridViewCheckBoxColumn
            // 
            this.estrangeiroDataGridViewCheckBoxColumn.DataPropertyName = "Estrangeiro";
            this.estrangeiroDataGridViewCheckBoxColumn.HeaderText = "Estrangeiro";
            this.estrangeiroDataGridViewCheckBoxColumn.Name = "estrangeiroDataGridViewCheckBoxColumn";
            this.estrangeiroDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewTextBoxColumn
            // 
            this.fotoDataGridViewTextBoxColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewTextBoxColumn.HeaderText = "Foto";
            this.fotoDataGridViewTextBoxColumn.Name = "fotoDataGridViewTextBoxColumn";
            this.fotoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitanteBindingSource
            // 
            this.visitanteBindingSource.DataMember = "Visitante";
            this.visitanteBindingSource.DataSource = this.recepcaoSistemaDataSet;
            // 
            // recepcaoSistemaDataSet
            // 
            this.recepcaoSistemaDataSet.DataSetName = "RecepcaoSistemaDataSet";
            this.recepcaoSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(71, 48);
            this.TxtCPF.Mask = "000,000,000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(193, 20);
            this.TxtCPF.TabIndex = 2;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(380, 23);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(155, 45);
            this.BtnPesquisar.TabIndex = 18;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(416, 377);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 49);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(281, 377);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(120, 49);
            this.BtnExcluir.TabIndex = 15;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(146, 377);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 49);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtUF
            // 
            this.TxtUF.Location = new System.Drawing.Point(71, 193);
            this.TxtUF.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUF.Name = "TxtUF";
            this.TxtUF.Size = new System.Drawing.Size(193, 20);
            this.TxtUF.TabIndex = 10;
            // 
            // TxtPais
            // 
            this.TxtPais.Location = new System.Drawing.Point(325, 193);
            this.TxtPais.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(211, 20);
            this.TxtPais.TabIndex = 11;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(325, 169);
            this.TxtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(211, 20);
            this.TxtCidade.TabIndex = 9;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(71, 169);
            this.TxtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(193, 20);
            this.TxtBairro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "País:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "UF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Bairro:";
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(71, 145);
            this.TxtLogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(464, 20);
            this.TxtLogradouro.TabIndex = 7;
            // 
            // ChbEstrangeiro
            // 
            this.ChbEstrangeiro.AutoSize = true;
            this.ChbEstrangeiro.Location = new System.Drawing.Point(281, 26);
            this.ChbEstrangeiro.Margin = new System.Windows.Forms.Padding(2);
            this.ChbEstrangeiro.Name = "ChbEstrangeiro";
            this.ChbEstrangeiro.Size = new System.Drawing.Size(79, 17);
            this.ChbEstrangeiro.TabIndex = 5;
            this.ChbEstrangeiro.Text = "Estrangeiro";
            this.ChbEstrangeiro.UseVisualStyleBackColor = true;
            this.ChbEstrangeiro.Click += new System.EventHandler(this.ChbEstrangeiro_Click);
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(71, 121);
            this.TxtIdade.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(193, 20);
            this.TxtIdade.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "RNE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(71, 23);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(193, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(4, 377);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 49);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // visitanteTableAdapter
            // 
            this.visitanteTableAdapter.ClearBeforeFill = true;
            // 
            // TelaVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 452);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaVisitantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Recepção - Visitantes";
            this.Load += new System.EventHandler(this.TelaVisitantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcaoSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox TxtUF;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.CheckBox ChbEstrangeiro;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.DataGridView DgvVisitantes;
        private RecepcaoSistemaDataSet recepcaoSistemaDataSet;
        private System.Windows.Forms.BindingSource visitanteBindingSource;
        private RecepcaoSistemaDataSetTableAdapters.VisitanteTableAdapter visitanteTableAdapter;
        private System.Windows.Forms.Button BtnNovaVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estrangeiroDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtRNE;
        private System.Windows.Forms.TextBox TxtRG;
    }
}