using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DAL.DTO.User_DTO
{
    public class UserReadDTO
    {
        public Guid Id { get; set; }

        public string Names { get; set; }

        public string LastNames { get; set; }

        public string UserNames { get; set; }

        public string Emails { get; set; }

        public string Passwords { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
