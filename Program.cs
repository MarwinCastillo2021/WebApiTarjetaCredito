using Microsoft.EntityFrameworkCore;

using WebApiTarjetaCredito;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//creacion politica de CORS
builder.Services.AddCors(
    optinos => 
    optinos.AddPolicy("AllowWebApi",
            builder => builder.AllowAnyOrigin()
                              .AllowAnyHeader()
                              .AllowAnyMethod())
);

//builder.Services.AddSqlServer<TarjetaCreditoDbContext>("Data Source=TarjetaCreditoDb.db");

builder.Services.AddDbContext<TarjetaCreditoDbContext>(
    options => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
        "CadenaConexionDbProyectosmc"))
);

/*builder.Services.AddDbContext<AzureProyectosmcDbContext>(
    options => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
        "CadenaConexionDbProyectosmc"))
);*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//aplicativo politica CORS
app.UseCors("AllowWebApi");

app.UseHsts();

app.UseHttpsRedirection();

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
