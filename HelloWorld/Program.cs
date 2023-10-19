namespace Vsite.CSharp.NetFramework
{
    // :000 Pogledati strukturu projekta: Properties, Dependencies...
    // :001 Kliknuti na projekt desnom tipkom miša i iz kontekstnog izbornika izabrati "Open Folder in File Explorer". Pogledati strukturu kazala.
    // :002 Napraviti build programa i pogledati koja kazala i datoteke je Visual Studio kreirao.
    // :003 Pokrenuti program i pogledati ispis.
    // :004 Pomoću programa ILDasm (obično unutar "C:\Program Files (x86)\Microsoft SDKs\Windows\vNN.N\bin\NETFX N.N.N Tools") pogledati sadržaj generirane izvedbene datoteke.
    static class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            double d = 3.14;
            string s = "Zdravo";
            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
