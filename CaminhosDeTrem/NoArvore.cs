//PROJETO II: GRAFOS - CAMINHOS DE TREM
//GIOVANA MENDONÇA ZAMBANINI - 20728
//PEDRO HENRIQUE PEREZ DIAS  - 20152

using System;
using System.Collections.Generic;
using System.Text;


class NoArvore<Dado> : IComparable<NoArvore<Dado>> where Dado : IComparable<Dado>
{
    Dado info;
    NoArvore<Dado> esq;
    NoArvore<Dado> dir;
    long indice;

    public NoArvore(Dado informacao)
    {
        this.Info = informacao;
        this.esq = null;
        this.dir = null;
        this.indice = 0;
    }

    public NoArvore(Dado informacao, long indi)
    {
        this.Info = informacao;
        this.esq = null;
        this.dir = null;
        this.indice = indi;
    }

    public NoArvore(Dado dados, NoArvore<Dado> esquerdo, NoArvore<Dado> direito, long indi)
    {
        this.Info = dados;
        this.Esq = esquerdo;
        this.Dir = direito;
        this.Indice = indi;
    }

    public Dado Info { get => info; set => info = value; }
    public NoArvore<Dado> Esq { get => esq; set => esq = value; }
    public NoArvore<Dado> Dir { get => dir; set => dir = value; }
    public long Indice { get => indice; set => indice = value; }

    public int CompareTo(NoArvore<Dado> o)
    {
        return info.CompareTo(o.info);
    }

    public bool Equals(NoArvore<Dado> o)
    {
        return this.info.Equals(o.info);
    }
}

