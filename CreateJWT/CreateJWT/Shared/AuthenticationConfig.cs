using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CreateJWT.Shared
{
    public static class AuthenticationConfig
    {
        public static string GenerateJSONWebToken(string user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("2D2EDF726FC9140D953C21560B005C9FA588D474CBCF1823119B6EFD708AF48F"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("UserName",user),
                new Claim("Role","1")
            };

            var token = new JwtSecurityToken("http://localhost:54042/",
                "http://localhost:54042/",
                claims,
                DateTime.UtcNow,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //ConfigureJwtAuthentication
        internal static TokenValidationParameters tokenValidationParams;
        public static void ConfigureJwtAuthentication(this IServiceCollection services)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("2D2EDF726FC9140D953C21560B005C9FA588D474CBCF1823119B6EFD708AF48F"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            tokenValidationParams = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                ValidIssuer = "xyz",
                ValidateLifetime = true,
                ValidAudience = "xyz",
                ValidateAudience = true,
                RequireSignedTokens = true,
                IssuerSigningKey = credentials.Key,
                ClockSkew = TimeSpan.FromMinutes(10)
            };
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = tokenValidationParams;
#if PROD || UAT
                options.IncludeErrorDetails = false;
#elif DEBUG
                options.RequireHttpsMetadata = false;
#endif
            });
        }
    }
}
