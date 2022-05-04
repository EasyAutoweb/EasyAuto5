using System;
using Assinaturas.Entities;
using Assinaturas.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Assinaturas.Controllers
{
    [Route("api/Assinatura")]
    [ApiController]
    public class AssinaturaController : ControllerBase
    {
        private IAssinaturaService _assinaturaService;
        public AssinaturaController(IAssinaturaService assinaturaService)
        {
            _assinaturaService = assinaturaService;
        }

        // GET: api/<AssinaturaController>
        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var assinaturas = _assinaturaService.BuscarTodasAssinaturas();
            return Ok(assinaturas);
        }

        // GET api/<AssinaturaController>/5
        [HttpGet("{id}")]
        public IActionResult Buscar(string id)
        {
            var assinatura = _assinaturaService.BuscarAssinatura(id);

            if (assinatura == null) return NotFound();

            return Ok(assinatura);
        }

        // POST api/<AssinaturaController>
        [HttpPost]
        public IActionResult Adicionar(Assinatura assinatura)
        {
            _assinaturaService.AdicionarAssinatura(assinatura);

            return Ok("Adicionado");
        }

        // PUT api/<AssinaturaController>/5
        [HttpPut]
        public IActionResult Atualizar(Assinatura assinatura)
        {
            _assinaturaService.AtualizarAssinatura(assinatura);

            return Ok("Atualizado");
        }

        // DELETE api/<AssinaturaController>/5
        [HttpDelete("{id}")]
        public IActionResult Remover(string id)
        {
            _assinaturaService.RemoverAssinatura(id);

            return Ok("Removido");
        }
    }
}
