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
            CatagoryComboBoxLoad();
        }
        public void CatagoryComboBoxLoad()
        {
            DBconnection.Open();
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter("SELECT * FROM Catagorys", DBconnection);
            DataTable CatagoryDataTable = new DataTable();
            SQLselectQuery.Fill(CatagoryDataTable);
            DBconnection.Close();
            ComboBoxCatagory.DataSource = CatagoryDataTable;
            ComboBoxCatagory.ValueMember = "CatagoryID";
            ComboBoxCatagory.DisplayMember = "CatagoryName";
        }

        public void DisplayContacts() 
        {
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter("SELECT Name, MobileNumber AS 'Mobile Number', Email, Address, CatagoryName AS 'Catagory' FROM Contacts LEFT JOIN Catagorys ON Contacts.CatagoryID = Catagorys.CatagoryID", DBconnection);
            DataTable ContactsDataTable = new DataTable();
            SQLselectQuery.Fill(ContactsDataTable);
            DatagridviewContacts.DataSource = ContactsDataTable;
        }     

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            Catagorys catagorys = new Catagorys();
            catagorys.ShowDialog();
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
    }
}