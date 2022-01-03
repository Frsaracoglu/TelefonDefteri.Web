using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteriEntity
{
    public class PhoneList
    {
        public int ListId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }

    }
}
