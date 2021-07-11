using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_payroll_management_system.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string userID { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string email_id { get; set; }
        public string designation { get; set; }
    }
}