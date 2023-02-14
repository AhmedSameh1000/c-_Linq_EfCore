namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
       string[] color = new string[] {
            "red","green","blue"
        };

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(color);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.ForeColor = Color.Red;
           else if (comboBox1.SelectedIndex == 1)
                textBox1.ForeColor = Color.Green;
            else
                textBox1.ForeColor = Color.Blue;
        }
    }
}