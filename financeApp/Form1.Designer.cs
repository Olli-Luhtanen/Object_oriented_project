namespace financeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLeft = new Panel();
            btnStatistics = new Button();
            btnHome = new Button();
            panelMain = new Panel();
            listViewTransactions = new ListView();
            columnHeaderDate = new ColumnHeader();
            columnHeaderDescription = new ColumnHeader();
            columnHeaderAmount = new ColumnHeader();
            columnHeaderAccount = new ColumnHeader();
            panelBalance = new Panel();
            btnAddTransaction = new Button();
            lblBalanceAmount = new Label();
            lblBalanceText = new Label();
            lblHeader = new Label();
            panelLeft.SuspendLayout();
            panelMain.SuspendLayout();
            panelBalance.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.SteelBlue;
            panelLeft.Controls.Add(btnStatistics);
            panelLeft.Controls.Add(btnHome);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(0, 40, 0, 0);
            panelLeft.Size = new Size(101, 600);
            panelLeft.TabIndex = 1;
            // 
            // btnStatistics
            // 
            btnStatistics.AllowDrop = true;
            btnStatistics.BackColor = Color.SteelBlue;
            btnStatistics.Dock = DockStyle.Top;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Segoe UI Emoji", 20F);
            btnStatistics.ForeColor = Color.Black;
            btnStatistics.Location = new Point(0, 96);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(101, 56);
            btnStatistics.TabIndex = 0;
            btnStatistics.Text = "📊";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.SteelBlue;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Emoji", 20F);
            btnHome.ForeColor = Color.Black;
            btnHome.Location = new Point(0, 40);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(101, 56);
            btnHome.TabIndex = 2;
            btnHome.Text = "🏠";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Controls.Add(listViewTransactions);
            panelMain.Controls.Add(panelBalance);
            panelMain.Controls.Add(lblHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(101, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(799, 600);
            panelMain.TabIndex = 0;
            // 
            // listViewTransactions
            // 
            listViewTransactions.Columns.AddRange(new ColumnHeader[] { columnHeaderDate, columnHeaderDescription, columnHeaderAmount, columnHeaderAccount });
            listViewTransactions.Dock = DockStyle.Fill;
            listViewTransactions.FullRowSelect = true;
            listViewTransactions.GridLines = true;
            listViewTransactions.Location = new Point(16, 96);
            listViewTransactions.Name = "listViewTransactions";
            listViewTransactions.Size = new Size(767, 488);
            listViewTransactions.TabIndex = 0;
            listViewTransactions.UseCompatibleStateImageBehavior = false;
            listViewTransactions.View = View.Details;
            listViewTransactions.SelectedIndexChanged += listViewTransactions_SelectedIndexChanged;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date";
            columnHeaderDate.Width = 100;
            // 
            // columnHeaderDescription
            // 
            columnHeaderDescription.Text = "Description";
            columnHeaderDescription.Width = 320;
            // 
            // columnHeaderAmount
            // 
            columnHeaderAmount.Text = "Amount";
            columnHeaderAmount.Width = 100;
            // 
            // columnHeaderAccount
            // 
            columnHeaderAccount.Text = "Category";
            columnHeaderAccount.Width = 120;
            // 
            // panelBalance
            // 
            panelBalance.Controls.Add(btnAddTransaction);
            panelBalance.Controls.Add(lblBalanceAmount);
            panelBalance.Controls.Add(lblBalanceText);
            panelBalance.Dock = DockStyle.Top;
            panelBalance.Location = new Point(16, 16);
            panelBalance.Name = "panelBalance";
            panelBalance.Padding = new Padding(0, 8, 0, 8);
            panelBalance.Size = new Size(767, 80);
            panelBalance.TabIndex = 1;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Dock = DockStyle.Right;
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTransaction.Location = new Point(711, 8);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(56, 64);
            btnAddTransaction.TabIndex = 2;
            btnAddTransaction.Text = "+";
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // lblBalanceAmount
            // 
            lblBalanceAmount.AutoSize = true;
            lblBalanceAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalanceAmount.Location = new Point(213, 17);
            lblBalanceAmount.Name = "lblBalanceAmount";
            lblBalanceAmount.Size = new Size(136, 41);
            lblBalanceAmount.TabIndex = 0;
            lblBalanceAmount.Text = "13,040 €";
            // 
            // lblBalanceText
            // 
            lblBalanceText.AutoSize = true;
            lblBalanceText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBalanceText.Location = new Point(3, 17);
            lblBalanceText.Name = "lblBalanceText";
            lblBalanceText.Size = new Size(204, 41);
            lblBalanceText.TabIndex = 1;
            lblBalanceText.Text = "Total Balance";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHeader.Location = new Point(8, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(211, 50);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Dashboard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelMain);
            Controls.Add(panelLeft);
            Name = "Form1";
            Text = "Finance Dashboard";
            panelLeft.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelBalance.ResumeLayout(false);
            panelBalance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Button btnHome;
        private Button btnStatistics;
        private Panel panelMain;
        private Label lblHeader;
        private Panel panelBalance;
        private Label lblBalanceText;
        private Label lblBalanceAmount;
        private Button btnAddTransaction;
        private ListView listViewTransactions;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderDescription;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderAccount;
    }
}
