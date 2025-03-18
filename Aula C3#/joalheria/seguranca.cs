namespace joalheria
{
    internal sealed class Seguranca:Funcionario
    {

        public Seguranca(string nome,string sobre_nome,double valor_hora, List<string> horarios):base( nome, sobre_nome,valor_hora){
            
            Horarios = horarios;

        }

        public List<string> Horarios {get;private set;}

        public override void InfoFuncionario()
        {
            base.InfoFuncionario();
            Console.WriteLine($"Horarios: {string.Join(", ",Horarios)}");
            Console.WriteLine("");
        }

    }
    
}