using System;
using System.Collections.Generic;
using Login_List.Models;

namespace Login_List.Services
{
    public class EmployeesServices
    {
        public static List<Employee> GetEmployee()
        {
            var list = new List<Employee>
            {
                new Employee
                {
                    Image="img1.png",
                    Name ="fawzi",
                    Departement="service"
                },
                new Employee
                {
                   Image="img2.png",
                   Name="emna",
                   Departement="frontend"
                },
                new Employee
                {
                   Image="img3.png",
                   Name="mahdi",
                   Departement="service"
                },
            };
            return list;
        }
    }
}
