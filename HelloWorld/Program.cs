using System;



namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = CapturarIdade();
            VerificarIdade(idade);

            Console.WriteLine("--Fim--");
            Console.ReadLine();
        }

        //Capturar a idade via terminal
        static int CapturarIdade()
        {
            //Passar para inteiro
            Console.WriteLine("Digite sua idade:");

            //Capturar idade
            int idade = int.Parse(Console.ReadLine());

            return idade;
        }

        //Verificar qual faixa o usuário esta
        static void VerificarIdade(int idade)
        {

            if (idade >= 0 && idade <= 10)
            {
                Console.WriteLine("Criança");
            }
            else if (idade >= 11 && idade <= 17)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade >= 18 && idade <= 29)
            {
                Console.WriteLine("Jovem");
            }
            else if (idade < 0)
            {
                Console.WriteLine("Idade tem que ser maior que 0");
                idade = capturarIdade();
                verificarIdade(idade);
            }
            else
            {
                Console.WriteLine("Adulto");
            }
        }
    }
}
