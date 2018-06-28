namespace Assignment_4
{
    partial class FrmLogin
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet = new Assignment_4.BookStoreDataSet();
            this.employeeTableAdapter = new Assignment_4.BookStoreDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new Assignment_4.BookStoreDataSetTableAdapters.TableAdapterManager();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.empPasswordTextBox = new System.Windows.Forms.TextBox();
            empIDLabel = new System.Windows.Forms.Label();
            empPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(101, 66);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(45, 13);
            empIDLabel.TabIndex = 1;
            empIDLabel.Text = "Emp ID:";
            // 
            // empPasswordLabel
            // 
            empPasswordLabel.AutoSize = true;
            empPasswordLabel.Location = new System.Drawing.Point(66, 90);
            empPasswordLabel.Name = "empPasswordLabel";
            empPasswordLabel.Size = new System.Drawing.Size(80, 13);
            empPasswordLabel.TabIndex = 3;
            empPasswordLabel.Text = "Emp Password:";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(176, 114);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bookStoreDataSet;
            // 
            // bookStoreDataSet
            // 
            this.bookStoreDataSet.DataSetName = "BookStoreDataSet";
            this.bookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.empIDTextBox.Location = new System.Drawing.Point(153, 66);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.empIDTextBox.TabIndex = 6;
            // 
            // empPasswordTextBox
            // 
            this.empPasswordTextBox.Location = new System.Drawing.Point(153, 88);
            this.empPasswordTextBox.Name = "empPasswordTextBox";
            this.empPasswordTextBox.PasswordChar = '*';
            this.empPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.empPasswordTextBox.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 194);
            this.Controls.Add(this.empPasswordTextBox);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(empPasswordLabel);
            this.Controls.Add(empIDLabel);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookStoreDataSet bookStoreDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BookStoreDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private BookStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox empPasswordTextBox;
    }
}

