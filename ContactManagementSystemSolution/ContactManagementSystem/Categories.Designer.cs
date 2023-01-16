namespace ContactManagementSystem
{
    partial class Categories
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
            this.TextBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.DatagridviewCategory = new System.Windows.Forms.DataGridView();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSearchCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCategoryName
            // 
            this.TextBoxCategoryName.Location = new System.Drawing.Point(12, 27);
            this.TextBoxCategoryName.Name = "TextBoxCategoryName";
            this.TextBoxCategoryName.Size = new System.Drawing.Size(234, 23);
            this.TextBoxCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name:*";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(12, 56);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(234, 23);
            this.btnCategoryAdd.TabIndex = 1;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCatagoryAdd_Click);
            // 
            // DatagridviewCategory
            // 
            this.DatagridviewCategory.AllowUserToAddRows = false;
            this.DatagridviewCategory.AllowUserToDeleteRows = false;
            this.DatagridviewCategory.AllowUserToResizeColumns = false;
            this.DatagridviewCategory.AllowUserToResizeRows = false;
            this.DatagridviewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridviewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridviewCategory.Location = new System.Drawing.Point(12, 122);
            this.DatagridviewCategory.Name = "DatagridviewCategory";
            this.DatagridviewCategory.RowHeadersVisible = false;
            this.DatagridviewCategory.RowTemplate.Height = 25;
            this.DatagridviewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridviewCategory.Size = new System.Drawing.Size(234, 150);
            this.DatagridviewCategory.TabIndex = 3;
            this.DatagridviewCategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DatagridviewCatagory_MouseDoubleClick);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(12, 278);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnCategoryUpdate.TabIndex = 4;
            this.btnCategoryUpdate.Text = "Update";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(130, 278);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(116, 23);
            this.btnCategoryDelete.TabIndex = 5;
            this.btnCategoryDelete.Text = "Delete";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCatagoryDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(234, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Categories";
            // 
            // TextBoxSearchCategory
            // 
            this.TextBoxSearchCategory.Location = new System.Drawing.Point(108, 93);
            this.TextBoxSearchCategory.Name = "TextBoxSearchCategory";
            this.TextBoxSearchCategory.PlaceholderText = "Search by Name";
            this.TextBoxSearchCategory.Size = new System.Drawing.Size(138, 23);
            this.TextBoxSearchCategory.TabIndex = 2;
            this.TextBoxSearchCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchCategory_KeyUp);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 350);
            this.Controls.Add(this.DatagridviewCategory);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSearchCategory);
            this.Controls.Add(this.TextBoxCategoryName);
            this.MaximumSize = new System.Drawing.Size(273, 389);
            this.MinimumSize = new System.Drawing.Size(273, 389);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catagorys";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxCategoryName;
        private Label label1;
        private Button btnCategoryAdd;
        private DataGridView DatagridviewCategory;
        private Button btnCategoryUpdate;
        private Button btnCategoryDelete;
        private Button btnBack;
        private Label label2;
        private TextBox TextBoxSearchCategory;
    }
}