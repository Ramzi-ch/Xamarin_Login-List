
using Login_List.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login_List.Services
{
    public class AdminsServices
    {
        public static List<Admin> GetAdmins()
        {
            var list = new List<Admin>
            {
                new Admin
                {
                    Mail="a",
                    Password="a"
                },
                new Admin
                {
                   Mail="hana",
                   Password="11"
                },
                new Admin
                {
                    Mail="sonia",
                    Password="22"
                },
            };
            return list;
        }
    }
}
