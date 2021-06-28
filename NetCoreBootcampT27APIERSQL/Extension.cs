using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampNetCoreT28ApiJwt_EX1
{
    public static class JwtSecurityTokenExtension
    {
        public static string WriteToken(this JwtSecurityToken token)
        {
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
