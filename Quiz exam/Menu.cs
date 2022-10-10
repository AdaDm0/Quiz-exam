using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;


namespace Quiz_exam
{
    internal class Menu
    {
        int entranceChoice;
        string login;
        string password;
        
        void entranceText()
        {
            WriteLine("ENTRANCE");
            WriteLine("1 - for login");
            WriteLine("2 - for registration");
            WriteLine("_________");
        }

        async void entrance ()
        {
            do
            {
                entranceText();
                entranceChoice = Convert.ToInt32(ReadKey());
                if (entranceChoice == 1)
                {
                    Write("Enter login:      ");
                    login = ReadLine();
                    Write("Enter password:      ");
                    password = ReadLine();
                }
                else if (entranceChoice == 2)
                {
                    User user = new User();
                    Write("Enter login:      ");
                    user.setLogin(Convert.ToString(ReadLine()));
                    Write("Enter password:      ");
                    user.setPassword(Convert.ToString(ReadLine()));
                    //Write("Enter date of birth:      ");
                    //string inputDate = ReadLine();
                    //DateTime inputDate2;
                    //DateTime.TryParse(inputDate, "dd.MM.yyyy", null, out inputDate2);
                    //user.setBirthDate()
                    //user.setBirthDate(DateTime.TryParseExact("dd.MM.yyyy", null, DateTimeStyles.None, out dob));

                    using (StreamWriter file = new StreamWriter(filePath, append: true))
                    {
                        await file.WriteLineAsync((user.getLogin() +" "+ user.getPassword()));
                    }
                    
                }
                else
                {
                    WriteLine("Entrance error. Try again");
                }
            }
            while (entranceChoice != 1 | entranceChoice != 2);

        }
    }
}
