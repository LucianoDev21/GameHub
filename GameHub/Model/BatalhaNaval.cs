using System;
namespace GameHub.Model
{
	public class BatalhaNaval
	{

		bool FimDeJogo;
        char[] col;
        char[] lin;

        public BatalhaNaval()
		{
			FimDeJogo = false;
            col = new[] {'A', 'B', 'C', 'D', 'E', 'F'};
            lin = new[] {'1', '2', '3', '4', '5', '6'};
		}

        public void IniciarJogo ( Jogador play1, Jogador play2 ) {
            //while (!FimDeJogo)
            {
                ImprimirTabuleiro();
                
            }
        }

        public void ImprimirTabuleiro () {
            Console.Clear();
            Console.WriteLine(Tabuleiro());
        }

        public string Tabuleiro () {
            return ($"   {col[0]}   {col[1]}   {col[2]}   {col[3]}   {col[4]}   {col[5]}\n" +
                    $"\n{lin[0]}\n\n{lin[1]}\n\n{lin[2]}\n\n{lin[3]}\n\n{lin[4]}\n\n{lin[5]}");
            
        }
    }
}

