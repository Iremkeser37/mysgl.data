using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irem_keser_300_mysql
{
    public partial class FormFilmElestiri : Form
    {
        string baglantiMetin = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";

        public FormFilmElestiri()
        {
            InitializeComponent();
        }

        private void FormFilmElestiri_Load(object sender, EventArgs e)
        {


            using (MySqlConnection baglan = new MySqlConnection(baglantiMetin))
            {
                baglan.Open();
                string sorgu =  "SELECT * FROM filmler \r\nJOIN elestiriler ON filmler.film_id =elestiriler.film_id; ";
                    
                   
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
        }
    }
    
}
