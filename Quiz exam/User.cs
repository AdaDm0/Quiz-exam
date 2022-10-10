using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_exam
{
    internal class User
    {
        string login, password;
        DateTime dateOfBirth;
        public static string filePath = "Users.txt";

        public User ()
        {
            login = "";
            password = "";
            dateOfBirth = DateTime.MinValue;
        }

        public User (string login, string password, DateTime dateOfBirth)
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

        public void setLogin(string login)
        {
            this.login = login;
        }

        public void setPassword (string password)
        {
            this.password = password;
        }

        public void setBirthDate (DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        

    }
}
