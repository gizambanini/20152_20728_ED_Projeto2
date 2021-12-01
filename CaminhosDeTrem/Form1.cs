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
        public FrmCaminho()
        {
            InitializeComponent();
        }

        private Font fnt = new Font("Arial", 10);
        private void FrmCaminho_Load(object sender, System.EventArgs e)
        {
            StreamReader srCidade = new StreamReader(@"C:\Users\pedro\source\repos\ProjetoEDII\CaminhosDeTrem\Cidades.txt");
            txtInicio.Text = srCidade.ReadLine();
            srCidade.Close(); 
            /*
            // Dock the PictureBox to the form and set its background to white.
            pbMapa.Dock = DockStyle.Fill;
            pbMapa.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapa_Paint);

            // Add the PictureBox control to the Form.
            this.Controls.Add(pbMapa);
            */
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
            g.DrawLine(pen, (float)(0.248 * pbMapa.Image.Width), (float)(0.192 * pbMapa.Image.Height), (float)(0.218 * pbMapa.Image.Width), (float)(0.796 * pbMapa.Image.Height));
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
    }
}
