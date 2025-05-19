
var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();

app.MapGet("/pessoa/{nome}",(string nome)=>{
   return $"Hello {nome}";
});

app.MapPost("/pessoa",(Pessoa pessoa)=>{
    return $"Nome recebido : {pessoa.Nome}, Cidade: {pessoa.Cidade}, Cep: {pessoa.Cep}";

});

app.Run();

record Pessoa(string Nome,string Cidade,string Cep);