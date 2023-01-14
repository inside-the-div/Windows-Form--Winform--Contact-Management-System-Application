using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace ContactManagementSystem
{
    public partial class Contacts : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source=.; Initial Catalog=CMSDB; TrustServerCertificate=True; Integrated Security=True ");
        public Contacts()
        {
            InitializeComponent();
            DisplayContacts();
            CategoryComboBoxLoad();
        }
        public void CategoryComboBoxLoad()
        {
            DBconnection.Open();
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter("SELECT * FROM Categories", DBconnection);
            DataTable CategoryDataTable = new DataTable();
            SQLselectQuery.Fill(CategoryDataTable);
            DBconnection.Close();
            ComboBoxCatagory.DataSource = CategoryDataTable;
            ComboBoxCatagory.ValueMember = "CategoryID";
            ComboBoxCatagory.DisplayMember = "CategoryName";
        }

        public void DisplayContacts() 
        {
            DBconnection.Open();
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter("SELECT Name, MobileNumber AS 'Mobile Number', Email, Address, CategoryName AS 'Category' FROM Contacts LEFT JOIN Categories ON Contacts.CategoryID = Categories.CategoryID", DBconnection);
            DataTable ContactsDataTable = new DataTable();
            SQLselectQuery.Fill(ContactsDataTable);
            DatagridviewContacts.DataSource = ContactsDataTable;
            DBconnection.Close();
            DatagridviewContacts.ClearSelection();
        }     

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            Categories categorys = new Categories();
            categorys.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int DuplicateCount(string CheckString, int RowNumber)
        {
            int count = 0;
            foreach (DataGridViewRow row in DatagridviewContacts.Rows)
            {
                string RowString = row.Cells[RowNumber].Value.ToString();
                if (RowString == CheckString)
                {
                    count++;
                }
            }
            return count;
        }
        public string NameValidation(string Name)
        {
            string ErrorMessage = string.Empty;
            Name = Name.Trim();
            int NameLength = Name.Length;
            Regex r = new Regex("^[a-zA-Z]([a-zA-Z0-9 ])*$");
            if (Name == "")
            {
                ErrorMessage = "Enter Your Name!!!\nName must be between 3-20 Characters.";
            }
            else if (NameLength < 3 || NameLength > 20)
            {
                ErrorMessage = "Invalid Name!!!\nName must be between 3-20 Characters.";
            }
            else if (!r.IsMatch(Name))
            {
                ErrorMessage = "Invalid Name!!!\nName can be letters only or combination of letters and numbers \nName can not start with number";
            }
            else
            {
                ErrorMessage = string.Empty;
            }
            return ErrorMessage;
        }

        private void Contacts_Activated(object sender, EventArgs e)
        {
            DisplayContacts();
            CategoryComboBoxLoad();
        }
    }
}