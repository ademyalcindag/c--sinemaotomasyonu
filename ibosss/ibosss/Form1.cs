using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  


namespace ibosss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(LocalDb)MSSQLLocalDB;Initial Catalog=sinema;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter adtr ;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaDataSet.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter.Fill(this.sinemaDataSet.Table_2);
            // TODO: This line of code loads data into the 'sinemaDataSet.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.sinemaDataSet.Table_1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            komut = new SqlCommand("select *from filmad", baglantı);
            adtr = new SqlDataAdapter(komut);
            baglantı.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
