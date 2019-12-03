﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAba5
{
    public abstract partial  class Animals : Base
    {
        public Animals(int age, int weight)
        {
            info.Age = age;
            info.Weight = weight;
        }
    }


    enum list
    {
        first = 1,
        second,
        third,
        fourth = 5,
        fifth
    }

    public class ZOO
    {
        public Base[]  animals;
        public int count = 0;
        public int size;
        

        public ZOO()
        {
            size = 6;
            animals = new Base[size];
        }

        public bool isFull()
        {
            return (count == size);
        }

        public bool isEmpty()
        {
            return (count == 0);
        }

        public void Add(Base el)
        {
            if (isFull())
                return;
            animals[count] = el;
            count++;
        }

        public void Del(Base el)
        {
            int num = 0;
            if (isEmpty())
                return;
            for (int i = 0; i < count; i++)
            {
                if (animals[i].Equals(el))
                    num = i;
            }
            for (int i = num; i < count; i++)
            {
                animals[i] = animals[i + 1];
            }
            count--;
        }

        public void show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(animals[i].ToString());
            }
            Console.WriteLine();
        }
    }
 

    public abstract class Base
    {
        public struct Info
        {
            public int Age;
            public int Weight;
        }
        public Info info = new Info();
    }

    public static class controller
    {


        public static void Weight(ZOO animal)
        {
            int sum = 0;
            for (int i = 0; i < animal.count; i++)
            {
                sum += animal.animals[i].info.Weight;
                Console.WriteLine(sum);
            }
            Console.WriteLine($"Средний вес: {(float)sum / (float)animal.count}");
        }

        public static void sort(ZOO animal)
        {
            Base elem;
            for (int i = 0; i < animal.count - 1; i++)
            {
                for (int j = 0; j < animal.count - i - 1; j++)
                {
                    if (animal.animals[j].info.Age < animal.animals[j + 1].info.Age)
                    {
                        elem = animal.animals[j];
                        animal.animals[j] = animal.animals[j + 1];
                        animal.animals[j + 1] = elem;
                    }
                }
            }
        }

        public static void show(ZOO animal)
        {
            

            string[]  Kind = new string[6];
            int[] Age = new int[6];
            int[] Weight = new int[6];
            int[] count = new int[7];
            int pos = 0;
            bool b = false;

            for (int j = 0; j < animal.count; j++)
            {
                for (int i = 0; i < pos; i++)
                {
                    if (Kind[i] == (animal.animals[j].GetType()).Name)
                    {
                        b = true;
                        count[i]++;
                        break;
                    }
                }
                if (!b)
                {
                    Kind[pos] = animal.animals[j].GetType().Name;
                    Age[pos] = animal.animals[j].info.Age;
                    Weight[pos] = animal.animals[j].info.Weight;
                    count[pos]++;
                    pos++;
                }
               
                b = false;
            }

            Console.WriteLine("Info:");
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine( $" Вид {Kind[i]} - Год рождения: {Age[i]} - Вес: {Weight[i]}Кг ");
            }
            Console.WriteLine();
        }
    }
}