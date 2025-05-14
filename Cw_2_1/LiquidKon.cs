namespace Cw_2;

public class LiquidKon : Kontener, IHazardNotifier
{
    public bool Hazard { get; set; }
    public LiquidKon(double wysokosc, double wagaWlasna, double glembokosc, double maxLadunek,bool hazard) 
        : base(wysokosc, wagaWlasna, glembokosc, maxLadunek)
    {
        NumerSeryjny = "KON-L-" + id;
        Hazard = hazard;
    }

    public void Notify(string msg)
    {
        Console.WriteLine($"{NumerSeryjny} {msg}");
    }

    public override void Zaladunek (double masa)
    {
        if (Hazard && MasaLadunku+masa > MaxLadunek * 0.5)
        {
            Notify("Niebezpieczny ładunek może zając jedynie 50% max wagi");
            return;
        }

        if (MasaLadunku+masa > MaxLadunek * 0.9)
        {
            Notify("Ładunek może zając jedynie 90% max wagi");
            return;
        }
        
        
        base.Zaladunek(masa);
    }

    public override string ToString()
    {
        return base.ToString()+"\nCzy niebezpieczny: "+Hazard;
    }
}