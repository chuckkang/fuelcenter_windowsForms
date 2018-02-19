namespace FuelCenterDB
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpExpenses = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dgExpensesList = new System.Windows.Forms.DataGridView();
            this.hdrExpensesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrDateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrSalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrVendorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrVendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrExpenseTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrTenderTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrTenderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrCheckNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrCleared = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hdrCheckNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkCleared = new System.Windows.Forms.CheckBox();
            this.txtCheckNotes = new System.Windows.Forms.TextBox();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.lblErrorMessage3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.cmbTenderType = new System.Windows.Forms.ComboBox();
            this.cmbExpensesType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.dtBusinessDate = new System.Windows.Forms.DateTimePicker();
            this.tbDailyLog = new System.Windows.Forms.TabControl();
            this.tpDailyLog = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSOTG = new System.Windows.Forms.Panel();
            this.dgSalesDept = new System.Windows.Forms.DataGridView();
            this.hdrSalesDeptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrSalesDateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrSalesDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeptSalesErrorMessage = new System.Windows.Forms.Label();
            this.lblSoldDollars = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSalesDepartment = new System.Windows.Forms.Label();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.txtDeptSoldAmount = new System.Windows.Forms.TextBox();
            this.ddQuantity = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ddDepartment = new System.Windows.Forms.ComboBox();
            this.btnPrevious2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.lblGasSoldTotal = new System.Windows.Forms.Label();
            this.lblUnleaded = new System.Windows.Forms.Label();
            this.lblPricePer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGallonsSold = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.txtUnleaded = new System.Windows.Forms.TextBox();
            this.txtPlus = new System.Windows.Forms.TextBox();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.grpGallonCost = new System.Windows.Forms.GroupBox();
            this.txtCostPremium = new System.Windows.Forms.TextBox();
            this.txtCostPlus = new System.Windows.Forms.TextBox();
            this.txtCostUnleaded = new System.Windows.Forms.TextBox();
            this.txtPriceUnleaded = new System.Windows.Forms.TextBox();
            this.txtPricePlus = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.txtPricePremium = new System.Windows.Forms.TextBox();
            this.txtTotalDollarsUnleaded = new System.Windows.Forms.TextBox();
            this.txtTotalDollarsPlus = new System.Windows.Forms.TextBox();
            this.txtTotalDollarsPremium = new System.Windows.Forms.TextBox();
            this.lblHorizontalRule = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalDollarsSold = new System.Windows.Forms.Label();
            this.lblTotalGallons = new System.Windows.Forms.Label();
            this.lblGasSalesErrorMessage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.tpExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpensesList)).BeginInit();
            this.tpReports.SuspendLayout();
            this.tbDailyLog.SuspendLayout();
            this.tpDailyLog.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSOTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesDept)).BeginInit();
            this.grpGallonCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.dailyLedgerToolStripMenuItem,
            this.reportingToolStripMenuItem,
            this.managerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dailyLedgerToolStripMenuItem
            // 
            this.dailyLedgerToolStripMenuItem.Name = "dailyLedgerToolStripMenuItem";
            this.dailyLedgerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dailyLedgerToolStripMenuItem.Text = "Daily Ledger";
            this.dailyLedgerToolStripMenuItem.Click += new System.EventHandler(this.dailyLedgerToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.reportingToolStripMenuItem.Text = "Reporting";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // tpExpenses
            // 
            this.tpExpenses.Controls.Add(this.btnClear);
            this.tpExpenses.Controls.Add(this.btnAddExpense);
            this.tpExpenses.Controls.Add(this.txtDescription);
            this.tpExpenses.Controls.Add(this.dgExpensesList);
            this.tpExpenses.Controls.Add(this.chkCleared);
            this.tpExpenses.Controls.Add(this.txtCheckNotes);
            this.tpExpenses.Controls.Add(this.txtCheckNo);
            this.tpExpenses.Controls.Add(this.txtExpenseAmount);
            this.tpExpenses.Controls.Add(this.lblErrorMessage3);
            this.tpExpenses.Controls.Add(this.btnDelete);
            this.tpExpenses.Controls.Add(this.cmbVendor);
            this.tpExpenses.Controls.Add(this.cmbUserList);
            this.tpExpenses.Controls.Add(this.cmbTenderType);
            this.tpExpenses.Controls.Add(this.cmbExpensesType);
            this.tpExpenses.Controls.Add(this.label2);
            this.tpExpenses.Location = new System.Drawing.Point(4, 22);
            this.tpExpenses.Name = "tpExpenses";
            this.tpExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpenses.Size = new System.Drawing.Size(1056, 772);
            this.tpExpenses.TabIndex = 2;
            this.tpExpenses.Text = "Expenses";
            this.tpExpenses.UseVisualStyleBackColor = true;
            this.tpExpenses.Click += new System.EventHandler(this.tpExpenses_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1008, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(955, 51);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(52, 23);
            this.btnAddExpense.TabIndex = 14;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(853, 51);
            this.txtDescription.MaxLength = 10;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(96, 20);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.Text = "Description";
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgExpensesList
            // 
            this.dgExpensesList.AllowUserToAddRows = false;
            this.dgExpensesList.AllowUserToOrderColumns = true;
            this.dgExpensesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExpensesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdrExpensesId,
            this.hdrDateId,
            this.hdrSalesDate,
            this.hdrVendorId,
            this.hdrVendorName,
            this.hdrExpenseID,
            this.hdrExpenseType,
            this.hdrExpenseTypeId,
            this.hdrAmount,
            this.hdrUserId,
            this.hdrUser,
            this.hdrTenderTypeId,
            this.hdrTenderType,
            this.hdrDescription,
            this.hdrCheckNo,
            this.hdrCleared,
            this.hdrCheckNotes});
            this.dgExpensesList.Location = new System.Drawing.Point(0, 75);
            this.dgExpensesList.Name = "dgExpensesList";
            this.dgExpensesList.ReadOnly = true;
            this.dgExpensesList.Size = new System.Drawing.Size(1056, 150);
            this.dgExpensesList.TabIndex = 12;
            // 
            // hdrExpensesId
            // 
            this.hdrExpensesId.HeaderText = "ExpensesId";
            this.hdrExpensesId.Name = "hdrExpensesId";
            this.hdrExpensesId.ReadOnly = true;
            this.hdrExpensesId.Visible = false;
            // 
            // hdrDateId
            // 
            this.hdrDateId.HeaderText = "DateId";
            this.hdrDateId.Name = "hdrDateId";
            this.hdrDateId.ReadOnly = true;
            this.hdrDateId.Visible = false;
            // 
            // hdrSalesDate
            // 
            this.hdrSalesDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hdrSalesDate.FillWeight = 45.68528F;
            this.hdrSalesDate.HeaderText = "Sales Date";
            this.hdrSalesDate.MaxInputLength = 15;
            this.hdrSalesDate.Name = "hdrSalesDate";
            this.hdrSalesDate.ReadOnly = true;
            // 
            // hdrVendorId
            // 
            this.hdrVendorId.HeaderText = "Vendor Id";
            this.hdrVendorId.Name = "hdrVendorId";
            this.hdrVendorId.ReadOnly = true;
            this.hdrVendorId.Visible = false;
            // 
            // hdrVendorName
            // 
            this.hdrVendorName.FillWeight = 112.2302F;
            this.hdrVendorName.HeaderText = "Vendor";
            this.hdrVendorName.MaxInputLength = 50;
            this.hdrVendorName.Name = "hdrVendorName";
            this.hdrVendorName.ReadOnly = true;
            // 
            // hdrExpenseID
            // 
            this.hdrExpenseID.HeaderText = "Expense ID";
            this.hdrExpenseID.Name = "hdrExpenseID";
            this.hdrExpenseID.ReadOnly = true;
            this.hdrExpenseID.Visible = false;
            // 
            // hdrExpenseType
            // 
            this.hdrExpenseType.FillWeight = 112.2302F;
            this.hdrExpenseType.HeaderText = "Expense Type";
            this.hdrExpenseType.Name = "hdrExpenseType";
            this.hdrExpenseType.ReadOnly = true;
            // 
            // hdrExpenseTypeId
            // 
            this.hdrExpenseTypeId.HeaderText = "ExpenseTypeId";
            this.hdrExpenseTypeId.Name = "hdrExpenseTypeId";
            this.hdrExpenseTypeId.ReadOnly = true;
            this.hdrExpenseTypeId.Visible = false;
            // 
            // hdrAmount
            // 
            this.hdrAmount.FillWeight = 112.2302F;
            this.hdrAmount.HeaderText = "Amount";
            this.hdrAmount.Name = "hdrAmount";
            this.hdrAmount.ReadOnly = true;
            // 
            // hdrUserId
            // 
            this.hdrUserId.HeaderText = "UserId";
            this.hdrUserId.Name = "hdrUserId";
            this.hdrUserId.ReadOnly = true;
            this.hdrUserId.Visible = false;
            // 
            // hdrUser
            // 
            this.hdrUser.FillWeight = 112.2302F;
            this.hdrUser.HeaderText = "User";
            this.hdrUser.Name = "hdrUser";
            this.hdrUser.ReadOnly = true;
            // 
            // hdrTenderTypeId
            // 
            this.hdrTenderTypeId.HeaderText = "TenderTypeId";
            this.hdrTenderTypeId.Name = "hdrTenderTypeId";
            this.hdrTenderTypeId.ReadOnly = true;
            this.hdrTenderTypeId.Visible = false;
            // 
            // hdrTenderType
            // 
            this.hdrTenderType.FillWeight = 112.2302F;
            this.hdrTenderType.HeaderText = "Tender";
            this.hdrTenderType.Name = "hdrTenderType";
            this.hdrTenderType.ReadOnly = true;
            // 
            // hdrDescription
            // 
            this.hdrDescription.FillWeight = 112.2302F;
            this.hdrDescription.HeaderText = "Description";
            this.hdrDescription.Name = "hdrDescription";
            this.hdrDescription.ReadOnly = true;
            // 
            // hdrCheckNo
            // 
            this.hdrCheckNo.FillWeight = 112.2302F;
            this.hdrCheckNo.HeaderText = "CheckNo";
            this.hdrCheckNo.Name = "hdrCheckNo";
            this.hdrCheckNo.ReadOnly = true;
            // 
            // hdrCleared
            // 
            this.hdrCleared.FillWeight = 112.2302F;
            this.hdrCleared.HeaderText = "Cleared";
            this.hdrCleared.Name = "hdrCleared";
            this.hdrCleared.ReadOnly = true;
            this.hdrCleared.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hdrCleared.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hdrCheckNotes
            // 
            this.hdrCheckNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hdrCheckNotes.FillWeight = 56.47328F;
            this.hdrCheckNotes.HeaderText = "Check Notes";
            this.hdrCheckNotes.Name = "hdrCheckNotes";
            this.hdrCheckNotes.ReadOnly = true;
            // 
            // chkCleared
            // 
            this.chkCleared.AutoSize = true;
            this.chkCleared.Location = new System.Drawing.Point(683, 53);
            this.chkCleared.Name = "chkCleared";
            this.chkCleared.Size = new System.Drawing.Size(62, 17);
            this.chkCleared.TabIndex = 11;
            this.chkCleared.Text = "Cleared";
            this.chkCleared.UseVisualStyleBackColor = true;
            // 
            // txtCheckNotes
            // 
            this.txtCheckNotes.Location = new System.Drawing.Point(751, 50);
            this.txtCheckNotes.MaxLength = 10;
            this.txtCheckNotes.Name = "txtCheckNotes";
            this.txtCheckNotes.Size = new System.Drawing.Size(96, 20);
            this.txtCheckNotes.TabIndex = 10;
            this.txtCheckNotes.Text = "Check Notes";
            this.txtCheckNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(610, 50);
            this.txtCheckNo.MaxLength = 10;
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(67, 20);
            this.txtCheckNo.TabIndex = 9;
            this.txtCheckNo.Text = "Check No";
            this.txtCheckNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(310, 50);
            this.txtExpenseAmount.MaxLength = 10;
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(67, 20);
            this.txtExpenseAmount.TabIndex = 8;
            this.txtExpenseAmount.Text = "Amount";
            this.txtExpenseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblErrorMessage3
            // 
            this.lblErrorMessage3.AutoSize = true;
            this.lblErrorMessage3.Location = new System.Drawing.Point(150, 228);
            this.lblErrorMessage3.Name = "lblErrorMessage3";
            this.lblErrorMessage3.Size = new System.Drawing.Size(78, 13);
            this.lblErrorMessage3.TabIndex = 7;
            this.lblErrorMessage3.Text = "ErrorMessage3";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(570, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbVendor
            // 
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(183, 48);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendor.TabIndex = 4;
            this.cmbVendor.Text = "VendorName";
            // 
            // cmbUserList
            // 
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(383, 49);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(97, 21);
            this.cmbUserList.TabIndex = 3;
            this.cmbUserList.Text = "UserList";
            // 
            // cmbTenderType
            // 
            this.cmbTenderType.FormattingEnabled = true;
            this.cmbTenderType.Location = new System.Drawing.Point(486, 49);
            this.cmbTenderType.Name = "cmbTenderType";
            this.cmbTenderType.Size = new System.Drawing.Size(98, 21);
            this.cmbTenderType.TabIndex = 2;
            this.cmbTenderType.Text = "TenderType";
            // 
            // cmbExpensesType
            // 
            this.cmbExpensesType.FormattingEnabled = true;
            this.cmbExpensesType.Location = new System.Drawing.Point(56, 48);
            this.cmbExpensesType.Name = "cmbExpensesType";
            this.cmbExpensesType.Size = new System.Drawing.Size(121, 21);
            this.cmbExpensesType.TabIndex = 1;
            this.cmbExpensesType.Text = "ExpensesType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ErrorMessageExpenses";
            // 
            // tpReports
            // 
            this.tpReports.Controls.Add(this.label3);
            this.tpReports.Location = new System.Drawing.Point(4, 22);
            this.tpReports.Name = "tpReports";
            this.tpReports.Padding = new System.Windows.Forms.Padding(3);
            this.tpReports.Size = new System.Drawing.Size(1056, 772);
            this.tpReports.TabIndex = 1;
            this.tpReports.Text = "Reports";
            this.tpReports.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(4, 50);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(205, 13);
            this.lblErrorMessage.TabIndex = 3;
            this.lblErrorMessage.Text = "Error ErrorMessage for Date Picker";
            // 
            // dtBusinessDate
            // 
            this.dtBusinessDate.Location = new System.Drawing.Point(4, 27);
            this.dtBusinessDate.MinDate = new System.DateTime(2005, 6, 5, 0, 0, 0, 0);
            this.dtBusinessDate.Name = "dtBusinessDate";
            this.dtBusinessDate.Size = new System.Drawing.Size(218, 20);
            this.dtBusinessDate.TabIndex = 1;
            this.dtBusinessDate.Value = new System.DateTime(2015, 2, 14, 0, 0, 0, 0);
            this.dtBusinessDate.ValueChanged += new System.EventHandler(this.dtBusinessDate_ValueChanged);
            // 
            // tbDailyLog
            // 
            this.tbDailyLog.Controls.Add(this.tpDailyLog);
            this.tbDailyLog.Controls.Add(this.tpExpenses);
            this.tbDailyLog.Controls.Add(this.tpReports);
            this.tbDailyLog.Location = new System.Drawing.Point(0, 66);
            this.tbDailyLog.Name = "tbDailyLog";
            this.tbDailyLog.SelectedIndex = 0;
            this.tbDailyLog.Size = new System.Drawing.Size(1064, 798);
            this.tbDailyLog.TabIndex = 1;
            // 
            // tpDailyLog
            // 
            this.tpDailyLog.Controls.Add(this.groupBox2);
            this.tpDailyLog.Controls.Add(this.btnPrevious2);
            this.tpDailyLog.Controls.Add(this.btnNext2);
            this.tpDailyLog.Location = new System.Drawing.Point(4, 22);
            this.tpDailyLog.Name = "tpDailyLog";
            this.tpDailyLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpDailyLog.Size = new System.Drawing.Size(1056, 772);
            this.tpDailyLog.TabIndex = 0;
            this.tpDailyLog.Text = "Daily Log";
            this.tpDailyLog.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblGasSoldTotal);
            this.groupBox2.Controls.Add(this.lblUnleaded);
            this.groupBox2.Controls.Add(this.lblPricePer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblGallonsSold);
            this.groupBox2.Controls.Add(this.lblPlus);
            this.groupBox2.Controls.Add(this.txtUnleaded);
            this.groupBox2.Controls.Add(this.txtPlus);
            this.groupBox2.Controls.Add(this.txtPremium);
            this.groupBox2.Controls.Add(this.grpGallonCost);
            this.groupBox2.Controls.Add(this.txtPriceUnleaded);
            this.groupBox2.Controls.Add(this.txtPricePlus);
            this.groupBox2.Controls.Add(this.txtQT);
            this.groupBox2.Controls.Add(this.txtPricePremium);
            this.groupBox2.Controls.Add(this.txtTotalDollarsUnleaded);
            this.groupBox2.Controls.Add(this.txtTotalDollarsPlus);
            this.groupBox2.Controls.Add(this.txtTotalDollarsPremium);
            this.groupBox2.Controls.Add(this.lblHorizontalRule);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblTotalDollarsSold);
            this.groupBox2.Controls.Add(this.lblTotalGallons);
            this.groupBox2.Location = new System.Drawing.Point(-4, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1064, 398);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daily Gas Sales";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlSOTG);
            this.groupBox1.Location = new System.Drawing.Point(468, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 364);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Register Totals";
            // 
            // pnlSOTG
            // 
            this.pnlSOTG.BackColor = System.Drawing.Color.Gray;
            this.pnlSOTG.Controls.Add(this.dgSalesDept);
            this.pnlSOTG.Controls.Add(this.lblDeptSalesErrorMessage);
            this.pnlSOTG.Controls.Add(this.lblSoldDollars);
            this.pnlSOTG.Controls.Add(this.lblQuantity);
            this.pnlSOTG.Controls.Add(this.lblSalesDepartment);
            this.pnlSOTG.Controls.Add(this.lblResults2);
            this.pnlSOTG.Controls.Add(this.txtDeptSoldAmount);
            this.pnlSOTG.Controls.Add(this.ddQuantity);
            this.pnlSOTG.Controls.Add(this.btnAdd);
            this.pnlSOTG.Controls.Add(this.ddDepartment);
            this.pnlSOTG.Location = new System.Drawing.Point(40, 19);
            this.pnlSOTG.Name = "pnlSOTG";
            this.pnlSOTG.Size = new System.Drawing.Size(541, 347);
            this.pnlSOTG.TabIndex = 3;
            this.pnlSOTG.Visible = false;
            // 
            // dgSalesDept
            // 
            this.dgSalesDept.AllowUserToAddRows = false;
            this.dgSalesDept.AllowUserToOrderColumns = true;
            this.dgSalesDept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSalesDept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSalesDept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSalesDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdrSalesDeptId,
            this.hdrSalesDateId,
            this.hdrSalesDept,
            this.hdrQuantity,
            this.hdrTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSalesDept.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalesDept.Location = new System.Drawing.Point(39, 92);
            this.dgSalesDept.Name = "dgSalesDept";
            this.dgSalesDept.ReadOnly = true;
            this.dgSalesDept.Size = new System.Drawing.Size(771, 200);
            this.dgSalesDept.TabIndex = 15;
            // 
            // hdrSalesDeptId
            // 
            this.hdrSalesDeptId.HeaderText = "DeptID";
            this.hdrSalesDeptId.MinimumWidth = 50;
            this.hdrSalesDeptId.Name = "hdrSalesDeptId";
            this.hdrSalesDeptId.ReadOnly = true;
            this.hdrSalesDeptId.Visible = false;
            // 
            // hdrSalesDateId
            // 
            this.hdrSalesDateId.HeaderText = "Sales Date Id";
            this.hdrSalesDateId.MinimumWidth = 50;
            this.hdrSalesDateId.Name = "hdrSalesDateId";
            this.hdrSalesDateId.ReadOnly = true;
            this.hdrSalesDateId.Visible = false;
            // 
            // hdrSalesDept
            // 
            this.hdrSalesDept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hdrSalesDept.FillWeight = 7.377128F;
            this.hdrSalesDept.HeaderText = "Sales Department";
            this.hdrSalesDept.MaxInputLength = 20;
            this.hdrSalesDept.MinimumWidth = 150;
            this.hdrSalesDept.Name = "hdrSalesDept";
            this.hdrSalesDept.ReadOnly = true;
            // 
            // hdrQuantity
            // 
            this.hdrQuantity.FillWeight = 7.851295F;
            this.hdrQuantity.HeaderText = "Quantity";
            this.hdrQuantity.MaxInputLength = 10;
            this.hdrQuantity.MinimumWidth = 100;
            this.hdrQuantity.Name = "hdrQuantity";
            this.hdrQuantity.ReadOnly = true;
            // 
            // hdrTotal
            // 
            this.hdrTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hdrTotal.FillWeight = 284.7716F;
            this.hdrTotal.HeaderText = "Total Amount";
            this.hdrTotal.MaxInputLength = 20;
            this.hdrTotal.MinimumWidth = 150;
            this.hdrTotal.Name = "hdrTotal";
            this.hdrTotal.ReadOnly = true;
            // 
            // lblDeptSalesErrorMessage
            // 
            this.lblDeptSalesErrorMessage.AutoSize = true;
            this.lblDeptSalesErrorMessage.Location = new System.Drawing.Point(120, 26);
            this.lblDeptSalesErrorMessage.Name = "lblDeptSalesErrorMessage";
            this.lblDeptSalesErrorMessage.Size = new System.Drawing.Size(69, 13);
            this.lblDeptSalesErrorMessage.TabIndex = 14;
            this.lblDeptSalesErrorMessage.Text = "DeptSalesErr";
            // 
            // lblSoldDollars
            // 
            this.lblSoldDollars.AutoSize = true;
            this.lblSoldDollars.Location = new System.Drawing.Point(316, 50);
            this.lblSoldDollars.Name = "lblSoldDollars";
            this.lblSoldDollars.Size = new System.Drawing.Size(67, 13);
            this.lblSoldDollars.TabIndex = 12;
            this.lblSoldDollars.Text = "Sold Amount";
            this.lblSoldDollars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(248, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalesDepartment
            // 
            this.lblSalesDepartment.AutoSize = true;
            this.lblSalesDepartment.Location = new System.Drawing.Point(127, 50);
            this.lblSalesDepartment.Name = "lblSalesDepartment";
            this.lblSalesDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblSalesDepartment.TabIndex = 10;
            this.lblSalesDepartment.Text = "Department";
            this.lblSalesDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Location = new System.Drawing.Point(624, 26);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(42, 13);
            this.lblResults2.TabIndex = 9;
            this.lblResults2.Text = "Results";
            // 
            // txtDeptSoldAmount
            // 
            this.txtDeptSoldAmount.Location = new System.Drawing.Point(301, 66);
            this.txtDeptSoldAmount.Name = "txtDeptSoldAmount";
            this.txtDeptSoldAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDeptSoldAmount.TabIndex = 8;
            // 
            // ddQuantity
            // 
            this.ddQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddQuantity.CausesValidation = false;
            this.ddQuantity.FormattingEnabled = true;
            this.ddQuantity.Location = new System.Drawing.Point(242, 66);
            this.ddQuantity.Name = "ddQuantity";
            this.ddQuantity.Size = new System.Drawing.Size(52, 21);
            this.ddQuantity.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ddDepartment
            // 
            this.ddDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddDepartment.FormattingEnabled = true;
            this.ddDepartment.Location = new System.Drawing.Point(89, 66);
            this.ddDepartment.Name = "ddDepartment";
            this.ddDepartment.Size = new System.Drawing.Size(143, 21);
            this.ddDepartment.TabIndex = 5;
            // 
            // btnPrevious2
            // 
            this.btnPrevious2.Location = new System.Drawing.Point(392, 404);
            this.btnPrevious2.Name = "btnPrevious2";
            this.btnPrevious2.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious2.TabIndex = 2;
            this.btnPrevious2.Text = "Previous";
            this.btnPrevious2.UseVisualStyleBackColor = true;
            this.btnPrevious2.Click += new System.EventHandler(this.btnPrevious2_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(496, 405);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 0;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // lblGasSoldTotal
            // 
            this.lblGasSoldTotal.AutoSize = true;
            this.lblGasSoldTotal.Location = new System.Drawing.Point(235, 57);
            this.lblGasSoldTotal.Name = "lblGasSoldTotal";
            this.lblGasSoldTotal.Size = new System.Drawing.Size(66, 13);
            this.lblGasSoldTotal.TabIndex = 30;
            this.lblGasSoldTotal.Text = "Total Dollars";
            // 
            // lblUnleaded
            // 
            this.lblUnleaded.AutoSize = true;
            this.lblUnleaded.Location = new System.Drawing.Point(10, 76);
            this.lblUnleaded.Name = "lblUnleaded";
            this.lblUnleaded.Size = new System.Drawing.Size(53, 13);
            this.lblUnleaded.TabIndex = 4;
            this.lblUnleaded.Text = "Unleaded";
            this.lblUnleaded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPricePer
            // 
            this.lblPricePer.AutoSize = true;
            this.lblPricePer.Location = new System.Drawing.Point(166, 57);
            this.lblPricePer.Name = "lblPricePer";
            this.lblPricePer.Size = new System.Drawing.Size(86, 13);
            this.lblPricePer.TabIndex = 29;
            this.lblPricePer.Text = "Price Per  Gallon";
            this.lblPricePer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Premium";
            // 
            // lblGallonsSold
            // 
            this.lblGallonsSold.AutoSize = true;
            this.lblGallonsSold.Location = new System.Drawing.Point(78, 57);
            this.lblGallonsSold.Name = "lblGallonsSold";
            this.lblGallonsSold.Size = new System.Drawing.Size(66, 13);
            this.lblGallonsSold.TabIndex = 28;
            this.lblGallonsSold.Text = "Gallons Sold";
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(35, 102);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(27, 13);
            this.lblPlus.TabIndex = 6;
            this.lblPlus.Text = "Plus";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnleaded
            // 
            this.txtUnleaded.Location = new System.Drawing.Point(66, 73);
            this.txtUnleaded.MaxLength = 12;
            this.txtUnleaded.Name = "txtUnleaded";
            this.txtUnleaded.Size = new System.Drawing.Size(88, 20);
            this.txtUnleaded.TabIndex = 1;
            this.txtUnleaded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnleaded.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtPlus
            // 
            this.txtPlus.Location = new System.Drawing.Point(66, 99);
            this.txtPlus.MaxLength = 12;
            this.txtPlus.Name = "txtPlus";
            this.txtPlus.Size = new System.Drawing.Size(88, 20);
            this.txtPlus.TabIndex = 2;
            this.txtPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPlus.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(66, 126);
            this.txtPremium.MaxLength = 12;
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(88, 20);
            this.txtPremium.TabIndex = 3;
            this.txtPremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPremium.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // grpGallonCost
            // 
            this.grpGallonCost.BackColor = System.Drawing.Color.Gainsboro;
            this.grpGallonCost.Controls.Add(this.txtCostPremium);
            this.grpGallonCost.Controls.Add(this.txtCostPlus);
            this.grpGallonCost.Controls.Add(this.txtCostUnleaded);
            this.grpGallonCost.Location = new System.Drawing.Point(353, 51);
            this.grpGallonCost.Name = "grpGallonCost";
            this.grpGallonCost.Size = new System.Drawing.Size(103, 122);
            this.grpGallonCost.TabIndex = 25;
            this.grpGallonCost.TabStop = false;
            this.grpGallonCost.Text = "Cost Per Gallon";
            // 
            // txtCostPremium
            // 
            this.txtCostPremium.Location = new System.Drawing.Point(21, 79);
            this.txtCostPremium.MaxLength = 8;
            this.txtCostPremium.Name = "txtCostPremium";
            this.txtCostPremium.Size = new System.Drawing.Size(62, 20);
            this.txtCostPremium.TabIndex = 12;
            this.txtCostPremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostPremium.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtCostPlus
            // 
            this.txtCostPlus.Location = new System.Drawing.Point(21, 48);
            this.txtCostPlus.MaxLength = 8;
            this.txtCostPlus.Name = "txtCostPlus";
            this.txtCostPlus.Size = new System.Drawing.Size(62, 20);
            this.txtCostPlus.TabIndex = 11;
            this.txtCostPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostPlus.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtCostUnleaded
            // 
            this.txtCostUnleaded.Location = new System.Drawing.Point(21, 22);
            this.txtCostUnleaded.MaxLength = 8;
            this.txtCostUnleaded.Name = "txtCostUnleaded";
            this.txtCostUnleaded.Size = new System.Drawing.Size(62, 20);
            this.txtCostUnleaded.TabIndex = 10;
            this.txtCostUnleaded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostUnleaded.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtPriceUnleaded
            // 
            this.txtPriceUnleaded.Location = new System.Drawing.Point(173, 73);
            this.txtPriceUnleaded.MaxLength = 8;
            this.txtPriceUnleaded.Name = "txtPriceUnleaded";
            this.txtPriceUnleaded.Size = new System.Drawing.Size(47, 20);
            this.txtPriceUnleaded.TabIndex = 4;
            this.txtPriceUnleaded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceUnleaded.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtPricePlus
            // 
            this.txtPricePlus.Location = new System.Drawing.Point(173, 99);
            this.txtPricePlus.MaxLength = 8;
            this.txtPricePlus.Name = "txtPricePlus";
            this.txtPricePlus.Size = new System.Drawing.Size(47, 20);
            this.txtPricePlus.TabIndex = 5;
            this.txtPricePlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePlus.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(238, 206);
            this.txtQT.MaxLength = 10;
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(0, 20);
            this.txtQT.TabIndex = 14;
            this.txtQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQT.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtPricePremium
            // 
            this.txtPricePremium.Location = new System.Drawing.Point(173, 126);
            this.txtPricePremium.MaxLength = 8;
            this.txtPricePremium.Name = "txtPricePremium";
            this.txtPricePremium.Size = new System.Drawing.Size(47, 20);
            this.txtPricePremium.TabIndex = 6;
            this.txtPricePremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePremium.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtTotalDollarsUnleaded
            // 
            this.txtTotalDollarsUnleaded.Location = new System.Drawing.Point(238, 73);
            this.txtTotalDollarsUnleaded.MaxLength = 12;
            this.txtTotalDollarsUnleaded.Name = "txtTotalDollarsUnleaded";
            this.txtTotalDollarsUnleaded.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDollarsUnleaded.TabIndex = 7;
            this.txtTotalDollarsUnleaded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDollarsUnleaded.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtTotalDollarsPlus
            // 
            this.txtTotalDollarsPlus.Location = new System.Drawing.Point(238, 99);
            this.txtTotalDollarsPlus.MaxLength = 12;
            this.txtTotalDollarsPlus.Name = "txtTotalDollarsPlus";
            this.txtTotalDollarsPlus.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDollarsPlus.TabIndex = 8;
            this.txtTotalDollarsPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDollarsPlus.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // txtTotalDollarsPremium
            // 
            this.txtTotalDollarsPremium.Location = new System.Drawing.Point(238, 130);
            this.txtTotalDollarsPremium.MaxLength = 12;
            this.txtTotalDollarsPremium.Name = "txtTotalDollarsPremium";
            this.txtTotalDollarsPremium.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDollarsPremium.TabIndex = 9;
            this.txtTotalDollarsPremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDollarsPremium.TextChanged += new System.EventHandler(this.txtUnleaded_TextChanged);
            // 
            // lblHorizontalRule
            // 
            this.lblHorizontalRule.AutoSize = true;
            this.lblHorizontalRule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorizontalRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorizontalRule.Location = new System.Drawing.Point(5, 184);
            this.lblHorizontalRule.Name = "lblHorizontalRule";
            this.lblHorizontalRule.Size = new System.Drawing.Size(338, 6);
            this.lblHorizontalRule.TabIndex = 19;
            this.lblHorizontalRule.Text = "_________________________________________________________________________________" +
    "______________________________";
            this.lblHorizontalRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(28, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalDollarsSold
            // 
            this.lblTotalDollarsSold.AutoSize = true;
            this.lblTotalDollarsSold.Location = new System.Drawing.Point(245, 160);
            this.lblTotalDollarsSold.Name = "lblTotalDollarsSold";
            this.lblTotalDollarsSold.Size = new System.Drawing.Size(90, 13);
            this.lblTotalDollarsSold.TabIndex = 18;
            this.lblTotalDollarsSold.Text = "Total Dollars Sold";
            this.lblTotalDollarsSold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGallons
            // 
            this.lblTotalGallons.AutoSize = true;
            this.lblTotalGallons.Location = new System.Drawing.Point(61, 160);
            this.lblTotalGallons.Name = "lblTotalGallons";
            this.lblTotalGallons.Size = new System.Drawing.Size(93, 13);
            this.lblTotalGallons.TabIndex = 17;
            this.lblTotalGallons.Text = "Total Gallons Sold";
            this.lblTotalGallons.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGasSalesErrorMessage
            // 
            this.lblGasSalesErrorMessage.AutoSize = true;
            this.lblGasSalesErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblGasSalesErrorMessage.Location = new System.Drawing.Point(393, 66);
            this.lblGasSalesErrorMessage.Name = "lblGasSalesErrorMessage";
            this.lblGasSalesErrorMessage.Size = new System.Drawing.Size(132, 13);
            this.lblGasSalesErrorMessage.TabIndex = 27;
            this.lblGasSalesErrorMessage.Text = "ErrorMessageForGasSales";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 633);
            this.Controls.Add(this.lblGasSalesErrorMessage);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.tbDailyLog);
            this.Controls.Add(this.dtBusinessDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Center Bookkeeping";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpExpenses.ResumeLayout(false);
            this.tpExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpensesList)).EndInit();
            this.tpReports.ResumeLayout(false);
            this.tpReports.PerformLayout();
            this.tbDailyLog.ResumeLayout(false);
            this.tpDailyLog.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlSOTG.ResumeLayout(false);
            this.pnlSOTG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesDept)).EndInit();
            this.grpGallonCost.ResumeLayout(false);
            this.grpGallonCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        //private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tpExpenses;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.DateTimePicker dtBusinessDate;
        private System.Windows.Forms.TabControl tbDailyLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.ComboBox cmbTenderType;
        private System.Windows.Forms.ComboBox cmbExpensesType;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblErrorMessage3;
        private System.Windows.Forms.DataGridView dgExpensesList;
        private System.Windows.Forms.CheckBox chkCleared;
        private System.Windows.Forms.TextBox txtCheckNotes;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrExpensesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrDateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrSalesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrVendorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrVendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrExpenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrExpenseTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrTenderTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrTenderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrCheckNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hdrCleared;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrCheckNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpDailyLog;
        private System.Windows.Forms.Label lblGasSalesErrorMessage;
        private System.Windows.Forms.Panel pnlSOTG;
        private System.Windows.Forms.DataGridView dgSalesDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrSalesDeptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrSalesDateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrSalesDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrTotal;
        private System.Windows.Forms.Label lblDeptSalesErrorMessage;
        private System.Windows.Forms.Label lblSoldDollars;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSalesDepartment;
        private System.Windows.Forms.Label lblResults2;
        private System.Windows.Forms.TextBox txtDeptSoldAmount;
        private System.Windows.Forms.ComboBox ddQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox ddDepartment;
        private System.Windows.Forms.Button btnPrevious2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.GroupBox grpGallonCost;
        private System.Windows.Forms.TextBox txtCostPremium;
        private System.Windows.Forms.TextBox txtCostPlus;
        private System.Windows.Forms.TextBox txtCostUnleaded;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label lblHorizontalRule;
        private System.Windows.Forms.Label lblTotalDollarsSold;
        private System.Windows.Forms.Label lblTotalGallons;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalDollarsPremium;
        private System.Windows.Forms.TextBox txtTotalDollarsPlus;
        private System.Windows.Forms.TextBox txtTotalDollarsUnleaded;
        private System.Windows.Forms.TextBox txtPricePremium;
        private System.Windows.Forms.TextBox txtPricePlus;
        private System.Windows.Forms.TextBox txtPriceUnleaded;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.TextBox txtPlus;
        private System.Windows.Forms.TextBox txtUnleaded;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnleaded;
        private System.Windows.Forms.Label lblPricePer;
        private System.Windows.Forms.Label lblGallonsSold;
        private System.Windows.Forms.Label lblGasSoldTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}