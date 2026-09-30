using System.Net.Http.Headers;

public class Arquero : Personaje
{
    public int Agilidad { get; set; }

    public Arquero(string nombre, int vida, int fuerza, int agilidad) 
        : base (nombre, vida, fuerza)

    {
        Agilidad = agilidad;
    }

    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"¡{Nombre} dispara una flecha certera a {objetivo.Nombre}!");
        objetivo.RecibirDano(Fuerza);
    }

    public override void RecibirDano(int dano)
    {
        int numero = Random.Shared.Next(0, 100);

        if (numero < Agilidad)
        {
            Console.WriteLine($"¡{Nombre} esquivo el ataque gracias a su agilidad!");
        }
        else
        {
            base.RecibirDano(dano);
        }
    }
}