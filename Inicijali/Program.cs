Console.Write("Ime: ");
string ime  = Console.ReadLine();
if(ime.Length == 0)
{
    Console.WriteLine("Ime je obavezno");
    return;
}
Console.Write("Prezime: ");
string prezime = Console.ReadLine();
if(prezime.Length == 0)
{
    Console.WriteLine("Prezime je obavezno");
    return;
}
Console.WriteLine("Vaši inicijali su {0}. {1}.", ime[0], prezime[0]);
//2. varijanta dobivanja inicijala - upotrebom funkcije Substring
Console.WriteLine("Vaši inicijali su {0}. {1}.", ime.Substring(0,1), prezime.Substring(0,1));