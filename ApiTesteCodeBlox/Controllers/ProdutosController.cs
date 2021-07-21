using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCodeBlox.Models;

namespace ApiTesteCodeBlox.Controllers
{
    [ApiController]
    [Route("produtos")]
    
    public class ProdutosController : ControllerBase
    {
        private readonly BDContext _context;

        public ProdutosController(BDContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("lista")]
        [Route("")]
        public List<Produto> Produtos()
        {
            var lstContext = _context.Produtos.ToList();
            return lstContext;
        }

        [HttpPost]
        [Route("inserir")]

        public async Task<ActionResult<Produto>> InserirProduto([FromBody]Produto produtos)
        {
            var entity = await _context.Produtos.AddAsync(produtos);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
