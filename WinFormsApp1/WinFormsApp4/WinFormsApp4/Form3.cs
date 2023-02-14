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
    public partial class Form3 : Form
    {
        public string[] arr;
        public string[] arr2;
        public Form3()
        {
            InitializeComponent();
             arr = new string[] { "ahmed", "sameh", "sara" };
             arr2 = new string[] { "ali", "said", "serag" };
            SetData(checkedListBox1, arr);
            SetData(checkedListBox2, arr2);
        }




        public void SetData(CheckedListBox checkedList,string[] names)
        {
            checkedList.Items.AddRange(names );
        }


        private void button1_Click(object sender, EventArgs e)
        {       
            foreach (object item in checkedListBox1.CheckedItems)
            {
                checkedListBox2.Items.Add(item);
            }
            for (int i = checkedListBox1.CheckedItems.Count-1; i >=0 ; i--)
            {
                checkedListBox1.Items.RemoveAt(i);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                checkedListBox2.Items.AddRange(checkedListBox1.Items);
               checkedListBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (object item in checkedListBox2.CheckedItems)
            {
                checkedListBox1.Items.Add(item);
            }
            for (int i = checkedListBox2.CheckedItems.Count - 1; i >= 0; i--)
            {
                checkedListBox2.Items.RemoveAt(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                checkedListBox1.Items.AddRange(checkedListBox2.Items);
            checkedListBox2.Items.Clear();
        }    
    }
}
