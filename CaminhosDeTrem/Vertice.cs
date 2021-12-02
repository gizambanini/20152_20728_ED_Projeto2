﻿//PROJETO II: GRAFOS - CAMINHOS DE TREM
//GIOVANA MENDONÇA ZAMBANINI - 20728
//PEDRO HENRIQUE PEREZ DIAS  - 20152

using System;
class Vertice
{
    private bool foiVisitado;
    private string rotulo;
    private bool estaAtivo;

    public bool FoiVisitado { get => foiVisitado; set => foiVisitado = value; }
    public string Rotulo { get => rotulo; set => rotulo = value; }
    public bool EstaAtivo { get => estaAtivo; set => estaAtivo = value; }

    public Vertice(string label)
    {
        Rotulo = label;
        FoiVisitado = false;
        estaAtivo = true;
    }

}

