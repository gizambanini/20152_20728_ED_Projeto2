//PROJETO II: GRAFOS - CAMINHOS DE TREM
//GIOVANA MENDONÇA ZAMBANINI - 20728
//PEDRO HENRIQUE PEREZ DIAS  - 20152

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CaminhosDeTrem
{
    
    public partial class FrmCaminho : Form
    {
        ArvoreDeBusca<Cidade> arv = new ArvoreDeBusca<Cidade>();
        
        Cidade[] vetCidade = new Cidade[System.IO.File.ReadAllLines(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\Cidades.txt").Length];
        
        double x1, y1, x2, y2;
        public FrmCaminho()
        {
            
            InitializeComponent();
        }

        private Font fnt = new Font("Arial", 10);
        private void FrmCaminho_Load(object sender, System.EventArgs e)
        {
            StreamReader srCidade = new StreamReader(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\Cidades.txt");
            int posicoesVetCidade = 0;
            while (!srCidade.EndOfStream)
            {
                string regCidade = srCidade.ReadLine();
                Cidade cid = new Cidade(regCidade.Substring(0, 16), float.Parse(regCidade.Substring(16, 5)), float.Parse(regCidade.Substring(22, 5)));
                vetCidade[posicoesVetCidade] = cid;
                posicoesVetCidade++;
            }

            for (int i = 0; i < vetCidade.Length; i++)
                arv.IncluirNovoRegistro(vetCidade[i]);
        }

        private void pbMapa_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            // Draw a string on the PictureBox.
            g.DrawString("This is a diagonal line drawn on the control",
                fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            Pen pen = new Pen(Color.Red);
            //g.DrawLine(pen, (float)(0.195 * pbMapa.Image.Width), (float)(0.151 * pbMapa.Image.Height), (float)(0.609 * pbMapa.Image.Width), (float)(0.609 * pbMapa.Image.Height));
        }

        //VERIFICAR A ANCORAGEM DO MAPA
        private void pbMapa_MouseClick(object sender, MouseEventArgs e)
        {
            txtX.Text = string.Format("{0:N3}", ((float)e.X / (float)pbMapa.Image.Width ));
            txtY.Text = string.Format("{0:N3}", ((float)e.Y / (float)pbMapa.Image.Height));
        }

        private void btnIncluirCidade_Click(object sender, EventArgs e)
        {
            if (txtX.Text == "")
                MessageBox.Show("Selecione a cidade desejada no mapa primeiro");
            
            else if(txtNomeCidade.Text == "")
                MessageBox.Show("Digite o nome da cidade a ser cadastrada primeiro");

            else
            {
                
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            arv.DesenharArvore(true, arv.Raiz, (int)pnlArvore.Width / 2, 0,
                  Math.PI / 2, Math.PI / 2.5, 300, pnlArvore.CreateGraphics());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Criar classe de conexoes
            //Criar vertices e arestas a partir da arvore e do arquivo de conexoes
            Grafo oGrafo = new Grafo();

            for (int i = 0; i < vetCidade.Length; i++)
                oGrafo.NovoVertice(vetCidade[i].Nome);
                
            
            lsbCaminho.Items.Clear();
            lsbCaminho.Items.Add("");
            lsbCaminho.Items.Add("Menores caminhos:");
            lsbCaminho.Items.Add("");
            int ori = int.Parse(txtInicio.Text);
            int des = int.Parse(txtFim.Text);
            string caminhoFinal = oGrafo.Caminho(ori, des, lsbCaminho);
            lsbCaminho.Items.Add(caminhoFinal);
            lsbCaminho.Items.Add("");
            string[] cidades = caminhoFinal.Split(' ');
            MostrarCaminho(cidades);
        }

        public void MostrarCaminho(string[] cidVisitadas)
        {
            for (int i = 0; i <= cidVisitadas.Length; i = i + 2)
            {
                MessageBox.Show(cidVisitadas[i]);
                //COMPARAR cidVisitadas[i] com as cidades no vetor de cidades
                switch (cidVisitadas[i])
                {
                    case "A": x1 = 0.195; y1 = 0.151; x2 = 0.609; y2 = 0.609;
                        Graphics g = pbMapa.CreateGraphics();
                        Pen pen = new Pen(Color.Red);
                        g.DrawLine(pen, (float)(x1 * pbMapa.Image.Width), (float)(y1 * pbMapa.Image.Height), (float)(x2 * pbMapa.Image.Width), (float)(y2 * pbMapa.Image.Height));
                        
                        break;
                    case "B": x1 = 0.609; y1 = 0.609; x2 = 0.697; y2 = 0.675;
                        Graphics g1 = pbMapa.CreateGraphics();
                        Pen can = new Pen(Color.Red);
                        g1.DrawLine(can, (float)(x1 * pbMapa.Image.Width), (float)(y1 * pbMapa.Image.Height), (float)(x2 * pbMapa.Image.Width), (float)(y2 * pbMapa.Image.Height));
                        
                        break;
                }

            }
        }

        private void btnIncluirLig_Click(object sender, EventArgs e)
        {
            
        }
    }
}
