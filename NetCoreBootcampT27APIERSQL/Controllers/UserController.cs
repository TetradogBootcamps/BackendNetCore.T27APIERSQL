using BootcampNetCoreT28ApiJwt_EX1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NetCoreBootcampT27APIERSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampNetCoreT28ApiJwt_EX1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        Context Context { get; set; }
        IConfiguration Configuration { get; set; }
        public AccountController(Context context, IConfiguration configuration)
        {
            Context = context;
            Configuration = configuration;
        }


        [HttpPost("/login")]
        public ActionResult GetToken(LoginUser userLogin)
        {
            ActionResult result;
            User user;
            if (!Equals(userLogin, default) && !string.IsNullOrEmpty(userLogin.UserName) && !string.IsNullOrEmpty(userLogin.Password))
            {
                user = Context.Users.Find(userLogin.UserName);
                if (Equals(user, default))
                {
                    result = NotFound();
                }
                else if(Equals(user.Password,userLogin.Password))
                {
                    result =Ok( user.GetToken(Configuration).WriteToken());
                }
                else
                {
                    result = Forbid();
                }
            }
            else
            {
                result = BadRequest();
            }
            return result;
        }

        [HttpPost("/register")]
        public async Task<ActionResult> Register(User user)
        {
            ActionResult result;
            if(Equals(user,default(User))||string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.Name))
            {
                result = BadRequest();
            }
            else if (!Equals(await Context.Users.FindAsync(user.UserName), default))
            {
                result = BadRequest();//ya existe!
            }
            else
            {
                await Context.Users.AddAsync(user);
                await Context.SaveChangesAsync();
                result = GetToken(user.ToLoginUser());//le doy el token para que empiece a usar la API
            }
            return result;
        }

        //[Authorize]
        //[HttpGet("/")]
        //public async Task<ActionResult> GetUser()
        //{
        //    ActionResult result;
        //    if (HttpContext.User.Identity.IsAuthenticated)
        //    {
        //        result = Ok(await Context.Users.FindAsync(HttpContext.User.Identities.First().Claims.First().Value));
        //    }
        //    else
        //    {
        //        result = Forbid();
        //    }
        //    return result;
        //}
    }
}
