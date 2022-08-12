using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Context;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {

        private readonly AppDbContext _context;

        public FilmesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Filme>> Get()
        {
            try
            {
                var filmes =  _context.Filmes.AsNoTracking().ToList();
                if(filmes == null)
                {
                    return NotFound("Filmes não encontrados");
                }

                Response.Headers.Add("Access-Control-Allow-Origin", " https://www.apirequest.io");

                return Ok(new { filmes });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Ocorreu um erro com sua solicitação");
            }
        }

        [HttpGet("{id:int}", Name ="ObterFilme")]
        public ActionResult<Filme> Get(int id)
        {
            try
            {
                var filme = _context.Filmes.AsNoTracking().FirstOrDefault(f => f.FilmeId == id);
                if(filme == null)
                {
                    return NotFound("Filme não encontrado");
                }
                return filme;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Ocorreu um erro com sua solicitação");
            }
        }

        [HttpPost]
        public ActionResult<Filme> Post(Filme filme)
        {

            try
            {
                if(filme is null)
                {
                    BadRequest();
                }

                _context.Filmes.Add(filme);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterFilme",
                    new { id = filme.FilmeId }, filme);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Ocorreu um erro com sua solicitação");
            }

        }

        [HttpPut("{id:int}")]
        public ActionResult<Filme> Put(int id, Filme filme)
        {
            try
            {
                if (id != filme.FilmeId)
                {
                    return NotFound();
                }

                _context.Entry(filme).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(filme);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Ocorreu um erro com sua solicitação");
            }

        }
        
        [HttpDelete("{id:int}")]
        public ActionResult<Filme> Delete(int id)
        {
            try
            {

                var filme = _context.Filmes.FirstOrDefault(f => f.FilmeId == id);

                if (id != filme.FilmeId)
                {
                    return NotFound("Filme não localizado");
                }

                _context.Filmes.Remove(filme);
                _context.SaveChanges();
                return Ok(filme);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Ocorreu um erro com sua solicitação");
            }
        }
    }
}
