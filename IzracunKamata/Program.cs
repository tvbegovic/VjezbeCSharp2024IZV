double IznosKamata(double iznos, double stopa)
{
    //provjera parametra stopa
    if (stopa < 0 || stopa > 20)
        throw new ArgumentOutOfRangeException("stopa je izvan raspona");
    double kamata = iznos * stopa / 100;
    return kamata;
}

bool nastavi = true;
do
{
    Console.Write("Glavnica: ");
    string unos = Console.ReadLine();
    if(string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        bool ok = double.TryParse(unos, out double glavnica);
        if(!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.Write("Stopa (0-20)%: ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        //ver2 - provjera stope je u funkciji
        /*if(stopa < 0 || stopa > 20)
        {
            Console.WriteLine("Stopa je izvan raspona");
            continue;
        }*/
        try
        {
            double kamata = IznosKamata(glavnica, stopa);
            Console.WriteLine($"Za glavnicu {glavnica:N2} i stopu {stopa} kamata je {kamata:N2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Pogreška: {ex.Message}");
        }
    }
}
while (nastavi);
