using System;
using System.Collections;

namespace NonGenericHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Ename", "Scott");
            ht.Add("Salary", 25000.00);
            ht.Add("Phone", "9999999999");
            ht.Add("Email", "scott@gmail.com");
            Console.WriteLine(ht["Ename"].GetHashCode());
   
            foreach (object key in ht.Keys)
            {
                Console.Write(key + " : "+ ht[key]); //Will Give only value
                Console.WriteLine();
            }
        }
    }
}
