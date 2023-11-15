using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Encapsulation
    {
        private string _username;
        public string Username { set; get; }
        public string mobilenumber { get; set; }
        public string nationalid { get; set; }
        public DateTime creatdata { get; set; }

    }
}
