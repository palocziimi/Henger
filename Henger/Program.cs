namespace Henger
{
    internal class Program
    {
        static double AtlagTerfogat(List<cHenger> cHengerek)
        {
            double szumTerfogat = 0;
            foreach (var cHenger in cHengerek)
            {
                szumTerfogat += cHenger.Terfogat();
            }
            return szumTerfogat / cHenger.SzuletesSzamlalo;
        }

        static void Lista(List<cHenger> cHengerek)
        {
            foreach (var cHenger in cHengerek)
            {
                Console.WriteLine(cHenger);
            }
        }
        static void Main(string[] args)
        {
            List<cHenger> testek = new List<cHenger>();
            testek.Add(new cHenger(1, 4));
            testek.Add(new TomorHenger(0.5, 4, 2));
            testek.Add(new TomorHenger(0.5, 4));
            testek.Add(new Cso(5, 5, 0.5));
            testek.Add(new Cso(5, 5));
            Lista(testek);
            Console.WriteLine("Testek száma:" + testek.Count);
            Console.WriteLine("Létrehozott cHengerek száma:" + cHenger.SzuletesSzamlalo);
            Console.WriteLine($"Átlag térfogat: {AtlagTerfogat(testek):N2}");
        }
    }
}