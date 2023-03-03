internal class Program
{
    private static void Main(string[] args)
    {
        //código feito por mim:
        /*

        int posicao;
        
        Console.WriteLine("Digite a posicão: ");
        posicao = int.Parse(Console.ReadLine());

        int[] fibonacci = new int[posicao];
        fibonacci[0] = 1;       


        if (posicao == 1) 
        {
            Console.WriteLine(fibonacci[0]);
        }

        else if(posicao == 2)
        {
            fibonacci[1] = 1;
            Console.WriteLine(fibonacci[0] + " " + fibonacci[1]);
        }

        else
        {
            fibonacci[1] = 1;

            for (int i = 2; i < posicao; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

            }


            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.Write(fibonacci[i] + " ");
            }
        }

        
            
        Console.ReadKey();

        */


        //código feito em aula:

        double ant = 1, prox = 0;
        int posicao;

        Console.Write("Informe a posição desejada: ");
        posicao = int.Parse(Console.ReadLine());

        for(int i = 0; i < posicao; i++) 
        {
            
            Console.Write(ant + prox + " ");
            prox = ant + prox;
            ant = prox - ant;
            
        }

        Console.ReadKey();
    }
}