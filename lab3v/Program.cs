using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public partial class shop
    {
        readonly int MaxSize = 20;
        private string[,] List;
        private int Pointer;
        private static int ListCount;
    }

    public partial class shop
    {
        //static constructor
        static shop()
        {
            ListCount++;
            Console.WriteLine("just a static constructor ¯\\_(ツ)_/¯(hate da utf-16)");
        }

        //constr w/no args
        public shop()
        {
            List = new string[MaxSize, 2];
            Pointer = 0;
        }

        //const w/args
        public shop(int maxSize)
        {
            List = new string[maxSize, 2];
            Pointer = 0;
            MaxSize = maxSize;

        }
    }
    
    public partial class shop
    {
        public override string ToString()
        {
            return this.Pointer.ToString();
        }
        public override int GetHashCode()
        {
            return this.Pointer.GetHashCode();
        }
        public int P
        {
            get
            {
                return this.Pointer;
            }

            set
            {
                if (value <= MaxSize && value >= 0)
                    Pointer = value;
                else
                    Console.WriteLine("out of range");
            }
        }
        ~shop()
        {
            Console.WriteLine("destroyed");
        }
    }

    public partial class shop
    {
        public void AddShop(string shopName, string owner, ref int refEx)
        {
            if (Pointer == List.Length / 2)
            {
                Console.WriteLine("list is full");
                return;
            }
            List[Pointer, 0] = shopName;
            List[Pointer, 1] = owner;
            ShowInfo(Pointer);
            Console.WriteLine($"saved under No.{Pointer}\n");
            refEx++;
            Pointer++;
        }

        public void ShowInfo(int id)
        {
            Console.WriteLine($"name:{List[id, 0]}\towner:{List[id, 1]}");
        }

        public string Fullines()
        {
            return $"{Pointer}/{List.Length / 2}";
        }

        public static int ListQuant()
        {
            return ListCount;
        }

    }

    static class Info
    {
        public static string inf(shop s1)
        {
            Console.WriteLine("number of shops in list is " + s1.ToString());
            return s1.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int refEx = 0;
            shop lista = new shop(5);
            lista.AddShop("a", "a", ref refEx);
            lista.AddShop("b", "b", ref refEx);
            lista.AddShop("c", "c", ref refEx);
            lista.AddShop("d", "d", ref refEx);
            lista.P = 3;
            lista.AddShop("e", "e", ref refEx);
            lista.AddShop("f", "f", ref refEx);
            lista.AddShop("g", "g", ref refEx);
            for (int i = 0; i < 5; i++)
                lista.ShowInfo(i);
            Console.WriteLine(refEx);
            Info.inf(lista);
            var anonShop = new { shopName = "ex", owner = "meb"};
            Console.WriteLine(anonShop.shopName);
            Console.ReadLine();
        }
    }
}
