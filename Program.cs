using System;

namespace page_50
{
    class Base
    {
        public int Add(int a1, int a2)
        {
            return a1 + a2;
        }
        public float Add(int a1, float a2)
        {
            return a1 + a2;
        }
    }
    class Derived : Base
    {
        public int Add(int a1, int a2, int a3)
        {
            return a1 + a2 + a3;
        }
        public float Add(float a1, int a2)
        {
            return a1 + a2;
        }
    }

    class MethodOverloadingUsage
    {
        static void Main()
        {
            Derived obj = new Derived();
            Console.WriteLine(obj.Add(10, 20));
            Console.WriteLine(obj.Add(10, 12.5f));
            Console.WriteLine(obj.Add(10, 20, 30));
            Console.WriteLine(obj.Add(13.5f, 10));
            Console.Read();


        }
    }
}