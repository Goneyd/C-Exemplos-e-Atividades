namespace joalheria
{
    internal sealed class Seguranca:Funcionario
    {

        public Seguranca(string nome,string sobre_nome,double valor_hora,int depedente ,List<string> horarios):base( nome, sobre_nome,valor_hora, depedente){
            
            Horarios = horarios;

        }

        public List<string> Horarios {get;private set;}

        public override void InfoFuncionario()
        {
            base.InfoFuncionario();
            Console.WriteLine($"Horarios: {string.Join(", ",Horarios)}");
            
            if (Depedente != 0)
            {
                var Salario = this.Salario();
                double SalarioReajustado = Salario + (Depedente * 500);

                Console.WriteLine($"Valor Do auxílio dependente: {Depedente * 500} \nValor Total: {SalarioReajustado}");
            }
            
            
        }

    }
    
}