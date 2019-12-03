using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    interface IInterface
    {
        string SomeFunc();
    }

    interface IPrint
    {
        string ToString();
    }

    abstract class Creatures
    {
        public int Age;
        public string Area;

        public Creatures()
        {
            Age = 0;
            Area = "";
        }

        public Creatures(int age, string area)
        {
            Age = age;
            Area = area;
        }

        public override bool Equals(object obj)
        {
            Creatures creature = (Creatures)obj;
            return ((this.Age == creature.Age) && (this.Area == creature.Area));
        }

        public override int GetHashCode()
        {
            return this.Age.GetHashCode() + this.Area.GetHashCode();
        }

        public override string ToString()
        {
            return this.Age.ToString() + " " + this.Area;
        }
    }

    class Birds : Creatures
    {
        public bool CanFly { get; set; }
        
        public Birds() : base()
        {
            CanFly = true;
        }

        public Birds(int age, string area, bool canFly) : base(age, area)
        {
            CanFly = canFly;
        }
    }

    class Owl : Birds
    {
        public string breed;

        public Owl() : base()
        {
            breed = "";
        }
        public Owl(int age, string area, bool canFly, string Breed) : base(age, area, canFly)
        {
            breed = "";
        }
    }

    class Parrot : Birds
    {
        public string breed;
        public Parrot() : base()
        {
            breed = "";
        }
        public Parrot(int age, string area, bool canFly, string Breed) : base(age, area, canFly)
        {
            breed = "";
        }
        public override string ToString()
        {
            return this.Age.ToString() + " " + this.Area;
        }
    }

    class Animals : Creatures
    {
        public bool ColdBlooded { get; set; }

        public Animals() : base()
        {
            ColdBlooded = false;
        }

        public Animals(int age, string area, bool coldBlooded) : base(age, area)
        {
            ColdBlooded = coldBlooded;
        }

    }

    sealed class Lion : Animals
    {
        public bool PrideLeader;

        public Lion() : base()
        {
            PrideLeader = true;
        }
        public Lion(int age, string area, bool coldBlooded, bool lead) : base(age, area, coldBlooded)
        {
            PrideLeader = lead;
        }
    }

    class Crocodile : Animals { }

    class Fish : Creatures
    {
        public bool Deep { get; set; }

        public Fish() : base()
        {
            Deep = false;
        }

        public Fish(int age, string area, bool deep) : base(age, area)
        {
            Deep = deep;
        }
    }

    class Shark : Fish
    {
        public string Breed;
        public Shark() : base()
        {
            Breed = "";
        }
        public Shark(int age, string area, bool coldBlooded, string breed) : base(age, area, coldBlooded)
        {
            Breed = breed;
        }
    }

    class SomeClass: SomeAbstrClass, IInterface
    {
        public override string someFunc()
        {
            return "dis is override";
        }

        string IInterface.SomeFunc()
        {
            return "I func realiz";
        }
    }

    abstract class SomeAbstrClass
    {
        abstract public string someFunc();
    }

    class Print
    {
        public static void toPrint(IPrint obj)
        {
            Console.WriteLine(obj.ToString());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {




        }
    }
}
