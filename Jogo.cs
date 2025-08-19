public class Jogo
{

    Jogador jogador;

    public void Comecar()
    {

        Console.WriteLine("Bem-vindo ao RPG!");
        Console.Write("Digite o nome do seu personagem: ");
        string nomeJogador = Console.ReadLine();
        jogador = new Jogador(nomeJogador, 100, 20);

        LoopPrincipal();
    }

    public void LoopPrincipal()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma ação:");
            Console.WriteLine("1. Explorar a floresta");
            Console.WriteLine("2. Ver status");
            Console.WriteLine("3. Sair do jogo");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {

                ExplorarFloresta();
            }

            else if (escolha == "2")
            {

                jogador.MostrarStatus();
            }

            else if (escolha == "3")
            {

                Console.WriteLine("Saindo do jogo...");
                break;
            }

            else
            {

                Console.WriteLine("Opção inválida, tente novamente.");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    public void ExplorarFloresta()
    {
        Console.WriteLine("Você está explorando a floresta...");
        Random random = new Random();
        int chance = random.Next(1, 4); // 1 a 3

        if (chance == 1)
        {

            Batalha batalha = new Batalha();
            Inimigo inimigo = new Inimigo("Goblin", 50, 10);
            inimigo.MostrarStatus();
            batalha.Luta(jogador, inimigo);
        }
        else
        {

            Console.WriteLine("Você não encontrou nenhum inimigo.");
        }
    }
}