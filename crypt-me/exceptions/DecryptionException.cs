using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptMe.exceptions
{
    public class DecryptionException : Exception
    {
        public DecryptionException(string message) : base(message)
        {
        }

        public DecryptionException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
