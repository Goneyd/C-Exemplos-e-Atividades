namespace AulaEx;
/* sealed é uma classe que não pode ser herdade */

internal sealed class Jornal:Publicacao{

    public Jornal(string titulo, int ano, string editora,DateOnly data, string cidade) : base(titulo, ano, 
    editora) 
    
    {

        Data = data;
        Cidade = cidade;

    }

    public DateOnly Data {get; private set;}
    public string Cidade {get;private set;}


}