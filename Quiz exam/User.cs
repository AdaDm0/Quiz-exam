using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Quiz_exam
{
    internal class User
    {
        string login, password, dateOfBirth;
        

        public User ()
        {
            login = "";
            password = "";
            dateOfBirth = "";
        }

        public User (string login, string password, string dateOfBirth)
        {
            this.login = login;
            this.password = password;
            this.dateOfBirth = dateOfBirth;
        }

        public string getLogin ()
        {
            return login;
        }

        public string getPassword ()
        {
            return password;
        }

        public string getDateBirth()
        {
            return dateOfBirth;
        }

        public bool setLogin()
        {
            Write("Enter login:      ");
            string login = ReadLine();
            if (Datebase.isLoginUnique(this.login))
            {
                this.login = login;
                return true;
            }
            else
            {
                WriteLine("This login is already exists");
                return false;
            }
        }

        public void setPassword (string password)
        {
            this.password = password;
        }

        public void setBirthDate (string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        

    }
}
