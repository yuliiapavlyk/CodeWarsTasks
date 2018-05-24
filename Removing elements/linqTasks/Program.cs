using System;
using System.Linq;
using System.Collections.Generic;

namespace linqTasks
{
    class Program
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            arr = arr.Where((value, index) => index % 2 == 0).ToArray();

            return arr;

        }
        static void Main(string[] args)
        {

            object[] my_list = { "Keep", "Remove", "Keep", "Remove", "Keep" };
            object[] arr = RemoveEveryOther(my_list);
            foreach (object i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }        
    }
}
