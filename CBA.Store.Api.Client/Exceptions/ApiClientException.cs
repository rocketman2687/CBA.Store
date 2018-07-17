using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA.Store.Api.Client.Exceptions
{
    public class ApiClientException : Exception
    {
        public ApiClientException(string message) : base(message)
        {
        }

        public ApiClientException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
