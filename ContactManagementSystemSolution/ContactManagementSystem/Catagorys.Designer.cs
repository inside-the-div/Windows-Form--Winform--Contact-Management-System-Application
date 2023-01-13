namespace ContactManagementSystem
{
    partial class Catagorys
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
            this.TextBoxCatagoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCatagoryAdd = new System.Windows.Forms.Button();
            this.DatagridviewCatagory = new System.Windows.Forms.DataGridView();
            this.btnCatagoryUpdate = new System.Windows.Forms.Button();
            this.btnCatagoryDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSearchCatagory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewCatagory)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCatagoryName
            // 
            this.TextBoxCatagoryName.Location = new System.Drawing.Point(12, 27);
            this.TextBoxCatagoryName.Name = "TextBoxCatagoryName";
            this.TextBoxCatagoryName.Size = new System.Drawing.Size(234, 23);
            this.TextBoxCatagoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catagory Name:*";
            // 
            // btnCatagoryAdd
            // 
            this.btnCatagoryAdd.Location = new System.Drawing.Point(12, 56);
            this.btnCatagoryAdd.Name = "btnCatagoryAdd";
            this.btnCatagoryAdd.Size = new System.Drawing.Size(234, 23);
            this.btnCatagoryAdd.TabIndex = 1;
            this.btnCatagoryAdd.Text = "Add";
            this.btnCatagoryAdd.UseVisualStyleBackColor = true;
            this.btnCatagoryAdd.Click += new System.EventHandler(this.btnCatagoryAdd_Click);
            // 
            // DatagridviewCatagory
            // 
            this.DatagridviewCatagory.AllowUserToAddRows = false;
            this.DatagridviewCatagory.AllowUserToDeleteRows = false;
            this.DatagridviewCatagory.AllowUserToResizeColumns = false;
            this.DatagridviewCatagory.AllowUserToResizeRows = false;
            this.DatagridviewCatagory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridviewCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridviewCatagory.Location = new System.Drawing.Point(12, 122);
            this.DatagridviewCatagory.Name = "DatagridviewCatagory";
            this.DatagridviewCatagory.RowHeadersVisible = false;
            this.DatagridviewCatagory.RowTemplate.Height = 25;
            this.DatagridviewCatagory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridviewCatagory.Size = new System.Drawing.Size(234, 150);
            this.DatagridviewCatagory.TabIndex = 3;
            this.DatagridviewCatagory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DatagridviewCatagory_MouseDoubleClick);
            // 
            // btnCatagoryUpdate
            // 
            this.btnCatagoryUpdate.Location = new System.Drawing.Point(12, 278);
            this.btnCatagoryUpdate.Name = "btnCatagoryUpdate";
            this.btnCatagoryUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnCatagoryUpdate.TabIndex = 3;
            this.btnCatagoryUpdate.Text = "Update";
            this.btnCatagoryUpdate.UseVisualStyleBackColor = true;
            this.btnCatagoryUpdate.Click += new System.EventHandler(this.btnCatagoryUpdate_Click);
            // 
            // btnCatagoryDelete
            // 
            this.btnCatagoryDelete.Location = new System.Drawing.Point(130, 278);
            this.btnCatagoryDelete.Name = "btnCatagoryDelete";
            this.btnCatagoryDelete.Size = new System.Drawing.Size(116, 23);
            this.btnCatagoryDelete.TabIndex = 4;
            this.btnCatagoryDelete.Text = "Delete";
            this.btnCatagoryDelete.UseVisualStyleBackColor = true;
            this.btnCatagoryDelete.Click += new System.EventHandler(this.btnCatagoryDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(234, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Catagorys";
            // 
            // TextBoxSearchCatagory
            // 
            this.TextBoxSearchCatagory.Location = new System.Drawing.Point(108, 93);
            this.TextBoxSearchCatagory.Name = "TextBoxSearchCatagory";
            this.TextBoxSearchCatagory.PlaceholderText = "Search by Name";
            this.TextBoxSearchCatagory.Size = new System.Drawing.Size(138, 23);
            this.TextBoxSearchCatagory.TabIndex = 2;
            this.TextBoxSearchCatagory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchCatagory_KeyUp);
            // 
            // Catagorys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 350);
            this.Controls.Add(this.DatagridviewCatagory);
            this.Controls.Add(this.btnCatagoryDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCatagoryUpdate);
            this.Controls.Add(this.btnCatagoryAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSearchCatagory);
            this.Controls.Add(this.TextBoxCatagoryName);
            this.MaximumSize = new System.Drawing.Size(273, 389);
            this.MinimumSize = new System.Drawing.Size(273, 389);
            this.Name = "Catagorys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catagorys";
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewCatagory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxCatagoryName;
        private Label label1;
        private Button btnCatagoryAdd;
        private DataGridView DatagridviewCatagory;
        private Button btnCatagoryUpdate;
        private Button btnCatagoryDelete;
        private Button btnBack;
        private Label label2;
        private TextBox TextBoxSearchCatagory;
    }
}