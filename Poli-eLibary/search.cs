using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Poli_eLibary
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Cburnett\source\repos\Poli-eLibary\poli.mdf; Integrated Security = True; Connect Timeout = 30");
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            private void search_Load(object sender, EventArgs e)
        {
            BookIDs.Text = Library.bookids;
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Select * from Books where BookID = @BookID", sqlcon);
            cmd.Parameters.AddWithValue("@BookID", int.Parse(BookIDs.Text));
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                title.Text = da.GetValue(1).ToString();
                author.Text = da.GetValue(1).ToString();
            }
            sqlcon.Close();
        }
    }
}
