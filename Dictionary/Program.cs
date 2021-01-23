using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyDictionary<int, string> yeniKayit = new MyDictionary<int, string>();
            yeniKayit.Add(59,"Yücel");
            yeniKayit.Add(589, "Yüksel");

            yeniKayit.Al();
  
            
        }
    }
}
