using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RepositoryFactory class

namespace Repository_Pattern
{
    public static class RepositoryFactory
    {
        public static TRepository Create<TRepository>(ContextTypes ctype) where TRepository : class
        {
            if (typeof(TRepository) == typeof(IEmployeeRepository))
            {
                return new EmployeeXMLRepository() as TRepository;
            }
            return null;
        }
    }
}

