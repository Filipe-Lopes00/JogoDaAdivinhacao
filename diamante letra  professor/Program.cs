namespace diamante_letra__professor
{   //Math.Abs tira numeros negativos
    //(numero chutado – numero aleatório) / 2
    internal class Program
    {
        static void Main(string[] args)

        {
            Random random = new Random();
            int numAleatorio = random.Next(1, 21);
            int numChutado;
            int chances = 0;
            int pontuacao = 1000;
            int dificuldade = 0;
            int tentativas = 1;
            Console.WriteLine(" ***************************************");
            Console.WriteLine(" * Bem-vindo(a) ao jogo da Adivinhação *");
            Console.WriteLine(" ***************************************");
            Console.WriteLine("  Escolha o Nivel de Dificuldade: \n  (1) Fácil (2) Medio (3) Dificil \n  Escolha: ");
            dificuldade = Convert.ToInt32(Console.ReadLine());
            
            

            switch (dificuldade)
            {
                case 1: chances = 15; break;

                case 2: chances = 10; break;

                case 3: chances = 5; break;
            }

            for (int i = 0; i < chances; i++)
            {
                Console.WriteLine();
                Console.WriteLine(" tentativa "+tentativas+ " de " +chances);
                Console.WriteLine();
                tentativas++;
                Console.Write(" qual o seu chute? ");               
                numChutado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                if (numChutado == numAleatorio)
                {
                    Console.WriteLine("**************************");
                    Console.WriteLine("* Parabens,voce acertou! *");
                    Console.WriteLine("**************************");
                    break;
                }
                else if (numChutado > numAleatorio)
                {
                    Console.WriteLine("--------------------------------------------\n");
                    Console.WriteLine(" Seu Chute foi maior que o numero secreto\n");
                    Console.WriteLine("**********************");
                    Console.WriteLine("*voce tem "+pontuacao+" pontos*");
                    Console.WriteLine("**********************");
                    pontuacao -= Math.Abs((numChutado - numAleatorio) / 2);
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------\n");

                }
                else if (numChutado < numAleatorio)
                {                   
                    Console.WriteLine("--------------------------------------------\n");
                    Console.WriteLine(" Seu Chute foi menor que o numero secreto\n");
                    Console.WriteLine("**********************");
                    Console.WriteLine("*voce tem "+pontuacao+" pontos*");
                    Console.WriteLine("**********************");
                    pontuacao -= Math.Abs((numChutado - numAleatorio) / 2); 
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------\n");

                }


















            }
        }
    }
}