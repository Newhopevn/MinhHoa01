using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa01.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

        public DateTime BirtDay { get; set; }
        public string Picture { get; set; }
    }
}
