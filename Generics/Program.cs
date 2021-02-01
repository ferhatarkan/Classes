using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            sehirler[0] = "İstanbul";//Set
            Console.WriteLine(sehirler[0]);//Get
            Console.WriteLine(sehirler.Count);


            myList<string> sehirler2 = new myList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            sehirler2[0] = "İstanbul";
            // Console.WriteLine(sehirler2[0]);
            //İndexer
            foreach (var sehir in sehirler2.Items)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine(sehirler2.Count);
        }
    }
}
class myList<T> //Generic class
{
    T[] _array;
    T[] _tempArray;
    public myList()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item;
    }


    public int Count
    {
        get { return _array.Length; }

    }

    public T[] Items
    {
        get
        {
            return _array;
        }
    }

    public T this[int index]
    {
        get
        {
            return _array[index];
        }
        set
        {
            _array[index] = value;
        }
    }

}
