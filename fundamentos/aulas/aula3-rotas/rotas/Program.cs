var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/", () =>
{
    var nome = new
    {
        Nome = "Andre",
        Sobrenome = "Calixto"
    };
    return Results.Ok(nome);
});

app.MapGet("/acessar/{nome}", (string nome) =>
{
    return Results.Ok($"Ola, {nome}");
});

app.MapGet("/contato/{contato}", (int contato) =>
{
    return Results.Ok($"Contato: {contato}");
});

app.Run();

