using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using static System.Console;


namespace Quiz_exam
{
    internal class Menu
    {
        static string entranceChoice;
        string login;
        string password;
        
       public static void startProgram()
        {
            entrance();

        }



        public static void entrance ()
        {
            WriteLine("ENTRANCE");
            WriteLine("1 - for login");
            WriteLine("2 - for registration");
            WriteLine("_________");

            entranceChoice = ReadLine();
            if (Convert.ToInt32(entranceChoice)== 1)
                Datebase.authorisation();
            else if (Convert.ToInt32(entranceChoice) == 2)
                Datebase.createUser();
            else
            {
                //необработанное исключение для текстовой строки (с цифрами норм)
                WriteLine("Entrance error. Try again...\n");
                entrance();
            }

        }
    }
}
