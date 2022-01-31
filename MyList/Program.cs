using System;

namespace MyList// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyListManager<string> myListManager = new MyListManager<string>();
            myListManager.Add("İstanbul");
            myListManager.Add("Ankara");
        }
    }
}
