Console.Write("Ocjena C: ");
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int ocjenaC);
if(!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
Console.Write("Ocjena C++: ");
unos = Console.ReadLine();
ok = int.TryParse(unos,out int ocjenaCPlus);
if (!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
Console.Write("Ocjena C#: ");
unos = Console.ReadLine();
ok = int.TryParse(unos, out int ocjenaCSharp);
if (!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
double prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;
Console.WriteLine($"Prosjek ocjena je {prosjek:N2}");