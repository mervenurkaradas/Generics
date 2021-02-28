using System;
using System.Collections.Generic;
using System.Text;

namespace _4GunOdev5
{
    class MyDictionary<Tkey, Tvalue> 
    {
        Tkey[] person;
        Tvalue[] ıd;

        public MyDictionary() //Constructor
        {
            person = new Tkey[0];  
            ıd = new Tvalue[0];
        }

        public void Add(Tkey persons, Tvalue ıds)
        {
            Tkey[] tempArray1 = person;
            Tvalue[] tempArray2 = ıd;

            person = new Tkey[person.Length + 1];
            ıd = new Tvalue[ıd.Length + 1];


            for (int i = 0; i < tempArray1.Length; i++)
            {
                person[i] = tempArray1[i];
            }
            person[person.Length - 1] = persons;


            for (int i = 0; i < tempArray2.Length; i++)
            {
                ıd[i] = tempArray2[i];
            }
            ıd[ıd.Length - 1] = ıds;

            Console.WriteLine("Person = " + persons + "\nID = " + ıds);
        }
    }
}
