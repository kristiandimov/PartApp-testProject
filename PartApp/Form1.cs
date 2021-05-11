using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartApp
{
    public partial class Form1 : Form
    {
        bool isValidAcc = false;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";

                usernameTextBox.ForeColor = Color.Black;
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";

                usernameTextBox.ForeColor = Color.Silver;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


            using (var db = new PartDbEntities())
            {
                try
                {
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;
                    Encryption en = new Encryption();
                    password = en.Encrypt(password);

                    var acc = db.Accounts.FirstOrDefault(u => u.Username == username && u.Password == password);

                    if (acc == null)
                    {
                        MessageBox.Show("Invalid account");
                        return;
                    }

                    if (acc.Username == username && acc.Password == password)
                    {
                        isValidAcc = true;

                        if (acc.FirstName != null && acc.LastName != null && acc.Email != null && acc.Phone != null && acc.Address != null)
                        {

                            this.Hide();
                            Parts p = new Parts(username, password);
                            p.Show();

                        }
                        else
                        {
                            this.Hide();
                            ProfileForm pf = new ProfileForm(username, password);
                            pf.Show();
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

                
            

            
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.PasswordChar = '*';

                passwordTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.PasswordChar = '\0';

                passwordTextBox.ForeColor = Color.Silver;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
