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

class Cidade: IComparable<Cidade>, IRegistro
{
    private string nome;
    private float coordX, coordY;


    public string Nome { get => nome; set => nome = value.PadRight(17, ' ').Substring(0, 17); }
    public float CoordX { get => coordX; set => coordX = value; }
    public float CoordY { get => coordY; set => coordY = value; }

    public Cidade()
    {
        Nome = "";
        CoordX = 0.0f;
        CoordY = 0.0f;
    }

    public Cidade(string nome, float x, float y)
    {
        this.Nome = nome;
        this.CoordX = x;
        this.CoordY = y;
    }

    public int CompareTo(Cidade cidade)
    {
        return Nome.CompareTo(cidade.Nome);
    }

    public override string ToString()
    {
        return Nome;
    }

    public void LerRegistro(StreamReader arquivo, long qualRegistro)
    {
        if (arquivo != null)
            try
            {
                string registro = arquivo.ReadLine();
                int x = registro.Length;
                Nome = registro.Substring(0, 16);
                CoordX = float.Parse(registro.Substring(16, 5));
                CoordY = float.Parse(registro.Substring(22, 5));
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
            arquivo.Write(Nome);
            arquivo.Write(string.Format("{0:N3}", CoordX));     //Grava o número com 3 casas decimais
            arquivo.Write(" ");
            arquivo.WriteLine(string.Format("{0:N3}", CoordY)); //Grava o número com 3 casas decimais
        }
    }

}

