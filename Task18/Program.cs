using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите скобки");
            string str = Console.ReadLine();
            List<char> list1 = new List<char>();
            list1.AddRange(str);

            Check (str);
            Console.ReadKey();

        }

        static bool Check(string str)
        { 

            char[] arr;   
            arr = str.ToCharArray();

            Stack<char> stack1 = new Stack<char>();

            var sk = new Dictionary<char, char>
            {
                {')','('},
                { '}','{'},
                {']','[' }
            };



            foreach (char symbl in arr)
            {
                if (symbl == '(' || symbl == '{' || symbl == '[')
                    stack1.Push(symbl);


                if (symbl == ']' || symbl == '}' || symbl == ')')
                {
                    if (stack1.Count == 0 || stack1.Pop() != sk[symbl])
                    {
                        Console.WriteLine("неверно");
                        return false; }
                }
            }


            if (stack1.Count == 0)
            {
                Console.WriteLine("верно");
                return true;
            }
            else
            {
                Console.WriteLine("неверно");
            }
            return false;

        }
    }
}
