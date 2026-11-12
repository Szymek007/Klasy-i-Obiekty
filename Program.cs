Player player = new Player("Maciuś", 100, 25);
Enemy goblin = new Enemy("Goblin", 30, 8);
Player player2 = new Player("Bartek", 90, 35);
Enemy ork = new Enemy("Ork", 70, 15);

Console.WriteLine($"{player.Name} spotyka {goblin.Name}.");

goblin.TakeDamage(12);
Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

if (goblin.IsAlive())
{
    player.TakeDamage(goblin.Damage);
    Console.WriteLine($"{player.Name} ma {player.Health} HP.");
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
}

List<Enemy> enemies = new List<Enemy>
{
    new Enemy("Goblin", 30, 8),
    new Enemy("Nietoperz", 20, 5),
    new Enemy("Ork", 70, 15)
};

foreach (Enemy enemy in enemies)
{
    Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
}

Console.WriteLine("\n---Obrazenia gracza---");

if (player.TakeDamage(20))
{
    Console.WriteLine($"Obrazenia zadane {player.Name}: {player.Health} HP");
}
else
{
    Console.WriteLine("Nie udalo sie zadac obrazen");
}

Console.WriteLine("\n---Leczenia gracza---");
if (player.Heal(30))
{
    Console.WriteLine($"Zycie przywrocone {player.Name}: {player.Health} HP");
}
else
{
    Console.WriteLine("Nie udalo sie uleczyc");
}

Console.WriteLine("\n---Obrazenia goblina---");
if (goblin.TakeDamage(20))
{
    Console.WriteLine($"Zadano obrazenia {goblin.Name}: {goblin.Health} HP");
}
else
{
    Console.WriteLine("Nie udalo sie zadac obrazen");
}

Console.WriteLine("\n---Leczenie goblina---");
if (goblin.Heal(30))
{
    Console.WriteLine($"Zycie przywrocone {goblin.Name}: {goblin.Health} HP");
}
else
{
    Console.WriteLine("Nie udalo sie uleczyc");
}
