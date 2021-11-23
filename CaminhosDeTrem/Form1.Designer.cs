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
            this.tbApp = new System.Windows.Forms.TabControl();
            this.tbMapa = new System.Windows.Forms.TabPage();
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
            this.gbIncluirCidade = new System.Windows.Forms.GroupBox();
            this.btnIncluirCid = new System.Windows.Forms.Button();
            this.txtCoordY = new System.Windows.Forms.TextBox();
            this.lbCoordY = new System.Windows.Forms.Label();
            this.txtCoordX = new System.Windows.Forms.TextBox();
            this.lbCoordX = new System.Windows.Forms.Label();
            this.txtNomeInc = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbApp.SuspendLayout();
            this.tbMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.tbArvore.SuspendLayout();
            this.tbOperacoes.SuspendLayout();
            this.gbRemoverCidade.SuspendLayout();
            this.gbIncluirLigacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDistancia)).BeginInit();
            this.gbIncluirCidade.SuspendLayout();
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
            this.tbApp.Location = new System.Drawing.Point(2, 1);
            this.tbApp.Name = "tbApp";
            this.tbApp.SelectedIndex = 0;
            this.tbApp.Size = new System.Drawing.Size(1037, 655);
            this.tbApp.TabIndex = 0;
            // 
            // tbMapa
            // 
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
            this.tbMapa.Size = new System.Drawing.Size(1029, 626);
            this.tbMapa.TabIndex = 0;
            this.tbMapa.Text = "Mapa";
            this.tbMapa.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(98, 207);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 52);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(98, 100);
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
            this.lsbCaminho.ItemHeight = 16;
            this.lsbCaminho.Location = new System.Drawing.Point(33, 345);
            this.lsbCaminho.Name = "lsbCaminho";
            this.lsbCaminho.Size = new System.Drawing.Size(302, 148);
            this.lsbCaminho.TabIndex = 6;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(28, 317);
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
            this.lbInicio.Location = new System.Drawing.Point(28, 30);
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
            this.pbMapa.ImageLocation = "C:\\Users\\pedro\\Downloads\\a.jpeg";
            this.pbMapa.Location = new System.Drawing.Point(451, 27);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(567, 593);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            this.pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapa_Paint);
            // 
            // tbArvore
            // 
            this.tbArvore.Controls.Add(this.btnMostrar);
            this.tbArvore.Controls.Add(this.lbTituloArvore);
            this.tbArvore.Controls.Add(this.pnlArvore);
            this.tbArvore.Location = new System.Drawing.Point(4, 25);
            this.tbArvore.Name = "tbArvore";
            this.tbArvore.Padding = new System.Windows.Forms.Padding(3);
            this.tbArvore.Size = new System.Drawing.Size(1029, 626);
            this.tbArvore.TabIndex = 1;
            this.tbArvore.Text = "Árvore";
            this.tbArvore.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(55, 25);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(123, 36);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // lbTituloArvore
            // 
            this.lbTituloArvore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTituloArvore.AutoSize = true;
            this.lbTituloArvore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArvore.Location = new System.Drawing.Point(315, 25);
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
            this.pnlArvore.Size = new System.Drawing.Size(1016, 529);
            this.pnlArvore.TabIndex = 0;
            // 
            // tbOperacoes
            // 
            this.tbOperacoes.Controls.Add(this.gbRemoverCidade);
            this.tbOperacoes.Controls.Add(this.gbIncluirLigacoes);
            this.tbOperacoes.Controls.Add(this.gbIncluirCidade);
            this.tbOperacoes.Location = new System.Drawing.Point(4, 25);
            this.tbOperacoes.Name = "tbOperacoes";
            this.tbOperacoes.Size = new System.Drawing.Size(1029, 626);
            this.tbOperacoes.TabIndex = 2;
            this.tbOperacoes.Text = "Operações";
            this.tbOperacoes.UseVisualStyleBackColor = true;
            // 
            // gbRemoverCidade
            // 
            this.gbRemoverCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRemoverCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.gbRemoverCidade.Controls.Add(this.btnRemover);
            this.gbRemoverCidade.Controls.Add(this.txtNomeRem);
            this.gbRemoverCidade.Controls.Add(this.label1);
            this.gbRemoverCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRemoverCidade.Location = new System.Drawing.Point(7, 475);
            this.gbRemoverCidade.Name = "gbRemoverCidade";
            this.gbRemoverCidade.Size = new System.Drawing.Size(1019, 145);
            this.gbRemoverCidade.TabIndex = 2;
            this.gbRemoverCidade.TabStop = false;
            this.gbRemoverCidade.Text = "Remoção de Cidades";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(793, 56);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(153, 59);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
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
            this.gbIncluirLigacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIncluirLigacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
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
            this.gbIncluirLigacoes.Location = new System.Drawing.Point(7, 212);
            this.gbIncluirLigacoes.Name = "gbIncluirLigacoes";
            this.gbIncluirLigacoes.Size = new System.Drawing.Size(1019, 246);
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
            this.txtCidade1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade1.Location = new System.Drawing.Point(122, 60);
            this.txtCidade1.Name = "txtCidade1";
            this.txtCidade1.Size = new System.Drawing.Size(257, 30);
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
            this.btnIncluirLig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluirLig.Location = new System.Drawing.Point(793, 77);
            this.btnIncluirLig.Name = "btnIncluirLig";
            this.btnIncluirLig.Size = new System.Drawing.Size(150, 59);
            this.btnIncluirLig.TabIndex = 7;
            this.btnIncluirLig.Text = "Incluir";
            this.btnIncluirLig.UseVisualStyleBackColor = true;
            // 
            // gbIncluirCidade
            // 
            this.gbIncluirCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIncluirCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.gbIncluirCidade.Controls.Add(this.btnIncluirCid);
            this.gbIncluirCidade.Controls.Add(this.txtCoordY);
            this.gbIncluirCidade.Controls.Add(this.lbCoordY);
            this.gbIncluirCidade.Controls.Add(this.txtCoordX);
            this.gbIncluirCidade.Controls.Add(this.lbCoordX);
            this.gbIncluirCidade.Controls.Add(this.txtNomeInc);
            this.gbIncluirCidade.Controls.Add(this.lbNome);
            this.gbIncluirCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIncluirCidade.Location = new System.Drawing.Point(7, 3);
            this.gbIncluirCidade.Name = "gbIncluirCidade";
            this.gbIncluirCidade.Size = new System.Drawing.Size(1019, 192);
            this.gbIncluirCidade.TabIndex = 0;
            this.gbIncluirCidade.TabStop = false;
            this.gbIncluirCidade.Text = "Inclusão de Cidades";
            // 
            // btnIncluirCid
            // 
            this.btnIncluirCid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluirCid.Location = new System.Drawing.Point(793, 43);
            this.btnIncluirCid.Name = "btnIncluirCid";
            this.btnIncluirCid.Size = new System.Drawing.Size(153, 59);
            this.btnIncluirCid.TabIndex = 6;
            this.btnIncluirCid.Text = "Incluir";
            this.btnIncluirCid.UseVisualStyleBackColor = true;
            // 
            // txtCoordY
            // 
            this.txtCoordY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoordY.Location = new System.Drawing.Point(522, 104);
            this.txtCoordY.Name = "txtCoordY";
            this.txtCoordY.Size = new System.Drawing.Size(153, 30);
            this.txtCoordY.TabIndex = 5;
            // 
            // lbCoordY
            // 
            this.lbCoordY.AutoSize = true;
            this.lbCoordY.Location = new System.Drawing.Point(371, 107);
            this.lbCoordY.Name = "lbCoordY";
            this.lbCoordY.Size = new System.Drawing.Size(145, 25);
            this.lbCoordY.TabIndex = 4;
            this.lbCoordY.Text = "Coordenada Y:";
            // 
            // txtCoordX
            // 
            this.txtCoordX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoordX.Location = new System.Drawing.Point(171, 104);
            this.txtCoordX.Name = "txtCoordX";
            this.txtCoordX.Size = new System.Drawing.Size(136, 30);
            this.txtCoordX.TabIndex = 3;
            // 
            // lbCoordX
            // 
            this.lbCoordX.AutoSize = true;
            this.lbCoordX.Location = new System.Drawing.Point(19, 105);
            this.lbCoordX.Name = "lbCoordX";
            this.lbCoordX.Size = new System.Drawing.Size(146, 25);
            this.lbCoordX.TabIndex = 2;
            this.lbCoordX.Text = "Coordenada X:";
            // 
            // txtNomeInc
            // 
            this.txtNomeInc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeInc.Location = new System.Drawing.Point(95, 40);
            this.txtNomeInc.Name = "txtNomeInc";
            this.txtNomeInc.Size = new System.Drawing.Size(287, 30);
            this.txtNomeInc.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(19, 43);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(70, 25);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // FrmCaminho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 658);
            this.Controls.Add(this.tbApp);
            this.Name = "FrmCaminho";
            this.Text = "Caminhos de Trem";
            this.ResizeEnd += new System.EventHandler(this.FrmCaminho_ResizeEnd);
            this.tbApp.ResumeLayout(false);
            this.tbMapa.ResumeLayout(false);
            this.tbMapa.PerformLayout();
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
            this.gbIncluirCidade.ResumeLayout(false);
            this.gbIncluirCidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbApp;
        private System.Windows.Forms.TabPage tbMapa;
        private System.Windows.Forms.TabPage tbArvore;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.Label lbTituloArvore;
        private System.Windows.Forms.Panel pnlArvore;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.ListBox lsbCaminho;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TabPage tbOperacoes;
        private System.Windows.Forms.GroupBox gbIncluirCidade;
        private System.Windows.Forms.GroupBox gbIncluirLigacoes;
        private System.Windows.Forms.TextBox txtCoordY;
        private System.Windows.Forms.Label lbCoordY;
        private System.Windows.Forms.TextBox txtCoordX;
        private System.Windows.Forms.Label lbCoordX;
        private System.Windows.Forms.TextBox txtNomeInc;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox gbRemoverCidade;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtNomeRem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade1;
        private System.Windows.Forms.Label lbCidade1;
        private System.Windows.Forms.Button btnIncluirLig;
        private System.Windows.Forms.Button btnIncluirCid;
        private System.Windows.Forms.NumericUpDown upPreco;
        private System.Windows.Forms.NumericUpDown upDistancia;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.TextBox txtCidade2;
        private System.Windows.Forms.Label lbCidade2;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Button btnBuscar;
    }
}

