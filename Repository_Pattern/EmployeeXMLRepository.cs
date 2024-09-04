// EmployeeXMLRepository class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;
using Repository_Source;

namespace Repository_Pattern
{
    public class EmployeeXMLRepository : XMLRepositoryBase<XMLSet<Employee>, Employee, int>, IEmployeeRepository
    {
        public EmployeeXMLRepository() : base("EmployeeInformation.xml")
        {
        }
    }
}
