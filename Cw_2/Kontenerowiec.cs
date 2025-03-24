namespace Cw_2;

public class Kontenerowiec
{
    public List<Kontener> Lista { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxKonCap { get; set; }
    public double MaxWaga { get; set; }
    public double CurrentWaga { get; set; }


    public Kontenerowiec(double maxSpeed, int maxKonCap, double maxWaga)
    {
        MaxSpeed = maxSpeed;
        MaxKonCap = maxKonCap;
        MaxWaga = maxWaga;
        CurrentWaga = 0;
        Lista = [];
    }

    public void Zaladuj(Kontener kon)
    {
        if (Lista.Count + 1 > MaxKonCap)
        {
            throw new OverfillException("Więcej kontenerów niż kontenerowiec może pomiesćic");
        }

        if (CurrentWaga + kon.CalkowitaWaga / 1000 > MaxWaga)
        {
            throw new OverfillException("Za duża waga kontenerów niż kontenerowiec może pomiesćic");
        }

        Lista.Add(kon);
        CurrentWaga += (kon.CalkowitaWaga / 1000);
    }

    public void Zaladuj(List<Kontener> kontenery)
    {
        if (Lista.Count + kontenery.Count > MaxKonCap)
        {
            throw new OverfillException("Więcej kontenerów niż kontenerowiec może pomiesćic");
        }

        double tmpWaga = 0;

        foreach (Kontener k in kontenery)
        {
            tmpWaga += k.CalkowitaWaga / 1000;
        }

        if (CurrentWaga + tmpWaga > MaxWaga)
        {
            throw new OverfillException("Za duża waga kontenerów niż kontenerowiec może pomiesćic");
        }

        Lista.AddRange(kontenery);
        CurrentWaga += tmpWaga;
    }

    public void Usun(string id)
    {
        for (int i = 0; i < Lista.Count; i++)
        {
            if (Lista[i].NumerSeryjny == id)
            {
                Lista.RemoveAt(i);
                break;
            }
        }
    }

    public void Zastap(string idOld, string idNew)
    {
        for (int i = 0; i < Lista.Count; i++)
        {
            if (Lista[i].NumerSeryjny == idOld)
            {
                Lista[i] = Kontener.Znajdz(idNew);
                break;
            }
        }
    }

    public void Przenieś(string id, Kontenerowiec kontenerowiec)
    {
        for (int i = 0; i < Lista.Count; i++)
        {
            if (Lista[i].NumerSeryjny == id)
            {
                kontenerowiec.Zaladuj(Lista[i]);
                Lista.RemoveAt(i);
                break;
            }
        } 
    }

    public override string ToString()
    {
        return "Max Speed: "+MaxSpeed + "kn\nMax pojemność: " + MaxKonCap + "\nMax Waga: "
               + MaxWaga+"t\nKontenery:\n"+KonteneryId();
    }

    private string KonteneryId()
    {
        string idKon = "";
        foreach (var k in Lista)
        {
            idKon+= k.NumerSeryjny+"\n";
        }
        return idKon;
    }
}