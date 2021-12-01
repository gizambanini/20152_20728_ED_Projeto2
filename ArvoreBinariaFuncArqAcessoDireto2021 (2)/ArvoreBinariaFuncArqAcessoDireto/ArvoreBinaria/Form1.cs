using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArvoreBinaria
{
    public partial class frmArvore : Form
    {
        ArvoreDeBusca<Funcionario> arvore = null;

        public frmArvore()
        {
            InitializeComponent();
            txtNome.MaxLength = Funcionario.tamanhoNome;
      arvore = new ArvoreDeBusca<Funcionario>();
        }

        private void pnlArvore_Paint(object sender, PaintEventArgs e)
        {
            if (arvore != null)
            {
                Graphics g = e.Graphics;
                arvore.DesenharArvore(true, arvore.Raiz, (int)pnlArvore.Width / 2, 0, 
                  Math.PI / 2, Math.PI / 2.5, 300, g);
                bool balanceada = true;
                lblAltura.Text = "Altura : " + Convert.ToString(arvore.alturaArvore(arvore.Raiz, ref balanceada));
                chkBalanceada.Checked = balanceada;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                var umFunc = new Funcionario(int.Parse(txtChave.Text), txtNome.Text,
                                             dtpNascimento.Value, int.Parse(txtSecao.Text),
                                             int.Parse(txtMatriculaChefe.Text),
                                             int.Parse(txtDependentes.Text),
                                             float.Parse(txtSalario.Text),
                                             chkAfastado.Checked);
                arvore.IncluirNovoRegistro(umFunc);
                pnlArvore.Invalidate();
            }
            catch (Exception mens)
            {
                MessageBox.Show(mens.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            arvore.GravarArquivoDeRegistros(dlgAbrir.FileName);
        }

        private void btnLerDadosParticionados_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                arvore = new ArvoreDeBusca<Funcionario>();
                arvore.OndeExibir = pnlArvore;
                if (!File.Exists(dlgAbrir.FileName))
                {
                    var func = new Funcionario();
                    var arquivoCriado = File.Create(dlgAbrir.FileName); 
                    arquivoCriado.Close();
                }
                arvore.LerArquivoDeRegistros(dlgAbrir.FileName);
                pnlArvore.Invalidate();  // disparar o evento Paint, que desenha a árvore
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtChave.Text != "")
            {
                var dadoProcurado = new Funcionario(int.Parse(txtChave.Text));
                if (arvore.Existe(dadoProcurado))
                {
                    // se existe (achou) o ponteiro arvore.Atual aponta o nó com o registro
                    // cuja chave foi digitada
                    txtNome.Text = arvore.Atual.Info.Nome;
                    txtMatriculaChefe.Text = arvore.Atual.Info.MatriculaChefe.ToString();
                    txtSalario.Text = arvore.Atual.Info.Salario.ToString();
                    txtDependentes.Text = arvore.Atual.Info.QuantosDependentes.ToString();
                    txtSecao.Text = arvore.Atual.Info.CodigoSecao.ToString();
                    dtpNascimento.Value = arvore.Atual.Info.Nascimento;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

    private void lbQuantosNos_DoubleClick(object sender, EventArgs e)
    {
      lbQuantosNos.Text = "Nós:"+arvore.QtosNos().ToString();
    }

    private void lbQuantasFolhas_DoubleClick(object sender, EventArgs e)
    {
      lbQuantasFolhas.Text = "Folhas:" + arvore.QtasFolhas();
    }

    private void lbExtritamenteBinaria_DoubleClick(object sender, EventArgs e)
    {
      chkEstritamenteBinaria.Checked = arvore.EstritamenteBinaria();
    }

    private void lbQuantasFolhas_Click(object sender, EventArgs e)
    {

    }

    private void LbEntreParenteses_DoubleClick(object sender, EventArgs e)
    {
      LbEntreParenteses.Text = arvore.EntreParenteses();
    }

    private void chkEspelhar_Click(object sender, EventArgs e)
    {
      arvore.Trocar();
      pnlArvore.Invalidate();
      chkEspelhar.Checked = !chkEspelhar.Checked;
    }

    private void lbPorNiveis_DoubleClick(object sender, EventArgs e)
    {
      lbPorNiveis.Text = "Por níveis:" + arvore.PercursoPorNiveis();
    }

    private void lbLargura_DoubleClick(object sender, EventArgs e)
    {
      lbLargura.Text = "Largura:" + arvore.Largura();
    }
  }
}