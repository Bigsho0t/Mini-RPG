public class Inimigo
{
    
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }

    public Inimigo(string nome, int vida, int ataque)
    {
        this.Nome = nome;
        this.Vida = vida;
        this.Ataque = ataque;
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"Inimigo: {Nome}, Vida: {Vida}, Ataque: {Ataque}");
    }
}