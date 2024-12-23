using Domain.Entities;
using InfraStructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Add Services


builder.Services.AddDbContext<ApplicationDatabaseContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDbConnection"));
});

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDatabaseContext>();

var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(br =>
{
    br.RequireHttpsMetadata = false;
    br.SaveToken = true;
    br.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
        ValidateIssuer = false,
        ValidateAudience = true
    };
});

builder.Services.AddCors();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//swagger configuration goes here
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme,
        new Microsoft.OpenApi.Models.OpenApiSecurityScheme
        {
            Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n" +
                          "Enter 'Bearer' [space] and your token in the text input below. \r\n\r\n" +
                          "Example: \"Bearer 123456abcdef\"",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Scheme = JwtBearerDefaults.AuthenticationScheme,
        });
    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});
#endregion

// overriding default config of password requirement by identity
//builder.Services.Configure<IdentityOptions>(options =>
//{
//    options.Password.RequireDigit = false;
//    options.Password.RequireLowercase = false;
//    options.Password.RequireUppercase = false;
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequiredLength = 1; // minimum length of password
//});



var app = builder.Build();
app.UseSwagger();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}
else
{
    app.UseSwaggerUI(s =>
    {
        s.SwaggerEndpoint("/swagger/v1/swagger.json","MY API V1");
        s.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseCors(o => o.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().WithExposedHeaders("*"));

app.UseAuthorization();

app.MapControllers();

app.Run();
