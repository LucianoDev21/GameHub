using System;
using GameHub.Model;

namespace GameHub
{
    public class Program
    {

        static void Main (string[] args)
        {
            Jogador play1 = new Jogador();
            Jogador play2 = new Jogador();
            var menu = new Menus();
            
            int opMenu;

            do
            {
                menu.MenuPrincipal();
                opMenu = int.Parse(Console.ReadLine());

                switch(opMenu){
                    case 1:
                        new RegistrarPlay().Registrar(play1, play2);
                        break;
                    case 2:
                        new RegistrarPlay().Exibir(play1, play2);
                        break;
                    case 3:
                        new JogoDaVelha().IniciarJogo(play1, play2);
                        break;
                    case 4:
                        Console.WriteLine("\nDesculpe! Jogo em desenvolvimento \n\n");
                        //new BatalhaNaval().IniciarJogo(play1, play2);
                        break;
                }

            }while(opMenu != 0);
            Console.WriteLine("Encerrando o GameHub");
        }


    }
}

