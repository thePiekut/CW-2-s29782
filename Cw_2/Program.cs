namespace Cw_2;

class Program
{
    static void Main(string[] args)
    {
        

        var lqKon01 = new LiquidKon(1, 100, 1, 1000,false);
        lqKon01.Zaladunek(800);
        var kontenerowiec01 = new Kontenerowiec(25, 100, 20);
        kontenerowiec01.Zaladuj(lqKon01);
        var lqKon02 = new LiquidKon(1, 100, 1, 1000,false);
        lqKon02.Zaladunek(900);
        var coolKon03 = new CoolKon(1, 100, 1, 1000,"Pomidory",10);
        coolKon03.Zaladunek(1000);
        var gazKon04 = new GazKon(1, 100, 1, 1000);
        gazKon04.Zaladunek(1000);
        List<Kontener> lstKon01 = new List<Kontener>();
        lstKon01.Add(lqKon02);
        lstKon01.Add(coolKon03);
        lstKon01.Add(gazKon04);
        kontenerowiec01.Zaladuj(lstKon01);
        //kontenerowiec01.Lista.ForEach(Console.WriteLine);
        kontenerowiec01.Usun("KON-L-1");
        //kontenerowiec01.Lista.ForEach(Console.WriteLine);
        //Console.WriteLine(lqKon01);
        lqKon01.Wyladunek();
        //Console.WriteLine(lqKon01);
        kontenerowiec01.Zastap("KON-C-3","KON-L-1");
        //kontenerowiec01.Lista.ForEach(Console.WriteLine);
        var kontenerowiec02 = new Kontenerowiec(15, 10, 2);
        kontenerowiec01.Przenieś("KON-L-1", kontenerowiec02);
        //kontenerowiec02.Lista.ForEach(Console.WriteLine);
        Console.WriteLine(kontenerowiec01);
        //kontenerowiec01.Lista.ForEach(Console.WriteLine);
        

        



    }
}