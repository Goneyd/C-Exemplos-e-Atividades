
namespace joalheria;

    internal class Programa
    {
        static void Main(string[] args)
        {
            List<string> horarioSeguranca1 = ["18:00 - 02:00","12:00 - 20:00"];

            void NovoFuncionario()
            {
                   
            }
            
            var gerente1 = new Surpervisor(nome:"Gabriel",sobre_nome:"Schmidt",valor_hora:18.00,depedente: 0,turno:"Noite");
            var seguranca1 = new Seguranca(nome:"Diogo",sobre_nome:"Castilha",valor_hora:10.00,depedente: 2,horarios:horarioSeguranca1);
            var gerente2 = new Surpervisor(nome:"Fernando",sobre_nome:"Silva",valor_hora:90.00,depedente: 2,turno:"Dia");
            var vendedor1 = new Vendedor(nome:"Claudia",sobre_nome:"Silva",valor_hora:8.00,depedente: 0,faturamento_mes_anterior:78456.00);
            var vendedor2 = new Vendedor(nome:"Luci",sobre_nome:"Fernandes",valor_hora:12.00,depedente: 1,faturamento_mes_anterior:89043.00);

            var Joalheria = new Joalheria(nome:"Joalheria Dilma",localizacao:"Cidade: Mar morto / Bairo: Alfredo Dias / Rua: Marcone / N 98");     
            Joalheria.AdicionarFuncionario(gerente1);
            Joalheria.AdicionarFuncionario(gerente2);
            Joalheria.AdicionarFuncionario(seguranca1);
            Joalheria.AdicionarFuncionario(vendedor1);
            Joalheria.AdicionarFuncionario(vendedor2);

            foreach (Funcionario funcionarioItem in Joalheria.ListaFuncionarios())
            {
                funcionarioItem.InfoFuncionario();
            }

            Joalheria.Local_E_Nome_Joalheria();
            


            
        }
        
    }
