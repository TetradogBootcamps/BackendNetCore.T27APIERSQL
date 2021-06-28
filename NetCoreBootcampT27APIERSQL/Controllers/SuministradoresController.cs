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
    public class SuministradoresController:ControllerBase { 

        Context Context { get; set; }

        public SuministradoresController(Context context) 
        {
            Context = context;
        }
        [HttpGet]
        [Route("/")]
        public async Task<IList<Suministra>> GetAll()
        {
            return  await Context.Suministras.ToListAsync();
        }
        [HttpGet]
        [Route("/{idPieza}/{idProveedor}")]
        public async Task<Suministra> Get(string idPieza,string idProveedor)
        {
            return await Context.Suministras.FindAsync(idPieza,idProveedor);
        }
        [HttpPost]
        [Route("/")]
        public async Task<ActionResult> Post(Suministra suministra)
        {
            ActionResult result;
            
            if (!Equals(await Context.Suministras.FindAsync(suministra.PiezaId,suministra.ProveedorId), default))
            {
                result = BadRequest();
            }
            else
            {
                await Context.Suministras.AddAsync(suministra);
                await Context.SaveChangesAsync();
                result = Ok();
            }
            return result;

        }
        [HttpPut]
        [Route("/")]
        public async Task<ActionResult> Put(Suministra suministra)
        {
            Context.Attach(suministra).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return NoContent();

        }

    }
}
