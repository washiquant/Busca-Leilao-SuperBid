using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaItem.Domain.Models;

public class Notebook
{
    public string NomeNotebook { get; set; }
    public decimal LanceAtual { get; set; }
    public decimal ValordeMercado { get; set; }
    public decimal TaxaLeiloeiro { get; set; }


    public Notebook(string nomeNotebook, decimal lanceAtual, decimal valordeMercado)
    {
        NomeNotebook = nomeNotebook;
        LanceAtual  = lanceAtual;
        ValordeMercado = valordeMercado;

    }
    public decimal LucroPotencial()
    {
        return ValordeMercado - LanceAtual;

    }
}