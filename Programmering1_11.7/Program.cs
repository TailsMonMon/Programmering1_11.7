using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_11._7 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Hur gammal är personen? ");
            int age = Convert.ToInt32(Console.ReadLine());
            OfAge(age);
            Console.ReadLine();
        }

        //      CHECKS IF PERSON IS OF AGE
        static string OfAge(int age) {
            string str = "before";
            if (age >= 18) {
                str = "Personen är myndig.";
            }
            else {
                str = "Personen är inte myndig.";
            }
            Console.WriteLine(str);
            return str;
        }
    }
}
