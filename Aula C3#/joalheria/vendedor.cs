namespace joalheria;

internal sealed class Vendedor:Funcionario
{

    public Vendedor(string nome,string sobre_nome,double valor_hora,double faturamento_mes_anterior):base(nome,sobre_nome,valor_hora){
        FaturamentoMesAnterior = faturamento_mes_anterior;
    }

    public double FaturamentoMesAnterior {get;set;}

    public override void InfoFuncionario()
    {
        
        base.InfoFuncionario(); 
        Console.WriteLine($"Faturamento Do Mes Anterior: {FaturamentoMesAnterior}");
        Console.WriteLine("");
    }
        
}