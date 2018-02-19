using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace FuelCenterDB
{
    // This is an example to create a Error Class:
    // This class should be implemented into almost all classes that might throw an error.
    // Might want to log this into the database or into the system logs.
    // It should contain all our error messages.
    // HOWEVER, THIS CLASS WILL ALWAYS RETURN THE INNER MOST EXCEPTION FIRST.

    public class Exceptions : Exception
    {   
        // these properties are get since you just want to return values from the Exception.
        //  You won't be able to set them.

        public string ErrorType { get; }
        public string ErrorMessage { get;}
        public string ClassName { get;} // haven't figured out which class is throwing the error
        public string AdditionalMessage { get; }
        public string ErrorValue { get; private set; }
        public List<Exception> ExceptionList { get; }
        public Exceptions()
        {
            ErrorType = string.Empty;
            ErrorMessage = string.Empty;
            ClassName = string.Empty;
            AdditionalMessage = string.Empty;
            ExceptionList = new List<Exception>();


        }

        public Exceptions(Exception ex) : base()
        {
            
            List<Exception> listException = new List<Exception>();
            ExceptionList = GetExceptionsList(ex, ref listException);

            //int listCounter = 0;
            if (ExceptionList.Count > 0)
            {
                
                ErrorType = ExceptionList[ExceptionList.Count-1].GetType().ToString();
                ErrorMessage = ExceptionList[ExceptionList.Count - 1].Message.ToString();
                ClassName = ExceptionList[ExceptionList.Count - 1].TargetSite.ToString();
                AdditionalMessage = ExceptionList[ExceptionList.Count - 1].StackTrace.ToString();
                
            }



        }

        private List<Exception> GetExceptionsList(Exception ex, ref List<Exception> list)
        {
            //List<Exception> getExceptionList = list;
            list.Add(ex);
            if (ex.InnerException != null)
            {
                
                list = GetExceptionsList(ex.InnerException, ref list);
                
            }
            return list;
        }




        
    }
}
