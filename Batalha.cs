public class Batalha
{
    
    public void Luta(Jogador jogador, Inimigo inimigo)
    {

        Console.WriteLine("Você encontrou um inimigo!");

        while (jogador.Vida > 0 && inimigo.Vida > 0)
        {
            Console.WriteLine("Escolha uma ação:");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Fugir");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {

                inimigo.Vida -= jogador.Ataque;
                Console.WriteLine($"Você atacou {inimigo.Nome} e causou {jogador.Ataque} de dano.");
            }

            else if (escolha == "2")
            {

                Console.WriteLine("Você fugiu da batalha.");
                return;
            }

            else
            {

                Console.WriteLine("Opção inválida, tente novamente.");
                continue;
            }

            if (inimigo.Vida > 0)
            {

                if (inimigo.Vida <= 10)
                {

                    Random random = new Random();
                    int chance = random.Next(1, 5);

                    if (chance == 1)
                    {

                        Console.WriteLine($"{inimigo.Nome} fugiu!");
                        continue;
                    }
                }

                else
                {
                    
                    jogador.Vida -= inimigo.Ataque;
                    Console.WriteLine($"{inimigo.Nome} atacou você e causou {inimigo.Ataque} de dano.");
                }
            }
        }

        if (jogador.Vida <= 0)
        {

            Console.WriteLine("Você foi derrotado! Fim de jogo.");
        }

        else
        {

            Console.WriteLine($"Você derrotou {inimigo.Nome}!");
        }
    }
}