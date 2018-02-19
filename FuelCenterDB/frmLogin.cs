using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FuelCenterDB;


namespace FuelCenterDB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // verify that all fields are filled in:
            if (username == "" || password == "")
            {
                if (username == string.Empty)
                {
                    txtUserName.Focus();
                }
                else if (password == string.Empty)
                {
                    txtPassword.Focus();
                }
                DisplayErrorMessage(1); // these int arguments will point to a specific message:  if you need a specific message, add to this method.
            }
            else
            {
                
                UserCredentialsDB verifyLogin = new UserCredentialsDB();

                // create the class that will be populated if the username, password has been found.
                UserData userData = new UserData();

                userData = verifyLogin.VerifyUserNamePassword(username, password);
                if (userData.UserId == 0)
                {  // Show any system errors first since DB connectino is required before any authentication.
                    DisplayErrorMessage(2); 
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    if (userData.UserId > 0)
                    {
                      
                        this.Hide();
                        frmMain frmMain = new frmMain();
                        frmMain.ShowDialog();
                        this.Close();
                    }

                }
                
            }
        }
        
        private string DisplayErrorMessage(int messageNumber)
        {
            //changes text color and sets the text.
            // programmer will have to add all the error messages here and select the correct integer to display the appropriate message
            string errMessage = "";
            switch (messageNumber)
            {
                case 1:
                    errMessage = "Please Enter A Username and Password.\n";
                    break;

                case 2:
                    errMessage = "User Not Found.\n Please re-reenter your User Name and Password.\n";
                    break;
            }

            SetErrorMessageLabel(errMessage);
            return errMessage;
        }

        private string DisplayErrorMessage(string errMessage) //overloaded method to display a specific ErrorMessage 
        {
            SetErrorMessageLabel(errMessage);
            return errMessage;
        }


        private void SetErrorMessageLabel(string errMessage)
        {
            lblInstructions.ForeColor = Color.Red;
            lblInstructions.Text = errMessage;
        }


    }
}
