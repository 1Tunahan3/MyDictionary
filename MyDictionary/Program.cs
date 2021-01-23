using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> sozluk=new MyDictionary<string,int>();
            sozluk.Add("l",3);
            sozluk.Add("a", 5);
            sozluk.Add("b", 6);
            sozluk.List();
        }
    }

    class MyDictionary<Tkey,Tvalue>
    {
         Tkey[] _key;
        Tvalue[] _value;
         

        public MyDictionary()
        {
            _key=new Tkey[0];
            _value=new Tvalue[0];

        }

        public void Add(Tkey item ,Tvalue item2)
        {
            Tkey[] tempt = _key;
            _key=new Tkey[_key.Length+1];
            for (int i = 0; i < tempt.Length; i++)
            {
                _key[i] = tempt[i];
            }

            _key[_key.Length - 1] = item;

            Tvalue[] tempt2 = _value;
            _value=new Tvalue[_value.Length+1];
            for (int i = 0; i < tempt2.Length; i++)
            {
                _value[i] = tempt2[i];
            }

            _value[_value.Length - 1] = item2;

        }

        public void List()
        {

            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine(_key[i] +","+ _value[i]);
            }
        }
    }
}
