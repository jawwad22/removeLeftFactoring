using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingLeftFactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "A-hgf|hgk";
            while (true)
            {
                RemovingLeftFactoring(input);
                break;
            }



        }

        private static void RemovingLeftFactoring(string input)
        {
            string[] k,l,m;
            string n = "";
            k=input.Split('-');
            l = k[1].Split('|');
            for (int i=0; i < l.Length-1; i++)
            {
                for (int j = i; j < l[i + 1].Length; j++)
                {
                    if (l[i][j] == l[i + 1][j]) { 
                    if(!n.Contains(l[i][j])){
                        n = n + l[i][j];
                    }
                    }
                }
            }
            Console.WriteLine(k[0] + "-" + n + "R");
            string temp = k[1].ToString();
            temp = temp.Replace(n, "");
            m = temp.Split('|');
            Console.Write("R-");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(m[i] + "|");
            }
            
            
        }
    }
}
