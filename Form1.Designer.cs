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
            tabControl1 = new TabControl();
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
            button3 = new Button();
            comboBox2 = new ComboBox();
            label10 = new Label();
            tabPage6 = new TabPage();
            lsbLoansOfCustomers = new ListBox();
            tabPage7 = new TabPage();
            comboBox1 = new ComboBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            comboBox4 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
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
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(815, 413);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(807, 385);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(415, 88);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(75, 23);
            btncreate.TabIndex = 8;
            btncreate.Text = "Confirm";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click_1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(183, 133);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(183, 93);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 6;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(183, 55);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 136);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 96);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 58);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Name Surname";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteCustomer);
            tabPage2.Controls.Add(cbxDeleteCustomer);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(807, 385);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(377, 35);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(121, 23);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // cbxDeleteCustomer
            // 
            cbxDeleteCustomer.FormattingEnabled = true;
            cbxDeleteCustomer.Location = new Point(174, 32);
            cbxDeleteCustomer.Name = "cbxDeleteCustomer";
            cbxDeleteCustomer.Size = new Size(121, 23);
            cbxDeleteCustomer.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 35);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 0;
            label5.Text = "Customer ID";
            label5.Click += label5_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lsbCustomers);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(807, 385);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "List Customer";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lsbCustomers
            // 
            lsbCustomers.FormattingEnabled = true;
            lsbCustomers.ItemHeight = 15;
            lsbCustomers.Location = new Point(27, 16);
            lsbCustomers.Name = "lsbCustomers";
            lsbCustomers.ScrollAlwaysVisible = true;
            lsbCustomers.Size = new Size(602, 259);
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
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(807, 385);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Add Loan to Customer";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAddLoanToCustomer
            // 
            btnAddLoanToCustomer.Location = new Point(349, 244);
            btnAddLoanToCustomer.Name = "btnAddLoanToCustomer";
            btnAddLoanToCustomer.Size = new Size(160, 23);
            btnAddLoanToCustomer.TabIndex = 10;
            btnAddLoanToCustomer.Text = "Add loan to customer";
            btnAddLoanToCustomer.UseVisualStyleBackColor = true;
            btnAddLoanToCustomer.Click += btnAddLoanToCustomer_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(349, 194);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(247, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Calculate according to campound interest";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(349, 160);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(224, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Calculate according to simple interest";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(482, 108);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(100, 23);
            txtInterestRate.TabIndex = 7;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(482, 65);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 6;
            // 
            // txtPresentValue
            // 
            txtPresentValue.Location = new Point(482, 27);
            txtPresentValue.Name = "txtPresentValue";
            txtPresentValue.Size = new Size(100, 23);
            txtPresentValue.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(349, 108);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 4;
            label9.Text = "Interest rate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 73);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 3;
            label8.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 33);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 2;
            label7.Text = "Present Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 30);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 1;
            label6.Text = "Customer ID :";
            label6.Click += label6_Click_1;
            // 
            // cbxAddLoanToCustomer
            // 
            cbxAddLoanToCustomer.FormattingEnabled = true;
            cbxAddLoanToCustomer.Location = new Point(118, 27);
            cbxAddLoanToCustomer.Name = "cbxAddLoanToCustomer";
            cbxAddLoanToCustomer.Size = new Size(121, 23);
            cbxAddLoanToCustomer.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(comboBox1);
            tabPage5.Controls.Add(button3);
            tabPage5.Controls.Add(comboBox2);
            tabPage5.Controls.Add(label10);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(807, 385);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Delete Loan to Customer";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(459, 83);
            button3.Name = "button3";
            button3.Size = new Size(189, 23);
            button3.TabIndex = 5;
            button3.Text = "Delete Loan from Customer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(212, 35);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(84, 42);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 3;
            label10.Text = "Customer ID";
            label10.Click += label10_Click;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(lsbLoansOfCustomers);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(807, 385);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "List Loans of Customers";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // lsbLoansOfCustomers
            // 
            lsbLoansOfCustomers.FormattingEnabled = true;
            lsbLoansOfCustomers.ItemHeight = 15;
            lsbLoansOfCustomers.Location = new Point(38, 29);
            lsbLoansOfCustomers.Name = "lsbLoansOfCustomers";
            lsbLoansOfCustomers.ScrollAlwaysVisible = true;
            lsbLoansOfCustomers.Size = new Size(466, 184);
            lsbLoansOfCustomers.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(button1);
            tabPage7.Controls.Add(textBox1);
            tabPage7.Controls.Add(comboBox4);
            tabPage7.Controls.Add(label14);
            tabPage7.Controls.Add(label13);
            tabPage7.Controls.Add(label12);
            tabPage7.Controls.Add(comboBox3);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(807, 385);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Update Customer";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(84, 134);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 7;
            label11.Text = "Customer Loans";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(158, 39);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 42);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 1;
            label12.Text = "Customer ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(398, 43);
            label13.Name = "label13";
            label13.Size = new Size(71, 15);
            label13.TabIndex = 2;
            label13.Text = "Old Address";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(398, 91);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 3;
            label14.Text = "New Address";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(535, 42);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(535, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(398, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
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
        private TabControl tabControl1;
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
        private ComboBox comboBox2;
        private Label label10;
        private ListBox lsbCustomers;
        private ListBox lsbLoansOfCustomers;
        private Label label11;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox4;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox comboBox3;
    }
}