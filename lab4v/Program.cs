using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public class Queue
    {
        public Owner owner;
        public DateTime date;
        private readonly int maxSize = 20;
        public int[] qq;
        private int Head;

        public Queue()
        {
            qq = new int[maxSize];
            Head = 0;
            owner = new Owner();
            date = DateTime.Now;
        }

        public Queue(int size)
        {
            qq = new int[size];
            Head = 0; owner = new Owner();
            date = DateTime.Now;
        }

        public void Show()
        {
            Console.WriteLine("queue:");
            for (int i = 0; i < Head; i++)
            {
                Console.WriteLine(qq[i]);
            }
        }
        public static Queue operator +(Queue q1, int x)
        {
            q1.add(x);
            return q1;
        }
        private void add(int x)
        {
            if (Head >= qq.Length)
            {
                Console.WriteLine("full(");
                return;
            }
            qq[Head] = x;
            Head++;
        }

        public static Queue operator --(Queue q1)
        {
            q1.remove();
            return q1;
        }
        public int remove()
        {
            int tmp = qq[0];
            for (int i = 0; i < Head; i++)
            {
                if (i != qq.Length-1)
                    qq[i] = qq[i + 1];
                else
                    qq[i] = 0;
            }
            Head--;
            return tmp;
        }

        public static bool operator true(Queue q1)
        {
            if (q1.Head == 0)
                return true;
            else
                return false;
        }
        public static bool operator false(Queue q1)
        {
            if (q1.Head == 0)
                return false;
            else
                return true;
        }

        public static Queue operator <(Queue q2, Queue q1)
        {
            int tmp = q1.Head;
            for (int i = 0; i <= tmp; i++)
            {
                q2.add(q1.remove());
            }
            return q2;
        }
        public static Queue operator >(Queue q1, Queue q2)
        {
            int tmp = q1.Head;
            for (int i = 0; i <= tmp; i++)
            {
                q2.qq[i] = q1.qq[i];
            }
            return q2;
        }

        public static explicit operator int(Queue q1)
        {
            return q1.Head;
        }
    }

    public class Owner
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }

        public Owner()
        {
            id = 0;
        }

        public Owner(int _id, string _Name, string _Organization)
        {
            id = _id;
            Name = _Name;
            Organization = _Organization;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue(5);
            if (q1)
                Console.WriteLine("empty");
            else
                Console.WriteLine("not empty");
            q1 += 5;
            q1 += -2;
            q1 += 71;
            q1 += -20;
            q1 += 3;
            q1.Show();
            q1--;
            int Power = (int)q1;
            Console.WriteLine(Power);
            if (q1)
                Console.WriteLine("empty");
            else
                Console.WriteLine("not empty");
            q1.Show();
            Queue q2 = new Queue(5);
            q2 = q2 < q1;
            q2.Show();
            q1.Show();
            Console.ReadLine();
        }
    }
}
