using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaItem.Application.DTOs
{
    public record NotebookSaidaDto(string Nome, decimal LanceAtual, DateTime UltimaDataLance, decimal LucroPotencial, string LinkDoLote);
}
