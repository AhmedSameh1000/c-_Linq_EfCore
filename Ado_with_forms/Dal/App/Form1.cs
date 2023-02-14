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

        BusinessLayer businessLayer = new BusinessLayer();
        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = businessLayer.GetDepartments();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";

            dataGridView1.DataSource = businessLayer.GetEmplooyees();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int depId = int.Parse(comboBox1.SelectedValue.ToString());
            string Fname = textBox1.Text;
            string Lname = textBox2.Text;
            decimal salary = numericUpDown1.Value;
            //Employee employee = new Employee();

            businessLayer.InsertEmployee(Fname, Lname, salary, depId);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessLayer.GetEmplooyees();


        }
    }
}
