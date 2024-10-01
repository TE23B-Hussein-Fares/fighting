int hpHero = Random.Shared.Next(50, 100);
int hpvillen = Random.Shared.Next(50, 100);

while (hpHero > 0 && hpvillen > 0)
{
    Console.WriteLine($"Hero: {hpHero}");

    int villainDamage = Random.Shared.Next(5, 21);
    Console.WriteLine($"villen did {villainDamage} damage to hero");

    hpHero -= villainDamage;
    if (hpHero < 0)
    {
        hpHero = 0;
    }

    Console.WriteLine($"Hero: {hpHero}");

    Console.ReadLine();

    Console.WriteLine($"villen:{hpvillen}");

    int heroDamage = Random.Shared.Next(5, 20);
    Console.WriteLine($"hero did {heroDamage} damage to villan");

    hpvillen -= villainDamage;

     hpvillen -= heroDamage;
    if (hpvillen < 0)
    {
        hpvillen = 0;
    }
      
    Console.WriteLine($"villan: {hpvillen}");
}

Console.ReadLine();



Console.WriteLine("bra fan");
string name = Console.ReadLine();

