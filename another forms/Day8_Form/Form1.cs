using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day8_Form
{
    public partial class Form1 : Form
    {
        Form2 Form2 = new Form2();

        BusinessLayer businessLayer = new BusinessLayer();
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.DataSource = businessLayer.GetDepartments();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";
            dataGridView1.DataSource= businessLayer.GetEmplooyees();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int depId = int.Parse(comboBox1.SelectedValue.ToString());
        
            string Fname = textBox1.Text;
            string Lname = textBox2.Text;
            int SSn =int.Parse(textBox3.Text);
            decimal salary = numericUpDown1.Value;
            //Employee employee = new Employee();

            businessLayer.InsertEmployee(Fname, Lname, salary, depId,SSn);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessLayer.GetEmplooyees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells["fname"].Value.ToString();
            textBox2.Text = row.Cells["lname"].Value.ToString();
            textBox3.Text = row.Cells["SSN"].Value.ToString();
            numericUpDown1.Text = row.Cells["Salary"].Value.ToString();
            comboBox1.Text = row.Cells[4].Value.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            decimal salray = int.Parse(numericUpDown1.Value.ToString());
            int SSN = int.Parse(textBox3.Text);
            businessLayer.Update_employee(textBox1.Text.ToString(), textBox2.Text.ToString(), salray, SSN);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessLayer.GetEmplooyees();
        }      
    }
}
