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
    
    public partial class AllUsers : Form
    {

        int id = -1;

        public AllUsers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new PartDbEntities())
            {
                var allParts = from p in db.Accounts select p;
                dataGridViewUsers.DataSource = allParts.ToList();
                
            }
        }
        private void updateData_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (var db = new PartDbEntities())
                {
                    var acc = db.Accounts.FirstOrDefault(u => u.UserId == id);
                    Encryption en = new Encryption();

                    acc.Username = textBox1.Text;
                    acc.Password = en.Encrypt(textBox2.Text);
                    
                    db.SaveChanges();

                    MessageBox.Show("You successfully updated acc info");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

                throw;
            }
                                
            LoadData();
        }
        
        private void AllUsers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string y = null;
            var ad = y;
            foreach (DataGridViewCell data in dataGridViewUsers.SelectedCells)
            {
                ad = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
            }
            if (id <= 0)
            {
                id = int.Parse(ad.First().ToString());
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string y = null;
            var ad = y;
            foreach (DataGridViewCell data in dataGridViewUsers.SelectedCells)
            {
                ad = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
            }
            id = int.Parse(ad.First().ToString());
        }

        private void dataGridViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {            
                OnKeyPress(new KeyPressEventArgs((Char)Keys.Delete));
                using (var db = new PartDbEntities())
                {
                    var acc = db.Accounts.FirstOrDefault(u => u.UserId == id);

                    if (acc.Username == "admin")
                    {
                        return;
                    }

                    DialogResult dialogResult = MessageBox.Show("Do you want delete this record", "Confirm",
                  MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        db.DeleteUser(id);
                        LoadData();
                    }
                }
            }
        }

        private void dataGridViewUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxData.Visible = true;
            using (var db = new PartDbEntities())
            {
                var acc = db.Accounts.FirstOrDefault(u => u.UserId == id);

                textBox1.Text = acc.Username;
                textBox2.Text = acc.Password;
            }
            this.Size = new Size(577, 407);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Search();
        }

        private void Search()
        {
            string text = textBox3.Text;

            using (var db = new PartDbEntities())
            {
                List<Account> a = new List<Account>();
                var part = a;

                part = db.Accounts.Where(p => p.Username.Contains(text) || p.FirstName.Contains(text) 
                || p.LastName.Contains(text) || p.Phone.Contains(text)).ToList();

                dataGridViewUsers.DataSource = part.ToList();
            }

            if (text == "")
            {
                LoadData();
            }
        }
    }
}
