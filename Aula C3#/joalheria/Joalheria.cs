using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
namespace joalheria;

internal class Joalheria
{

    public Joalheria(string nome, string localizacao){
        Nome = nome;
        Localizacao = localizacao;
    }

    private string Nome {get;set;}
    private string Localizacao {get;set;}

    private List<Funcionario> FuncionarioLista = new List<Funcionario>(); 
    
    public void AdicionarFuncionario (Funcionario novoFuncionario){
            FuncionarioLista.Add(novoFuncionario);
    }

    public List<Funcionario> ListaFuncionarios()
    {
        return FuncionarioLista;
    }

    public List<Funcionario> ListarGerentes(){
        return FuncionarioLista.Where(g => g is Surpervisor).ToList();
    }

    public List<Funcionario> ListarSeguraça(){
        return FuncionarioLista.Where(s => s is Seguranca).ToList();
    }

    
    public List<Funcionario> ListarVendedor(){
        return FuncionarioLista.Where(v => v is Vendedor).ToList();
    }

    public void Local_E_Nome_Joalheria(){
        
        Console.WriteLine($"Nome: {Nome} \nLocalização: {Localizacao}");
    }
    

}
