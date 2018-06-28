namespace Assignment_4
{
    partial class FrmChangeAccount
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
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label empPasswordLabel;
            System.Windows.Forms.Label empRoleLabel;
            this.bookStoreDataSet = new Assignment_4.BookStoreDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Assignment_4.BookStoreDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new Assignment_4.BookStoreDataSetTableAdapters.TableAdapterManager();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.empPasswordTextBox = new System.Windows.Forms.TextBox();
            this.empRoleCheckBox = new System.Windows.Forms.CheckBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            empIDLabel = new System.Windows.Forms.Label();
            empPasswordLabel = new System.Windows.Forms.Label();
            empRoleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(45, 41);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(45, 13);
            empIDLabel.TabIndex = 1;
            empIDLabel.Text = "Emp ID:";
            // 
            // empPasswordLabel
            // 
            empPasswordLabel.AutoSize = true;
            empPasswordLabel.Location = new System.Drawing.Point(45, 67);
            empPasswordLabel.Name = "empPasswordLabel";
            empPasswordLabel.Size = new System.Drawing.Size(80, 13);
            empPasswordLabel.TabIndex = 3;
            empPasswordLabel.Text = "Emp Password:";
            // 
            // empRoleLabel
            // 
            empRoleLabel.AutoSize = true;
            empRoleLabel.Location = new System.Drawing.Point(45, 95);
            empRoleLabel.Name = "empRoleLabel";
            empRoleLabel.Size = new System.Drawing.Size(56, 13);
            empRoleLabel.TabIndex = 5;
            empRoleLabel.Text = "Emp Role:";
            // 
            // bookStoreDataSet
            // 
            this.bookStoreDataSet.DataSetName = "BookStoreDataSet";
            this.bookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bookStoreDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Assignment_4.BookStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpID", true));
            this.empIDTextBox.Enabled = false;
            this.empIDTextBox.Location = new System.Drawing.Point(131, 38);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.empIDTextBox.TabIndex = 2;
            // 
            // empPasswordTextBox
            // 
            this.empPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpPassword", true));
            this.empPasswordTextBox.Location = new System.Drawing.Point(131, 64);
            this.empPasswordTextBox.Name = "empPasswordTextBox";
            this.empPasswordTextBox.Size = new System.Drawing.Size(104, 20);
            this.empPasswordTextBox.TabIndex = 4;
            // 
            // empRoleCheckBox
            // 
            this.empRoleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeeBindingSource, "EmpRole", true));
            this.empRoleCheckBox.Enabled = false;
            this.empRoleCheckBox.Location = new System.Drawing.Point(131, 90);
            this.empRoleCheckBox.Name = "empRoleCheckBox";
            this.empRoleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.empRoleCheckBox.TabIndex = 6;
            this.empRoleCheckBox.UseVisualStyleBackColor = true;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Location = new System.Drawing.Point(131, 121);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(103, 23);
            this.changePasswordBtn.TabIndex = 7;
            this.changePasswordBtn.Text = "Change password";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // FrmChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(empPasswordLabel);
            this.Controls.Add(this.empPasswordTextBox);
            this.Controls.Add(empRoleLabel);
            this.Controls.Add(this.empRoleCheckBox);
            this.Name = "FrmChangeAccount";
            this.Text = "FrmChangeAccount";
            this.Load += new System.EventHandler(this.FrmChangeAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookStoreDataSet bookStoreDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BookStoreDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private BookStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox empPasswordTextBox;
        private System.Windows.Forms.CheckBox empRoleCheckBox;
        private System.Windows.Forms.Button changePasswordBtn;
    }
}