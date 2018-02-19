using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FuelCenterDB
{
    class ControlErrorCheck
    {
        //ContolErrorCheck:
        // Class to determine whether or not a control has been completed.
        // Upon instantiation of class with a control parameter, you may check the Messages property to see if there was an error.
        // Upon instantiation of emppty class, you can use the isEmpty method to determine if the control text is empty.
        protected internal string Message { get; set; }
        protected internal bool IsValid { get; set; }

        public ControlErrorCheck()
        {
            Message = "";
            IsValid = false;
        }
        public ControlErrorCheck(Control input) : base()
        {
            //bool isvalid = false;
            if (input is TextBox)
            {
                TextBox txtInput = (TextBox)input;
                IsValid = IsComplete(txtInput);
                
            }
            else if (input is ComboBox)
            {
                ComboBox cmbInput = (ComboBox)input;
                IsValid = IsComplete(cmbInput);
            }
        }

        protected internal bool IsComplete(Control input)
        {
            bool isValid = false;
            if (input.Text.Trim() == "")
                Message = "Please enter a value for the " + ReturnControlNameForDisplay(input);
            else { Message = ""; isValid = true; IsValid = true; }

            return isValid;
        }

        public static string ReturnControlNameForDisplay(Control objControl)
        {
            // ReturnControlNameForDisplay: method returns a string used for display of name of control
            // primarily used for displaying a user message about a particular control
            string textBoxName = "";
            //lblResults2.Text = objControl.Name + "ASDFADSFASDF\n";
            if (objControl.Name == "txtUnleaded")
            { textBoxName = "Unleaded - Sold Amount"; }
            else if (objControl.Name == "txtPriceUnleaded")
            { textBoxName = "Unleaded - Price"; }
            else if (objControl.Name == "txtTotalDollarsUnleaded")
            { textBoxName = "Unleaded - Total Dollars"; }
            else if (objControl.Name == "txtCostUnleaded")
            { textBoxName = "Unleaded - Cost Of Gas"; }
            else if (objControl.Name == "txtPlus")
            { textBoxName = "Plus - Sold Amount"; }
            else if (objControl.Name == "txtPricePlus")
            { textBoxName = "Plus - Price"; }
            else if (objControl.Name == "txtTotalDollarsPlus")
            { textBoxName = "Plus - Total Dollars"; }
            else if (objControl.Name == "txtCostPlus")
            { textBoxName = "Plus - Cost Of Gas"; }
            else if (objControl.Name == "txtPremium")
            { textBoxName = "Premium - Sold Amount"; }
            else if (objControl.Name == "txtPricePremium")
            { textBoxName = "Premium - Price"; }
            else if (objControl.Name == "txtTotalDollarsPremium")
            { textBoxName = "Premium - Total Dollars"; }
            else if (objControl.Name == "txtCostPremium")
            { textBoxName = "Premium - Cost Of Gas"; }
            //******************************SalesDept Panel***************************
            else if (objControl.Name == "ddDepartment")
            { textBoxName = "Department"; }
            else if (objControl.Name == "ddQuantity")
            { textBoxName = "Quantity"; }
            else if (objControl.Name == "txtDeptSoldAmount")
            { textBoxName = "Dollar Amount"; }
            //******************************ExpensesTab***************************
            else if (objControl.Name == "cmbExpensesType")
            { textBoxName = "ExpenseType"; }
            else if (objControl.Name == "cmbVendor")
            { textBoxName = "Vendor"; }
            else if (objControl.Name == "txtExpenseAmount")
            { textBoxName = "Expense Amount"; }
            else if (objControl.Name == "cmbUserList")
            { textBoxName = "User"; }
            else if (objControl.Name == "cmbTenderType")
            { textBoxName = "Tender Type"; }
            else if (objControl.Name == "txtCheckNo")
            { textBoxName = "Check No"; }
            else if (objControl.Name == "txtCheckNotes")
            { textBoxName = "Check Notes"; }
            else if (objControl.Name == "txtDescription")
            { textBoxName = "Description"; }


            return textBoxName;
        }

        
    }
}
