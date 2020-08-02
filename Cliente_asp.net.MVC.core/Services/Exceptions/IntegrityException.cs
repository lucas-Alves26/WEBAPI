using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Services.Exceptions
{
    public class IntegrityException: ApplicationException
    {
 
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
