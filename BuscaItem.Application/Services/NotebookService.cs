using System;
using System.Collections.Generic;
using System.Text;
using BuscaItem.Domain.Interfaces;
using BuscaItem.Domain.Models;
namespace BuscaItem.Application.Services
{
    public class NotebookService
    {
        private readonly INotebookRepository _notebookRepository;

        public NotebookService(INotebookRepository notebookRepository)
        {
            _notebookRepository = notebookRepository;
        }
        public void CadastrarOportunidade(string nomeNotebook, decimal lanceAtual,decimal valorDeMercado)
        {
            if (lanceAtual <= 0 || valorDeMercado <= 0)
            {
                throw new ArgumentException("Lance atual & Valor de mercado deve ser maiores que R$0");
            }
            var notebook = new Notebook(nomeNotebook, lanceAtual, valorDeMercado);

            if (notebook.LucroPotencial() <= 0)
            {
            
                throw new InvalidOperationException("Oportunidade descartada: Lucro potencial menor ou igual a zero");
                
            }
            _notebookRepository.AdicionarNotebook(notebook);

        }
        public List<Notebook> ListarOportunidades()
        {
            return _notebookRepository.ListarNotebooks();
        }
    }
    
}
