namespace joalheria;

internal sealed class Vendedor:Funcionario
{

    public Vendedor(string nome,string sobre_nome,double valor_hora,string faturamento_mes_anterior):base(nome,sobre_nome,valor_hora){
        FaturamentoMesAnterior = faturamento_mes_anterior;
    }

    public string FaturamentoMesAnterior {get;set;}
        
}