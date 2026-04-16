using System;

string[] oblibena_vec;
int pocet_polozek;
string vstup;

Console.WriteLine("----- Oblíbené věci -----");
Console.Write("Zadej počet položek v seznamu: ");
int.TryParse(Console.ReadLine(), out pocet_polozek);
oblibena_vec = new string[pocet_polozek];
Console.WriteLine();

for (int i = 0; i < oblibena_vec.Length; i++)
{
    Console.Write($"Zadej položku {i + 1}: ");
    oblibena_vec[i] = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine($"Váš seznam: {string.Join(", ", oblibena_vec)}");
Console.WriteLine();

Console.Write("Chceš upravit seznam? (ano/ne): ");
vstup = Console.ReadLine();

if (vstup == "ano")
{
    Console.Write("Zvol úpravu (swap / edit): ");
    vstup = Console.ReadLine();

    if (vstup == "swap")
    {
        Console.Write("Zadej první index: ");
        int.TryParse(Console.ReadLine(), out int index1);
        index1--;

        Console.Write("Zadej druhý index: ");
        int.TryParse(Console.ReadLine(), out int index2);
        index2--;

        string docasna = oblibena_vec[index1];
        oblibena_vec[index1] = oblibena_vec[index2];
        oblibena_vec[index2] = docasna;

        Console.WriteLine();
        Console.WriteLine("Upravený seznam:");
        Console.WriteLine(string.Join(", ", oblibena_vec));
    }
    else if (vstup == "edit")
    {
        Console.Write("Zadej hodnotu, kterou chcete změnit: ");
        string hledana = Console.ReadLine();

        int index_zmena = Array.IndexOf(oblibena_vec, hledana);

        if (index_zmena == -1)
        {
            Console.WriteLine("Hodnota nebyla nalezena.");
        }
        else
        {
            Console.Write("Zadej novou hodnotu: ");
            oblibena_vec[index_zmena] = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Upravený seznam:");
            Console.WriteLine(string.Join(", ", oblibena_vec));
        }
    }
    else
    {
        Console.WriteLine("špatně zadanej vstup");
    }
}
else if (vstup == "ne")
{
    Console.WriteLine($"Výsledný seznam: {string.Join(", ", oblibena_vec)}");
}
else
{
    Console.WriteLine("špatně zadanej vstup");
}