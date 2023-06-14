using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    internal class Program
    {
        public string encrypt(string str, string kk)
        {
            int[] key = new int[kk.Length];
            for (int i = 0; i < kk.Length; i++)
            {

                key[i] = (int)(kk[i] % 48);
            }

            int j = 0;
            string msg="";
            for (int i = 0; i < str.Length; i++)
            {
                if (j == key.Length) { j = 0; }
                char ch = (char)(str[i] + key[j]);
                msg += Convert.ToString(ch);
                j++;
           
            }
         
            return msg;
        }
        public string decrpyt(string str, string kk)
        {
            int[] key = new int[kk.Length];
            for (int i = 0; i < kk.Length; i++)
            {

                key[i] = (int)(kk[i] % 48);
            }
            int j = 0;
            string msg = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (j == key.Length) { j = 0; }
                char ch = (char)(str[i] - key[j]);
                msg += Convert.ToString(ch);
                j++;
            }
           
            return msg;

        }
        
        

        static void Main(string[] args)
        {
            Program p= new Program();
            while(true) {
                Console.WriteLine("1.encrypt message:");
                Console.WriteLine("2.decrypt message");
                Console.WriteLine("3.clear screen");
                Console.Write("0.exit \n>:");
                int s=Convert.ToInt32(Console.ReadLine());
                if(s==1)
                {
                    Console.Write("Enter key: ");
                    string k=Console.ReadLine();
                    Console.Write("Enter message to encrypt: ");
                    string str=Console.ReadLine(); 
                    Console.Write("Encrypted Message: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(p.encrypt(str,k)+"\n");
                    Console.WriteLine();
                    Console.ResetColor();   

                }
                else if(s==2)
                {
                    Console.Write("Enter key: ");
                    string k = Console.ReadLine();
                    Console.Write("Enter message to decrypt: ");
                    string str = Console.ReadLine();
                    Console.Write("Decrypted Message: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(p.decrpyt(str, k)+"\n");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                else if(s==0)
                {
                    break;
                }
                else if(s==3)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Console.Clear();
                }
                
            
            }
            
         


        }
    }
}
