Console.WriteLine("podaj pierwsza liczbe:");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("podaj druga liczbe:");
double number2 = double.Parse(Console.ReadLine());
Console.WriteLine("podaj jaka operacje chcesz wykonac:\n1.dodawanie\n2.odejmowanie\n3.mnozenie\n4.dzielenie");
int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine($"Twoj wynik to: {number1 + number2}");
}
else if (choice == 2)
{
    Console.WriteLine($"Twoj wynik to: {number1 - number2}");
}
else if (choice == 3)
{
    Console.WriteLine($"Twoj wynik to: {number1 * number2}");
}
else if (choice == 4 && (number1 == 0 || number2 == 0))
{
    Console.WriteLine("Nie dziel przez zero");
}
else if (choice == 4)
{
    Console.WriteLine($"Twoj wynik to: {number1 / number2}");
}
else
{
    Console.WriteLine("musisz wybrac od 1 do 4");
}
