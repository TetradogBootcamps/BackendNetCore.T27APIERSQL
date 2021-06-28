using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCoreBootcampT27APIERSQL;
using NetCoreBootcampT27APIERSQL.Models;

namespace BootcampNetCoreT28ApiJwt_EX1.Controllers
{
    
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PiezasController:ControllerBase { 

        Context Context { get; set; }

        public PiezasController(Context context) 
        {
            Context = context;
        }
        [HttpGet]
        [Route("/")]
        public async Task<IList<Pieza>> GetAll()
        {
            return  await Context.Piezas.ToListAsync();
        }
        [HttpGet]
        [Route("/{idPieza:int}")]
        public async Task<Pieza> Get(int? idPieza)
        {
            return await Context.Piezas.FindAsync(idPieza);
        }
        [HttpPost]
        [Route("/{codigo}")]
        public async Task<ActionResult> Post(string codigo,Pieza pieza)
        {
            ActionResult result;
            
            if (Equals(pieza,default) || string.IsNullOrEmpty(codigo)||!codigo.Equals(pieza.Codigo) || !Equals(await Context.Piezas.FindAsync(pieza.Codigo), default))
            {
                result = BadRequest();
            }
            else
            {
                await Context.Piezas.AddAsync(pieza);
                await Context.SaveChangesAsync();
                result = Ok();
            }
            return result;

        }
        [HttpPut]
        [Route("/")]
        public async Task<ActionResult> Put(Pieza pieza)
        {
            Context.Attach(pieza).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return NoContent();

        }

    }
}
