using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13
{
    internal class User
    {
        static public LinkedList<User> users = new LinkedList<User>();
        string Name { get; set; }
        string SubName { get; set; }
        string Password { get; set; }
        string SubPass { get; set; }
        public User(string _name, string _subName, string _password, string _subPass) 
        {
            Name = _name;
            SubName = _subName;
            Password = _password;
            SubPass = _subPass;
        }
    }
}
