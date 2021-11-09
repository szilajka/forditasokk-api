using Forditasokk.Data.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.IdentityModel.Tokens.Jwt;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<ForditasokkDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ForditasokkPgsql"));
});
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Forditasokk.Api", Version = "v1" });
});
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.IncludeErrorDetails = true;
        //AuthServer url
        options.Authority = "https://localhost:44338";
        options.TokenValidationParameters.ValidAudiences = new List<string>() { "" };
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.SecurityTokenValidators.Add(new JwtSecurityTokenHandler
        {
            // Disable the built-in JWT claims mapping feature.
            InboundClaimTypeMap = new Dictionary<string, string>()
        });

        options.TokenValidationParameters.NameClaimType = "name";
        options.TokenValidationParameters.RoleClaimType = "role";
    });

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy();
//});

builder.Services.AddHttpClient();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Forditasokk.Api v1"));
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.Run();