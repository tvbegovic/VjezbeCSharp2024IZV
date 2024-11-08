Console.Write("Unesite broj (1-100.000): ");
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int broj);
if(!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
if(broj < 1 ||  broj > 100000)
{
    Console.WriteLine("Broj je izvan raspona");
    return;
}
//zbroj proglašavamo long da izbjegnemo overflow kod velikih brojeva
long zbroj = 0;
for (int i = 1; i <= broj; i++)
{
    if(i % 3 == 0 || i % 5 == 0)
    {
        zbroj += i;
    }
}
Console.WriteLine($"Zbroj brojeva djeljivih sa 3 ili 5 od 1 to {broj} je {zbroj:N0}");
