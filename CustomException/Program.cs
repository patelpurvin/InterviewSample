using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new UserAlreadyLoggedInException("Uesr is loged in");
        }
    }
}
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
        
}