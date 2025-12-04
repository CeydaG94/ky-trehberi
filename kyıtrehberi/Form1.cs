namespace kyıtrehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //butona tıklandığında ;
        {
            label5.Text = textBox1.Text; //textbox1'in textini label5'e yazdırır.
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            label8.Text = textBox4.Text;

        }

        private void button2_Click(object sender, EventArgs e) //butona tıklandığında ;
        {
            comboBox1.Items.Add("bilgisayar prog.");//combobox'a eleman ekler.
            comboBox1.Items.Add("harita");
            comboBox1.Items.Add("biyomedikal");
            comboBox1.Items.Add("makine");
            label10.Text = comboBox1.Text;
        }
    }
}
