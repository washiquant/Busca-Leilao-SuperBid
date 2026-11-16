using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaItem.Domain.Interfaces
{
    internal interface INotebookRepository
    {
        void AdicionarNotebook(Notebook notebook); // Adiciona um notebook ao repositório

        List<Notebook> ListarNotebooks(); // Retorna uma lista tipada de notebooks
    }
}
