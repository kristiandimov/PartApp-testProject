
namespace PartApp
{
    partial class InsertUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1PartName = new System.Windows.Forms.TextBox();
            this.textBox2PartID = new System.Windows.Forms.TextBox();
            this.textBox3CarModel = new System.Windows.Forms.TextBox();
            this.numericUpDown1Price = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Quantity = new System.Windows.Forms.NumericUpDown();
            this.comboBox1Type = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1PartName
            // 
            this.textBox1PartName.Location = new System.Drawing.Point(117, 50);
            this.textBox1PartName.Multiline = true;
            this.textBox1PartName.Name = "textBox1PartName";
            this.textBox1PartName.Size = new System.Drawing.Size(145, 28);
            this.textBox1PartName.TabIndex = 0;
            // 
            // textBox2PartID
            // 
            this.textBox2PartID.Location = new System.Drawing.Point(117, 146);
            this.textBox2PartID.Multiline = true;
            this.textBox2PartID.Name = "textBox2PartID";
            this.textBox2PartID.Size = new System.Drawing.Size(145, 28);
            this.textBox2PartID.TabIndex = 1;
            // 
            // textBox3CarModel
            // 
            this.textBox3CarModel.Location = new System.Drawing.Point(117, 190);
            this.textBox3CarModel.Multiline = true;
            this.textBox3CarModel.Name = "textBox3CarModel";
            this.textBox3CarModel.Size = new System.Drawing.Size(145, 28);
            this.textBox3CarModel.TabIndex = 2;
            // 
            // numericUpDown1Price
            // 
            this.numericUpDown1Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1Price.Location = new System.Drawing.Point(117, 233);
            this.numericUpDown1Price.Name = "numericUpDown1Price";
            this.numericUpDown1Price.Size = new System.Drawing.Size(145, 28);
            this.numericUpDown1Price.TabIndex = 3;
            // 
            // numericUpDown2Quantity
            // 
            this.numericUpDown2Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2Quantity.Location = new System.Drawing.Point(117, 279);
            this.numericUpDown2Quantity.Name = "numericUpDown2Quantity";
            this.numericUpDown2Quantity.Size = new System.Drawing.Size(145, 28);
            this.numericUpDown2Quantity.TabIndex = 4;
            // 
            // comboBox1Type
            // 
            this.comboBox1Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1Type.FormattingEnabled = true;
            this.comboBox1Type.Location = new System.Drawing.Point(117, 97);
            this.comboBox1Type.Name = "comboBox1Type";
            this.comboBox1Type.Size = new System.Drawing.Size(142, 28);
            this.comboBox1Type.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(96, 335);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(95, 30);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Part Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Car Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity:";
            // 
            // InsertUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.comboBox1Type);
            this.Controls.Add(this.numericUpDown2Quantity);
            this.Controls.Add(this.numericUpDown1Price);
            this.Controls.Add(this.textBox3CarModel);
            this.Controls.Add(this.textBox2PartID);
            this.Controls.Add(this.textBox1PartName);
            this.Name = "InsertUpdateForm";
            this.Text = "InsertUpdateForm";
            this.Load += new System.EventHandler(this.InsertUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1PartName;
        private System.Windows.Forms.TextBox textBox2PartID;
        private System.Windows.Forms.TextBox textBox3CarModel;
        private System.Windows.Forms.NumericUpDown numericUpDown1Price;
        private System.Windows.Forms.NumericUpDown numericUpDown2Quantity;
        private System.Windows.Forms.ComboBox comboBox1Type;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}