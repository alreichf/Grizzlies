using System;
using System.Runtime.Serialization;

namespace SilverBear.WebMVC.Exceptions
{
    [Serializable]
    public class ConfigNotFoundException : Exception
    {
        public ConfigNotFoundException()
        {

        }

        public ConfigNotFoundException(string message) : base(message)
        {

        }

        public ConfigNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected ConfigNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
