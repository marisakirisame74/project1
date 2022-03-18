using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string name = "onosyouji";
            
               Console.WriteLine(name+"sama");
            
               while (true) { }
            */

            /* int age = 20;

            if (age >= 20) 
            {
                Console.WriteLine("あなたは成人です");
            }else
            {
                Console.WriteLine("あなたは成人じゃないです");
            }
            */

            /*
             for (int i = 0; i < 5; i++) {
                Console.WriteLine("ono");
                Console.WriteLine(i+1+"回目");
            }
            */

            List<string> name = new List<string>();

            name.Add("小野");
            name.Add("高田");
            name.Add("浅沼");

            for (int i = 0; i < name.Count; i++)
            {

                Console.WriteLine(name[i]);

            }

            while (true) { }

        }
    }
}
