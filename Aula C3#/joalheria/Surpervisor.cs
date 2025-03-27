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
            if (Depedente != 0)
            {
                double Salario = this.Salario();
                double SalarioReajustado = Salario + (Depedente * 500);

                Console.WriteLine($"Valor Do auxílio dependente: {Depedente * 500} \nValor Total: {SalarioReajustado}");

            }
     

        }

}