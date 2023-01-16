namespace ContactManagementSystem
{
    partial class Contacts
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
            this.label1 = new System.Windows.Forms.Label();
            this.DatagridviewContacts = new System.Windows.Forms.DataGridView();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxCatagory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCatagory = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.TextBoxSearchContacts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:*";
            // 
            // DatagridviewContacts
            // 
            this.DatagridviewContacts.AllowUserToAddRows = false;
            this.DatagridviewContacts.AllowUserToDeleteRows = false;
            this.DatagridviewContacts.AllowUserToOrderColumns = true;
            this.DatagridviewContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridviewContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DatagridviewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridviewContacts.Location = new System.Drawing.Point(13, 201);
            this.DatagridviewContacts.Name = "DatagridviewContacts";
            this.DatagridviewContacts.RowHeadersVisible = false;
            this.DatagridviewContacts.RowTemplate.Height = 25;
            this.DatagridviewContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridviewContacts.Size = new System.Drawing.Size(697, 181);
            this.DatagridviewContacts.TabIndex = 8;
            this.DatagridviewContacts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DatagridviewContacts_MouseDoubleClick);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(13, 69);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(202, 23);
            this.TextBoxName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mobile Number:*";
            // 
            // TextBoxMobile
            // 
            this.TextBoxMobile.Location = new System.Drawing.Point(498, 69);
            this.TextBoxMobile.Name = "TextBoxMobile";
            this.TextBoxMobile.Size = new System.Drawing.Size(212, 23);
            this.TextBoxMobile.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:*";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(254, 69);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(217, 23);
            this.TextBoxEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(13, 113);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(202, 23);
            this.TextBoxAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(173, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact Management System";
            // 
            // ComboBoxCatagory
            // 
            this.ComboBoxCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCatagory.FormattingEnabled = true;
            this.ComboBoxCatagory.Location = new System.Drawing.Point(254, 113);
            this.ComboBoxCatagory.Name = "ComboBoxCatagory";
            this.ComboBoxCatagory.Size = new System.Drawing.Size(217, 23);
            this.ComboBoxCatagory.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Catagory:*";
            // 
            // btnCatagory
            // 
            this.btnCatagory.Location = new System.Drawing.Point(13, 402);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Size = new System.Drawing.Size(100, 23);
            this.btnCatagory.TabIndex = 11;
            this.btnCatagory.Text = "Catagory";
            this.btnCatagory.UseVisualStyleBackColor = true;
            this.btnCatagory.Click += new System.EventHandler(this.btnCatagory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(610, 112);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Clear";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TextBoxSearchContacts
            // 
            this.TextBoxSearchContacts.Location = new System.Drawing.Point(505, 171);
            this.TextBoxSearchContacts.Name = "TextBoxSearchContacts";
            this.TextBoxSearchContacts.PlaceholderText = "Search by Name";
            this.TextBoxSearchContacts.Size = new System.Drawing.Size(202, 23);
            this.TextBoxSearchContacts.TabIndex = 7;
            this.TextBoxSearchContacts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchContacts_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "All Contacts";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(244, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Contact";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(643, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(498, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 437);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCatagory);
            this.Controls.Add(this.ComboBoxCatagory);
            this.Controls.Add(this.TextBoxSearchContacts);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxMobile);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatagridviewContacts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(739, 476);
            this.MinimumSize = new System.Drawing.Size(739, 476);
            this.Name = "Contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Activated += new System.EventHandler(this.Contacts_Activated);
            this.Load += new System.EventHandler(this.Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView DatagridviewContacts;
        private TextBox TextBoxName;
        private Label label2;
        private TextBox TextBoxMobile;
        private Label label3;
        private TextBox TextBoxEmail;
        private Label label4;
        private TextBox TextBoxAddress;
        private Label label5;
        private ComboBox ComboBoxCatagory;
        private Label label6;
        private Button btnCatagory;
        private Button btnRefresh;
        private TextBox TextBoxSearchContacts;
        private Label label8;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExit;
        private Button btnSave;
    }
}