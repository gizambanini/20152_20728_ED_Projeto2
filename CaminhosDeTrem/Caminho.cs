//PROJETO II: GRAFOS - CAMINHOS DE TREM
//GIOVANA MENDONÇA ZAMBANINI - 20728
//PEDRO HENRIQUE PEREZ DIAS  - 20152

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

class Caminho
{
    private string inicio, fim;
    private int distancia, passagem;


    public string Inicio { get => inicio.TrimEnd(); set => inicio = value; }
    public string Fim { get => fim.TrimEnd(); set => fim = value; }
    public int Distancia { get => distancia; set => distancia = value; }
    public int Passagem { get => passagem; set => passagem = value; }

    public Caminho()
    {
        Inicio = "";
        Fim = "";
        Distancia = 0;
        Passagem = 0;
    }

    public Caminho(string cidade1, string cidade2, int distancia, int passagem)
    {
        Inicio = cidade1.PadRight(15);
        Fim = cidade2.PadRight(16);
        Distancia = distancia;
        Passagem = passagem;
    }

    public override string ToString()
    {
        return Inicio;
    }

    public void LerRegistro(StreamReader arquivo)
    {
        if (arquivo != null)
            try
            {
                string registro = arquivo.ReadLine();
                Inicio    = registro.Substring(0, 15);
                Fim       = registro.Substring(15, 16);
                Distancia = int.Parse(registro.Substring(31, 3));
                Passagem  = int.Parse(registro.Substring(36, 3));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
    }

    public void GravarRegistro(StreamWriter arquivo)
    {
        if (arquivo != null)
        {
            arquivo.Write(Inicio.PadRight(15));
            arquivo.Write(Fim.PadRight(16));
            arquivo.Write(Distancia.ToString().PadLeft(3, ' '));
            arquivo.Write("  ");
            arquivo.WriteLine(Passagem.ToString().PadLeft(3, ' '));
        }
    }
}

