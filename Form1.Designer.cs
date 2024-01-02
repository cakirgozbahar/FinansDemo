namespace FinansDemo
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbcBank = new TabControl();
            tabPage1 = new TabPage();
            btncreate = new Button();
            txtAddress = new TextBox();
            txtID = new TextBox();
            txtCustomerID = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnDeleteCustomer = new Button();
            cbxDeleteCustomer = new ComboBox();
            label5 = new Label();
            tabPage3 = new TabPage();
            lsbCustomers = new ListBox();
            tabPage4 = new TabPage();
            btnAddLoanToCustomer = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtInterestRate = new TextBox();
            txtTime = new TextBox();
            txtPresentValue = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbxAddLoanToCustomer = new ComboBox();
            tabPage5 = new TabPage();
            label11 = new Label();
            cbxDltCsLoans = new ComboBox();
            button3 = new Button();
            cbxDltLoanToCs = new ComboBox();
            label10 = new Label();
            tabPage6 = new TabPage();
            lsbLoansOfCustomers = new ListBox();
            tabPage7 = new TabPage();
            btnUpdateCustomer = new Button();
            txtUpdateAddress = new TextBox();
            label14 = new Label();
            label12 = new Label();
            cbxUpdateCustomer = new ComboBox();
            tbcBank.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbcBank
            // 
            tbcBank.Controls.Add(tabPage1);
            tbcBank.Controls.Add(tabPage2);
            tbcBank.Controls.Add(tabPage3);
            tbcBank.Controls.Add(tabPage4);
            tbcBank.Controls.Add(tabPage5);
            tbcBank.Controls.Add(tabPage6);
            tbcBank.Controls.Add(tabPage7);
            tbcBank.Location = new Point(12, 13);
            tbcBank.Margin = new Padding(3, 4, 3, 4);
            tbcBank.Name = "tbcBank";
            tbcBank.SelectedIndex = 0;
            tbcBank.Size = new Size(1007, 551);
            tbcBank.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btncreate);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Controls.Add(txtID);
            tabPage1.Controls.Add(txtCustomerID);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(999, 518);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(474, 117);
            btncreate.Margin = new Padding(3, 4, 3, 4);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(86, 31);
            btncreate.TabIndex = 8;
            btncreate.Text = "Confirm";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click_1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(209, 177);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(114, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(209, 124);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 6;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(209, 73);
            txtCustomerID.Margin = new Padding(3, 4, 3, 4);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(114, 27);
            txtCustomerID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(209, 23);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 181);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 128);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 77);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Name Surname";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteCustomer);
            tabPage2.Controls.Add(cbxDeleteCustomer);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(999, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(431, 47);
            btnDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(138, 31);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // cbxDeleteCustomer
            // 
            cbxDeleteCustomer.FormattingEnabled = true;
            cbxDeleteCustomer.Location = new Point(199, 43);
            cbxDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            cbxDeleteCustomer.Name = "cbxDeleteCustomer";
            cbxDeleteCustomer.Size = new Size(138, 28);
            cbxDeleteCustomer.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 47);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 0;
            label5.Text = "Customer ID";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lsbCustomers);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(999, 518);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "List Customer";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lsbCustomers
            // 
            lsbCustomers.FormattingEnabled = true;
            lsbCustomers.ItemHeight = 20;
            lsbCustomers.Location = new Point(31, 21);
            lsbCustomers.Margin = new Padding(3, 4, 3, 4);
            lsbCustomers.Name = "lsbCustomers";
            lsbCustomers.ScrollAlwaysVisible = true;
            lsbCustomers.Size = new Size(687, 344);
            lsbCustomers.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnAddLoanToCustomer);
            tabPage4.Controls.Add(radioButton2);
            tabPage4.Controls.Add(radioButton1);
            tabPage4.Controls.Add(txtInterestRate);
            tabPage4.Controls.Add(txtTime);
            tabPage4.Controls.Add(txtPresentValue);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(cbxAddLoanToCustomer);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(999, 518);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Add Loan to Customer";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAddLoanToCustomer
            // 
            btnAddLoanToCustomer.Location = new Point(399, 325);
            btnAddLoanToCustomer.Margin = new Padding(3, 4, 3, 4);
            btnAddLoanToCustomer.Name = "btnAddLoanToCustomer";
            btnAddLoanToCustomer.Size = new Size(183, 31);
            btnAddLoanToCustomer.TabIndex = 10;
            btnAddLoanToCustomer.Text = "Add loan to customer";
            btnAddLoanToCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(399, 259);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(307, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Calculate according to campound interest";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(399, 213);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(280, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Calculate according to simple interest";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(551, 144);
            txtInterestRate.Margin = new Padding(3, 4, 3, 4);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(114, 27);
            txtInterestRate.TabIndex = 7;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(551, 87);
            txtTime.Margin = new Padding(3, 4, 3, 4);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(114, 27);
            txtTime.TabIndex = 6;
            // 
            // txtPresentValue
            // 
            txtPresentValue.Location = new Point(551, 36);
            txtPresentValue.Margin = new Padding(3, 4, 3, 4);
            txtPresentValue.Name = "txtPresentValue";
            txtPresentValue.Size = new Size(114, 27);
            txtPresentValue.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(399, 144);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 4;
            label9.Text = "Interest rate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 97);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 3;
            label8.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 44);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 2;
            label7.Text = "Present Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 40);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 1;
            label6.Text = "Customer ID :";
            // 
            // cbxAddLoanToCustomer
            // 
            cbxAddLoanToCustomer.FormattingEnabled = true;
            cbxAddLoanToCustomer.Location = new Point(135, 36);
            cbxAddLoanToCustomer.Margin = new Padding(3, 4, 3, 4);
            cbxAddLoanToCustomer.Name = "cbxAddLoanToCustomer";
            cbxAddLoanToCustomer.Size = new Size(138, 28);
            cbxAddLoanToCustomer.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(cbxDltCsLoans);
            tabPage5.Controls.Add(button3);
            tabPage5.Controls.Add(cbxDltLoanToCs);
            tabPage5.Controls.Add(label10);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(999, 518);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Delete Loan to Customer";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(96, 179);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 7;
            label11.Text = "Customer Loans";
            // 
            // cbxDltCsLoans
            // 
            cbxDltCsLoans.FormattingEnabled = true;
            cbxDltCsLoans.Location = new Point(242, 175);
            cbxDltCsLoans.Margin = new Padding(3, 4, 3, 4);
            cbxDltCsLoans.Name = "cbxDltCsLoans";
            cbxDltCsLoans.Size = new Size(138, 28);
            cbxDltCsLoans.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(525, 111);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(216, 31);
            button3.TabIndex = 5;
            button3.Text = "Delete Loan from Customer";
            button3.UseVisualStyleBackColor = true;
            // 
            // cbxDltLoanToCs
            // 
            cbxDltLoanToCs.FormattingEnabled = true;
            cbxDltLoanToCs.Location = new Point(242, 47);
            cbxDltLoanToCs.Margin = new Padding(3, 4, 3, 4);
            cbxDltLoanToCs.Name = "cbxDltLoanToCs";
            cbxDltLoanToCs.Size = new Size(138, 28);
            cbxDltLoanToCs.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(96, 56);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 3;
            label10.Text = "Customer ID";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(lsbLoansOfCustomers);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 4, 3, 4);
            tabPage6.Size = new Size(999, 518);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "List Loans of Customers";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // lsbLoansOfCustomers
            // 
            lsbLoansOfCustomers.FormattingEnabled = true;
            lsbLoansOfCustomers.ItemHeight = 20;
            lsbLoansOfCustomers.Location = new Point(43, 39);
            lsbLoansOfCustomers.Margin = new Padding(3, 4, 3, 4);
            lsbLoansOfCustomers.Name = "lsbLoansOfCustomers";
            lsbLoansOfCustomers.ScrollAlwaysVisible = true;
            lsbLoansOfCustomers.Size = new Size(532, 244);
            lsbLoansOfCustomers.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(btnUpdateCustomer);
            tabPage7.Controls.Add(txtUpdateAddress);
            tabPage7.Controls.Add(label14);
            tabPage7.Controls.Add(label12);
            tabPage7.Controls.Add(cbxUpdateCustomer);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(3, 4, 3, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3, 4, 3, 4);
            tabPage7.Size = new Size(999, 518);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Update Customer";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(465, 220);
            btnUpdateCustomer.Margin = new Padding(3, 4, 3, 4);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(86, 31);
            btnUpdateCustomer.TabIndex = 6;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // txtUpdateAddress
            // 
            txtUpdateAddress.Location = new Point(582, 49);
            txtUpdateAddress.Margin = new Padding(3, 4, 3, 4);
            txtUpdateAddress.Multiline = true;
            txtUpdateAddress.Name = "txtUpdateAddress";
            txtUpdateAddress.Size = new Size(160, 27);
            txtUpdateAddress.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(455, 52);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 3;
            label14.Text = "New Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 56);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 1;
            label12.Text = "Customer ID";
            // 
            // cbxUpdateCustomer
            // 
            cbxUpdateCustomer.FormattingEnabled = true;
            cbxUpdateCustomer.Location = new Point(181, 52);
            cbxUpdateCustomer.Margin = new Padding(3, 4, 3, 4);
            cbxUpdateCustomer.Name = "cbxUpdateCustomer";
            cbxUpdateCustomer.Size = new Size(138, 28);
            cbxUpdateCustomer.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 600);
            Controls.Add(tbcBank);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Bank Form";
            tbcBank.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btncreate;
        private TextBox txtAddress;
        private TextBox txtID;
        private TextBox txtCustomerID;
        private TextBox txtName;
        private TabPage tabPage7;
        private Button btnDeleteCustomer;
        private ComboBox cbxDeleteCustomer;
        private Label label5;
        private Label label6;
        private ComboBox cbxAddLoanToCustomer;
        private RadioButton radioButton1;
        private TextBox txtInterestRate;
        private TextBox txtTime;
        private TextBox txtPresentValue;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnAddLoanToCustomer;
        private RadioButton radioButton2;
        private Button button3;
        private ComboBox cbxDltLoanToCs;
        private Label label10;
        private ListBox lsbCustomers;
        private ListBox lsbLoansOfCustomers;
        private Label label11;
        private ComboBox cbxDltCsLoans;
        private Button btnUpdateCustomer;
        private TextBox txtUpdateAddress;
        private Label label14;
        private Label label12;
        private ComboBox cbxUpdateCustomer;
        private TabControl tbcBank;
    }
}