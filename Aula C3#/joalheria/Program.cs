
namespace joalheria;

    internal class Programa
    {
        static void Main(string[] args)
        {
            List<string> horarioSeguranca1 = ["18:00 - 02:00","12:00 - 20:00"];
            
            var gerente1 = new Surpervisor(nome:"Gabriel",sobre_nome:"Schmidt",valor_hora:18.00,turno:"Noite");
            var seguranca1 = new Seguranca(nome:"Diogo",sobre_nome:"Castilha",valor_hora:10.00,horarios:horarioSeguranca1);
            var vendedor1 = new Vendedor(nome:"Claudia",sobre_nome:"Silva",valor_hora:8.00,faturamento_mes_anterior:78456.00);

            vendedor1.InfoFuncionario();
            gerente1.InfoFuncionario();
            seguranca1.InfoFuncionario();


            
        }
        
    }
