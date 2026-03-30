var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona o suporte para Controllers (exigido pelo exercício)
builder.Services.AddControllers();

// Configuração do Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura o pipeline de requisições
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// 2. Mapeia as rotas dos seus Controllers automaticamente
app.MapControllers();

app.Run();