try
{
	Console.Write("Ocjena C: ");
	string unos = Console.ReadLine();
	int ocjenaC = int.Parse(unos);
	Console.Write("Ocjena C++: ");
	unos = Console.ReadLine();
	int ocjenaCPlus = int.Parse(unos);
	Console.Write("Ocjena C#: ");
	unos = Console.ReadLine();
	int ocjenaCSharp = int.Parse(unos);
	double prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;
	Console.WriteLine($"Prosjek ocjena je {prosjek:N2}");
}
catch (Exception ex)
{
	Console.WriteLine($"Dogodila se pogreška. Tekst: {ex.Message}");
}
