using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new UserAlreadyLoggedInException(" This is a custom exception");
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {
        }
        public UserAlreadyLoggedInException(string message)
            : base(message)
        { 
        
        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { 
        
        }


    }

}
