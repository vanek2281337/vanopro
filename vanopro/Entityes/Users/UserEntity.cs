using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vanopro.Const;

namespace vanopro.Entityes.Users
{
    public class UserEntity
    {
        public string FIO { get; set; }
        public string GenderEnum { get; set; }
        public int PhoneNumber { get; set; }
        public RoleEnum Role { get; set; }
        public float Rating { get; set; }


    }
}
