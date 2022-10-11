using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Quiz_exam
{
    
    class Datebase
    {
        public static string login, password;
        public static string fileUsers = "Users.txt";


        public static void authorisation ()
        {
            WriteLine("AUTHORISATION");
            WriteLine("_____________");
            Write("Enter login:      ");
            login = ReadLine();
            Write("Enter password:      ");
            password = ReadLine();
            if (isValidAuthrisation(login, password))
                WriteLine("Success authrisation!");
            else
            {
                WriteLine("Entrance error. Try again...\n");
                authorisation();
            }
        }

        public static void createUser()
        {
            WriteLine("CREATE NEW ACCOUNT");
            WriteLine("____________________");
            User user = new User();

            do user.setLogin();
            while (!user.setLogin());

            Write("Enter password:      ");
            user.setPassword(Convert.ToString(ReadLine()));
            Write("Enter date of birth:      ");
            user.setBirthDate(ReadLine());

            try
            {
                using (FileStream file = new FileStream(fileUsers, FileMode.Append));
                FileAccess.Write.ToString(user.getLogin() + " " + user.getPassword() + " " + user.getDateBirth());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.ToString());
            }


        }

        public static bool isLoginUnique (string login)
        {
            if (File.Exists(fileUsers))
            {
                string[] lines = File.ReadAllLines(fileUsers);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] userData = lines[i].Split(' ');
                    if (userData[0].Equals(login))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool isValidAuthrisation (string login, string password)
        {
            string[] lines = File.ReadAllLines(fileUsers);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] userData = lines[i].Split(' ');
                if (userData[0].Equals(login) && userData[1].Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
