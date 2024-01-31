using System.Collections.Immutable;
using System.Net;

int[] tipp = new int[6] {0, 0, 0, 0, 0, 0};
int neu = 100;
int run = 0;
bool dupe = false;
while (run <= 5)
{
    Console.WriteLine("Bitte geben sie eine Zahl ein");
    try { neu = int.Parse(Console.ReadLine());
        if (neu >= 1 && neu <= 49)
        {
            foreach (var item in tipp)
            {
                if (neu == item)
                {
                    dupe = true;
                }
            }
            if (dupe == false)
            {
                Console.WriteLine("Zahl gespeichert");
                tipp[run] = neu;
                run++;
                neu = 100;
            }
            else if (dupe == true)
            {
                Console.WriteLine("Zahl bereits eingegeben. Wählen sie eine andere");
            }
        }
        else
        {
            Console.WriteLine("Unerwarteter Fehler, liegt die Zahl zwischen 1-49 und ist kein Buchstabe?");
        }
        dupe = false;
    }
    catch { Console.WriteLine("Unerwarteter Fehler, ist ihre Zahl eine ganze Zahl ohne Sonderzeichen?"); }
    
}
Array.Sort(tipp);
Console.WriteLine("Hier sind ihre sortierten Lottozahlen:");
foreach (var item in tipp)
{
    Console.WriteLine(item.ToString());
}