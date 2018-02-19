using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using FuelCenterDB;
using System.Diagnostics;
namespace FuelCenterDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //************************* Properties ***************************
        //then update this flag so that a db commit will occur.
        // if the text boxes have changed after they have been loaded
        // an event occurs to change hasDataChanged to true.  

        private bool hasDataChanged { get; set; }
        private int SalesDateId { get; set; }
        private DateTime SalesDate { get; set; }
        private DataTable dt = new DataTable();

        //ExpensesDadtaLists:  Used as a list for comboboxes but can get key/value when necessary. Dataset will include:
        private DataSet ExpensesDataLists = new DataSet();
        private DataSet dsExpensesGrid = new DataSet(); // this is for use with the Expenses DataGrid


        private void Main_Load(object sender, EventArgs e)
        {
            //  this should set up the default date for the time picker
            //dtBusinessDate.Value = new DateTime(2011, 12, 05);
            lblGasSalesErrorMessage.Text = string.Empty;
            lblErrorMessage.Text = string.Empty;

            // set current date
            SetDefaultSalesDateAndIdTimePicker();
            GetExpensesDataLists(); // this will retrieve all lists for the combo boxes and set up the class variable dataset
                                    // pre populate data for pull down menus

            PopulateControls();

            ((Control)tbDailyLog.TabPages[2]).Enabled = false;
            PopulateGasSalesForm();
            PopulateDepartmentSalesData();


            //PopulateExpenseTypeComboBox();

        }

        private void dtBusinessDate_ValueChanged(object sender, EventArgs e)
        {
            // update the text boxes for all panels
            // This will update the gas sales panel, Department sales and expenses all at once.
            //
            // Verify that the date is valid before doing any checking.
            // for this instance we will only allow for days that have records in teh fuelDB.
            // 6/14/2005-2/28/2015 #06/14/2005# && dtBusinessDate.Value <= '02/28/2015'

            DateTime startdate = Convert.ToDateTime("06/14/2005");
            DateTime enddate = Convert.ToDateTime("02/05/2015");
            //Reset error messages
            ResetAllErrorMessage(); // remove any old error messages

            if (dtBusinessDate.Value >= startdate && dtBusinessDate.Value <= enddate)
            {     // get salesID and set the 'global' variable so that is accessible for the entire form.
                BusinessDate businessDate = new BusinessDate(dtBusinessDate.Value);
                SalesDateId = businessDate.SalesDateID;
                SalesDate = (DateTime)businessDate.SalesDate;

                // Need to update the data by the date picked from time picker.
                PopulateGasSalesForm();
                PopulateDepartmentSalesData();
                PopulateExpensesGrid();
            }

            else
            {  // Show error message 
                DisplayDatePickerErrorMessage("Please select a date between " + startdate.ToShortDateString() + " and " + enddate.ToShortDateString() + ".");
            }
        }

        private bool UpdateRegisterTotals()
        {
            bool updatesuccessful = false;

            return updatesuccessful;
        }

        //****************************Daily Sales Department Panel*****************************************************

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // error checking
            bool isValid = false;
            // Clean values
            CleanTextBoxValues(txtDeptSoldAmount);
            ResetAllErrorMessage();
            isValid = ValidateDeptSalesEntry();

            //DataGridViewRow row = new DataGridViewRow();
            //row.Cells[0].Value = "XYZ";
            //row.Cells[1].Value = 50.2;


            if (isValid == true)
            {
                // update the list view box
                // only update if the sales department has not already been included.
                DataTable dt = dgSalesDept.DataSource as DataTable;
                DataRow[] arrSearch = dt.Select("SalesDept = '" + ddDepartment.Text + "'");
                for (int x = 0; x < dt.Columns.Count; x++)
                {
                    lblResults2.Text += "Column-" + dt.Columns[x].ColumnName + "-" + dt.Columns[x].GetType() + "\n";
                }
                //Create the new row
                FormValidation validate = new FormValidation();
                decimal newdecimal;
                // add new value to the datatable:
                // verify that the table does not already have the same department.
                if (arrSearch.Length == 0)
                {
                    lblResults2.Text += "---upper\n";
                    DataRow dr = dt.NewRow();

                    dr[0] = ddDepartment.Text;
                    lblResults2.Text += dr[0].ToString() + "---upper\n";
                    dr[1] = ddQuantity.Text;
                    lblResults2.Text += dr[1].ToString() + "---upper\n";
                    validate.IsCurrency(txtDeptSoldAmount.Text, out newdecimal);
                    dr[2] = newdecimal;
                    dr[3] = GetSalesDeptIDByName(ddDepartment.Text.Trim());
                    lblResults2.Text += dr[3].ToString() + "---upper\n";
                    dr[4] = SalesDateId;
                    lblResults2.Text += dr[4].ToString() + "---upper\n";

                    //int count = dgSalesDept.Rows.Add(); // the add method will return the index of the row that was just created.

                    dt.Rows.Add(dr);
                    ResetSalesDeptEntry();
                }
                else
                {
                    // this department already exists -- errMessage

                    DisplayErrorMessage(lblDeptSalesErrorMessage, ControlErrorCheck.ReturnControlNameForDisplay(ddDepartment) +
                        " already exists for this date. \n Please enter data for a " +
                        "different day or delete the row below and re-enter this data.");
                    SetTextBoxFocusForError(lblSalesDepartment);

                    //lblResults2.Text += arrSearch.Length.ToString() + "--asdf-upper\n";
                }

            }


        }

        private int GetSalesDeptIDByName(string deptName)
        {
            int deptId;
            SalesDepartmentData dept = new SalesDepartmentData();
            deptId = dept.GetDeptIDByName(deptName);
            return deptId;
        }

        private bool ValidateDeptSalesEntry()
        {
            bool isValid = false;
            if (ddDepartment.Text == "" || ddQuantity.Text == "" || txtDeptSoldAmount.Text == "")
            {
                if (ddDepartment.Text == "")
                {
                    DisplayErrorMessage(lblDeptSalesErrorMessage, "Please select a Sales Department.");
                    SetTextBoxFocusForError(ddDepartment);
                }
                else if (ddQuantity.Text == "")
                {
                    DisplayErrorMessage(lblDeptSalesErrorMessage, "Please select the total Quantity sold.");
                    SetTextBoxFocusForError(ddQuantity);
                }
                else if (txtDeptSoldAmount.Text == "")
                {
                    DisplayErrorMessage(lblDeptSalesErrorMessage, "Please complete the Total Dollar Amount box.");
                    SetTextBoxFocusForError(txtDeptSoldAmount);
                }
            }
            else
            {
                FormValidation validate = new FormValidation();
                decimal cleaneddecimal;
                if (!validate.IsInt(ddQuantity.Text) || ddQuantity.Text == "0")
                {
                    DisplayErrorMessage(lblDeptSalesErrorMessage, "Please enter the total for the\n Quantity box.");
                    SetTextBoxFocusForError(ddQuantity);

                }
                else if (!validate.IsCurrency(txtDeptSoldAmount.Text, out cleaneddecimal))
                {
                    DisplayErrorMessage(lblDeptSalesErrorMessage, "Please enter only currency in the\n Dollar Amount box.");
                    SetTextBoxFocusForError(txtDeptSoldAmount);

                }
                else
                {
                    txtDeptSoldAmount.Text = String.Format("{0:C2}", Math.Round(cleaneddecimal, 2));
                    isValid = true;
                }
            }


            return isValid;
        }

        private void ResetSalesDeptEntry()
        {
            ddDepartment.SelectedIndex = -1;
            ddQuantity.Text = "";
            txtDeptSoldAmount.Text = "";
            ddDepartment.Focus();

        }
        //*******************************Expenses List Tab ********************************************************
        //btnAddExpense:  Verify that entries are valid and then submits value
        // question? - is it better to update immediately or use a disconnected record set.
        // if it's better to use a disconnected recordset, then maybe everytime they navigate AWAY from the tab, that it automatically saves.



        private void ResetExpensesForm()
        {
            cmbExpensesType.Text = "";
            cmbVendor.Text = "";
            txtExpenseAmount.Text = "";
            cmbUserList.Text = "";
            cmbTenderType.Text = "";
            txtCheckNo.Text = "";
            chkCleared.Checked = false;
            txtCheckNotes.Text = "";
            txtDescription.Text = "";
        }

        private void AddToExpenseDataGrid()
        {
            DataRow newExpenseRow = dsExpensesGrid.Tables["ExpensesDataList"].NewRow();
            AddToExpensesDataRow(newExpenseRow); // this will add the new row to the dataset

            ExpensesDataDB updateExpensesList = new ExpensesDataDB();
            int rowsCounted = 0;
            //DisplayTestTablesAndRows(dsExpensesGrid.Tables["ExpensesDataList"]);
            //DisplayTestTablesAndRows(ExpensesDataLists.Tables["UserName"]);
            rowsCounted = updateExpensesList.UpdateExpenseDataGridList(dsExpensesGrid.Tables["ExpensesDataList"]);
            //if (updateExpensesList.ErrorMessage.ErrorMessage == "" || updateExpensesList.ErrorMessage.ErrorMessage == null)
            //{
            //ResetAllErrorMessage();
            //ResetExpensesForm();
            //cmbVendor.Focus();
            //}
            //else
            //{ DisplayErrorMessage(lblErrorMessage3, "An error occurred. " + updateExpensesList.ErrorMessage.ErrorMessage); }
        }

        private void AddToExpensesDataRow(DataRow newRow)
        {
            newRow["ExpenseTypeId"] = LookUpExpenseTypeId(cmbExpensesType.Text.Trim() + "");
            newRow["ExpenseType"] = cmbExpensesType.Text.Trim() + "";
            newRow["VendorId"] = LookUpVendorId(cmbVendor.Text.Trim() + "");
            newRow["VendorName"] = cmbVendor.Text.Trim() + "";
            newRow["Description"] = txtDescription.Text.Trim() + "";
            newRow["Amount"] = Convert.ToDecimal(txtExpenseAmount.Text) + "";
            newRow["UserId"] = LookUpUserId(cmbUserList.Text.Trim() + "");
            newRow["FullName"] = cmbUserList.Text + "";
            newRow["TenderTypeId"] = LookupTenderTypeId(cmbTenderType.Text.Trim() + "");
            newRow["TenderType"] = cmbTenderType.Text.Trim() + "";
            newRow["DateId"] = SalesDateId;
            newRow["SalesDate"] = SalesDate;
            newRow["Cleared"] = chkCleared.Checked + "";
            newRow["CheckNo"] = txtCheckNo.Text.Trim() + "";
            newRow["CheckNotes"] = txtCheckNotes.Text.Trim() + "";
            dsExpensesGrid.Tables["ExpensesDataList"].Rows.Add(newRow); // this dataset is set at the global level.
            dgExpensesList.Refresh();

        }
        //RequiredEntriesComplete:  Accepts a list of controls-mostly text and combos that are required for complettion.
        // Returns false if one is empty and ends loop and sets focus on the required box.



        //******************************* General Functions **************************
        // not sure if these methods should go somewhere else.
        // these methods will return ids from a disconnected dataset at main_load.  Therefore it does not necessarily need db connection
        // and seem to un nessary with the Expenses Data Class.
        private int LookUpUserId(string UserName)
        {
            int userId = 0;
            DataRow[] filteredRows = ExpensesDataLists.Tables["UserName"].Select("FullName LIKE '%" + UserName + "%'");
            if (filteredRows.Length == 1)
                userId = (int)filteredRows[0]["UserId"];
            //for(int x= 0; x < filteredRows.Length; x++)
            //{
            //    DisplayTestMessage(lblErrorMessage3, filteredRows[x]["FullName"].ToString() + "-asdf");
            //}

            return userId;
        }

        private int LookUpExpenseTypeId(string expenseType)
        {
            int expenseTypeId = 0;
            DataRow[] filteredRows = ExpensesDataLists.Tables["ExpenseType"].Select("ExpenseType LIKE '%" +
                    FormValidation.ReplaceApostrophe(expenseType) + "%'"); // need to change the apostrophes in sql strings
            if (filteredRows.Length == 1)
                expenseTypeId = (int)filteredRows[0]["ExpensesTypeId"];
            return expenseTypeId;
        }

        private int LookUpVendorId(string vendorName)
        {
            int vendorId = 0;
            string sqlSearch = "VendorName LIKE '%" + FormValidation.ReplaceApostrophe(vendorName) + "%'";
            DataRow[] filteredRows = ExpensesDataLists.Tables["Vendor"].Select(sqlSearch);
            MessageBox.Show(FormValidation.ReplaceApostrophe(vendorName) + "\n" + "sqlSearch = " + sqlSearch + "\n");
            if (filteredRows.Length == 1)
                vendorId = (int)filteredRows[0]["VendorId"];

            //DisplayErrorMessage(lblErrorMessage3, "--VendorID\n" + 
            //filteredRows[0][0].ToString() + "\n");
            return vendorId;
        }

        private int LookupTenderTypeId(string tender)
        {
            int tenderTypeId = 0;
            DataRow[] filteredRows = ExpensesDataLists.Tables["TenderType"].Select("TenderType LIKE '%" +
                FormValidation.ReplaceApostrophe(tender) + "%'");
            if (filteredRows.Length == 1)
                tenderTypeId = (int)filteredRows[0]["TenderTypeId"];
            //DisplayErrorMessage(lblErrorMessage3, "\n" + filteredRows[0][0].ToString() + "- TenderTypeasdfasdf\n");
            return tenderTypeId;
        }

        //*******************************OnChanged Events for Text Boxes**************************
        // If anything changes in the textboxes after the values have been inputted by the DB
        // then set a flag so that when teh NEXT button is pressed, it will commit the changes to the DB.
        private void txtUnleaded_TextChanged(object sender, EventArgs e)
        {
            hasDataChanged = true;
        }

        //****************************************************************************************

        private void PopulateControls()
        {
            // Populate sales department box on SOTG panel.
            Dictionary<int, string> salesDept = new Dictionary<int, string>();
            PopulateControls loadControls = new PopulateControls();

            // load Sales Department Panel
            PopulateSalesDepartmentDropDown(loadControls.GetSalesDeptList());
            PopulateQuantityBox();

            //Load Expenses Tab
            //LookUpUserId("Chuck");
            PopulateExpensesDropDownAll();

        }

        // get one dataset using one call to db for combobox population
        // this will populate the 'global' variable so that you can access data within the set at any time.
        // 


        private bool PopulateGasSalesForm()
        {
            //  PopulateGasSalesForm():  
            //  Populating this form should occur on_load, when salesdate has changed, 
            bool updateCompleted = true;
            // Retrieves an ArrayList of FuelData objs then will cycle through them to update the text boxes.
            ArrayList arrGasSales = new ArrayList();
            GasSalesDB getGasSales = new GasSalesDB();
            arrGasSales = getGasSales.GetGasSalesByDateId(SalesDateId);

            if (arrGasSales != null)
            // only update the form if there are any no errors.
            {
                foreach (var fueldataitem in arrGasSales)
                {
                    FuelData fdGasSales = (FuelData)fueldataitem;
                    //lblResults.Text += fdGasSales.ReturnFuelDataClass() + "\n";
                    if (fdGasSales.FuelType == 1)
                    { // udpate the unleaded box
                        txtUnleaded.Text = fdGasSales.SoldAmount.ToString();
                        txtPriceUnleaded.Text = String.Format("{0:C3}", fdGasSales.Price);
                        txtTotalDollarsUnleaded.Text = String.Format("{0:C3}", fdGasSales.DollarAmount);
                        txtCostUnleaded.Text = String.Format("{0:C3}", fdGasSales.CostOfGas);
                    }
                    else if (fdGasSales.FuelType == 3)
                    { // udpate all the plus text boxes
                      //txtPlus.Text = fdGasSales.SoldAmount.ToString();
                        txtPlus.Text = fdGasSales.SoldAmount.ToString();
                        txtPricePlus.Text = String.Format("{0:C3}", fdGasSales.Price);
                        txtTotalDollarsPlus.Text = String.Format("{0:C3}", fdGasSales.DollarAmount);
                        txtCostPlus.Text = String.Format("{0:C3}", fdGasSales.CostOfGas);
                    }
                    else if (fdGasSales.FuelType == 2)
                    {

                        //txtPlus.Text = fdGasSales.SoldAmount.ToString();
                        txtPremium.Text = fdGasSales.SoldAmount.ToString();
                        txtPricePremium.Text = String.Format("{0:C3}", fdGasSales.Price);
                        txtTotalDollarsPremium.Text = String.Format("{0:C3}", fdGasSales.DollarAmount);
                        txtCostPremium.Text = String.Format("{0:C3}", fdGasSales.CostOfGas);
                    }
                }
            }
            else
            {
                DisplayErrorMessage(lblGasSalesErrorMessage, getGasSales.ExceptionsMessages.Message);
            }
            hasDataChanged = false; // delete flag that indicates taht the data has changed.
            return updateCompleted;
        }

        private void PopulateDepartmentSalesData()
        {
            // load the datagrid with data
            BindingSource bind = new BindingSource();

            SalesDepartmentData sdData = new SalesDepartmentData();
            dt = sdData.GetDepartmentSalesDataByDateID(SalesDateId);

            dgSalesDept.AutoGenerateColumns = false;

            // In the properties window, create a collection of headers and edit their name..
            // then set the named column[nameofcolumn] to the 
            // datapropertyname, which is the 'header' of the datatable that was loaded with the data.
            // 
            dgSalesDept.Columns["hdrSalesDateId"].DataPropertyName = "DateId";
            dgSalesDept.Columns["hdrSalesDeptId"].DataPropertyName = "SalesDeptId";
            dgSalesDept.Columns["hdrSalesDept"].DataPropertyName = "SalesDept";
            dgSalesDept.Columns["hdrQuantity"].DataPropertyName = "SalesCount";
            dgSalesDept.Columns["hdrTotal"].DataPropertyName = "Amount";
            //bind.DataSource = dt;
            dgSalesDept.DataSource = dt;


            //dgSalesDept.
        }

        private void PopulateSalesDepartmentDropDown(Dictionary<int, string> salesdept)
        {
            ddDepartment.ValueMember = "Key";
            ddDepartment.DisplayMember = "Value";
            ddDepartment.DataSource = new BindingSource(salesdept, null);
        }

        private void GetExpensesDataLists()
        {
            PopulateControls populateDataSet = new FuelCenterDB.PopulateControls();
            ExpensesDataLists = populateDataSet.GetExpenseListsAll();
        }

        private void PopulateExpensesDropDownAll()
        {
            //PopulateExpenseType();
            //PopulateUserList();
            //PopulateVendorName();

            //Populate comboboxes
            PopulateExpenseTypeComboBox();
            PopulateUserListCombo();
            PopulateVendorCombo();
            PopulateTenderTypeCombo();

            // populate Expenses 
            PopulateExpensesGrid(); // this is for teh datagrid
        }

        private void PopulateExpenseTypeComboBox()
        {

            cmbExpensesType.DataSource = ExpensesDataLists.Tables["ExpenseType"];
            cmbExpensesType.ValueMember = "ExpensesTypeId";
            cmbExpensesType.DisplayMember = "ExpenseType";
        }

        private void PopulateUserListCombo()
        {
            cmbUserList.DataSource = ExpensesDataLists.Tables["UserName"];
            cmbUserList.ValueMember = "UserID";
            cmbUserList.DisplayMember = "FirstName";
        }

        private void PopulateTenderTypeCombo()
        {
            cmbTenderType.DataSource = ExpensesDataLists.Tables["TenderType"];
            cmbTenderType.ValueMember = "TenderTypeId";
            cmbTenderType.DisplayMember = "TenderType";
        }

        private void PopulateVendorCombo()
        {
            cmbVendor.DataSource = ExpensesDataLists.Tables["Vendor"];
            cmbVendor.ValueMember = "VendorId";
            cmbVendor.DisplayMember = "VendorName";
        }


        private void PopulateExpensesGrid()
        {
            // populate the Expenses List
            ExpensesData expensesList = new FuelCenterDB.ExpensesData();
            dsExpensesGrid = expensesList.GetExpensesListByDate(SalesDateId);
            dgExpensesList.AutoGenerateColumns = false;
            dgExpensesList.Columns["hdrExpensesId"].DataPropertyName = "ExpensesId";
            dgExpensesList.Columns["hdrExpenseTypeId"].DataPropertyName = "ExpenseTypeId";
            dgExpensesList.Columns["hdrExpenseType"].DataPropertyName = "ExpenseType";
            dgExpensesList.Columns["hdrVendorId"].DataPropertyName = "VendorId";
            dgExpensesList.Columns["hdrVendorName"].DataPropertyName = "VendorName";
            dgExpensesList.Columns["hdrDescription"].DataPropertyName = "Description";
            dgExpensesList.Columns["hdrAmount"].DataPropertyName = "Amount";
            dgExpensesList.Columns["hdrUserId"].DataPropertyName = "UserId";
            dgExpensesList.Columns["hdrUser"].DataPropertyName = "FullName";
            dgExpensesList.Columns["hdrTenderType"].DataPropertyName = "TenderType";
            dgExpensesList.Columns["hdrTenderTypeId"].DataPropertyName = "TenderTypeId";
            dgExpensesList.Columns["hdrDateId"].DataPropertyName = "DateId";
            dgExpensesList.Columns["hdrSalesDate"].DataPropertyName = "SalesDate";
            dgExpensesList.Columns["hdrCleared"].DataPropertyName = "Cleared";
            dgExpensesList.Columns["hdrCheckNo"].DataPropertyName = "CheckNo";
            dgExpensesList.Columns["hdrCheckNotes"].DataPropertyName = "CheckNotes";
            dgExpensesList.DataSource = dsExpensesGrid.Tables["ExpensesDataList"];
        }

        private void PopulateQuantityBox()
        {
            // this will load the quantity combo box.  0-1000

            List<int> integerList = new List<int>();

            for (int x = 0; x < 1001; x++)
            {
                integerList.Add(x);
                //lblResults2.Text += integerList[x].ToString();
            }
            ddQuantity.DataSource = integerList;

        }

        // *******************************File Menu Navigation ********************************
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dailyLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open daily ledger
        }

        private void tpExpenses_Click(object sender, EventArgs e)
        {

        }
        //******************************** Navigation  ****************************************

        private void btnNext1_Click(object sender, EventArgs e)
        {
            // one they click the button, check for changed items, check for correct input validation, then commit changes.
            // user should be allowed to go forward if there are any changes.  Show a message box to confirm this.
            bool isFormValid = false;
            // Need to include error checking
            if (hasDataChanged == true)
            {

                ResetAllErrorMessage();  // reset any error messages

                isFormValid = ValidateGasSales();
                hasDataChanged = false; // reset the data changed flag
                if (isFormValid == true)
                {
                    // commit changes to database
                    // get salesid
                    ArrayList arrFueldata = new ArrayList();
                    //int fuelType, decimal price, int NumberOfUnits, decimal soldamount, decimal dollaramount, decimal costofga
                    arrFueldata.Add(new FuelData(1, decimal.Parse(txtPriceUnleaded.Text), 1, decimal.Parse(txtUnleaded.Text),
                        decimal.Parse(txtTotalDollarsUnleaded.Text), decimal.Parse(txtCostUnleaded.Text)));
                    //arrFueldata.Add(new FuelData(1, 123.45m, 1, 123.78m, 123.98m, 123.32m));

                    arrFueldata.Add(new FuelData(2, decimal.Parse(txtPricePremium.Text), 1, decimal.Parse(txtPremium.Text),
                        decimal.Parse(txtTotalDollarsPremium.Text), decimal.Parse(txtCostPremium.Text)));
                    arrFueldata.Add(new FuelData(3, decimal.Parse(txtPricePlus.Text), 1, decimal.Parse(txtPlus.Text),
                        decimal.Parse(txtTotalDollarsPlus.Text), decimal.Parse(txtCostPlus.Text)));
                    // call update method.

                    GasSalesDB updateFuelData = new GasSalesDB();
                    BusinessDate salesDate = new BusinessDate(dtBusinessDate.Value);

                    updateFuelData.UpdateGasSalesChanges(arrFueldata, salesDate.SalesDateID);
                    if (updateFuelData.ExceptionsMessages.Message != "")
                    {
                        DisplayErrorMessage(lblGasSalesErrorMessage,
                             //updateFuelData.ExceptionsMessages.Message + "\n\n" +
                             updateFuelData.ExceptionsMessages.ErrorMessage + "\n\n" +
                              updateFuelData.ExceptionsMessages.ErrorType + "\n\n"
                            //updateFuelData.ExceptionsMessages.AdditionalMessage
                            );
                    }

                }
            }
            else
            { //pnlGasSales.Hide();
                pnlSOTG.Visible = true;
            }

            //pnlSOTG.Visible = true;
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            pnlSOTG.Visible = false;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {   // updates or inserts the Sales Department data.
            // update the dataabase
            // Create a list with all teh data from datagrid

            SalesDepartmentData salesdata = new FuelCenterDB.SalesDepartmentData();
            //int rows = 0;

            //for (int x = 0; x <= dt.columns.count - 1; x++)
            //{
            //    lblresults2.text += dt.columns[x].columnname;
            //}
            //rows = salesdata.insertsalesdatalistdb(dt, salesdata.dasql);

            //pnlregister.visible = true;
            Debug.Write("the btnNExt was clicked");
        }

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            //pnlRegister.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //pnlSOTG.Visible = false; pnlRegister.Visible = false;
        }

        //*****************************************Error ErrorMessage Functionality

        private void DisplayDatePickerErrorMessage(string errmessag)
        {
            lblErrorMessage.Visible = true;
            lblErrorMessage.ForeColor = System.Drawing.Color.Red;
        }

        private void DisplayErrorMessage(Label lblErr, string errMessage)
        {   // in the the label that will display the error message.

            lblErr.Visible = true;
            lblErr.ForeColor = System.Drawing.Color.Red;

            lblErr.Text = errMessage;


        }

        private void ResetAllErrorMessage()
        {
            lblErrorMessage.Text = "";
            lblGasSalesErrorMessage.Text = "";
            lblDeptSalesErrorMessage.Text = "";
            hasDataChanged = false;
        }

        // Test Methods to display information
        private void DisplayTestMessage(Label lbl, string message)
        {
            lbl.Text += message + "--\n";
        }

        private void DisplayTestTablesAndRows(DataTable data)
        {
            bool blnValue = false;

            for (int rows = 0; rows < data.Rows.Count; rows++)
            {
                for (int cols = 0; cols < data.Columns.Count; cols++)
                {
                    if (data.Rows[rows][cols] == null)
                    {
                        blnValue = true;
                    }
                    else { blnValue = false; }

                    lblErrorMessage3.Text += data.TableName + "--" + data.Columns[cols].ColumnName
                            + "--" + data.Rows[rows][cols] + "--VALUE" + blnValue + "\n";
                }
            }
            lblErrorMessage3.Text += "\n";
        }
        //******************************** Formatting/Display *********************************
        private void SetTextBoxFocusForError(Control objControl)
        { // this method will:
            // Clear text box and set focus
            if (objControl is TextBox)
            {
                (objControl as TextBox).Clear();
            }
            else if (objControl is ComboBox)
            {
                (objControl as ComboBox).SelectedIndex = -1;
            }

            objControl.Focus();

        }

        private void CleanTextBoxValues(TextBox objTextBox)
        {  // gets text box entry and returns a trimmed version.
            objTextBox.Text = objTextBox.Text.Trim();
        }


        private void SetDefaultSalesDateAndIdTimePicker()
        {
            //dtBusinessDate.Value = new DateTime();
            BusinessDate salesDate = new BusinessDate();
            SalesDate = dtBusinessDate.Value;
            SalesDateId = salesDate.GetSalesDateIDBySalesDate(SalesDate);
            //SalesDateID will return a -1 if the salesdate was not created or found.

            //MessageBox.Show(SalesDate.ToString() + "--*" + SalesDateId.ToString());
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            List<Control> controls = new List<Control>();
            controls.Add(cmbExpensesType);
            controls.Add(cmbVendor);
            controls.Add(txtExpenseAmount);
            controls.Add(cmbUserList);
            controls.Add(cmbTenderType);
            //controls.Add(txtCheckNo);
            //controls.Add(chkCleared);
            //controls.Add(txtCheckNotes);
            //controls.Add(txtDescription);
            isValid = RequiredEntriesComplete(controls); // RequiredEntriesComplete only checks for incomplete required items.
            FormValidation validate = new FormValidation();
            decimal newdecimal;
            //int newInt;
            DisplayTestMessage(lblErrorMessage3, "\n" + cmbTenderType.Text.ToLower().ToString());
            if (isValid)
            {
                if (validate.IsCurrency(txtExpenseAmount.Text, out newdecimal))
                {
                    txtExpenseAmount.Text = Convert.ToString(newdecimal);

                    // check if check no and check exist
                    if (cmbTenderType.Text.ToLower().Contains("check"))
                    {
                        if (validate.IsInt(txtCheckNo.Text))
                        {
                            // add to datagrid and db
                            AddToExpenseDataGrid();
                        }
                        else
                        {
                            DisplayErrorMessage(lblErrorMessage3, "Please enter a valid number for the Check Number.");
                            SetTextBoxFocusForError(txtCheckNo);
                        }
                    }
                    else if (!cmbExpensesType.Text.ToLower().Contains("check") && txtCheckNo.Text != "")
                    {
                        DisplayErrorMessage(lblErrorMessage3, "Please enter a valid checking account or delete the entry for Check Number.");
                        SetTextBoxFocusForError(txtCheckNo);
                    }
                    else if (!cmbExpensesType.Text.ToLower().Contains("check"))
                    {
                        AddToExpenseDataGrid();
                    }
                }
                else
                {
                    DisplayErrorMessage(lblErrorMessage3, "Please enter a valid number/currency for the Amount.");
                    SetTextBoxFocusForError(txtExpenseAmount);
                }
            }
        }
        // Double check that all there are no blank entries
        private List<TextBox> RequiredControlsForValidation()
        {
            // RequiredControlsForValidation():
            // Will return a list of all controls for Gas Sales Panel that require validation.
            // Be sure to add to this list when new controls are added.
            List<TextBox> tbList = new List<TextBox>();
            tbList.Add(txtUnleaded);
            tbList.Add(txtPriceUnleaded);
            tbList.Add(txtTotalDollarsUnleaded);
            tbList.Add(txtCostUnleaded);
            tbList.Add(txtPlus);
            tbList.Add(txtPricePlus);
            tbList.Add(txtTotalDollarsPlus);
            tbList.Add(txtCostPlus);
            tbList.Add(txtPremium);
            tbList.Add(txtPricePremium);
            tbList.Add(txtTotalDollarsPremium);
            tbList.Add(txtCostPremium);
            return tbList;
        }
        private bool ValidateGasSales()
        {
            bool isValid = true;
            decimal newDecimal;

            FormValidation verify = new FormValidation();
            List<TextBox> tbList = RequiredControlsForValidation();
            foreach (TextBox tb in tbList)
            {
                if (tb.Name.Contains("txtUnleaded") || tb.Name.Contains("txtPlus") || tb.Name.Contains("txtPremium"))
                { // this will only execute if the text boxes require only decimals
                    if (verify.IsDecimal(tb.Text.Trim(), out newDecimal))
                    {
                        CleanTextBoxValues(tb);
                        tb.Text = newDecimal.ToString();
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                else
                {
                    if (verify.IsCurrency(tb.Text.Trim(), out newDecimal))
                    {
                        // CleanTextBoxValues for this application will round to teh nearest 100th.
                        CleanTextBoxValues(tb);
                        tb.Text = newDecimal.ToString();
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                if (isValid == false)
                {
                    SetTextBoxFocusForError(tb);
                    DisplayErrorMessage(lblGasSalesErrorMessage,
                        "Please enter only numbers/currency for the \n" + ControlErrorCheck.ReturnControlNameForDisplay(tb) + " input box.");
                    break;
                }
            }
            return isValid;
        }

        private bool RequiredEntriesComplete(List<Control> listControl)
        {
            bool isValid = true;
            // check to see if all the textboxes/comboboxes have been completed.
            ControlErrorCheck errCheck = new ControlErrorCheck();
            foreach (Control x in listControl)
            {
                if (errCheck.IsComplete(x) == false)
                {
                    DisplayErrorMessage(lblErrorMessage3, errCheck.Message);
                    SetTextBoxFocusForError(x); // This will clear the text box and set focus
                    isValid = false;
                    break;
                }

            }
            return isValid;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
