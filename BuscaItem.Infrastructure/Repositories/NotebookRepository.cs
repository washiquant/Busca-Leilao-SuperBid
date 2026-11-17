using System;
using System.Collections.Generic;
using System.Text;
using BuscaItem.Domain.Interfaces;
using BuscaItem.Domain.Models;
namespace BuscaItem.Infrastructure.Repositories
{
    public class NotebookRepository : INotebookRepository
    {
        private readonly List<Notebook> _notebook = [];
        public void AdicionarNotebook(Notebook notebook)
        {
           _notebook.Add(notebook);

        }

        public List<Notebook> ListarNotebooks()
        {
            return _notebook; 
        }
    }
}
