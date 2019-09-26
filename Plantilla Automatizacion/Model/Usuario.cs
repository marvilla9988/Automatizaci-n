using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private string _username;
        private string _password;
        private string _firstName;
        private string _lastName;

        public Usuario(string username, string password, string firstName, string lastName)
        {
            _username = username;
            _password = password;
            _firstName = firstName;
            _lastName = lastName;
        }

        public string username
        {
            get
            { return _username; }
        }

        public string password
        {
            get
            { return _password; }
        }

        public string firstName
        {
            get
            { return _firstName; }
        }

        public string lastName
        {
            get
            { return _lastName; }
        }

    }
}
