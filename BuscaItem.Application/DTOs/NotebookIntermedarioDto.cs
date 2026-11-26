using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaItem.Application.DTOs
{
    public record NotebookIntermedarioDto(string Nome, decimal LanceAtual,decimal ValordeMercado, DateTime UltimoDiaDeLance, string Cidade, string Leiloeiro );
}
