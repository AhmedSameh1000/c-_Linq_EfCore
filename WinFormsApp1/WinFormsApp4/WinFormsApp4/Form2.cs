using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
   
    public partial class Form2 : Form
    {

        List<employee> employees;
        public Form2()
        {
            InitializeComponent();
         
            employees = new List<employee>();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees.Add(new employee() { id = int.Parse(textBox1.Text), Name = textBox2.Text, salary = int.Parse(textBox3.Text),dateTime= dateTimePicker1.Value.ToString() });
            dataGridView1.DataSource = employees;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    class employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
       public string dateTime { get; set; }
    }
}

