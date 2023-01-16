using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace ContactManagementSystem
{
    public partial class Contacts : Form
    {
        public int ContactID = 0;
        public string PreviousMobileNumber = string.Empty;
        SqlConnection DBconnection = new SqlConnection("Data Source=.; Initial Catalog=CMSDB; TrustServerCertificate=True; Integrated Security=True ");
        public Contacts()
        {
            InitializeComponent();            
        }
        private void Contacts_Load(object sender, EventArgs e)
        {
            DisplayContacts();
            CategoryLoad();
            btnUpdate.Enabled = false;
        }
        public void CategoryLoad()
        {
            DBconnection.Open();
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories", DBconnection);
            DataTable CategoryDataTable = new DataTable();
            SQLselectQuery.Fill(CategoryDataTable);
            DBconnection.Close();
            ComboBoxCatagory.DataSource = CategoryDataTable;
            ComboBoxCatagory.ValueMember = "CategoryID";
            ComboBoxCatagory.DisplayMember = "CategoryName";
            ComboBoxCatagory.SelectedIndex = 0;
        }

        public void DisplayContacts() 
        {
            DBconnection.Open();
            string DisplayQuery = "SELECT C.CategoryID, C.ContactID AS ID, C.Name, C.MobileNumber AS 'Mobile Number', C.Email, C.Address, CT.CategoryName AS 'Category'" +
                " FROM Contacts C LEFT JOIN Categories CT ON C.CategoryID = CT.CategoryID";
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter(DisplayQuery, DBconnection);
            DataTable ContactsDataTable = new DataTable();
            SQLselectQuery.Fill(ContactsDataTable);
            DatagridviewContacts.DataSource = ContactsDataTable;
            DBconnection.Close();           
            this.DatagridviewContacts.Columns["ID"].Visible = false;
            this.DatagridviewContacts.Columns["CategoryID"].Visible = false;
            DatagridviewContacts.ClearSelection();
        }     

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            Categories categorys = new Categories();
            categorys.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                ErrorMessage = "Name must be between 3-20 Characters.";
            }
            else if (!r.IsMatch(Name))
            {
                ErrorMessage = "Invalid Name!!!\nName can be letters only or combination of letters and numbers.\nName can not start with number.";
            }
            else
            {
                ErrorMessage = string.Empty;
            }
            return ErrorMessage;
        }

        public string EmailValidation(string Email)
        {
            string ErrorMessage = string.Empty;
            Email = Email.Trim();
            int EmailLength = Email.Length;
            Regex r = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (Email == "")
            {
                ErrorMessage = "Enter Your Email!!!\nEmail must be between 6-50 Characters.";
            }
            else if (EmailLength < 6 || EmailLength > 50)
            {
                ErrorMessage = "Invalid Email!!!\nEmail must be between 6-50 Characters.";
            }
            else if (!r.IsMatch(Email))
            {
                ErrorMessage = "Invalid Email!!!\n Enter correct email";
            }
            else
            {
                ErrorMessage = string.Empty;
            }
            return ErrorMessage;
        }
        public string MobileNumberValidation(string Number)
        {
            string ErrorMessage = string.Empty;
            Number = Number.Trim();
            int NumberLength = Number.Length;
            Regex r = new Regex("^[+-]?[0-9]+$");

            if (Number == "")
            {
                ErrorMessage = "Enter Your Number!!!";
            }
            else if (NumberLength < 11 || NumberLength > 20)
            {
                ErrorMessage = "Wrong Number!!!\nEnter correct Number which will have minimum 11 digits.";
            }
            else if (!r.IsMatch(Number))
            {
                ErrorMessage = "Invalid Number!!!\n Enter correct Number.";
            }
            else
            {
                ErrorMessage = string.Empty;
            }
            return ErrorMessage;
        }
        public string AddressValidation(string Address)
        {
            string ErrorMessage = string.Empty;
            Address = Address.Trim();
            int AddressLength = Address.Length;
            Regex r = new Regex("^[a-zA-Z0-9\\s, '-]*$"); 

            if (Address == "")
            {
                ErrorMessage = "You did not give your address.\nYou can update it letter.";
            }
            else if (AddressLength > 40)
            {
                ErrorMessage = "Address exceeds maximum limit of 40 characters. Please shorten the address and try again.";
            }
            else if (!r.IsMatch(Address))
            {
                ErrorMessage = "Invalid address!!!\nUse Numbers and Alphabets, Do not use special characters except this two (,)(-). ";
            }
            else
            {
                ErrorMessage = string.Empty;
            }
            return ErrorMessage;
        }


        public void ClearFeilds()
        {
            TextBoxAddress.Clear();
            TextBoxEmail.Clear();
            TextBoxMobile.Clear();
            TextBoxSearchContacts.Clear();
            TextBoxName.Clear();
            ComboBoxCatagory.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFeilds();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            bool IsValid = true;
            
            if (IsValid)
            {
                ErrorMessage = NameValidation(TextBoxName.Text);
                if (ErrorMessage != "")
                {
                    IsValid= false;
                }
            }

            if (IsValid)
            {
                ErrorMessage = EmailValidation(TextBoxEmail.Text);
                if (ErrorMessage != "")
                {
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                ErrorMessage = MobileNumberValidation(TextBoxMobile.Text);
                if (ErrorMessage != "")
                {
                    IsValid = false;
                }
                else
                {
                    int count = DuplicateCount(TextBoxMobile.Text,3);
                    if(count != 0)
                    {
                        ErrorMessage += "Mobile Number Already Exist, Enter a New Mobile Number.";
                        IsValid = false;
                    }
                }
            }

            if (IsValid)
            {
                ErrorMessage = AddressValidation(TextBoxAddress.Text);
                if (ErrorMessage != "")
                {
                    if(TextBoxAddress.Text == "")
                    {
                        IsValid = true;
                    }
                    else
                    {
                        IsValid = false;
                    }
                }
            }

            if (IsValid)
            {
                if (ComboBoxCatagory.SelectedIndex <= -1)
                {
                    ErrorMessage = ("Select a category.");
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                int CategoryId = int.Parse(ComboBoxCatagory.SelectedValue.ToString());
                string SaveQuery = "INSERT INTO Contacts " +
                    "(Name, MobileNumber, Email, CategoryID, Address) VALUES ('"
                    +TextBoxName.Text+"', '"
                    +TextBoxMobile.Text+"', '"
                    +TextBoxEmail.Text+"',"
                    + CategoryId + " , '"
                    +TextBoxAddress.Text+"')";
                DBconnection.Open();
                SqlCommand ContactAdd = new SqlCommand(SaveQuery, DBconnection);
                if (ContactAdd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Saved successfully. " + ErrorMessage);
                    btnUpdate.Enabled = false;
                    ClearFeilds();
                }
                else
                {
                    MessageBox.Show("Something Error, Try Again");
                }               
                DBconnection.Close();
                DisplayContacts();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Ids = string.Empty;
            foreach (DataGridViewRow row in DatagridviewContacts.SelectedRows)
            {
                int id = (int)row.Cells[1].Value;
                Ids += id.ToString() + ",";   
            }
            Ids = Ids.TrimEnd(',');
            if(Ids == "")
            {
                MessageBox.Show("Select a Contact frist.");
            }
            else
            {
                string DeleteQuerry = "DELETE FROM Contacts  WHERE  ContactID IN (" + Ids + ")";           
                DBconnection.Open();
                SqlCommand deleteCommand = new SqlCommand(DeleteQuerry, DBconnection);
                if (deleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Contact deleted successfully.");
                }
                DBconnection.Close();
                DisplayContacts();                
            }
            
        }

        private void DatagridviewContacts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ContactID = int.Parse(DatagridviewContacts.SelectedRows[0].Cells[1].Value.ToString());
            TextBoxName.Text = DatagridviewContacts.SelectedRows[0].Cells[2].Value.ToString();
            PreviousMobileNumber = DatagridviewContacts.SelectedRows[0].Cells[3].Value.ToString();
            TextBoxMobile.Text = PreviousMobileNumber;
            TextBoxEmail.Text = DatagridviewContacts.SelectedRows[0].Cells[4].Value.ToString();
            TextBoxAddress.Text = DatagridviewContacts.SelectedRows[0].Cells[5].Value.ToString();
            int CategoryID = int.Parse(DatagridviewContacts.SelectedRows[0].Cells[0].Value.ToString());
            ComboBoxCatagory.SelectedValue = CategoryID;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            bool IsValid = true;

            if (IsValid)
            {
                ErrorMessage = NameValidation(TextBoxName.Text);
                if (ErrorMessage != "")
                {
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                ErrorMessage = EmailValidation(TextBoxEmail.Text);
                if (ErrorMessage != "")
                {
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                ErrorMessage = MobileNumberValidation(TextBoxMobile.Text);
                if (ErrorMessage != "")
                {
                    IsValid = false;
                }
                else
                {
                    int count = DuplicateCount(TextBoxMobile.Text, 3);
                    if (count > 0)
                    {
                        if (count == 1)
                        {
                            if (PreviousMobileNumber.Trim() != TextBoxMobile.Text.Trim())
                            {
                                ErrorMessage += "Mobile Number Already Exist, Enter a New Mobile Number.";
                                IsValid = false;
                            }
                        }
                        else if(count > 1)
                        {
                            ErrorMessage += "Mobile Number Already Exist, Enter a New Mobile Number.";
                            IsValid = false;
                        }
                        else
                        {
                            IsValid = true;
                        }                        
                    }
                }
            }

            if (IsValid)
            {
                ErrorMessage = AddressValidation(TextBoxAddress.Text);
                if (ErrorMessage != "")
                {
                    if (TextBoxAddress.Text == "")
                    {
                        IsValid = true;
                    }
                    else
                    {
                        IsValid = false;
                    }
                }
            }

            if (IsValid)
            {
                if (ComboBoxCatagory.SelectedIndex <= -1)
                {
                    ErrorMessage = ("Select a category.");
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                string UpdateQuery = "UPDATE Contacts SET " +
                    "Name = '"+TextBoxName.Text+"', " +
                    "MobileNumber = '"+TextBoxMobile.Text+"', " +
                    "Email = '"+TextBoxEmail.Text+"', " +
                    "CategoryID = "+ComboBoxCatagory.SelectedValue+", " +
                    "Address = '"+TextBoxAddress.Text+"' WHERE " +
                    "ContactID = "+ContactID;
                DBconnection.Open();
                SqlCommand ContactUpdate = new SqlCommand(UpdateQuery, DBconnection);
                if (ContactUpdate.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Updated successfully. " + ErrorMessage);
                    btnUpdate.Enabled = false;
                    ClearFeilds();
                }
                else
                {
                    MessageBox.Show("Something Error, Try Again");
                }
                DBconnection.Close();
                DisplayContacts();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
            btnUpdate.Enabled = false;
        }

        private void TextBoxSearchContacts_KeyUp(object sender, KeyEventArgs e)
        {
            string SearchValue = TextBoxSearchContacts.Text.Trim().ToLower();
            foreach (DataGridViewRow row in DatagridviewContacts.Rows)
            {
                var SearchName = row.Cells[2].Value.ToString();
                var SearchNameLower = SearchName.ToLower();
                if (!SearchNameLower.Contains(SearchValue))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewContacts.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewContacts.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = true;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        private void Contacts_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PageReload == true)
            {
                DisplayContacts();
                CategoryLoad();
                Properties.Settings.Default.PageReload = false;
                Properties.Settings.Default.Save();
            }
        }
        
    }
}