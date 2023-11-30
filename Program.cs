
using System;
using jeumotglisse.objets;

Console.WriteLine("Hello, World!");
Class1 t = new Class1("lala");

Console.WriteLine(t.toString());

Console.Write("Hey jeune lady comment tu t'intitule ? ");
string nomdeveloppeur = Console.ReadLine();


if (nomdeveloppeur == "noe")
{
    Console.WriteLine("Wesh " + nomdeveloppeur + "ca farte ?");
}
else if (nomdeveloppeur == "yannis")
{
    Console.WriteLine("Wesh " + nomdeveloppeur + "ca roule ?");
}
else
{
    Console.WriteLine("Casse toi povcon");
}