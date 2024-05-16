﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Restaurant_Site.Auth
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMyAuth(this IServiceCollection service)
        {
            service.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly",
                    policy =>
                    {
                        policy.RequireRole("admin");
                        policy.RequireRole("editor");
                    });
                options.AddPolicy("UserOnly", policy => policy.RequireRole("User"));
            });
            service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = AuthOptions.ISSUER,

                        ValidateAudience = true,
                        ValidAudience = AuthOptions.AUDIENCE,

                        ValidateLifetime = true,

                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                    };
                });
        }
    }
}
