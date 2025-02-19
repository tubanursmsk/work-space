using System.Xml.Linq;
using Days_16.Utils;

namespace Days_16;

public class Program
{
public static void Main(string[] args)
    {
        // array - immutable
        
        string[] users = { "ahmet", "veli" };
        Console.WriteLine(users);

        //collections - mutable
        // ArrayList
        UseArrayList useArrayList = new UseArrayList();
        useArrayList.Call();

        Console.WriteLine("===============");


        //List
        //Generic
        Actions<int> actions = new Actions<int>();
        actions.Add(100);

        UseList useList = new UseList();
        useList.Call();

       /* public override string productc() 17. dersin ilk oturumunda alınan not eksik tamamla
    {
        return $"{title} - {detail} - {price} - {status}";
    }

        */





}
}