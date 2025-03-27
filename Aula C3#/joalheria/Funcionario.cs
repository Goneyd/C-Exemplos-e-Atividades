namespace joalheria;

internal  class Funcionario
{
    public Funcionario(string nome,string sobre_nome,double valor_hora,int depedente){

        Nome = nome;
        Sobrenome = sobre_nome;
        ValorHora = valor_hora;
        Depedente = depedente;
    }

    
    public string Nome{get;private set;}
    public string Sobrenome{get;private set;}
    public double ValorHora{get;set;}
    public int Depedente{get;set;}

    public Double Salario(){
        Double salario = ValorHora * 160;
        return salario;
    }


    public virtual void InfoFuncionario (){
        Console.WriteLine("\n ##### Dados Basicos ##### \n");
        Console.WriteLine($"Nome: {Nome} \nSobre Nome: {Sobrenome} \nSalario Base: {Salario()}");
    }

}