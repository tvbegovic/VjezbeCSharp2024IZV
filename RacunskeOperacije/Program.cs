Console.Write("Broj 1: ");
string unos = Console.ReadLine();
int broj1 = int.Parse(unos);
Console.Write("Broj 2: ");
unos = Console.ReadLine();
int broj2 = int.Parse(unos);
Console.WriteLine($"Zbroj brojeva je {broj1 + broj2}");
Console.WriteLine($"Razlika brojeva je {broj1 - broj2}");
Console.WriteLine($"Umnožak brojeva je {broj1 * broj2}");
if (broj2 == 0)
    Console.WriteLine("Ne mogu dijeliti s 0");
else
    Console.WriteLine($"Kvocijent brojeva je {broj1 / broj2}");