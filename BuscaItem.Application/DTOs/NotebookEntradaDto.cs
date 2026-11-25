using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaItem.Application.DTOs
{
    public record class NotebookEntradaDto
    {
        public string nomeNotebook;
        public DateTime ultimoDiaLanceNotebook;
        public decimal lanceAtual;

       
    }
}
