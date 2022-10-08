var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Configura��o do CORS

builder.Services.AddCors(
    s => s.AddPolicy("DefaultPolicy", builder =>
    {
        builder.AllowAnyOrigin() //qualquer servidor de origem pode acessar a API
               .AllowAnyMethod() //qualquer m�todo (POST, PUT, DELETE, GET)
               .AllowAnyHeader(); //qualquer par�metro de cabe�alho (HEADER)
    })
);

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region habilitar o CORS

app.UseCors("DefaultPolicy");

#endregion

app.UseAuthorization();

app.MapControllers();

app.Run();