using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.UserException
{
    internal class NullReferenceException:ApplicationException
    {
        public NullReferenceException() { }
        public NullReferenceException(string message):base(message) { }
    }
}
