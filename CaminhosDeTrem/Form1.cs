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
        //ARRUMAR LINK DA IMAGEM NO PICTURE BOX E DO FILE
        //Se precisar, arrumar o list
        ArvoreDeBusca<Cidade> arv = new ArvoreDeBusca<Cidade>();

        Cidade [] vetCidade  = new Cidade [System.IO.File.ReadAllLines("..\\..\\Cidades.txt").Length];
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

            //Criação da lista de caminhos, com base no arquivo texto
            while(!srCaminho.EndOfStream)
            {
                Caminho cam = new Caminho();
                cam.LerRegistro(srCaminho);
                listaCaminho.Add(cam);
            }
                
            //Lê o vetor e armazena os valores de forma balanceada na árvore
            arv.LerVetorDeRegistros(vetCidade);

            //Cria o grafo, seus vértices e suas arestas
            oGrafo = new Grafo(dgvGrafo);
            CriaVertices(arv.Raiz);
            CriaArestas();
        }

        private void pbMapa_MouseClick(object sender, MouseEventArgs e)
        {
            //Escreve a coordenada X e Y do clique do mouse, em porcentagem de tela
            //com 3 casas decimais
            txtX.Text = string.Format("{0:N3}", ((float)e.X / (float)pbMapa.Width));
            txtY.Text = string.Format("{0:N3}", ((float)e.Y / (float)pbMapa.Height));
        }

        private void btnIncluirCidade_Click(object sender, EventArgs e)
        {
            //Verifica se o campo que exibe a coordenada X está vazio
            //Como os dois campos (txtX e txtY) sao atualizados ao mesmo tempo, basta verificar se um deles esta vazio
            if (txtX.Text == "")
                MessageBox.Show("Selecione a cidade desejada no mapa primeiro");

            //Verifica se o campo que exibe o nome da cidade a ser incluída está vazio
            else if (txtNomeCidade.Text == "")
                MessageBox.Show("Digite o nome da cidade a ser cadastrada primeiro");

            //Inclui a cidade
            else
            {
                
                Cidade cidInclusao = new Cidade(txtNomeCidade.Text, float.Parse(txtX.Text), float.Parse(txtY.Text));
                try
                {
                    //Inclui a cidade especificada na árvore
                    arv.Incluir(cidInclusao);
                    //Inclui o nome da cidade como vértice no grafo
                    oGrafo.NovoVertice(cidInclusao.Nome);
                    MessageBox.Show("Cidade cadastrada com sucesso");
                }
                catch (Exception erro)
                {
                    //Printa a mensagem de exceção em uma MessageBox
                    //Nesse caso, a única exceção que pode ser disparada, é a de inclusão de registro repetido na árvore
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
            
            
            int ori = oGrafo.IndiceVertice(txtInicio.Text);
            int des = oGrafo.IndiceVertice(txtFim.Text);
            //Printa a mensagem abaixo, se a cidade especificada como origem, não existir no grafo
            if (ori == -1)
            {
                MessageBox.Show("A cidade " + txtInicio.Text + " não está cadastrada");
            }
            //Printa a mensagem abaixo, se a cidade especificada como destino, não existir no grafo
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

                //Considerando que existe um caminho, caminhoFinal será algo como: "Madrid --> Salamanca --> A Coruna"
                //Então nós pegamos essa string, substituímos a " --> " por "*" que é um caracter que nunca é utilizado no nome de uma cidade
                //O resultado dessa operação será: "Madrid*Salamanca*A Coruna"
                caminhoFinal = caminhoFinal.Replace(" --> ", "*");

                //Nós então dividimos caminhoFinal em um vetor, utilizando "*" como caracter separador
                //O resultado dessa operação será: {"Madrid", "Salamanca", "A Coruna"}
                //Utilizaremos esse vetor para desenhar o caminho
                string[] cidades = caminhoFinal.Split('*');

                //Limpa o que tiver sido desenhado no mapa
                pbMapa.Refresh();

                //Verifica se existe um caminho, antes de chamar o método para desenhar o caminho
                if (caminhoFinal != "Não há caminho")
                {
                    CaminhoInfo(cidades, lsbCaminho);
                }
                
                
            }
        }

        private void CriaVertices(NoArvore<Cidade> raiz)
        {
            //Percorre a árvore recursivamente
            if (raiz != null)
            {
                if (raiz.Esq != null)
                    CriaVertices(raiz.Esq);
                if (raiz.Dir != null)
                    CriaVertices(raiz.Dir);
                oGrafo.NovoVertice(raiz.Info.Nome.TrimEnd(), raiz.Indice); //Cria um vértice com o nome e o índice da raiz
            }
        }

        //VERIFICAR RESPOSTA DO CHICO
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
            Graphics g = pbMapa.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            int distancia = 0;
            int preco = 0;
            int hora;
            double min;
            for (int i = 0; i < cidVisitadas.Length; i = i + 1)
            {
                int distParcial = 0;
                
                int f = i;
                if (i + 1 < cidVisitadas.Length)
                    f = i + 1;
                
                //Chama a função indiceVertice do Grafo, passando por parâmetro o nome na posição i do vetor de cidades visitadas
                //Aproveita o retorno dessa função, para pegar o nó da árvore que possui o mesmo índice
                //Armazenamos em 'inicio' e em 'fim', a informação dos nós retornados (ou seja, as cidades desses nós)
                Cidade inicio = arv.NoIndice(oGrafo.IndiceVertice(cidVisitadas[i])).Info;
                Cidade fim = arv.NoIndice(oGrafo.IndiceVertice(cidVisitadas[f])).Info;
                if(inicio != fim)
                {
                    //Armazena na variável distParcial, o peso da aresta formada pela cidade inicial e cidade final
                    //Esse peso, é a distância entre essas cidades
                    distParcial = oGrafo.PesoAresta(oGrafo.IndiceVertice(cidVisitadas[i]), oGrafo.IndiceVertice(cidVisitadas[f]));
                    //Soma o valor da distância parcial ao valor da distância total
                    distancia += distParcial; 
                

                    for (int posLista = 0; posLista < listaCaminho.Count; posLista++)
                        if (listaCaminho[posLista].Inicio.TrimEnd() == inicio.Nome && listaCaminho[posLista].Fim.TrimEnd() == fim.Nome && listaCaminho[posLista].Distancia == distParcial 
                            || listaCaminho[posLista].Inicio.TrimEnd() == fim.Nome && listaCaminho[posLista].Fim.TrimEnd() == inicio.Nome && listaCaminho[posLista].Distancia == distParcial)
                            preco += listaCaminho[posLista].Passagem;
                }
                
                //Desenha uma linha no mapa, utilizando as coordenadas X e Y do início e do fim
                g.DrawLine(pen, (float)(inicio.CoordX * pbMapa.Width), (float)(inicio.CoordY * pbMapa.Height), (float)(fim.CoordX * pbMapa.Width), (float)(fim.CoordY * pbMapa.Height));

            }
            ls.Items.Add("Distância total: " + distancia);
            ls.Items.Add("Preço total: " + preco);

            //calcula o tempo a partir da velocidade 200km/h
            hora = distancia / 200;  //calcula horas
            double resto = (distancia % 200);  
            min =  ((double)resto / (double)200) * 60; //calcula minutos
            if(hora == 0) 
                ls.Items.Add("Tempo viagem total: " + (int)min + "min" );
            else
                ls.Items.Add("Tempo viagem total: " + hora + "hr " + (int)min + "min");
        }

        private void btnIncluirLig_Click(object sender, EventArgs e)
        {
            //Verifica se os campos de criação de ligação, foram preenchidos corretamente
            if(txtCidade1.Text != "" && txtCidade2.Text != "" && upDistancia.Value != 0 && upPreco.Value != 0)
            {
                Cidade cid1 = new Cidade();
                cid1.Nome = txtCidade1.Text;
                Cidade cid2 = new Cidade();
                cid2.Nome = txtCidade2.Text;

                //Verifica se as árvores especificadas nos campos de digitação existem, antes de incluir a ligação
                if (!arv.Existe(cid1))
                    MessageBox.Show("A cidade 1 especificada não está cadastrada");

                else if (!arv.Existe(cid2))
                    MessageBox.Show("A cidade 2 especificada não está cadastrada");
                
                //Inclui o caminho
                else
                {
                    Caminho cam = new Caminho(txtCidade1.Text, txtCidade2.Text, Decimal.ToInt32(upDistancia.Value), Decimal.ToInt32(upPreco.Value));
                    //Adiciona o caminho especificado na lista, para facilitar a gravação no arquivo
                    listaCaminho.Add(cam);
                    //Cria uma aresta no grafo, tendo como índices: o índice da cidade inicial e o índice da cidade final
                    oGrafo.NovaAresta(oGrafo.IndiceVertice(txtCidade1.Text), oGrafo.IndiceVertice(txtCidade2.Text), Decimal.ToInt32(upDistancia.Value));
                    oGrafo.NovaAresta(oGrafo.IndiceVertice(txtCidade2.Text), oGrafo.IndiceVertice(txtCidade1.Text), Decimal.ToInt32(upDistancia.Value));
                    MessageBox.Show("Caminho incluído com sucesso");
                }
            }

            //Printa essa mensagem se os campos não foram preenchidos corretamente
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verifica se o nome da cidade a ser removida foi digitado
            if (txtNomeRem.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente");
            }

            //Exclui a cidade
            else
            {
                Cidade cidRemover = new Cidade();
                cidRemover.Nome = txtNomeRem.Text;
                
                //Verifica se a cidade que se deseja excluir, existe na árvore
                if (!arv.Existe(cidRemover))
                    MessageBox.Show("A cidade especificada não está cadastrada");
                else
                {
                    //Exclui a cidade especificada  da árvore
                    arv.Excluir(cidRemover);
                    //Reorganiza os índices da árvore, a partir do indice seguinte ao da árvore excluída
                    arv.ReorganizarIndicesNos(oGrafo.IndiceVertice(cidRemover.Nome)+1);
                    //Remove o vértice com o índice especificado do grafo
                    oGrafo.removerVertice(oGrafo.IndiceVertice(cidRemover.Nome));

                    //Percorre a lista de caminhos, verificando se o Inicio ou Fim armazenados em suas posições são iguais ao nome da cidade excluída 
                    for (int i = 0; i < listaCaminho.Count; i++)
                        if (listaCaminho[i].Inicio.TrimEnd() == cidRemover.Nome || listaCaminho[i].Fim.TrimEnd() == cidRemover.Nome)
                        {
                            listaCaminho.RemoveAt(i); //Remove a posição especificada da lista.
                            i--;                      //Na remoção, a lista reorganiza suas posições. 
                                                      //Por isso temos que voltar para a posição anterior,
                                                      //para que não se perca nenhum registro na leitura
                        }       

                    MessageBox.Show("Cidade removida com sucesso");
                }
            }
        }

        private void FrmCaminho_FormClosing(object sender, FormClosingEventArgs e)
        {
            arv.GravarArquivoDeRegistros("..\\..\\Cidades.txt"); //Grava os registros da árvore no arquivo de Cidades
            StreamWriter swCaminho = new StreamWriter("..\\..\\GrafoTremEspanhaPortugal.txt");
            for (int i = 0; i < listaCaminho.Count; i++)
                listaCaminho[i].GravarRegistro(swCaminho);  //Percorre a lista com os caminhos para 
                                                            //gravar no arquivo
            swCaminho.Close();
        }

        private void btnMostrarGrafo_Click(object sender, EventArgs e)
        {
            //Mostra as adjacências do grafo, no datagridview criado
            oGrafo.ExibirAdjacencias();
        }
    }
}
