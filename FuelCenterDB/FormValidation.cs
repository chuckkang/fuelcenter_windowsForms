using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace FuelCenterDB
{
    internal class FormValidation
    {
        // Set validations so that a string value is only characters and numbers.
        // Set validations so that a value is only a currency.
        // set validations so that an int is an number
        // implement these items using globalization, conversion and showing how that will affect the result.

        //Validation for only characters and numbers
        protected internal string NotCurrencyMessage = "is not a numeric/currency value. \n Please re-enter a correct value.";
        protected internal bool IsOnlyLettersAndNumbers(string textvalue)
        {
            bool isValid = false;
            // check the value // this will check within the entire string but also checks characters
            
            if (Regex.IsMatch(textvalue, @"^[a-zA-Z0-9!@#$ %-'%&""]*$") ) 
                { isValid = true; }
            return isValid;

        }
        protected internal bool IsOnlyLetters(string strValue)
        {
            bool isValid = true;
            foreach (char c in strValue)
            {
                if (!char.IsLetter(c) &&  !char.IsWhiteSpace(c))
                {
                    return false;

                    //break;
                }
                
            }

            return isValid;

        }

        protected internal bool IsCurrency (string strValue, out decimal newdecimal)
        {
            // checks input to see if the value is a proper format for currency.
            // IN THIS CASE IT WILL ALSO ROUND TO THE NEXT NUMBER.

            bool isValid = false;
            string strTrimmed = string.Format("{0:C}", strValue.Trim()) ;
            if (decimal.TryParse(strTrimmed, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"),  out newdecimal))
            {
                newdecimal = Math.Round(newdecimal, 3);
                isValid = true;
            }

            return isValid;
        }
        protected internal bool IsDecimal(string txtValue, out decimal newdecimal)
        {
            // this will round to the 3rd digit right of the decimal.

            bool isValidDecimal = false;

            // checked only throws an exception since a narrowing may not throw an exception.
            if (decimal.TryParse(txtValue.Trim(), out newdecimal))
                 {
                newdecimal = Math.Round(newdecimal, 3);
                isValidDecimal = true;
                }
            return isValidDecimal;
            // check to make sure it is an int
        }
        protected internal bool IsInt(string txtValue)
        {
            int intValue = 0;
            bool isValidInt = false;

            // checked only throws an exception since a narrowing may not throw an exception.
            try
            {
                intValue = int.Parse(txtValue);
                isValidInt = true;
            }
            catch
            {

                isValidInt = false;
            }
            

            return isValidInt;
            // check to make sure it is an int
        }
        //Clean string inputs
        protected internal string CleanTextEntries(string strInput)
        {
            // this will clean the input for a text box.  
            // It willl remove trailing spaces and....

            string cleaned = "";
            cleaned = strInput.Trim();
            return cleaned;
            //return cleaned;
        }

        protected internal static string ReplaceApostrophe(string strValue)
        { // This is for the the apostrophe that can occur within a sql statement, primarily from values 
            string newValue = "";
                if (strValue.Contains("'"))
                    { newValue = strValue.Replace("'", "''"); }
                else
                     { newValue = strValue; }
            return newValue;
        }

        protected internal static string RemoveApostrophe(string strValue)
        {
            string newValue = "";
            if (strValue.Contains("'"))
            { newValue = strValue.Replace("'", "''"); }

            return newValue;
        }
    }
}
