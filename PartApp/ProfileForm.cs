using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PartApp
{
    public partial class ProfileForm : Form
    {
        int id;
        
        string firstName, lastName, email, phone, address;

        string user,pass;


        public ProfileForm(string username,string password)
        {
            
            InitializeComponent();
                    
            TextBox1Username.Text = username;
            TextBox2Password.Text = password;
            user = username;
            pass = password;
            
            
            using (var db = new PartDbEntities())
            {               

                var acc = db.Accounts.FirstOrDefault(u => u.Username == TextBox1Username.Text);

                if (acc.FirstName == null || acc.LastName == null || acc.Email == null 
                    || acc.Phone == null || acc.Address == null)
                {
                    label8.Visible = true;
                    partBtn.Enabled = false;

                }
                else
                {
                    id = acc.UserId;
                    firstName = acc.FirstName;
                    lastName = acc.LastName;
                    email = acc.Email;
                    phone = acc.Phone;
                    address = acc.Address;

                    TextBox3FirstName.Text = firstName;
                    TextBox4LastName.Text = lastName;
                    TextBox5Email.Text = email;
                    TextBox6Phone.Text = phone;
                    TextBox7Address.Text = address;

                }

                if (acc.Username == "admin")
                {
                    newAccButton.Visible = true;
                    allUsersBtn.Visible = true;
                    
                }

            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadOnlyFalse();

            editInfo.Visible = false;
            saveBtn.Visible = true;

        }

        private void ReadOnlyFalse()
        {
            TextBox3FirstName.ReadOnly = false;
            TextBox4LastName.ReadOnly = false;
            TextBox5Email.ReadOnly = false;
            TextBox6Phone.ReadOnly = false;
            TextBox7Address.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            

        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            System.Windows.Forms.Application.Exit();

        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        string operation = "NewUser";
        private void newAccButton_Click(object sender, EventArgs e)
        {

            
            //if (operation == "Back")
            //{
            //    LoadData(user);
            //    partBtn.Visible = true;
            //    editInfo.Visible = true;
            //    saveBtn.Visible = true;
            //    createNewUser.Visible = false;
            //    operation = "NewUser";
            //}

            if (operation == "NewUser")
            {               
                partBtn.Visible = false;
                editInfo.Visible = false;
                saveBtn.Visible = false;
                createNewUser.Visible = true;

                ClearTextBox();

                TextBox1Username.ReadOnly = false;
                TextBox2Password.ReadOnly = false;

                TextBox3FirstName.Visible = false;
                TextBox4LastName.Visible = false;
                TextBox5Email.Visible = false;
                TextBox6Phone.Visible = false;
                TextBox7Address.Visible = false;


                operation = "Back";

            }
            else
            {
                LoadData(user);
                partBtn.Visible = true;                          
                editInfo.Visible = true;
                createNewUser.Visible = false;

                TextBox1Username.ReadOnly = true;
                TextBox2Password.ReadOnly = true;

                TextBox3FirstName.Visible = true;
                TextBox4LastName.Visible = true;
                TextBox5Email.Visible = true;
                TextBox6Phone.Visible = true;
                TextBox7Address.Visible = true;

                operation = "NewUser";
            }
          
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createNewUser_Click(object sender, EventArgs e)
        {
            
            Encryption en = new Encryption();
            using (var db = new PartDbEntities())
            {
                string newPass = "";
                newPass = TextBox2Password.Text;
                newPass = en.Encrypt(newPass);
                db.NewUser(TextBox1Username.Text, newPass);
            }

        }

        private void partBtn_Click(object sender, EventArgs e)
        {
            Parts p = new Parts(user,pass);
            this.Hide();
            p.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (TextBox3FirstName.Text.Length < 3 && TextBox4LastName.Text.Length < 3 && TextBox5Email.Text.Length < 8
                && TextBox6Phone.Text.Length <= 9)
            {
                TextBox3FirstName.Text = firstName;
                TextBox4LastName.Text = lastName;
                TextBox5Email.Text = email;
                TextBox6Phone.Text = phone;
                TextBox7Address.Text = address;

                MessageBox.Show("Invalid data");
            }
            else
            {
                try
                {
                    using (var db = new PartDbEntities())
                    {
                        var acc = db.Accounts.FirstOrDefault(u => u.Username == TextBox1Username.Text);

                        acc.FirstName = TextBox3FirstName.Text;
                        acc.LastName = TextBox4LastName.Text;
                        acc.Email = TextBox5Email.Text;
                        acc.Phone = TextBox6Phone.Text;
                        acc.Address = TextBox7Address.Text;

                        db.SaveChanges();
                        partBtn.Enabled = true;

                    }

                    MessageBox.Show("You successfully updated your account info");
                    label8.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            saveBtn.Visible = false;
            editInfo.Visible = true;
            ReadOnlyTrue();

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void allUsersBtn_Click(object sender, EventArgs e)
        {
            AllUsers a = new AllUsers();
            
            if (a.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void ReadOnlyTrue()
        {
            TextBox3FirstName.ReadOnly = true;
            TextBox4LastName.ReadOnly = true;
            TextBox5Email.ReadOnly = true;
            TextBox6Phone.ReadOnly = true;
            TextBox7Address.ReadOnly = true;
        }

        public void EnterInfo(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            
            string textBox = a.Name;
            
                if (TextBox3FirstName.Text == firstName && textBox == TextBox3FirstName.Name)
                {
                    TextBox3FirstName.Text = "";
                }
                else if (TextBox4LastName.Text == lastName && textBox == TextBox4LastName.Name)
                {
                    TextBox4LastName.Text = "";
                }
                else if (TextBox5Email.Text == email && textBox == TextBox5Email.Name)
                {
                    TextBox5Email.Text = "";
                }
                else if (TextBox6Phone.Text == phone && textBox == TextBox6Phone.Name)
                {
                    TextBox6Phone.Text = "";
                }
                else if (TextBox7Address.Text == address && textBox == TextBox7Address.Name)
                {
                    TextBox7Address.Text = "";
                }           
        }

        public void LeaveInfo(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;

            string textBox = a.Name;

            if (TextBox3FirstName.Text == "" && textBox == TextBox3FirstName.Name)
            {
                TextBox3FirstName.Text = firstName;
            }
            else if (TextBox4LastName.Text == "" && textBox == TextBox4LastName.Name)
            {
                TextBox4LastName.Text = lastName;
            }
            else if (TextBox5Email.Text == "" && textBox == TextBox5Email.Name)
            {
                TextBox5Email.Text = email;
            }
            else if (TextBox6Phone.Text == "" && textBox == TextBox6Phone.Name)
            {
                TextBox6Phone.Text = phone;
            }
            else if (TextBox7Address.Text == "" && textBox == TextBox7Address.Name)
            {
                TextBox7Address.Text = address;
            }
        }

        public void ClearTextBox()
        {
            //var t = this.Controls.OfType<TextBox>().AsEnumerable<TextBox>();
            foreach (TextBox textbox in Controls.OfType<TextBox>())
            {
                textbox.Text = "";
                
            }
        }

        public void LoadData(string username)
        {
            using (var db = new PartDbEntities())
            {
                var acc = db.Accounts.FirstOrDefault(u => u.Username == username);
               
                

                List<string> data = new List<string>();
                
                data.Add(acc.Username);
                data.Add(acc.Password);
                data.Add(acc.FirstName);
                data.Add(acc.LastName);
                data.Add(acc.Email);
                data.Add(acc.Phone);
                data.Add(acc.Address);

                int count = data.Count - 1;
                foreach (TextBox textbox in Controls.OfType<TextBox>())
                {
                    
                    while (count > -1)
                    {
                        textbox.Text = data[count];
                        break;
                    }
                    count--;
                    
                    
                }
            }
        }

       
    }
}
