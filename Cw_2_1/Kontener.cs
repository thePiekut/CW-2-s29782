namespace Cw_2;

public abstract class Kontener
{
    public double MasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double WagaWlasna { get; set; }
    public double Glembokosc { get; set; }
    public string NumerSeryjny { get; set; }
    public double MaxLadunek { get; set; }
    public static int id;
    public double CalkowitaWaga { get; set; }
    public static List<Kontener> allKontenery=new List<Kontener>();

    public Kontener(double wysokosc, double wagaWlasna, double glembokosc, double maxLadunek)
    {
        Wysokosc = wysokosc;
        WagaWlasna = wagaWlasna;
        Glembokosc = glembokosc;
        MaxLadunek = maxLadunek;
        NumerSeryjny ="KON-";
        id = ++id;
        CalkowitaWaga = wagaWlasna;
        allKontenery.Add(this);
    }

    public virtual void Wyladunek()
    {
        CalkowitaWaga -= MasaLadunku;
        MasaLadunku = 0;
    }

    public virtual void  Zaladunek(double masa)
    {
        if (MasaLadunku + masa > MaxLadunek)
        {
            throw new OverfillException("Masa ladunku wieksza niż  maxymalna pojenmosc kontenera");
        }
        MasaLadunku += masa;
        CalkowitaWaga += masa;
    }
    
    

    public override string ToString()
    {
        return  NumerSeryjny+"\nWysokosc: "+Wysokosc+" cm\nWaga Wlasna: "+WagaWlasna+
                " kg\nGłębokośc: " + Glembokosc+" cm\nMax Ladunek: " + MaxLadunek+
                " kg\nCałkowita Waga: "+CalkowitaWaga+"\nWaga Ładunku: "+MasaLadunku;
    }

    public static Kontener Znajdz(string numerSeryjny)
    {
        for (int i = 0; i < allKontenery.Count; i++)
        {
            if (allKontenery[i].NumerSeryjny == numerSeryjny)
            {
                return allKontenery[i];
                
            }
        }
        return null;
    }
}