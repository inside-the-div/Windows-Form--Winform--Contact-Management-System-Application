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
    public partial class Catagorys : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source =.; Initial Catalog=CMSDB; TrustServerCertificate=True; Integrated Security=True ");
        public int CatagoryID;
        public string PreviosCatagoryName;
        public Catagorys()
        {
            InitializeComponent();
            CatagorysDisplay();
            btnCatagoryUpdate.Enabled = false;
        }
        public void ClearCatagoryTextFeild()
        {
            TextBoxCatagoryName.Text = string.Empty;
        }
        public void CatagorysDisplay()
        {
            string SqlQuery = "SELECT ct.Catagoryid AS ID, ct.CatagoryName AS Catagory, COUNT(c.Catagoryid) AS 'Total Number' FROM Catagorys ct" +
                                " LEFT JOIN Contacts c ON " +
                                "c.CatagoryID = ct.CatagoryID GROUP BY ct.Catagoryid, CatagoryName";
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter(SqlQuery, DBconnection);
            DataTable CatagoryDataTable = new DataTable();
            SQLselectQuery.Fill(CatagoryDataTable);
            DatagridviewCatagory.DataSource = CatagoryDataTable;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
        private void btnCatagoryAdd_Click(object sender, EventArgs e)
        {
            string NewCatagoryName = TextBoxCatagoryName.Text;
            string ErrorMessage = CatagoryNameValidation(NewCatagoryName);
            if (ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage);
            }

            else if (DuplicateCount(NewCatagoryName) > 0)
            {
                ErrorMessage = NewCatagoryName + " is already exist.\nAdd a new Catagory";
                MessageBox.Show(ErrorMessage);
            }
            else
            {
                string CatagoryAddQuery = "INSERT INTO Catagorys (CatagoryName) VALUES ('"+NewCatagoryName+"')";
                DBconnection.Open();
                SqlCommand CatagoryAdd = new SqlCommand(CatagoryAddQuery, DBconnection);
                if (CatagoryAdd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Category Added successfully.");
                    btnCatagoryUpdate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Something Error, Try Again");
                }
                CatagorysDisplay();
                ClearCatagoryTextFeild();
                DBconnection.Close();
            }
        }

        
        public int DuplicateCount(string CatagoryName)
        {
            CatagoryName = CatagoryName.Trim();
            CatagoryName = CatagoryName.ToLower();
            int count = 0;
            foreach (DataGridViewRow row in DatagridviewCatagory.Rows)
            {
                string RowString = row.Cells[0].Value.ToString();
                RowString = RowString.ToLower();
                if (CatagoryName == RowString)
                {
                    count++;
                }
            }
            return count;
        }
        public string CatagoryNameValidation(string Name)
        {
            string ErrorMessage = string.Empty;
            Name = Name.Trim();
            int NameLength = Name.Length;
            Regex r = new Regex("^[a-zA-Z]([a-zA-Z0-9 ])*$");
            if (Name == "")
            {
                ErrorMessage = "Enter Catagory Name!!!\nName must be between 3-20 Characters.";
            }
            else if (NameLength < 3 || NameLength > 20)
            {
                ErrorMessage = "Invalid Catagory Name!!!\nName must be between 3-20 Characters.";
            }
            else if (!r.IsMatch(Name))
            {
                ErrorMessage = "Invalid Catagory Name!!!\nCatagory Name can be letters only or combination of letters and numbers and\nCatagory name can not start with number";
            }
            else
            {
                ErrorMessage = string.Empty;
            }
            return ErrorMessage;
        }

        private void DatagridviewCatagory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CatagoryID = int.Parse(DatagridviewCatagory.SelectedRows[0].Cells[0].Value.ToString());
            PreviosCatagoryName = DatagridviewCatagory.SelectedRows[0].Cells[1].Value.ToString();
            TextBoxCatagoryName.Text = PreviosCatagoryName;
            btnCatagoryUpdate.Enabled = true;
        }

        private void btnCatagoryUpdate_Click(object sender, EventArgs e)
        {
            bool Isvalid = true;
            string NewCatagoryName = TextBoxCatagoryName.Text;
            NewCatagoryName = NewCatagoryName.Trim();
            string ErrorMessage = CatagoryNameValidation(NewCatagoryName);
            
            if (Isvalid)
            {
                if (ErrorMessage != "")
                {
                    Isvalid = false;
                }
            }

            if (Isvalid)
            {
                if (DuplicateCount(NewCatagoryName) >= 1)
                {
                    if ((NewCatagoryName.ToLower()) != (PreviosCatagoryName.ToLower()))
                    {
                        ErrorMessage = NewCatagoryName + " is already exist.\nAdd a new Catagory";
                        Isvalid = false;
                    }
                    else
                    {
                        ErrorMessage = NewCatagoryName + " is Updated";
                        ClearCatagoryTextFeild();
                        btnCatagoryUpdate.Enabled = false;
                        Isvalid = false;
                    }
                }
            }
            
            if(Isvalid)
            {
                string CatagoryAddQuery = "UPDATE Catagorys SET CatagoryName = '"
                    + NewCatagoryName + "' WHERE CatagoryID = " + CatagoryID;
                DBconnection.Open();
                SqlCommand CatagoryAdd = new SqlCommand(CatagoryAddQuery, DBconnection);
                if (CatagoryAdd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Category Updated successfully.");
                    btnCatagoryUpdate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Something Error, Try Again");
                }
                CatagorysDisplay();
                ClearCatagoryTextFeild();
                DBconnection.Close();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnCatagoryDelete_Click(object sender, EventArgs e)//fix the loop for delete 
        {
            DBconnection.Open();
            int TotalRow = DatagridviewCatagory.Rows.Count;
            for (int i = 0; i < TotalRow; i++)
            { /*for fixing the bug we have to store all the selected id in a array then delete all the rows*/
                DataGridViewRow gridViewRow = DatagridviewCatagory.Rows[i]; 
                if (gridViewRow.Selected == true)
                {
                    CatagoryID = int.Parse(DatagridviewCatagory.Rows[i].Cells[0].Value.ToString());
                    if (CatagoryID == 1)
                    {
                        MessageBox.Show("You can not delete this Catagory");
                    }
                    else
                    {
                        string UpdateQuery = "UPDATE Contacts SET CatagoryID = 1 WHERE CatagoryID = " + CatagoryID;
                        string DeleteQuery = "DELETE Catagorys WHERE CatagoryID = " + CatagoryID;
                        using (SqlTransaction transaction = DBconnection.BeginTransaction())
                        {
                            try
                            {
                                using (SqlCommand UpdatedCommand = new SqlCommand(UpdateQuery, DBconnection, transaction))
                                    UpdatedCommand.ExecuteNonQuery();
                                using (SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, DBconnection, transaction))
                                    DeleteCommand.ExecuteNonQuery();
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw ex;
                            }
                        }
                        MessageBox.Show("Catagory Deleted Successfully");
                        CatagorysDisplay();
                    }
                }                
            }
            DBconnection.Close();
                                  
        }

        private void TextBoxSearchCatagory_KeyUp(object sender, KeyEventArgs e)
        {
            string SearchValue = TextBoxSearchCatagory.Text.Trim().ToLower();
            foreach (DataGridViewRow row in DatagridviewCatagory.Rows)
            {
                var SearchName = row.Cells[0].Value.ToString();
                var SearchNameLower = SearchName.ToLower();
                if (!SearchNameLower.Contains(SearchValue))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewCatagory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewCatagory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = true;
                    currencyManager1.ResumeBinding();
                }
            }
        }
    }
}
