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
    /// <summary>
    /// активно търсене при спиране на писане (с таймер)
    /// панел от който да добавяне записи в базата и да ги ъпдайтване
    /// при double click на данни от таблицата да започват да се редактират
    /// при селектиране на запис от таблицата и при натискане на бутона да се изтриват и при натискане на delete на клавиятуранта също
    /// </summary>
    public partial class Parts : Form
    {
        string user, pass;
        int id;
        public Parts(string username,string password)
        {
            InitializeComponent();
            user = username;
            pass = password;
            LoadData();
            searchByComboBox.Text = "All";
            
        }

        private void LoadData()
        {
            using (var db = new PartDbEntities())
            {
                var allParts = from p in db.Parts select p;
                dataGridView.DataSource = allParts.ToList();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            id = -1;
            InsertUpdateForm iuf = new InsertUpdateForm(id,user,pass);

            if (iuf.ShowDialog() == DialogResult.OK)
            {
                
                LoadData();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            

            using (var db = new PartDbEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Do you want delete this record","Confirm",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.DeletePart(id);
                    LoadData();
                }
                

            }
            
        }
        
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string y = null;
            var ad = y;
            foreach (DataGridViewCell data in dataGridView.SelectedCells)
            {
                ad = dataGridView.CurrentRow.Cells[0].Value.ToString();
            }
            if (id <= 0)
            {
                id = int.Parse(ad);
            }
            
            

        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InsertUpdateForm iuf = new InsertUpdateForm(id,user,pass);
            if (iuf.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }

        }

        private void Parts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Parts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Delete)
            {
                OnKeyPress(new KeyPressEventArgs((Char)Keys.Delete));
                using (var db = new PartDbEntities())
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want delete this record", "Confirm",
                   MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        db.DeletePart(id);
                        LoadData();
                    }
                }
            }
        }

        private void TextBox1Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Search();
        }

        private void Search()
        {
            string text = TextBox1Search.Text;

            using (var db = new PartDbEntities())
            {
                List<Part> a = new List<Part>();
                var part = a;
                if (searchByComboBox.Text == "PartID")
                {
                    part = db.Parts.Where(p => p.PartId.Contains(text)).ToList();
                }
                else
                {
                    part = db.Parts.Where(p => p.PartName.Contains(text) || p.PartId.Contains(text)).ToList();

                }


                dataGridView.DataSource = part.ToList();
            }

            if (text == "")
            {
                LoadData();
            }
        }

        private void TextBox1Search_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
           

        }

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Search();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(user, pass);
            this.Hide();
            pf.Show();

        }
    }
}
