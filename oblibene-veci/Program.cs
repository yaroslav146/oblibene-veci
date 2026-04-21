using System;
using System.Numerics;

string vstup;
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

// for (int i = 0; i < oblibena_vec.Length; i++)
// {
//     Console.Write($"Položka {i + 1}: {oblibena_vec[i]}");
//     Console.WriteLine();
// 
// }

Console.Write("Chceš upravit seznam? (ano/ne):\t");
vstup = Console.ReadLine();
if (vstup == "ano")
{
    Console.Write("Zvol úpravu (prohození / změna): ");
    vstup = Console.ReadLine();
    if (vstup == "prohození")
    {
        Console.Clear();

        for (int i = 0; i < oblibena_vec.Length; i++)
        {
            Console.Write($"Položka {i + 1}: {oblibena_vec[i]} - index: {i + 1}");
            Console.WriteLine();
        
        }

        Console.Write("Zadej první index >> ");
        int.TryParse(Console.ReadLine(), out int index1);
        index1 = index1 - 1;
        string docasna = oblibena_vec[index1];
        Console.Write("Zadej druhý index >> ");
        int.TryParse(Console.ReadLine(), out int index2);
        index2 = index2 - 1;
        oblibena_vec[index1] = oblibena_vec[index2];
        oblibena_vec[index2] = docasna;
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("< < < |Upravený seznam| > > >");
        Console.WriteLine();
        for (int i = 0; i < oblibena_vec.Length; i++)
        {
            Console.Write($"Položka {i + 1}: {oblibena_vec[i]}");
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (vstup == "změna")
    {
        Console.Clear();
        Console.WriteLine($"dostupne: {string.Join(" | ", oblibena_vec)}");
        Console.Write("Zadej hodnotu, kterou chcete změnit: ");
        int index_zmeny = Array.IndexOf(oblibena_vec, Console.ReadLine());
        Console.Write("Zadej novou hodnotu: ");
        oblibena_vec[index_zmeny] = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("< < < |Upravený seznam| > > >");
        Console.WriteLine();
        for (int i = 0; i < oblibena_vec.Length; i++)
        {
            Console.Write($"Položka {i + 1}: {oblibena_vec[i]}");
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.WriteLine("špatně zadanej vstup");
    }
}
else if (vstup == "ne")
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("< < < |Vysledni seznam| > > >");
    Console.WriteLine();
    Console.WriteLine($"{string.Join(", ", oblibena_vec)}");
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.WriteLine("špatně zadanej vstup");
}



