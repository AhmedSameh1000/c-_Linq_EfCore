namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        Form2 form2=new Form2();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.show += Form2_show;
        }

        private void Form2_show(object? sender, EventArgs e)
        {
            textBox1.ForeColor = form2._color;
            textBox1.Font = form2._font;
        }
    }
}


