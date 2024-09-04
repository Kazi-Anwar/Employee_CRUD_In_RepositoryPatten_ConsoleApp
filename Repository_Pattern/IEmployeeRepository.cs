﻿// IEmployeeRepository interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;

namespace Repository_Pattern
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
    }
}
