namespace joalheria;

internal  class Funcionario
{
    public Funcionario(string nome,string sobre_nome,double valor_hora){

        Nome = nome;
        Sobrenome = sobre_nome;
        ValorHora = valor_hora;
    }

    
    public string Nome{get;private set;}
    public string Sobrenome{get;private set;}
    public double ValorHora{get;private set;}

}