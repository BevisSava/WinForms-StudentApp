namespace WinFormUI
{
    partial class CustomerForm
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
            lName = new Label();
            lEmail = new Label();
            lCustomerID = new Label();
            NameCustomer = new TextBox();
            Email = new TextBox();
            CustomerID = new TextBox();
            bAddCus = new Button();
            bGetCus = new Button();
            SuspendLayout();
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new Point(80, 77);
            lName.Name = "lName";
            lName.Size = new Size(49, 20);
            lName.TabIndex = 0;
            lName.Text = "Name";
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Location = new Point(83, 110);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(46, 20);
            lEmail.TabIndex = 1;
            lEmail.Text = "Email";
            // 
            // lCustomerID
            // 
            lCustomerID.AutoSize = true;
            lCustomerID.Location = new Point(38, 144);
            lCustomerID.Name = "lCustomerID";
            lCustomerID.Size = new Size(91, 20);
            lCustomerID.TabIndex = 2;
            lCustomerID.Text = "Customer ID";
            // 
            // NameCustomer
            // 
            NameCustomer.Location = new Point(135, 74);
            NameCustomer.Name = "NameCustomer";
            NameCustomer.Size = new Size(125, 27);
            NameCustomer.TabIndex = 3;
            // 
            // Email
            // 
            Email.Location = new Point(135, 107);
            Email.Name = "Email";
            Email.Size = new Size(125, 27);
            Email.TabIndex = 4;
            // 
            // CustomerID
            // 
            CustomerID.Location = new Point(135, 144);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(125, 27);
            CustomerID.TabIndex = 5;
            // 
            // bAddCus
            // 
            bAddCus.Location = new Point(27, 188);
            bAddCus.Name = "bAddCus";
            bAddCus.Size = new Size(129, 29);
            bAddCus.TabIndex = 6;
            bAddCus.Text = "Add Customer";
            bAddCus.UseVisualStyleBackColor = true;
            bAddCus.Click += bAddCus_Click;
            // 
            // bGetCus
            // 
            bGetCus.Location = new Point(162, 188);
            bGetCus.Name = "bGetCus";
            bGetCus.Size = new Size(129, 29);
            bGetCus.TabIndex = 7;
            bGetCus.Text = "Get Customer";
            bGetCus.UseVisualStyleBackColor = true;
            bGetCus.Click += bGetCus_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bGetCus);
            Controls.Add(bAddCus);
            Controls.Add(CustomerID);
            Controls.Add(Email);
            Controls.Add(NameCustomer);
            Controls.Add(lCustomerID);
            Controls.Add(lEmail);
            Controls.Add(lName);
            Name = "CustomerForm";
            Text = "Form1";
            Load += CustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lName;
        private Label lEmail;
        private Label lCustomerID;
        private TextBox NameCustomer;
        private TextBox Email;
        private TextBox CustomerID;
        private Button bAddCus;
        private Button bGetCus;
    }
}
