using System.Numerics;

string[] oblibena_vec;
int pocet_polozek;


Console.WriteLine("----- Oblíbené věci -----");
Console.Write("Zadej počet položek v seznamu: ");
int.TryParse(Console.ReadLine(), out pocet_polozek);
oblibena_vec = new string[pocet_polozek];
Console.WriteLine();

for (int i = 0; i < oblibena_vec.Length; i++)
{
    Console.Write($"Zadej položku {i+1}: ");
    oblibena_vec[i] = Console.ReadLine();

}
Console.WriteLine($"Váš seznam: {string.Join(", ", oblibena_vec)}");
Console.WriteLine();

for (int i = 0; i < oblibena_vec.Length; i++)
{
    Console.Write($"Položka {i + 1}: {oblibena_vec[i]}");
    Console.WriteLine();

}

Console.Write("Chceš upravit seznam? (ano/ne):\t");
if(Console.ReadLine() == "ano")
{
    Console.Write("Zvol úpravu (prohození / změna): ");
    if(Console.ReadLine() == "prohození")
    {
        Console.Write("Zadej první index: ");
        int.TryParse(Console.ReadLine(), out int index1);
        index1 = index1 - 1;
        string docasna = oblibena_vec[index1];
        Console.Write("Zadej druhý index: ");
        int.TryParse(Console.ReadLine(), out int index2);
        index2 = index2 - 1;
        oblibena_vec[index1] = oblibena_vec[index2];
        oblibena_vec[index2] = docasna;
    }
    else if (Console.ReadLine() == "změna")
    {

    }
    else
    {
        Console.WriteLine("špatně zadanej vstup");
    }
}
else if (Console.ReadLine() == "ne")
{
    Console.WriteLine($"Vysledni seznam: {string.Join(", ", oblibena_vec)}");
}
else
{
    Console.WriteLine("špatně zadanej vstup");
}



