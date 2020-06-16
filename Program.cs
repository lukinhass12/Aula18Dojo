
using System;

namespace Aula18Dojo1
{
    class Program
    {
             
        static void Main(string[] args)
        {

            Jogador lucca = new Jogador();
            lucca.Nome= "Lucca";
            lucca.Altura = 1.78f;
            lucca.Peso = 68f;
            lucca.Nascimento = DateTime.Parse("20/11/2020");
            lucca.Posicao = "Goleiro";
            
            Console.WriteLine(lucca.CalcularIdade());
            Console.WriteLine(lucca.VerificarAposentadoria());
            
        }
    
        
    }
}