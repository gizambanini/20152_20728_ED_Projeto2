//PROJETO II: GRAFOS - CAMINHOS DE TREM
//GIOVANA MENDONÇA ZAMBANINI - 20728
//PEDRO HENRIQUE PEREZ DIAS  - 20152


using System;
using System.IO;

interface IRegistro
{
    void LerRegistro(StreamReader arquivo, long qualRegistro);
    void GravarRegistro(StreamWriter arquivo);
    //int TamanhoRegistro { get; }
}