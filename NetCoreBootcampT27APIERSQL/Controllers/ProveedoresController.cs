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
    public class ProveedoresController:ControllerBase { 

        Context Context { get; set; }

        public ProveedoresController(Context context) 
        {
            Context = context;
        }
        [HttpGet]
        [Route("/")]
        public async Task<IList<Proveedor>> GetAll()
        {
            return  await Context.Proveedores.ToListAsync();
        }
        [HttpGet]
        [Route("/{idProveedor}")]
        public async Task<Proveedor> Get(string idProveedor)
        {
            return await Context.Proveedores.FindAsync(idProveedor);
        }
        [HttpPost]
        [Route("/")]
        public async Task<ActionResult> Post(Proveedor proveedores)
        {
            ActionResult result;
            
            if (!Equals(await Context.Proveedores.FindAsync(proveedores.Id), default))
            {
                result = BadRequest();
            }
            else
            {
                await Context.Proveedores.AddAsync(proveedores);
                await Context.SaveChangesAsync();
                result = Ok();
            }
            return result;

        }
        [HttpPut]
        [Route("/")]
        public async Task<ActionResult> Put(Proveedor proveedor)
        {
            Context.Attach(proveedor).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return NoContent();

        }

    }
}
