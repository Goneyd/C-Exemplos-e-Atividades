
namespace joalheria;

    internal class Programa
    {
        static void Main(string[] args)
        {
            List<string> horarioSeguranca1 = ["18:00 - 02:00","12:00 - 20:00"];
            
            var gerente1 = new Surpervisor(nome:"Gabriel",sobre_nome:"Schmidt",valor_hora:18.00,turno:"Noite");
            var seguranca1 = new Seguranca(nome:"Diogo",sobre_nome:"Castilha",valor_hora:10.00,horarios:horarioSeguranca1);
            var gerente2 = new Surpervisor(nome:"Fernando",sobre_nome:"Silva",valor_hora:90.00,turno:"Dia");
            var vendedor1 = new Vendedor(nome:"Claudia",sobre_nome:"Silva",valor_hora:8.00,faturamento_mes_anterior:78456.00);
            var vendedor2 = new Vendedor(nome:"Luci",sobre_nome:"Fernandes",valor_hora:12.00,faturamento_mes_anterior:89043.00);

            List<Funcionario> funcionariosLista = [gerente1,seguranca1,gerente2,vendedor2,vendedor1];

            foreach (Funcionario funcionarioItem in funcionariosLista )
            {
                funcionarioItem.InfoFuncionario();
            }
            


            
        }
        
    }
