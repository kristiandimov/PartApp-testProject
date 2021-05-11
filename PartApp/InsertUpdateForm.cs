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

    public partial class InsertUpdateForm : Form
    {
        public string partName, type, partID, carModel;
        public decimal price;
        public float quantity;
        public bool isUpdate;
        public int ID;
        string user, pass;

        private void InsertUpdateForm_Load(object sender, EventArgs e)
        {
           
        }

        public InsertUpdateForm(int id,string username,string password)
        {
            InitializeComponent();
            ID = id;
            user = username;
            pass = password;

            DataLoad();
            OperationCheck();

            if (isUpdate)
            {
                
                textBox1PartName.Text = partName;
                comboBox1Type.Text = type;
                textBox2PartID.Text = partID;
                textBox3CarModel.Text = carModel;
                numericUpDown1Price.Value = price;
                numericUpDown2Quantity.Value = decimal.Parse(quantity.ToString());

            }

        }
        
        public void DataLoad()
        {
            try
            {
                if (ID > 0)
                {
                    using (var db = new PartDbEntities())
                    {
                        var data = db.Parts.FirstOrDefault(x => x.Id == ID);

                        partName = data.PartName;
                        type = data.Type;
                        partID = data.PartId;
                        carModel = data.Car;
                        price = data.Price;
                        quantity = float.Parse(data.Quantity.ToString());
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        public bool OperationCheck()
        {
            if (partName != null)
            {
                isUpdate = true;
            }
            else
            {
                isUpdate = false;
            }
            return isUpdate;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            OperationCheck();
            if (isUpdate)
            {
                try
                {
                    using (var db = new PartDbEntities())
                    {
                        var data = db.Parts.FirstOrDefault(x => x.Id == ID);


                        data.PartName = textBox1PartName.Text;
                        data.Type = comboBox1Type.Text;
                        data.PartId = textBox2PartID.Text;
                        data.Car = textBox3CarModel.Text;
                        data.Price = decimal.Parse(numericUpDown1Price.Value.ToString());
                        data.Quantity = float.Parse(numericUpDown2Quantity.Value.ToString());

                        db.SaveChanges();

                    }

                    MessageBox.Show("You successfully updated info");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                partName = textBox1PartName.Text;
                type = comboBox1Type.Text;
                partID = textBox2PartID.Text;
                carModel = textBox3CarModel.Text;
                price = decimal.Parse(numericUpDown1Price.Value.ToString());
                quantity = float.Parse(numericUpDown2Quantity.Value.ToString());


                using (var db = new PartDbEntities())
                {
                    db.InsertPart(partName, type, partID, carModel, price, quantity); 
                }

                MessageBox.Show("You successfully inserted your info");

            }


            this.Hide();

        }
       
    }
}
