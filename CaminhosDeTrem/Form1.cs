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
            // Dock the PictureBox to the form and set its background to white.
            pbMapa.Dock = DockStyle.Fill;
            pbMapa.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapa_Paint);

            // Add the PictureBox control to the Form.
            this.Controls.Add(pbMapa);
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
            g.DrawLine(pen, (float)(0.195 * pbMapa.Image.Width), (float)(0.151 * pbMapa.Image.Height), (float)(0.609 * pbMapa.Image.Width), (float)(0.609 * pbMapa.Image.Height));
        }
        private void FrmCaminho_ResizeEnd(object sender, EventArgs e)
        {
pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapa_Paint);
        }
    }
}
