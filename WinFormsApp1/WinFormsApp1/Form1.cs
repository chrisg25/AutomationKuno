using Accessibility;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Middle Name";
            dataGridView1.Columns[2].Name = "Last Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        public void AddData(string firstName, string middleName, string lastName)
        {
            string[] row = { firstName, middleName, lastName };
            dataGridView1.Rows.Add(row);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

        }
    }
}