using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    internal class Program
    {
        public string encrypt(string str)
        {
            int[] key = { 2, -5, 5, 8, -4, 7 };
            int j = 0;
            string msg="";
            for (int i = 0; i < str.Length; i++)
            {
                if (j == key.Length) { j = 0; }
                char ch = (char)(str[i] + key[j]);
                msg += Convert.ToString(ch);
                j++;
           
            }
            Console.WriteLine();
            return msg;
        }
        public string decrpyt(string str)
        {
            int[] key = { 2, -5, 5, 8, -4, 7 };
            int j = 0;
            string msg = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (j == key.Length) { j = 0; }
                char ch = (char)(str[i] - key[j]);
                msg += Convert.ToString(ch);
                j++;

            }
            Console.WriteLine();
            return msg;

        }
        

        static void Main(string[] args)
        {
            Program p = new Program();
            string str = Console.ReadLine();
            Console.WriteLine(p.decrpyt(str));            
        }
    }
}
