using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_payroll_management_system.Models;

namespace Online_payroll_management_system.DbFolder.DbOperations
{
    public class AccountDbOps
    {
        public bool new_signUp(AccountModel am)
        {
            using (var context = new OPMS_Entities())
            {
                var chk = context.Accounts.FirstOrDefault(x => x.userID == am.userID);
                if (chk?.userID == null)
                {
                    var acc = new Account()
                    {
                        userID=am.userID,
                        password=am.password,
                        name=am.name,
                        designation=am.designation,
                        email_id=am.email_id
                   };
                    context.Accounts.Add(acc);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            }

        public bool validate_login(AccountModel am)
        {
            using(var context=new OPMS_Entities())
            {
                var chk = context.Accounts.FirstOrDefault(x => x.userID == am.userID);
                if (chk == null)
                {
                    if (chk?.password == am.password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}