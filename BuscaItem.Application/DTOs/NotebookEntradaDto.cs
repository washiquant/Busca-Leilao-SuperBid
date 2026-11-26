using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaItem.Application.DTOs
{
    public record NotebookEntradaDto(string NomeProcurado, decimal ValorMaximoLance, decimal LucroMinimoDesejado);
}
