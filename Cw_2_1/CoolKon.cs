namespace Cw_2;

public class CoolKon:Kontener
{
    public string Product { get; set; }
    public double Temp { get; set; }
    public CoolKon(double wysokosc, double wagaWlasna, double glembokosc, double maxLadunek,string product,double temp)
        : base(wysokosc, wagaWlasna, glembokosc, maxLadunek)
    {
        NumerSeryjny = "KON-C-" + id;
        Product = product;
        Temp = temp;

    }

    public override string ToString()
    {
        return base.ToString()+"\nProdukt: "+Product+"\nTemperatura: "+Temp+" \u00b0C";
        
    }
}