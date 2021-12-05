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

        Cidade [] vetCidade  = new Cidade [System.IO.File.ReadAllLines("..\\..\\Cidades.txt").Length];
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
            StreamReader srCidade = new StreamReader("..\\..\\Cidades.txt");
            int posicoesVetCidade = 0;
            StreamReader srCaminho = new StreamReader("..\\..\\GrafoTremEspanhaPortugal.txt");
            

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
                
            //Lê o vetor e armazena os valores de forma balanceada na árvore
            arv.LerVetorDeRegistros(vetCidade);

            oGrafo = new Grafo(dgvGrafo);
            CriaVertices(arv.Raiz);
            CriaArestas();
        }

        //VERIFICAR A ANCORAGEM DO MAPA
        private void pbMapa_MouseClick(object sender, MouseEventArgs e)
        {
            txtX.Text = string.Format("{0:N3}", ((float)e.X / (float)pbMapa.Width));
            txtY.Text = string.Format("{0:N3}", ((float)e.Y / (float)pbMapa.Height));
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
                caminhoFinal = caminhoFinal.Replace(" --> ", "*");
                string[] cidades = caminhoFinal.Split('*');

                if (caminhoFinal != "Não há caminho")
                {
                    CaminhoInfo(cidades, lsbCaminho);
                }
                
                
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
            {
                oGrafo.NovaAresta(oGrafo.IndiceVertice(listaCaminho[i].Inicio.TrimEnd()), oGrafo.IndiceVertice(listaCaminho[i].Fim.TrimEnd()), listaCaminho[i].Distancia);
                oGrafo.NovaAresta(oGrafo.IndiceVertice(listaCaminho[i].Fim.TrimEnd()), oGrafo.IndiceVertice(listaCaminho[i].Inicio.TrimEnd()), listaCaminho[i].Distancia); //Possibilitar volta do caminhos
            }
                
        }

        private void CaminhoInfo(string[] cidVisitadas, ListBox ls)
        {
            pbMapa.Refresh();
            Graphics g = pbMapa.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            int distancia = 0;
            int preco = 0;
            int hora;
            double min;
            for (int i = 0; i < cidVisitadas.Length; i = i + 1)
            {
                int distParcial = 0;
                //Tentar corrigir verificando as posicoes seguintes do vetor 
                int f = i;
                if (i + 1 < cidVisitadas.Length)
                    f = i + 1;
                
                Cidade inicio = arv.NoIndice(oGrafo.IndiceVertice(cidVisitadas[i])).Info;
                Cidade fim = arv.NoIndice(oGrafo.IndiceVertice(cidVisitadas[f])).Info;
                if(inicio != fim)
                {
                    distParcial = oGrafo.PesoAresta(oGrafo.IndiceVertice(cidVisitadas[i]), oGrafo.IndiceVertice(cidVisitadas[f]));
                    distancia += distParcial; 
                

                    for (int posLista = 0; posLista < listaCaminho.Count; posLista++)
                        if (listaCaminho[posLista].Inicio.TrimEnd() == inicio.Nome && listaCaminho[posLista].Fim.TrimEnd() == fim.Nome && listaCaminho[posLista].Distancia == distParcial 
                            || listaCaminho[posLista].Inicio.TrimEnd() == fim.Nome && listaCaminho[posLista].Fim.TrimEnd() == inicio.Nome && listaCaminho[posLista].Distancia == distParcial)
                            preco += listaCaminho[posLista].Passagem;
                }
                

                g.DrawLine(pen, (float)(inicio.CoordX * pbMapa.Width), (float)(inicio.CoordY * pbMapa.Height), (float)(fim.CoordX * pbMapa.Width), (float)(fim.CoordY * pbMapa.Height));

            }
            ls.Items.Add("Distância total: " + distancia);
            ls.Items.Add("Preço total: " + preco);

            hora = distancia / 200;
            double resto = (distancia % 200);
            min =  ((double)resto / (double)200) * 60;
            /*
             * distancia
             * --------- = 200
             * tempo
             * horas e minutosss                     
             */
            if(hora == 0)
                ls.Items.Add("Tempo viagem total: " + (int)min + "min" );
            else
                ls.Items.Add("Tempo viagem total: " + hora + "hr " + (int)min + "min");
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
                    oGrafo.NovaAresta(oGrafo.IndiceVertice(txtCidade2.Text), oGrafo.IndiceVertice(txtCidade1.Text), Decimal.ToInt32(upDistancia.Value));
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
                    /*
                     40
                     41 -> 40
                     42 -> 41
                     43 -> 42
                     44 -> 43

                     41 -> 40
                     */
                    arv.Excluir(cidRemover);
                    arv.ReorganizarIndicesNos(oGrafo.IndiceVertice(cidRemover.Nome)+1);
                    oGrafo.removerVertice(oGrafo.IndiceVertice(cidRemover.Nome));

                    for (int i = 0; i < listaCaminho.Count; i++)
                        if (listaCaminho[i].Inicio.TrimEnd() == cidRemover.Nome || listaCaminho[i].Fim.TrimEnd() == cidRemover.Nome)
                        {
                            listaCaminho.RemoveAt(i);
                            i--;
                        } 

                    MessageBox.Show("Cidade removida com sucesso");
                }
            }
        }

        private void FrmCaminho_FormClosing(object sender, FormClosingEventArgs e)
        {
            arv.GravarArquivoDeRegistros("..\\..\\Cidades.txt");
            StreamWriter swCaminho = new StreamWriter("..\\..\\GrafoTremEspanhaPortugal.txt");
            for (int i = 0; i < listaCaminho.Count; i++)
                listaCaminho[i].GravarRegistro(swCaminho);
            swCaminho.Close();
        }
    }
}
