
int damage;

int hp = 30;
int opphp = 50;

Console.WriteLine("what's your name? ");
string name = Console.ReadLine();

string oppname = "";

int namernd = Random.Shared.Next(3);

if (namernd == 0)
{
    oppname = "GODZILLA";
}

else if (namernd == 1)
{
    oppname = "illuminati";
}
else if (namernd == 2)
{
    oppname = "Dracula";
}



while (hp > 0 && opphp > 0)
 {
     Console.WriteLine("------ New Round ------");
     Console.WriteLine($"{name} hp: {hp}   {oppname} hp: {opphp}\n");

     damage = Random.Shared.Next(0, 15);
     hp -= damage;
     hp = Math.Max(0, hp);

     Console.WriteLine($"{oppname} does {damage} damage to {name}");

     damage = Random.Shared.Next(3, 11);
     opphp -= damage;
     opphp = Math.Max(0, opphp);
     Console.WriteLine($"{name} does {damage} damage to {oppname}");

     Console.WriteLine("Press any key to continue\n");
     Console.ReadKey();
 }

Console.WriteLine("\nMATCH OVERS");
Console.WriteLine($"{name} hp: {hp}  {oppname} hp: {opphp}");

if (hp == 0 && opphp == 0)
{
    Console.WriteLine("It's a draw");
}

else if (hp == 0)
{
    Console.WriteLine($"{oppname} won");
}

else if (opphp == 0)
{
    Console.WriteLine($"{name} won");
}

else
{
    Console.WriteLine("something is broken");
}

Console.ReadLine();