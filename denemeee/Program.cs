using System;
using System.Collections.Generic;

namespace denemeee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler=new List<string>();
            sehirler.Add("ist");
            int count = sehirler.Count;
            Console.WriteLine(count);
            foreach (var x in sehirler)
            {
                Console.WriteLine(x);
            }

            MyList<string> sehirler2=new MyList<string>();
            sehirler2.Add("İzm");
            sehirler2.List();
        }
    }



   public class MyList<T>
   { 
       T[] sehirler2;
        T[] _array;

       public MyList()
       {
           sehirler2=new T[0];
       }

       public void Add(T item )
       {
           
           _array = sehirler2;
           sehirler2=new T[sehirler2.Length+1];
           for (int i = 0; i < _array.Length; i++)
           {
               sehirler2[i] = _array[i];
           }

           sehirler2[sehirler2.Length - 1] = item;
       }

       public void List()
       {
           foreach (var y in sehirler2)
           {
               Console.WriteLine(y);
           }
       }


   }
}
