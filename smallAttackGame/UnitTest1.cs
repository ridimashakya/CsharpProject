int hero = 10;
int monster = 10;

Random attack = new Random();

do
{
    int health = attack.Next(1, 11);
    monster -= health;
    Console.WriteLine($"Monster was damaged and lost {health} health and now has {monster} health.");

    if (monster <= 0) continue;

    health = attack.Next(1, 11);
    hero -= health;
    Console.WriteLine($"Hero was damaged and lost {health} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
