using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondPractise2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }

        public int Age { get; set; }
    }
}