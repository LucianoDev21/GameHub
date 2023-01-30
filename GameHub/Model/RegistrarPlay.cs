using System;
using GameHub.Model;

namespace GameHub.Model
{
	public class RegistrarPlay
	{
		public void Registrar(Jogador play1, Jogador play2)
		{
            Console.WriteLine("\nInforme o nome do primeiro jogador: ");
            play1.Nome = Console.ReadLine();
            Console.WriteLine("\nInforme o nome do segundo jogador: ");
            play2.Nome = Console.ReadLine();
            Console.WriteLine("\n");
        }

        public void Exibir( Jogador play1, Jogador play2 )
        {

            Console.WriteLine($"\nHistorico até o momento: \n\n" +
           $"Jogador 1: {play1.Nome}  || Jogador 2: {play2.Nome} \n" +
           $"Vitorias:  {play1.Vitorias}      || Vitorias:  {play2.Vitorias} \n" +
           $"Derrotas:  {play1.Derrotas}      || Derrotas:  {play2.Derrotas} \n" +
           $"Empates:   {play1.Empates}      || Empates:   {play2.Empates} \n" +
           $"Pontos:    {play1.Pontos}      || Pontos:    {play2.Pontos} \n\n");

        }
    }

}