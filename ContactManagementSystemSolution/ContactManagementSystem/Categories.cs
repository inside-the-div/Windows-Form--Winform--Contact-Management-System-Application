using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManagementSystem
{
    public partial class Categories : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source =.; Initial Catalog=CMSDB; TrustServerCertificate=True; Integrated Security=True ");
        public int CategoryID;
        public string PreviosCategoryName;
        public Categories()
        {
            InitializeComponent();
            CategorysDisplay();
            btnCategoryUpdate.Enabled = false;
        }
        public void ClearCategoryTextFeild()
        {
            TextBoxCategoryName.Text = string.Empty;
        }
        public void CategorysDisplay()
        {
            string SqlQuery = "SELECT ct.Categoryid AS ID, ct.CategoryName AS Category, COUNT(c.Categoryid) AS 'Total Numbers' FROM Categories ct" +
                                " LEFT JOIN Contacts c ON " +
                                "c.CategoryID = ct.CategoryID GROUP BY ct.Categoryid, ct.CategoryName";
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter(SqlQuery, DBconnection);
            DataTable CategoryDataTable = new DataTable();
            SQLselectQuery.Fill(CategoryDataTable);
            DatagridviewCategory.DataSource = CategoryDataTable;
            DatagridviewCategory.ClearSelection();
            this.DatagridviewCategory.Columns["ID"].Visible = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        private void btnCatagoryAdd_Click(object sender, EventArgs e)
        {
            string NewCategoryName = TextBoxCategoryName.Text;
            string ErrorMessage = CategoryNameValidation(NewCategoryName);
            if (ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage);
            }

            else if (DuplicateCount(NewCategoryName) > 0)
            {
                ErrorMessage = NewCategoryName + " is already exist.\nAdd a new Category.";
                MessageBox.Show(ErrorMessage);
            }
            else
            {
                string CategoryAddQuery = "INSERT INTO Categories (CategoryName) VALUES ('"+NewCategoryName+"')";
                DBconnection.Open();
                SqlCommand CategoryAdd = new SqlCommand(CategoryAddQuery, DBconnection);
                if (CategoryAdd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Category Added successfully.");
                    btnCategoryUpdate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Something Wrong!, Try Again");
                }
                CategorysDisplay();
                ClearCategoryTextFeild();
                DBconnection.Close();
            }
        }

        
        public int DuplicateCount(string CategoryName)
        {
            CategoryName = CategoryName.Trim();
            CategoryName = CategoryName.ToLower();
            int count = 0;
            foreach (DataGridViewRow row in DatagridviewCategory.Rows)
            {
                string RowString = row.Cells[1].Value.ToString();
                RowString = RowString.ToLower();
                if (CategoryName == RowString)
                {
                    count++;
                }
            }
            return count;
        }
        public string CategoryNameValidation(string Name)
        {
            string ErrorMessage = string.Empty;
            Name = Name.Trim();
            int NameLength = Name.Length;
            Regex r = new Regex("^[a-zA-Z]([a-zA-Z0-9 ])*$");
            if (Name == "")
            {
                ErrorMessage = "Enter Category Name!!!\nName must be between 3-20 Characters.";
            }
            else if (NameLength < 3 || NameLength > 20)
            {
                ErrorMessage = "Invalid Category Name!!!\nName must be between 3-20 Characters.";
            }
            else if (!r.IsMatch(Name))
            {
                ErrorMessage = "Invalid Category Name!!!\nCategory Name can be letters only or combination of letters and numbers and\nCategory name can not start with number";
            }
            else
            {
                ErrorMessage = string.Empty;
            }
            return ErrorMessage;
        }

        private void DatagridviewCatagory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CategoryID = int.Parse(DatagridviewCategory.SelectedRows[0].Cells[0].Value.ToString());
            PreviosCategoryName = DatagridviewCategory.SelectedRows[0].Cells[1].Value.ToString();
            TextBoxCategoryName.Text = PreviosCategoryName;
            btnCategoryUpdate.Enabled = true;
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            bool Isvalid = true;
            string NewCategoryName = TextBoxCategoryName.Text;
            NewCategoryName = NewCategoryName.Trim();
            string ErrorMessage = CategoryNameValidation(NewCategoryName);
            
            if (Isvalid)
            {
                if (ErrorMessage != "")
                {
                    Isvalid = false;
                }
            }

            if (Isvalid)
            {
                if (DuplicateCount(NewCategoryName) >= 1)
                {
                    if ((NewCategoryName.ToLower()) != (PreviosCategoryName.ToLower()))
                    {
                        ErrorMessage = NewCategoryName + " is already exist.\nAdd a new Category";
                        Isvalid = false;
                    }
                    else
                    {
                        ErrorMessage = NewCategoryName + " is Updated";
                        ClearCategoryTextFeild();
                        btnCategoryUpdate.Enabled = false;
                        Isvalid = false;
                    }
                }
            }
            
            if(Isvalid)
            {
                string CategoryAddQuery = "UPDATE Categories SET CategoryName = '"
                    + NewCategoryName + "' WHERE CategoryID = " + CategoryID;
                DBconnection.Open();
                SqlCommand CategoryAdd = new SqlCommand(CategoryAddQuery, DBconnection);
                if (CategoryAdd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Category Updated successfully.");
                    btnCategoryUpdate.Enabled = false;
                    ClearCategoryTextFeild();
                }
                else
                {
                    MessageBox.Show("Something Error, Try Again");
                }
                CategorysDisplay();
                DBconnection.Close();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnCatagoryDelete_Click(object sender, EventArgs e)
        {
            string Error = string.Empty;
            string Ids = string.Empty;
            foreach(DataGridViewRow row in DatagridviewCategory.SelectedRows)
            {
                int id = (int)row.Cells[0].Value;
                if (id == 1)
                {
                    Error = "You can not delete Category 'Unassign'";
                }
                else
                {
                    Ids += id.ToString() + ",";
                }
            }
            Ids = Ids.TrimEnd(',');
            string UpdateQuerry = "UPDATE Contacts SET CategoryID = 1 WHERE  CategoryID IN ("+ Ids + ")";
            string DeleteQuerry = "DELETE FROM Categories  WHERE  CategoryID IN ("+ Ids + ")";
            if (Error != "")
            {
                MessageBox.Show(Error);
                DatagridviewCategory.ClearSelection();
            }
            else
            {
                DBconnection.Open();
                using(SqlTransaction transaction = DBconnection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand updateCommand = new SqlCommand(UpdateQuerry, DBconnection, transaction))
                        updateCommand.ExecuteNonQuery();
                        using (SqlCommand deleteCommand = new SqlCommand(DeleteQuerry, DBconnection, transaction))                        
                        deleteCommand.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show("Category deleted successfully.");
                    CategorysDisplay();
                }
                DBconnection.Close();
            }
        }

        private void TextBoxSearchCategory_KeyUp(object sender, KeyEventArgs e)
        {
            string SearchValue = TextBoxSearchCategory.Text.Trim().ToLower();
            foreach (DataGridViewRow row in DatagridviewCategory.Rows)
            {
                var SearchName = row.Cells[1].Value.ToString();
                var SearchNameLower = SearchName.ToLower();
                if (!SearchNameLower.Contains(SearchValue))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewCategory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewCategory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = true;
                    currencyManager1.ResumeBinding();
                }
            }
        }
    }
}
