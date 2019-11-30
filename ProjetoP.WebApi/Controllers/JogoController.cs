using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoP.WebApi.Data;
using ProjetoP.WebApi.Model;

namespace ProjetoP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        public readonly DataContext _context;

        public JogoController(DataContext context)
        {
            _context = context;
        }

        // GET api/jogo
        [HttpGet]
        public async Task<IActionResult> GetAllJogos()
        {
            try
            {
                var result = await _context.Jogo.ToListAsync();
                return Ok(result);
            }
            catch (System.Exception)
            {
                var status500 = StatusCodes.Status500InternalServerError;
                var messageError = "Erro no Banco de Dados";
                return this.StatusCode(status500, messageError);
                throw;
            }
        }

        //GetJogoById
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJogoById(int id)
        {
            var jogo = await _context.Jogo.FirstOrDefaultAsync((v) => v.Id == id);
            if (jogo == null)
            {
                var status404 = StatusCodes.Status404NotFound;
                var messageError = "Não foi encontrado um jogo com o Id = " + id;
                return this.StatusCode(status404, messageError);
            }
            return Ok(jogo);
        }

        //GetJogoByGenero
        [HttpGet("genero/{genero}")]
        public async Task<IActionResult> GetJogosByGenero(string genero)
        {
            var jogos = await _context.Jogo.ToListAsync();
            var generos = jogos.Where(
                    (v) => string.Equals(v.Genero, genero,
                    StringComparison.OrdinalIgnoreCase));

            return Ok(generos);
        }


    }
}