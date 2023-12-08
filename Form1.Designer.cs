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
            pnlInterest = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            compoundInterest = new Button();
            simpleInterest = new Button();
            textInterestRate = new TextBox();
            textTime = new TextBox();
            textPresentValue = new TextBox();
            pnlInsideForm = new Panel();
            label7 = new Label();
            txtCustomerID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btncreate = new Button();
            txtID = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            pnlSearch = new Panel();
            panel4 = new Panel();
            btnConfirm = new Button();
            rbtList = new RadioButton();
            rbtSearch = new RadioButton();
            rbtAdd = new RadioButton();
            pnlListNames = new Panel();
            lsbNames = new ListBox();
            pnlInterest.SuspendLayout();
            pnlInsideForm.SuspendLayout();
            panel4.SuspendLayout();
            pnlListNames.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInterest
            // 
            pnlInterest.BorderStyle = BorderStyle.FixedSingle;
            pnlInterest.Controls.Add(label3);
            pnlInterest.Controls.Add(label2);
            pnlInterest.Controls.Add(label1);
            pnlInterest.Controls.Add(compoundInterest);
            pnlInterest.Controls.Add(simpleInterest);
            pnlInterest.Controls.Add(textInterestRate);
            pnlInterest.Controls.Add(textTime);
            pnlInterest.Controls.Add(textPresentValue);
            pnlInterest.ForeColor = SystemColors.ActiveCaptionText;
            pnlInterest.Location = new Point(540, 22);
            pnlInterest.Name = "pnlInterest";
            pnlInterest.Size = new Size(265, 366);
            pnlInterest.TabIndex = 0;
            pnlInterest.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 147);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 7;
            label3.Text = "Interest rate %  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Time :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 5;
            label1.Text = "Present Value :";
            // 
            // compoundInterest
            // 
            compoundInterest.BackColor = SystemColors.ActiveCaption;
            compoundInterest.ForeColor = SystemColors.MenuHighlight;
            compoundInterest.Location = new Point(155, 252);
            compoundInterest.Name = "compoundInterest";
            compoundInterest.Size = new Size(104, 46);
            compoundInterest.TabIndex = 4;
            compoundInterest.Text = "Compound Interest";
            compoundInterest.UseVisualStyleBackColor = false;
            compoundInterest.Click += compoundInterest_Click;
            // 
            // simpleInterest
            // 
            simpleInterest.BackColor = SystemColors.ActiveCaption;
            simpleInterest.ForeColor = SystemColors.MenuHighlight;
            simpleInterest.Location = new Point(18, 252);
            simpleInterest.Name = "simpleInterest";
            simpleInterest.Size = new Size(104, 46);
            simpleInterest.TabIndex = 3;
            simpleInterest.Text = "Simple Interest";
            simpleInterest.UseVisualStyleBackColor = false;
            simpleInterest.Click += simpleInterest_Click;
            // 
            // textInterestRate
            // 
            textInterestRate.Location = new Point(132, 144);
            textInterestRate.Name = "textInterestRate";
            textInterestRate.Size = new Size(100, 23);
            textInterestRate.TabIndex = 2;
            // 
            // textTime
            // 
            textTime.Location = new Point(132, 89);
            textTime.Name = "textTime";
            textTime.Size = new Size(100, 23);
            textTime.TabIndex = 1;
            // 
            // textPresentValue
            // 
            textPresentValue.Location = new Point(132, 34);
            textPresentValue.Name = "textPresentValue";
            textPresentValue.Size = new Size(100, 23);
            textPresentValue.TabIndex = 0;
            // 
            // pnlInsideForm
            // 
            pnlInsideForm.Controls.Add(label7);
            pnlInsideForm.Controls.Add(txtCustomerID);
            pnlInsideForm.Controls.Add(label6);
            pnlInsideForm.Controls.Add(label5);
            pnlInsideForm.Controls.Add(label4);
            pnlInsideForm.Controls.Add(btncreate);
            pnlInsideForm.Controls.Add(txtID);
            pnlInsideForm.Controls.Add(txtAddress);
            pnlInsideForm.Controls.Add(txtName);
            pnlInsideForm.Location = new Point(269, 22);
            pnlInsideForm.Name = "pnlInsideForm";
            pnlInsideForm.Size = new Size(251, 416);
            pnlInsideForm.TabIndex = 1;
            pnlInsideForm.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 101);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 8;
            label7.Text = "Address";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(118, 228);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 231);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 6;
            label6.Text = "Customer ID";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 160);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 5;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 38);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 4;
            label4.Text = "Name Surname";
            // 
            // btncreate
            // 
            btncreate.Location = new Point(159, 390);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(75, 23);
            btncreate.TabIndex = 3;
            btncreate.Text = "Create";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(118, 157);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(118, 93);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // pnlSearch
            // 
            pnlSearch.ImeMode = ImeMode.On;
            pnlSearch.Location = new Point(829, 22);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(259, 366);
            pnlSearch.TabIndex = 2;
            pnlSearch.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnConfirm);
            panel4.Controls.Add(rbtList);
            panel4.Controls.Add(rbtSearch);
            panel4.Controls.Add(rbtAdd);
            panel4.Location = new Point(12, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 366);
            panel4.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(21, 244);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // rbtList
            // 
            rbtList.AutoSize = true;
            rbtList.Location = new Point(25, 144);
            rbtList.Name = "rbtList";
            rbtList.Size = new Size(120, 19);
            rbtList.TabIndex = 2;
            rbtList.TabStop = true;
            rbtList.Text = "List All Customers";
            rbtList.UseVisualStyleBackColor = true;
            // 
            // rbtSearch
            // 
            rbtSearch.AutoSize = true;
            rbtSearch.Location = new Point(25, 96);
            rbtSearch.Name = "rbtSearch";
            rbtSearch.Size = new Size(115, 19);
            rbtSearch.TabIndex = 1;
            rbtSearch.TabStop = true;
            rbtSearch.Text = "Search Customer";
            rbtSearch.UseVisualStyleBackColor = true;
            // 
            // rbtAdd
            // 
            rbtAdd.AutoSize = true;
            rbtAdd.Location = new Point(25, 43);
            rbtAdd.Name = "rbtAdd";
            rbtAdd.Size = new Size(102, 19);
            rbtAdd.TabIndex = 0;
            rbtAdd.TabStop = true;
            rbtAdd.Text = "Add Customer";
            rbtAdd.UseVisualStyleBackColor = true;
            rbtAdd.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // pnlListNames
            // 
            pnlListNames.Controls.Add(lsbNames);
            pnlListNames.Location = new Point(1107, 22);
            pnlListNames.Name = "pnlListNames";
            pnlListNames.Size = new Size(251, 366);
            pnlListNames.TabIndex = 4;
            pnlListNames.Visible = false;
            // 
            // lsbNames
            // 
            lsbNames.FormattingEnabled = true;
            lsbNames.ItemHeight = 15;
            lsbNames.Location = new Point(20, 35);
            lsbNames.Name = "lsbNames";
            lsbNames.Size = new Size(211, 289);
            lsbNames.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 450);
            Controls.Add(pnlListNames);
            Controls.Add(panel4);
            Controls.Add(pnlSearch);
            Controls.Add(pnlInsideForm);
            Controls.Add(pnlInterest);
            Name = "Form1";
            Text = "Form1";
            pnlInterest.ResumeLayout(false);
            pnlInterest.PerformLayout();
            pnlInsideForm.ResumeLayout(false);
            pnlInsideForm.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlListNames.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInterest;
        private TextBox textPresentValue;
        private Button compoundInterest;
        private Button simpleInterest;
        private TextBox textInterestRate;
        private TextBox textTime;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel pnlInsideForm;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btncreate;
        private Panel pnlSearch;
        private Panel panel4;
        private RadioButton rbtList;
        private RadioButton rbtSearch;
        private RadioButton rbtAdd;
        private Button btnConfirm;
        private Panel pnlListNames;
        private Label label7;
        private TextBox txtCustomerID;
        private ListBox lsbNames;
    }
}