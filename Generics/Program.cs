using System;
using System.Collections.Generic;

namespace GenericApplication
{
    public class MyGenericArray<T,P,M>
    {
        private T[] array;
        private Dictionary<P,M> dictionary;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
            dictionary = new Dictionary<P,M>();
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }

        public M getDictionary(P key)
        {
            return dictionary[key];
        }

        public void setDictionary(P key,M value)
        {
            dictionary[key] = value;
        }
        public void returnAllItems()
        {
            for (int i=0;  i< array.Length; i++)
            {
                Console.WriteLine("Items of array[{0}]:{1}", i, array[i]);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine("Items of dictionary{0},{1}", item.Key,item.Value);
            }
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {

            //declaring an int array
            MyGenericArray<int, int, string> intArray = new MyGenericArray<int, int, string>(5);
            intArray.setDictionary(1,"aladinuu");
            intArray.setItem(1,2);

            Console.WriteLine("Get dictionary: {0}", intArray.getDictionary(1));
            Console.WriteLine("Get item of array : {0}", intArray.getItem(1));

            Console.WriteLine("\n\n Begin return of all items of intArray");

            intArray.returnAllItems();

            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    intArray.setItem(c, c * 5);
            //}

            ////retrieving the values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(intArray.getItem(c) + " ");
            //}

            //Console.WriteLine();

            ////declaring a character array
            //MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    charArray.setItem(c, (char)(c + 97));
            //}

            ////retrieving the values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(charArray.getItem(c) + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Dictionary<int,MyGenericArray<int>> aladin = new Dictionary<int, MyGenericArray<int>>();
            //aladin.Add(1, intArray);
            //Console.WriteLine("Primul element din dictionar e {0}", aladin[1].getItem(1));
            Console.ReadKey();
        }
    }
}