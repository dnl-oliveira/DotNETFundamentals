using System;
using System.Collections.Generic;
using System.Linq;

/*Desafio
Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado 
em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.

O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o 
aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.*/

namespace DIO.NETFundamentals.Desafios
{
    class RemoveDuplicados
    {
        public static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            // Implemente a solução aqui
            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                List<string> listDeCompras = new List<String>(Console.ReadLine().Split(' '));
                List<string> listaSemDuplicados = listDeCompras.Distinct().ToList();

                listaSemDuplicados.Sort();

                foreach (string item in listaSemDuplicados)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
