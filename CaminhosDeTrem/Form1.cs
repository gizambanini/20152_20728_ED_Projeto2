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
        //Se precisar, arrumar o list

        ArvoreDeBusca<Cidade> arv = new ArvoreDeBusca<Cidade>();

        Cidade [] vetCidade  = new Cidade [System.IO.File.ReadAllLines(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\Cidades.txt").Length];
        //Caminho[] vetCaminho = new Caminho[System.IO.File.ReadAllLines(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\GrafoTremEspanhaPortugal.txt").Length];
        List<Caminho> listaCaminho = new List<Caminho>(); 
        
        Grafo oGrafo;
        public FrmCaminho()
        {
            InitializeComponent();
        }

        private Font fnt = new Font("Arial", 10);
        private void FrmCaminho_Load(object sender, System.EventArgs e)
        {
            StreamReader srCidade = new StreamReader(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\Cidades.txt");
            int posicoesVetCidade = 0;
            StreamReader srCaminho = new StreamReader(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\GrafoTremEspanhaPortugal.txt");
            

            //Criação do vetor de cidades com base no arquivo texto
            while (!srCidade.EndOfStream)
            {
                string regCidade = srCidade.ReadLine();
                Cidade cid = new Cidade(regCidade.Substring(0, 15), float.Parse(regCidade.Substring(15, 5)), float.Parse(regCidade.Substring(21, 5)));
                cid.Nome = cid.Nome.TrimEnd(); //Talvez tirar dps
                vetCidade[posicoesVetCidade] = cid;
                posicoesVetCidade++;
            }

            while(!srCaminho.EndOfStream)
            {
                Caminho cam = new Caminho();
                cam.LerRegistro(srCaminho);
                listaCaminho.Add(cam);
            }
                
            //Lê o vetor e armazena osvalores de forma balanceada na árvore
            arv.LerVetorDeRegistros(vetCidade);

            oGrafo = new Grafo(dgvGrafo);
            CriaVertices(arv.Raiz);
            CriaArestas();
        }

        //VERIFICAR A ANCORAGEM DO MAPA
        private void pbMapa_MouseClick(object sender, MouseEventArgs e)
        {
            txtX.Text = string.Format("{0:N3}", ((float)e.X / (float)pbMapa.Image.Width));
            txtY.Text = string.Format("{0:N3}", ((float)e.Y / (float)pbMapa.Image.Height));
        }

        private void btnIncluirCidade_Click(object sender, EventArgs e)
        {
            //Como os dois campos (txtX e txtY) sao atualizados ao mesmo tempo, basta verificar se um deles esta vazio
            if (txtX.Text == "")
                MessageBox.Show("Selecione a cidade desejada no mapa primeiro");

            else if (txtNomeCidade.Text == "")
                MessageBox.Show("Digite o nome da cidade a ser cadastrada primeiro");

            else
            {
                //Incluir a cidade aqui
                Cidade cidInclusao = new Cidade(txtNomeCidade.Text, float.Parse(txtX.Text), float.Parse(txtY.Text));
                try
                {
                    //ALTERAR INDICE P QTD NOS ARVORE
                    arv.Incluir(cidInclusao);
                    oGrafo.NovoVertice(cidInclusao.Nome);
                    MessageBox.Show("Cidade cadastrada com sucesso");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            arv.DesenharArvore(true, arv.Raiz, (int)pnlArvore.Width / 2, 0,
                  Math.PI / 2, Math.PI / 2.2, 300, pnlArvore.CreateGraphics());

        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Criar classe de conexoes
            //Criar vertices e arestas a partir da arvore e do arquivo de conexoes
            

            //Cria os vertices do grafo a partir das cidades da arvore
            
            oGrafo.ExibirAdjacencias();
            int ori = oGrafo.IndiceVertice(txtInicio.Text);
            int des = oGrafo.IndiceVertice(txtFim.Text);
            if (ori == -1)
            {
                MessageBox.Show("A cidade " + txtInicio.Text + " não está cadastrada");
            }
            else if (des == -1)
            {
                MessageBox.Show("A cidade " + txtFim.Text + " não está cadastrada");
            }
            else
            {
                lsbCaminho.Items.Clear();
                lsbCaminho.Items.Add("");
                lsbCaminho.Items.Add("Menores caminhos:");
                lsbCaminho.Items.Add("");
                string caminhoFinal = oGrafo.Caminho(ori, des, lsbCaminho);
                lsbCaminho.Items.Add(caminhoFinal);
                lsbCaminho.Items.Add("");
                //Tentar trocar para Replace, Remove
                string[] cidades = caminhoFinal.Split(new string[] { " --> " }, StringSplitOptions.None);

                if(caminhoFinal != "Não há caminho")
                    MostrarCaminho(cidades);
            }
        }

        private void CriaVertices(NoArvore<Cidade> raiz)
        {
            if (raiz != null)
            {
                if (raiz.Esq != null)
                    CriaVertices(raiz.Esq);
                if (raiz.Dir != null)
                    CriaVertices(raiz.Dir);
                oGrafo.NovoVertice(raiz.Info.Nome.TrimEnd(), raiz.Indice);
            }
        }

        private void CriaArestas()
        {
            for (int i = 0; i < listaCaminho.Count; i++)
                oGrafo.NovaAresta(oGrafo.IndiceVertice(listaCaminho[i].Inicio.TrimEnd()), oGrafo.IndiceVertice(listaCaminho[i].Fim.TrimEnd()), listaCaminho[i].Distancia);
        }

        private void MostrarCaminho(string[] cidVisitadas)
        {
            pbMapa.Refresh();
            Graphics g = pbMapa.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            for (int i = 0; i < cidVisitadas.Length; i = i + 1)
            {
                //Tentar corrigir verificando as posicoes seguintes do vetor 
                int f = i;
                if (i + 1 < cidVisitadas.Length)
                    f = i + 1;
                
                Cidade inicio = arv.NoIndice(oGrafo.IndiceVertice(cidVisitadas[i]));
                Cidade fim = arv.NoIndice(oGrafo.IndiceVertice(cidVisitadas[f]));
                g.DrawLine(pen, (float)(inicio.CoordX * pbMapa.Image.Width), (float)(inicio.CoordY * pbMapa.Image.Height), (float)(fim.CoordX * pbMapa.Image.Width), (float)(fim.CoordY * pbMapa.Image.Height));

            }
        }

        private void btnIncluirLig_Click(object sender, EventArgs e)
        {
            if(txtCidade1.Text != "" && txtCidade2.Text != "" && upDistancia.Value != 0 && upPreco.Value != 0)
            {
                Cidade cid1 = new Cidade();
                cid1.Nome = txtCidade1.Text;
                Cidade cid2 = new Cidade();
                cid2.Nome = txtCidade2.Text;
                if (!arv.Existe(cid1))
                    MessageBox.Show("A cidade 1 especificada não está cadastrada");

                else if (!arv.Existe(cid2))
                    MessageBox.Show("A cidade 2 especificada não está cadastrada");

                else
                {
                    //incluir o caminho aqui
                    Caminho cam = new Caminho(txtCidade1.Text, txtCidade2.Text, Decimal.ToInt32(upDistancia.Value), Decimal.ToInt32(upPreco.Value));
                    listaCaminho.Add(cam);
                    oGrafo.NovaAresta(oGrafo.IndiceVertice(txtCidade1.Text), oGrafo.IndiceVertice(txtCidade2.Text), Decimal.ToInt32(upDistancia.Value));
                    MessageBox.Show("Caminho incluído com sucesso");
                }
            }

            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtNomeRem.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente");
            }

            else
            {
                Cidade cidRemover = new Cidade();
                cidRemover.Nome = txtNomeRem.Text;
                if (!arv.Existe(cidRemover))
                    MessageBox.Show("A cidade especificada não está cadastrada");
                else
                {
                    //Excluir a cidade aqui
                    arv.Excluir(cidRemover);
                    oGrafo.removerVertice(oGrafo.IndiceVertice(cidRemover.Nome));
                    MessageBox.Show("Cidade removida com sucesso");
                }
            }
        }

        private void FrmCaminho_FormClosing(object sender, FormClosingEventArgs e)
        {
            arv.GravarArquivoDeRegistros(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\Cidades.txt");
        }
    }
}
