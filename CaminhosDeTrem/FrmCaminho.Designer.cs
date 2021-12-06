namespace CaminhosDeTrem
{
    partial class FrmCaminho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaminho));
            this.tbApp = new System.Windows.Forms.TabControl();
            this.tbMapa = new System.Windows.Forms.TabPage();
            this.gbIncCidade = new System.Windows.Forms.GroupBox();
            this.btnIncluirCidade = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.lbNomeCidade = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.lsbCaminho = new System.Windows.Forms.ListBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.tbArvore = new System.Windows.Forms.TabPage();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbTituloArvore = new System.Windows.Forms.Label();
            this.pnlArvore = new System.Windows.Forms.Panel();
            this.tbOperacoes = new System.Windows.Forms.TabPage();
            this.gbRemoverCidade = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtNomeRem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIncluirLigacoes = new System.Windows.Forms.GroupBox();
            this.upPreco = new System.Windows.Forms.NumericUpDown();
            this.upDistancia = new System.Windows.Forms.NumericUpDown();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.txtCidade2 = new System.Windows.Forms.TextBox();
            this.lbCidade2 = new System.Windows.Forms.Label();
            this.txtCidade1 = new System.Windows.Forms.TextBox();
            this.lbCidade1 = new System.Windows.Forms.Label();
            this.btnIncluirLig = new System.Windows.Forms.Button();
            this.tbDataGridView = new System.Windows.Forms.TabPage();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.btnMostrarGrafo = new System.Windows.Forms.Button();
            this.tbApp.SuspendLayout();
            this.tbMapa.SuspendLayout();
            this.gbIncCidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.tbArvore.SuspendLayout();
            this.tbOperacoes.SuspendLayout();
            this.gbRemoverCidade.SuspendLayout();
            this.gbIncluirLigacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDistancia)).BeginInit();
            this.tbDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbApp
            // 
            this.tbApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApp.Controls.Add(this.tbMapa);
            this.tbApp.Controls.Add(this.tbArvore);
            this.tbApp.Controls.Add(this.tbOperacoes);
            this.tbApp.Controls.Add(this.tbDataGridView);
            this.tbApp.Location = new System.Drawing.Point(2, 1);
            this.tbApp.Name = "tbApp";
            this.tbApp.SelectedIndex = 0;
            this.tbApp.Size = new System.Drawing.Size(1188, 658);
            this.tbApp.TabIndex = 0;
            // 
            // tbMapa
            // 
            this.tbMapa.Controls.Add(this.gbIncCidade);
            this.tbMapa.Controls.Add(this.btnBuscar);
            this.tbMapa.Controls.Add(this.txtFim);
            this.tbMapa.Controls.Add(this.txtInicio);
            this.tbMapa.Controls.Add(this.lsbCaminho);
            this.tbMapa.Controls.Add(this.lbResultado);
            this.tbMapa.Controls.Add(this.lbFinal);
            this.tbMapa.Controls.Add(this.lbInicio);
            this.tbMapa.Controls.Add(this.pbMapa);
            this.tbMapa.Location = new System.Drawing.Point(4, 25);
            this.tbMapa.Name = "tbMapa";
            this.tbMapa.Padding = new System.Windows.Forms.Padding(3);
            this.tbMapa.Size = new System.Drawing.Size(1180, 629);
            this.tbMapa.TabIndex = 0;
            this.tbMapa.Text = "Mapa";
            this.tbMapa.UseVisualStyleBackColor = true;
            // 
            // gbIncCidade
            // 
            this.gbIncCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.gbIncCidade.Controls.Add(this.btnIncluirCidade);
            this.gbIncCidade.Controls.Add(this.txtY);
            this.gbIncCidade.Controls.Add(this.lbY);
            this.gbIncCidade.Controls.Add(this.txtX);
            this.gbIncCidade.Controls.Add(this.lbX);
            this.gbIncCidade.Controls.Add(this.txtNomeCidade);
            this.gbIncCidade.Controls.Add(this.lbNomeCidade);
            this.gbIncCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIncCidade.Location = new System.Drawing.Point(6, 355);
            this.gbIncCidade.Name = "gbIncCidade";
            this.gbIncCidade.Size = new System.Drawing.Size(439, 265);
            this.gbIncCidade.TabIndex = 16;
            this.gbIncCidade.TabStop = false;
            this.gbIncCidade.Text = "Inclusão de Cidades";
            // 
            // btnIncluirCidade
            // 
            this.btnIncluirCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirCidade.Location = new System.Drawing.Point(110, 198);
            this.btnIncluirCidade.Name = "btnIncluirCidade";
            this.btnIncluirCidade.Size = new System.Drawing.Size(120, 52);
            this.btnIncluirCidade.TabIndex = 22;
            this.btnIncluirCidade.Text = "Incluir";
            this.btnIncluirCidade.UseVisualStyleBackColor = true;
            this.btnIncluirCidade.Click += new System.EventHandler(this.btnIncluirCidade_Click);
            // 
            // txtY
            // 
            this.txtY.Enabled = false;
            this.txtY.Location = new System.Drawing.Point(165, 151);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(164, 30);
            this.txtY.TabIndex = 21;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY.Location = new System.Drawing.Point(15, 155);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(145, 25);
            this.lbY.TabIndex = 20;
            this.lbY.Text = "Coordenada Y:";
            // 
            // txtX
            // 
            this.txtX.Enabled = false;
            this.txtX.Location = new System.Drawing.Point(165, 100);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(164, 30);
            this.txtX.TabIndex = 19;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(15, 103);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(146, 25);
            this.lbX.TabIndex = 18;
            this.lbX.Text = "Coordenada X:";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(92, 40);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(245, 30);
            this.txtNomeCidade.TabIndex = 17;
            // 
            // lbNomeCidade
            // 
            this.lbNomeCidade.AutoSize = true;
            this.lbNomeCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCidade.Location = new System.Drawing.Point(15, 43);
            this.lbNomeCidade.Name = "lbNomeCidade";
            this.lbNomeCidade.Size = new System.Drawing.Size(70, 25);
            this.lbNomeCidade.TabIndex = 16;
            this.lbNomeCidade.Text = "Nome:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(304, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 52);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(98, 97);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(164, 22);
            this.txtFim.TabIndex = 8;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(98, 33);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(164, 22);
            this.txtInicio.TabIndex = 7;
            // 
            // lsbCaminho
            // 
            this.lsbCaminho.FormattingEnabled = true;
            this.lsbCaminho.HorizontalScrollbar = true;
            this.lsbCaminho.ItemHeight = 16;
            this.lsbCaminho.Location = new System.Drawing.Point(6, 185);
            this.lsbCaminho.Name = "lsbCaminho";
            this.lsbCaminho.Size = new System.Drawing.Size(439, 164);
            this.lsbCaminho.TabIndex = 6;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(28, 157);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(105, 25);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "Resultado:";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinal.Location = new System.Drawing.Point(28, 97);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(50, 25);
            this.lbFinal.TabIndex = 3;
            this.lbFinal.Text = "Fim:";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.Location = new System.Drawing.Point(28, 27);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(63, 25);
            this.lbInicio.TabIndex = 1;
            this.lbInicio.Text = "Inicio:";
            // 
            // pbMapa
            // 
            this.pbMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMapa.ImageLocation = "";
            this.pbMapa.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMapa.InitialImage")));
            this.pbMapa.Location = new System.Drawing.Point(457, 27);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(717, 578);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            this.pbMapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMapa_MouseClick);
            // 
            // tbArvore
            // 
            this.tbArvore.Controls.Add(this.btnMostrar);
            this.tbArvore.Controls.Add(this.lbTituloArvore);
            this.tbArvore.Controls.Add(this.pnlArvore);
            this.tbArvore.Location = new System.Drawing.Point(4, 25);
            this.tbArvore.Name = "tbArvore";
            this.tbArvore.Padding = new System.Windows.Forms.Padding(3);
            this.tbArvore.Size = new System.Drawing.Size(1180, 629);
            this.tbArvore.TabIndex = 1;
            this.tbArvore.Text = "Árvore";
            this.tbArvore.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(39, 19);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(142, 60);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lbTituloArvore
            // 
            this.lbTituloArvore.AutoSize = true;
            this.lbTituloArvore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArvore.Location = new System.Drawing.Point(374, 25);
            this.lbTituloArvore.Name = "lbTituloArvore";
            this.lbTituloArvore.Size = new System.Drawing.Size(386, 36);
            this.lbTituloArvore.TabIndex = 1;
            this.lbTituloArvore.Text = "Árvore contendo as cidades";
            // 
            // pnlArvore
            // 
            this.pnlArvore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArvore.Location = new System.Drawing.Point(7, 91);
            this.pnlArvore.Name = "pnlArvore";
            this.pnlArvore.Size = new System.Drawing.Size(1162, 529);
            this.pnlArvore.TabIndex = 0;
            // 
            // tbOperacoes
            // 
            this.tbOperacoes.Controls.Add(this.gbRemoverCidade);
            this.tbOperacoes.Controls.Add(this.gbIncluirLigacoes);
            this.tbOperacoes.Location = new System.Drawing.Point(4, 25);
            this.tbOperacoes.Name = "tbOperacoes";
            this.tbOperacoes.Size = new System.Drawing.Size(1180, 629);
            this.tbOperacoes.TabIndex = 2;
            this.tbOperacoes.Text = "Operações";
            this.tbOperacoes.UseVisualStyleBackColor = true;
            // 
            // gbRemoverCidade
            // 
            this.gbRemoverCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbRemoverCidade.Controls.Add(this.btnRemover);
            this.gbRemoverCidade.Controls.Add(this.txtNomeRem);
            this.gbRemoverCidade.Controls.Add(this.label1);
            this.gbRemoverCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRemoverCidade.Location = new System.Drawing.Point(664, 22);
            this.gbRemoverCidade.Name = "gbRemoverCidade";
            this.gbRemoverCidade.Size = new System.Drawing.Size(505, 514);
            this.gbRemoverCidade.TabIndex = 2;
            this.gbRemoverCidade.TabStop = false;
            this.gbRemoverCidade.Text = "Remoção de Cidades";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(191, 297);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(153, 59);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtNomeRem
            // 
            this.txtNomeRem.Location = new System.Drawing.Point(95, 70);
            this.txtNomeRem.Name = "txtNomeRem";
            this.txtNomeRem.Size = new System.Drawing.Size(287, 30);
            this.txtNomeRem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // gbIncluirLigacoes
            // 
            this.gbIncluirLigacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbIncluirLigacoes.Controls.Add(this.upPreco);
            this.gbIncluirLigacoes.Controls.Add(this.upDistancia);
            this.gbIncluirLigacoes.Controls.Add(this.lbPreco);
            this.gbIncluirLigacoes.Controls.Add(this.lbDistancia);
            this.gbIncluirLigacoes.Controls.Add(this.txtCidade2);
            this.gbIncluirLigacoes.Controls.Add(this.lbCidade2);
            this.gbIncluirLigacoes.Controls.Add(this.txtCidade1);
            this.gbIncluirLigacoes.Controls.Add(this.lbCidade1);
            this.gbIncluirLigacoes.Controls.Add(this.btnIncluirLig);
            this.gbIncluirLigacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIncluirLigacoes.Location = new System.Drawing.Point(7, 22);
            this.gbIncluirLigacoes.Name = "gbIncluirLigacoes";
            this.gbIncluirLigacoes.Size = new System.Drawing.Size(631, 514);
            this.gbIncluirLigacoes.TabIndex = 1;
            this.gbIncluirLigacoes.TabStop = false;
            this.gbIncluirLigacoes.Text = "Inclusão de Ligações entre Cidades";
            // 
            // upPreco
            // 
            this.upPreco.Location = new System.Drawing.Point(535, 138);
            this.upPreco.Name = "upPreco";
            this.upPreco.Size = new System.Drawing.Size(63, 30);
            this.upPreco.TabIndex = 15;
            // 
            // upDistancia
            // 
            this.upDistancia.Location = new System.Drawing.Point(535, 61);
            this.upDistancia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDistancia.Name = "upDistancia";
            this.upDistancia.Size = new System.Drawing.Size(63, 30);
            this.upDistancia.TabIndex = 14;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(431, 143);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(69, 25);
            this.lbPreco.TabIndex = 13;
            this.lbPreco.Text = "Preço:";
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(431, 63);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(98, 25);
            this.lbDistancia.TabIndex = 12;
            this.lbDistancia.Text = "Distância:";
            // 
            // txtCidade2
            // 
            this.txtCidade2.Location = new System.Drawing.Point(122, 140);
            this.txtCidade2.Name = "txtCidade2";
            this.txtCidade2.Size = new System.Drawing.Size(260, 30);
            this.txtCidade2.TabIndex = 11;
            // 
            // lbCidade2
            // 
            this.lbCidade2.AutoSize = true;
            this.lbCidade2.Location = new System.Drawing.Point(19, 143);
            this.lbCidade2.Name = "lbCidade2";
            this.lbCidade2.Size = new System.Drawing.Size(97, 25);
            this.lbCidade2.TabIndex = 10;
            this.lbCidade2.Text = "Cidade 2:";
            // 
            // txtCidade1
            // 
            this.txtCidade1.Location = new System.Drawing.Point(122, 60);
            this.txtCidade1.Name = "txtCidade1";
            this.txtCidade1.Size = new System.Drawing.Size(260, 30);
            this.txtCidade1.TabIndex = 9;
            // 
            // lbCidade1
            // 
            this.lbCidade1.AutoSize = true;
            this.lbCidade1.Location = new System.Drawing.Point(19, 63);
            this.lbCidade1.Name = "lbCidade1";
            this.lbCidade1.Size = new System.Drawing.Size(97, 25);
            this.lbCidade1.TabIndex = 8;
            this.lbCidade1.Text = "Cidade 1:";
            // 
            // btnIncluirLig
            // 
            this.btnIncluirLig.Location = new System.Drawing.Point(229, 297);
            this.btnIncluirLig.Name = "btnIncluirLig";
            this.btnIncluirLig.Size = new System.Drawing.Size(153, 59);
            this.btnIncluirLig.TabIndex = 7;
            this.btnIncluirLig.Text = "Incluir";
            this.btnIncluirLig.UseVisualStyleBackColor = true;
            this.btnIncluirLig.Click += new System.EventHandler(this.btnIncluirLig_Click);
            // 
            // tbDataGridView
            // 
            this.tbDataGridView.Controls.Add(this.dgvGrafo);
            this.tbDataGridView.Controls.Add(this.btnMostrarGrafo);
            this.tbDataGridView.Location = new System.Drawing.Point(4, 25);
            this.tbDataGridView.Name = "tbDataGridView";
            this.tbDataGridView.Size = new System.Drawing.Size(1180, 629);
            this.tbDataGridView.TabIndex = 3;
            this.tbDataGridView.Text = "Tabela";
            this.tbDataGridView.UseVisualStyleBackColor = true;
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(7, 143);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersWidth = 51;
            this.dgvGrafo.RowTemplate.Height = 24;
            this.dgvGrafo.Size = new System.Drawing.Size(1162, 480);
            this.dgvGrafo.TabIndex = 1;
            // 
            // btnMostrarGrafo
            // 
            this.btnMostrarGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarGrafo.Location = new System.Drawing.Point(31, 39);
            this.btnMostrarGrafo.Name = "btnMostrarGrafo";
            this.btnMostrarGrafo.Size = new System.Drawing.Size(122, 53);
            this.btnMostrarGrafo.TabIndex = 0;
            this.btnMostrarGrafo.Text = "Mostrar";
            this.btnMostrarGrafo.UseVisualStyleBackColor = true;
            this.btnMostrarGrafo.Click += new System.EventHandler(this.btnMostrarGrafo_Click);
            // 
            // FrmCaminho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 661);
            this.Controls.Add(this.tbApp);
            this.Name = "FrmCaminho";
            this.Text = "Caminhos de Trem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCaminho_FormClosing);
            this.Load += new System.EventHandler(this.FrmCaminho_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmCaminho_ResizeEnd);
            this.Resize += new System.EventHandler(this.FrmCaminho_Resize);
            this.tbApp.ResumeLayout(false);
            this.tbMapa.ResumeLayout(false);
            this.tbMapa.PerformLayout();
            this.gbIncCidade.ResumeLayout(false);
            this.gbIncCidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.tbArvore.ResumeLayout(false);
            this.tbArvore.PerformLayout();
            this.tbOperacoes.ResumeLayout(false);
            this.gbRemoverCidade.ResumeLayout(false);
            this.gbRemoverCidade.PerformLayout();
            this.gbIncluirLigacoes.ResumeLayout(false);
            this.gbIncluirLigacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDistancia)).EndInit();
            this.tbDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbApp;
        private System.Windows.Forms.TabPage tbMapa;
        private System.Windows.Forms.TabPage tbArvore;
        private System.Windows.Forms.Label lbTituloArvore;
        private System.Windows.Forms.Panel pnlArvore;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.ListBox lsbCaminho;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TabPage tbOperacoes;
        private System.Windows.Forms.GroupBox gbIncluirLigacoes;
        private System.Windows.Forms.GroupBox gbRemoverCidade;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtNomeRem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade1;
        private System.Windows.Forms.Label lbCidade1;
        private System.Windows.Forms.Button btnIncluirLig;
        private System.Windows.Forms.NumericUpDown upPreco;
        private System.Windows.Forms.NumericUpDown upDistancia;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.TextBox txtCidade2;
        private System.Windows.Forms.Label lbCidade2;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.GroupBox gbIncCidade;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Label lbNomeCidade;
        private System.Windows.Forms.Button btnIncluirCidade;
        private System.Windows.Forms.TabPage tbDataGridView;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.Button btnMostrarGrafo;
    }
}

