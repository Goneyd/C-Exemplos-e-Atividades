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

    public Double Salario(){
        Double salario = ValorHora * 160;
        return salario;
    }

    public virtual void InfoFuncionario (){
        Console.WriteLine("##### Dados Basicos #####");
        Console.WriteLine($"Nome: {Nome} \n Sobre Nome: {Sobrenome} \n Salario: {Salario()}");
    }

}