﻿using System;
using Microsoft.EntityFrameworkCore;
using WebappDEmo.Data;

namespace WebappDEmo.Models
{
    public class EmployeeContext : ApplicationDbContext
    {
        public EmployeeContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; }
    }

    public class Employee
	{
		public int id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
    }
}

