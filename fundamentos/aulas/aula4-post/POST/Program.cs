// var builder = WebApplication.CreateBuilder(args);




// var app = builder.Build();

// var cadastros = new List<Cadastro>();

// app.MapPost("/cadastro", (Cadastro cadastro) =>
// {
//     if (string.IsNullOrWhiteSpace(cadastro.nome) || string.IsNullOrWhiteSpace(cadastro.email)
//     || string.IsNullOrWhiteSpace(cadastro.senha))
//     {
//         return Results.BadRequest("Preencha todos os campos");

//     }
//     cadastros.Add(cadastro);
//     return Results.Ok($"Cadastro recebido: nome: {cadastro.nome}, email: {cadastro.email}, senha:{cadastro.senha}");
// });


// app.MapPut("/cadastro/{nome}", (string nome, Cadastro dadosAtualizados) =>
// {
//     var cadastroExiste = cadastros.FirstOrDefault(c => c.nome == nome);
//     if (cadastroExiste == null)
//     {
//         return Results.NotFound("Erro cadastro não encontrado");
//     }
//     cadastroExiste.email = dadosAtualizados.email;
//     cadastroExiste.senha = dadosAtualizados.senha;

//     return Results.Ok($"Cadastro de {nome} atualizado");



// });




// app.Run();
// record Cadastro(string nome, string email, string senha) {
//     public string nome { get; set; } = nome;
//     public string email { get; set; } = email;
//     public string senha { get; set; } = senha;
// }

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var cadastros = new List<Cadastro>();
app.MapPost("/createCadastro", (Cadastro cadastro) =>
{
    if (string.IsNullOrWhiteSpace(cadastro.nome)
    || string.IsNullOrWhiteSpace(cadastro.email)
    || string.IsNullOrWhiteSpace(cadastro.senha))
    {
        return Results.BadRequest("Preencha por favor todos os campos");
    }
    cadastros.Add(cadastro);
    return Results.Ok($"Cadastro criado com sucesso: {cadastro.nome}, {cadastro.email},{cadastro.senha}");

});

app.MapPut("/updateCadastro/{nome}", (string nome, Cadastro atualizar) =>
{
    var verificarCadastro = cadastros.FirstOrDefault(c => c.nome == nome);
    if (verificarCadastro == null)
    {
        return Results.NotFound("Cadsro não encontrado");

    }
    verificarCadastro.email = atualizar.email;
    verificarCadastro.senha = atualizar.senha;

    return Results.Ok($"Cadastro de {nome} atualizado com sucesso");
});
app.Run();

record Cadastro(string nome, string email, string senha)
{
    public string nome { get; set; } = nome;
    public string email { get; set; } = email;
    public string senha { get; set; } = senha;
}