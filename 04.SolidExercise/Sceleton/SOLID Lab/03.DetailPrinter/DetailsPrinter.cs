﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
