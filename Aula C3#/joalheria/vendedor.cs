namespace joalheria;

internal sealed class Vendedor:Funcionario
{

    public Vendedor(string nome,string sobre_nome,double valor_hora,int depedente,double faturamento_mes_anterior):base(nome,sobre_nome,valor_hora,depedente){
        FaturamentoMesAnterior = faturamento_mes_anterior;
    }

    public double FaturamentoMesAnterior {get;set;}

    public override void InfoFuncionario()
    {
        
        base.InfoFuncionario(); 
        Console.WriteLine($"Faturamento Do Mes Anterior: {FaturamentoMesAnterior}");
        if (Depedente != 0)
        {
            var Salario = this.Salario();
            double SalarioReajustado = Salario + (Depedente * 500);

            Console.WriteLine($"Valor Do auxílio dependente: {Depedente * 500} \nValor Total: {SalarioReajustado}");

        }
      
    }
        
}