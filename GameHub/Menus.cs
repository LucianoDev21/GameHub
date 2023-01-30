using System;
namespace GameHub
{
	public class Menus
	{
		public void MenuPrincipal()
		{
			Console.WriteLine("Bem-Vindo ao menu principal do GameHub. " +
							  "Escolha uma das opções abaixo: \n\n" +
							  "1 >> Cadastrar um jogador \n" +
                              "2 >> Ver historico e pontuações \n" +
                              "3 >> Jogar 'Jogo da Velha' \n" +
                              "4 >> Jogar 'Batalha Naval' \n" +
							  "0 >> Sair");
		}
	}
}

