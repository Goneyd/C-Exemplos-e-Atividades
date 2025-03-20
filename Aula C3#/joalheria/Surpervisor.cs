namespace joalheria;

internal sealed class Surpervisor:Funcionario
{
    public Surpervisor(string nome,string sobre_nome,double valor_hora,int depedente,string turno):base( nome, sobre_nome,valor_hora,depedente)
    {   
        Turno = turno;
    }

    public string Turno {get;private set;}

    public override void InfoFuncionario()
        {
            
            base.InfoFuncionario();
            Console.WriteLine($"Turno: {Turno}");
            Console.WriteLine("");

        }

}