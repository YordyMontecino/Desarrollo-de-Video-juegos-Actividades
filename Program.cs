Console.WriteLine("=== INICIO DE LA BATALLA ===\n");
Guerrero arthur = new Guerrero("Arthur el Valiente", 100, 15, 10);
Mago merlin = new Mago("Merlín el Sabio", 70, 5, 20);
Arquero legolas = new Arquero("Legolas", 80, 12, 50);

int ronda = 1;
// Bucle del combate
//while (arthur.Vida > 0 && merlin.Vida > 0)
while (arthur.Vida > 0 && legolas.Vida > 0)
{
    Console.WriteLine($"--- RONDA {ronda} ---");
    // Turno 1
    //arthur.Atacar(merlin);
    arthur.Atacar(legolas);
    // Condición de quiebre para evitar ataques de un personaje derrotado
    //if (merlin.Vida <= 0) break;
    if (legolas.Vida <= 0) break;
    // Turno 2
    //merlin.Atacar(arthur);
    legolas.Atacar(arthur);
    ronda++;
    Console.WriteLine("Presiona ENTER para la siguiente ronda...\n");
    Console.ReadLine();
}
Console.WriteLine("=== FIN DE LA BATALLA ===\n");
// Resolución
if (arthur.Vida > 0)
    Console.WriteLine($"¡{arthur.Nombre} es el vencedor!");
else
    //Console.WriteLine($"¡{merlin.Nombre} es el vencedor!");
    Console.WriteLine($"¡{legolas.Nombre} es el vencecor!");