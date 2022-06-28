using System;

namespace Interface_Multipal_Inheritence
{
    interface A1
    {
       
        void M1();
    }
    interface A2
    {
        void M2();
    }
    class Program:A1,A2
    {
        public void M1()
        {
            Console.WriteLine("M1 Method :");
        }
        public void M2()
        {
            Console.WriteLine("M2 Method :");
        }
        static void Main(string[] args)
        {
            A1 obj = new Program();
            obj.M1();
            A2 obj1 = new Program();
            obj1.M2();
        
            Console.WriteLine(obj.GetHashCode());
        }
    }
}
