Console.WriteLine("podaj pierwsza liczbe:");
double liczba1 = double.Parse(Console.ReadLine());
Console.WriteLine("podaj druga liczbe:");
double liczba2 = double.Parse(Console.ReadLine());
Console.WriteLine("podaj jaka operacje chcesz wykonac:\n1.dodawanie\n2.odejmowanie\n3.mnozenie\n4.dzielenie");
int wybor = int.Parse(Console.ReadLine());

if (wybor == 1)
{
    Console.WriteLine($"Twoj wynik to: {liczba1 + liczba2}");
}
else if (wybor == 2)
{
    Console.WriteLine($"Twoj wynik to: {liczba1 - liczba2}");
}
else if (wybor == 3)
{
    Console.WriteLine($"Twoj wynik to: {liczba1 * liczba2}");
}
else if (wybor == 4)
{
    Console.WriteLine($"Twoj wynik to: {liczba1 / liczba2}");
}
else
{
    Console.WriteLine("musisz wybrac od 1 do 4");
}