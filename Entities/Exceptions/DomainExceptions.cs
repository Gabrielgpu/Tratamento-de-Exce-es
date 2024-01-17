using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_8.Entities.Exceptions
{
    public class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message) {

        }
    }
}