namespace ArvoreBinaria
{
    partial class frmArvore
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
      this.pnlArvore = new System.Windows.Forms.Panel();
      this.lblAltura = new System.Windows.Forms.Label();
      this.chkBalanceada = new System.Windows.Forms.CheckBox();
      this.txtChave = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnIncluir = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.btnGravar = new System.Windows.Forms.Button();
      this.btnLerDadosParticionados = new System.Windows.Forms.Button();
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.label3 = new System.Windows.Forms.Label();
      this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.txtSecao = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtMatriculaChefe = new System.Windows.Forms.TextBox();
      this.txtDependentes = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtSalario = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.chkAfastado = new System.Windows.Forms.CheckBox();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.lbQuantosNos = new System.Windows.Forms.Label();
      this.lbQuantasFolhas = new System.Windows.Forms.Label();
      this.lbExtritamenteBinaria = new System.Windows.Forms.Label();
      this.chkEstritamenteBinaria = new System.Windows.Forms.CheckBox();
      this.LbEntreParenteses = new System.Windows.Forms.Label();
      this.chkEspelhar = new System.Windows.Forms.CheckBox();
      this.lbPorNiveis = new System.Windows.Forms.Label();
      this.lbLargura = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // pnlArvore
      // 
      this.pnlArvore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlArvore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.pnlArvore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlArvore.Location = new System.Drawing.Point(9, 138);
      this.pnlArvore.Margin = new System.Windows.Forms.Padding(4);
      this.pnlArvore.Name = "pnlArvore";
      this.pnlArvore.Size = new System.Drawing.Size(1495, 659);
      this.pnlArvore.TabIndex = 1;
      this.pnlArvore.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlArvore_Paint);
      // 
      // lblAltura
      // 
      this.lblAltura.AutoSize = true;
      this.lblAltura.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAltura.Location = new System.Drawing.Point(171, 43);
      this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblAltura.Name = "lblAltura";
      this.lblAltura.Size = new System.Drawing.Size(56, 19);
      this.lblAltura.TabIndex = 2;
      this.lblAltura.Text = "Altura:";
      // 
      // chkBalanceada
      // 
      this.chkBalanceada.AutoSize = true;
      this.chkBalanceada.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkBalanceada.Location = new System.Drawing.Point(175, 15);
      this.chkBalanceada.Margin = new System.Windows.Forms.Padding(4);
      this.chkBalanceada.Name = "chkBalanceada";
      this.chkBalanceada.Size = new System.Drawing.Size(117, 23);
      this.chkBalanceada.TabIndex = 3;
      this.chkBalanceada.Text = "Balanceada";
      this.chkBalanceada.UseVisualStyleBackColor = true;
      // 
      // txtChave
      // 
      this.txtChave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtChave.Location = new System.Drawing.Point(434, 11);
      this.txtChave.Margin = new System.Windows.Forms.Padding(4);
      this.txtChave.MaxLength = 5;
      this.txtChave.Name = "txtChave";
      this.txtChave.Size = new System.Drawing.Size(75, 27);
      this.txtChave.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(328, 13);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(81, 19);
      this.label1.TabIndex = 5;
      this.label1.Text = "Matrícula:";
      // 
      // btnIncluir
      // 
      this.btnIncluir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnIncluir.Location = new System.Drawing.Point(1310, 55);
      this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
      this.btnIncluir.Name = "btnIncluir";
      this.btnIncluir.Size = new System.Drawing.Size(97, 41);
      this.btnIncluir.TabIndex = 8;
      this.btnIncluir.Text = "Incluir";
      this.btnIncluir.UseVisualStyleBackColor = true;
      this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(538, 14);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 19);
      this.label2.TabIndex = 9;
      this.label2.Text = "Nome:";
      // 
      // txtNome
      // 
      this.txtNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNome.Location = new System.Drawing.Point(602, 13);
      this.txtNome.Margin = new System.Windows.Forms.Padding(4);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(447, 27);
      this.txtNome.TabIndex = 10;
      // 
      // btnGravar
      // 
      this.btnGravar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGravar.Location = new System.Drawing.Point(9, 61);
      this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(138, 41);
      this.btnGravar.TabIndex = 11;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = true;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // btnLerDadosParticionados
      // 
      this.btnLerDadosParticionados.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLerDadosParticionados.Location = new System.Drawing.Point(9, 12);
      this.btnLerDadosParticionados.Margin = new System.Windows.Forms.Padding(4);
      this.btnLerDadosParticionados.Name = "btnLerDadosParticionados";
      this.btnLerDadosParticionados.Size = new System.Drawing.Size(138, 41);
      this.btnLerDadosParticionados.TabIndex = 12;
      this.btnLerDadosParticionados.Text = "Ler Registros";
      this.btnLerDadosParticionados.UseVisualStyleBackColor = true;
      this.btnLerDadosParticionados.Click += new System.EventHandler(this.btnLerDadosParticionados_Click);
      // 
      // dlgAbrir
      // 
      this.dlgAbrir.CheckFileExists = false;
      this.dlgAbrir.DefaultExt = "*.dat";
      this.dlgAbrir.InitialDirectory = "c:\\temp";
      this.dlgAbrir.Title = "Selecione o arquivo de funcionários";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(1061, 15);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(99, 19);
      this.label3.TabIndex = 13;
      this.label3.Text = "Nascimento:";
      // 
      // dtpNascimento
      // 
      this.dtpNascimento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpNascimento.Location = new System.Drawing.Point(1168, 11);
      this.dtpNascimento.Margin = new System.Windows.Forms.Padding(4);
      this.dtpNascimento.Name = "dtpNascimento";
      this.dtpNascimento.Size = new System.Drawing.Size(344, 27);
      this.dtpNascimento.TabIndex = 14;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(538, 69);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(61, 19);
      this.label4.TabIndex = 15;
      this.label4.Text = "Seção:";
      // 
      // txtSecao
      // 
      this.txtSecao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSecao.Location = new System.Drawing.Point(602, 66);
      this.txtSecao.Margin = new System.Windows.Forms.Padding(4);
      this.txtSecao.MaxLength = 5;
      this.txtSecao.Name = "txtSecao";
      this.txtSecao.Size = new System.Drawing.Size(49, 27);
      this.txtSecao.TabIndex = 16;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(327, 65);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(99, 19);
      this.label5.TabIndex = 18;
      this.label5.Text = "Matr. Chefe:";
      // 
      // txtMatriculaChefe
      // 
      this.txtMatriculaChefe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMatriculaChefe.Location = new System.Drawing.Point(434, 63);
      this.txtMatriculaChefe.Margin = new System.Windows.Forms.Padding(4);
      this.txtMatriculaChefe.MaxLength = 5;
      this.txtMatriculaChefe.Name = "txtMatriculaChefe";
      this.txtMatriculaChefe.Size = new System.Drawing.Size(75, 27);
      this.txtMatriculaChefe.TabIndex = 17;
      // 
      // txtDependentes
      // 
      this.txtDependentes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDependentes.Location = new System.Drawing.Point(790, 66);
      this.txtDependentes.Margin = new System.Windows.Forms.Padding(4);
      this.txtDependentes.MaxLength = 5;
      this.txtDependentes.Name = "txtDependentes";
      this.txtDependentes.Size = new System.Drawing.Size(41, 27);
      this.txtDependentes.TabIndex = 18;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(672, 69);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(110, 19);
      this.label6.TabIndex = 17;
      this.label6.Text = "Dependentes:";
      // 
      // txtSalario
      // 
      this.txtSalario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSalario.Location = new System.Drawing.Point(923, 63);
      this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
      this.txtSalario.MaxLength = 5;
      this.txtSalario.Name = "txtSalario";
      this.txtSalario.Size = new System.Drawing.Size(126, 27);
      this.txtSalario.TabIndex = 20;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(850, 69);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(65, 19);
      this.label7.TabIndex = 19;
      this.label7.Text = "Salário:";
      // 
      // chkAfastado
      // 
      this.chkAfastado.AutoSize = true;
      this.chkAfastado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkAfastado.Location = new System.Drawing.Point(1065, 67);
      this.chkAfastado.Name = "chkAfastado";
      this.chkAfastado.Size = new System.Drawing.Size(95, 23);
      this.chkAfastado.TabIndex = 21;
      this.chkAfastado.Text = "Afastado";
      this.chkAfastado.UseVisualStyleBackColor = true;
      // 
      // btnExcluir
      // 
      this.btnExcluir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExcluir.Location = new System.Drawing.Point(1415, 55);
      this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(97, 41);
      this.btnExcluir.TabIndex = 22;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(1195, 55);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(97, 41);
      this.btnBuscar.TabIndex = 23;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // lbQuantosNos
      // 
      this.lbQuantosNos.AutoSize = true;
      this.lbQuantosNos.Location = new System.Drawing.Point(12, 111);
      this.lbQuantosNos.Name = "lbQuantosNos";
      this.lbQuantosNos.Size = new System.Drawing.Size(42, 19);
      this.lbQuantosNos.TabIndex = 24;
      this.lbQuantosNos.Text = "Nós:";
      this.lbQuantosNos.DoubleClick += new System.EventHandler(this.lbQuantosNos_DoubleClick);
      // 
      // lbQuantasFolhas
      // 
      this.lbQuantasFolhas.AutoSize = true;
      this.lbQuantasFolhas.Location = new System.Drawing.Point(85, 111);
      this.lbQuantasFolhas.Name = "lbQuantasFolhas";
      this.lbQuantasFolhas.Size = new System.Drawing.Size(62, 19);
      this.lbQuantasFolhas.TabIndex = 25;
      this.lbQuantasFolhas.Text = "Folhas:";
      this.lbQuantasFolhas.Click += new System.EventHandler(this.lbQuantasFolhas_Click);
      this.lbQuantasFolhas.DoubleClick += new System.EventHandler(this.lbQuantasFolhas_DoubleClick);
      // 
      // lbExtritamenteBinaria
      // 
      this.lbExtritamenteBinaria.AutoSize = true;
      this.lbExtritamenteBinaria.Location = new System.Drawing.Point(181, 111);
      this.lbExtritamenteBinaria.Name = "lbExtritamenteBinaria";
      this.lbExtritamenteBinaria.Size = new System.Drawing.Size(46, 19);
      this.lbExtritamenteBinaria.TabIndex = 26;
      this.lbExtritamenteBinaria.Text = "E.B.:";
      this.lbExtritamenteBinaria.DoubleClick += new System.EventHandler(this.lbExtritamenteBinaria_DoubleClick);
      // 
      // chkEstritamenteBinaria
      // 
      this.chkEstritamenteBinaria.AutoSize = true;
      this.chkEstritamenteBinaria.Location = new System.Drawing.Point(233, 111);
      this.chkEstritamenteBinaria.Name = "chkEstritamenteBinaria";
      this.chkEstritamenteBinaria.Size = new System.Drawing.Size(18, 17);
      this.chkEstritamenteBinaria.TabIndex = 27;
      this.chkEstritamenteBinaria.UseVisualStyleBackColor = true;
      // 
      // LbEntreParenteses
      // 
      this.LbEntreParenteses.AutoSize = true;
      this.LbEntreParenteses.Location = new System.Drawing.Point(284, 109);
      this.LbEntreParenteses.Name = "LbEntreParenteses";
      this.LbEntreParenteses.Size = new System.Drawing.Size(26, 19);
      this.LbEntreParenteses.TabIndex = 28;
      this.LbEntreParenteses.Text = "( )";
      this.LbEntreParenteses.DoubleClick += new System.EventHandler(this.LbEntreParenteses_DoubleClick);
      // 
      // chkEspelhar
      // 
      this.chkEspelhar.AutoSize = true;
      this.chkEspelhar.Location = new System.Drawing.Point(376, 113);
      this.chkEspelhar.Name = "chkEspelhar";
      this.chkEspelhar.Size = new System.Drawing.Size(95, 23);
      this.chkEspelhar.TabIndex = 29;
      this.chkEspelhar.Text = "Espelhar";
      this.chkEspelhar.UseVisualStyleBackColor = true;
      this.chkEspelhar.Click += new System.EventHandler(this.chkEspelhar_Click);
      // 
      // lbPorNiveis
      // 
      this.lbPorNiveis.AutoSize = true;
      this.lbPorNiveis.Location = new System.Drawing.Point(510, 113);
      this.lbPorNiveis.Name = "lbPorNiveis";
      this.lbPorNiveis.Size = new System.Drawing.Size(84, 19);
      this.lbPorNiveis.TabIndex = 30;
      this.lbPorNiveis.Text = "Por Níveis";
      this.lbPorNiveis.DoubleClick += new System.EventHandler(this.lbPorNiveis_DoubleClick);
      // 
      // lbLargura
      // 
      this.lbLargura.AutoSize = true;
      this.lbLargura.Location = new System.Drawing.Point(1061, 111);
      this.lbLargura.Name = "lbLargura";
      this.lbLargura.Size = new System.Drawing.Size(71, 19);
      this.lbLargura.TabIndex = 31;
      this.lbLargura.Text = "Largura:";
      this.lbLargura.DoubleClick += new System.EventHandler(this.lbLargura_DoubleClick);
      // 
      // frmArvore
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1517, 798);
      this.Controls.Add(this.lbLargura);
      this.Controls.Add(this.lbPorNiveis);
      this.Controls.Add(this.chkEspelhar);
      this.Controls.Add(this.LbEntreParenteses);
      this.Controls.Add(this.chkEstritamenteBinaria);
      this.Controls.Add(this.lbExtritamenteBinaria);
      this.Controls.Add(this.lbQuantasFolhas);
      this.Controls.Add(this.lbQuantosNos);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.chkAfastado);
      this.Controls.Add(this.txtSalario);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtDependentes);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtMatriculaChefe);
      this.Controls.Add(this.txtSecao);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.dtpNascimento);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnLerDadosParticionados);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnIncluir);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtChave);
      this.Controls.Add(this.chkBalanceada);
      this.Controls.Add(this.lblAltura);
      this.Controls.Add(this.pnlArvore);
      this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmArvore";
      this.Text = "Árvores Balanceadas";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlArvore;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.CheckBox chkBalanceada;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLerDadosParticionados;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatriculaChefe;
        private System.Windows.Forms.TextBox txtDependentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAfastado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Label lbQuantosNos;
    private System.Windows.Forms.Label lbQuantasFolhas;
    private System.Windows.Forms.Label lbExtritamenteBinaria;
    private System.Windows.Forms.CheckBox chkEstritamenteBinaria;
    private System.Windows.Forms.Label LbEntreParenteses;
    private System.Windows.Forms.CheckBox chkEspelhar;
    private System.Windows.Forms.Label lbPorNiveis;
    private System.Windows.Forms.Label lbLargura;
  }
}

