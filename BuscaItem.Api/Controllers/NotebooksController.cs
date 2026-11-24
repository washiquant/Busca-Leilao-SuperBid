using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using BuscaItem.Domain.Interfaces;
using BuscaItem.Application.Services;
namespace BuscaItem.Api.Controllers
{
    public sealed record CadastrarNotebookRequest(
        string nomeNotebook,
        decimal LanceAtual,
        decimal ValorDeMercado
        );

    [ApiController]
    [Route("api/[controller]")]
    public class NotebooksController : ControllerBase
    {
        private readonly NotebookService _notebookService;

        public NotebooksController(NotebookService notebookService)
        {
            _notebookService = notebookService;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var Oportunidades = _notebookService.ListarOportunidades();
            return Ok(Oportunidades);

        }
        [HttpPost]
        public IActionResult Cadastrar([FromBody] CadastrarNotebookRequest request)
        {
            try
            {
                _notebookService.CadastrarOportunidade(
                    request.nomeNotebook,
                    request.LanceAtual,
                    request.ValorDeMercado
                );
                return Ok(new { Mensagem = "Oportunidade cadastrada com sucesso!" });
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                return BadRequest(new { Erro = ex.Message });
            }

        }
    }
}
