using System;
using GameHub.Model;

namespace GameHub.Model
{
	public class JogoDaVelha
	{

            char[] posicao;
            bool fimDeJogo;
            char playerDaVez;
            int quantidadePreenchida, emp = 0, total = 0;

            public JogoDaVelha() {
                fimDeJogo = false;
                posicao = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                playerDaVez = 'X';
                quantidadePreenchida = 0;
            }

            public void IniciarJogo (Jogador play1, Jogador play2) {
                while (!fimDeJogo)
                {
                    ImprimirTabuleiro();
                    EscolhaDoUsuario();
                    ImprimirTabuleiro();
                    VerificarFim(play1, play2);
                    MudarPlayer();
                }
            }

        public void MudarPlayer () {
                if (playerDaVez == 'X')
                {
                    playerDaVez = 'O';
                }
                else
                {
                    playerDaVez = 'X';
                }
            }

            public void EscolhaDoUsuario () {
                Console.WriteLine($"Agora é a vez de '{playerDaVez}'. Escolha um numero de 1 a 9, " +
                    $"que esteja disponivel no tabuleiro.");

                bool conversao = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

                while (!conversao || !ValidarEscolha(posicaoEscolhida))
                {
                    Console.WriteLine("\nPosicao Indisponivel. Digite um numero de 1 a 9, que esteja disponivel " +
                        "no tabuleiro");
                    conversao = int.TryParse(Console.ReadLine(), out posicaoEscolhida);
                }
                Escolha(posicaoEscolhida);
            }

            public void Escolha ( int posicaoEscolhida ) {
                int i = posicaoEscolhida - 1;

                posicao[i] = playerDaVez;
                quantidadePreenchida++;
            }

            public bool ValidarEscolha ( int posicaoEscolhida ) {
                int i = posicaoEscolhida - 1;

                return posicao?[i] != 'O' && posicao?[i] != 'X';
            }

            public void ImprimirTabuleiro () {
                Console.Clear();
                Console.WriteLine(Tabuleiro());
            }

            public string Tabuleiro(){
                return ($"__{posicao?[0]}__|__{posicao?[1]}__|__{posicao?[2]}__\n" +
                        $"__{posicao?[3]}__|__{posicao?[4]}__|__{posicao?[5]}__\n" +
                        $"  {posicao?[6]}  |  {posicao?[7]}  |  {posicao?[8]}  \n\n");
            }

            public void VerificarFim (Jogador play1, Jogador play2) {
                if (quantidadePreenchida < 5)
                    return;
                if (FimHorizontal() || FimVertical() || FimDiagonal())
                {
                    fimDeJogo = true;
                    if (playerDaVez == 'X')
                    {
                        Console.WriteLine($"Fim de Jogo! Vitoria de '{play1.Nome}'. " +
                        $"\n");
                        play1.Vitorias++;
                        play2.Derrotas++;
                        play1.Pontos++;
                    }
                    else
                    {
                        Console.WriteLine($"Fim de Jogo! Vitoria de '{play2.Nome}'. " +
                        $"\n");
                        play2.Vitorias++;
                        play1.Derrotas++;
                        play2.Pontos++;
                    }
                    return;
                }
                if (quantidadePreenchida == 9)
                {
                    fimDeJogo = true;
                    Console.WriteLine("Jogo Terminou em Empate!\n");
                    play1.Empates++;
                    play2.Empates++;
                }
            }

            public bool FimHorizontal () {
                bool linha1 = posicao?[0] == posicao?[1] && posicao?[0] == posicao?[2];
                bool linha2 = posicao?[3] == posicao?[4] && posicao?[3] == posicao?[5];
                bool linha3 = posicao?[6] == posicao?[7] && posicao?[6] == posicao?[8];

                return linha1 || linha2 || linha3;
            }

            public bool FimVertical () {
                bool linha1 = posicao?[0] == posicao?[3] && posicao?[0] == posicao?[6];
                bool linha2 = posicao?[1] == posicao?[4] && posicao?[1] == posicao?[7];
                bool linha3 = posicao?[2] == posicao?[5] && posicao?[2] == posicao?[8];

                return linha1 || linha2 || linha3;
            }

            public bool FimDiagonal () {
                bool linha1 = posicao?[2] == posicao?[4] && posicao?[2] == posicao?[6];
                bool linha2 = posicao?[0] == posicao?[4] && posicao?[0] == posicao?[8];

                return linha1 || linha2;
            }

	}
}

