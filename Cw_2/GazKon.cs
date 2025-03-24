namespace Cw_2;

public class GazKon:Kontener,IHazardNotifier
{
    public GazKon(double wysokosc, double wagaWlasna, double glembokosc, double maxLadunek) 
        : base(wysokosc, wagaWlasna, glembokosc, maxLadunek)
    {
        NumerSeryjny = "KON-G-" + id;
    }

    public override void Wyladunek()
    {
        MasaLadunku = MasaLadunku*0.05;
        
    }

    public void Notify(string msg)
    {
        Console.WriteLine($"{NumerSeryjny} {msg}");
    }
}