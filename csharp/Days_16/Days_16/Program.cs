using System;
using System.Xml.Linq;
using Days_16.Utils;

namespace Days_16;

public class Program
{
    public static void Main(string[] args)
    {
        // array(dizi) - immutable - değişmez

        string[] users = { "ahmet", "veli" };
        Console.WriteLine(users);

        //collections - mutable - değişebilir
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

    }
}