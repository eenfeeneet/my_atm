using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Accounts
    {
        public static void Account1()
        {
            string name()
            {
                return "Clark Kent";
            }
            string id()
            {
                return "1-902871-187";
            }
            double balance()
            {
                return 500;
            }
        }

        public static void Account2(string pin)
        {
            string name()
            {
                return "Bruce Wayne";
            }
            string id()
            {
                return "5-278390-010";
            }
            double balance()
            {
                return 52.50;
            }
           
        }
        public static void Account3(string pin)
        {
            string name()
            {
                return "Diana Prince";
            }
            string id()
            {
                return "8-198222-011";
            }
            double balance()
            {
                return 900.50;
            }
           
        }
        public static void Account4(string pin)
        {

            string name()
            {
                return "Hal Jordan";
            }
            string id()
            {
                return "9-122873-227";
            }
            double balance()
            {
                return 20.30;
            }
        }
    }
}
