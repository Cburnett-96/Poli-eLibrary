using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Poli_eLibary
{
    public partial class UpdateBooks : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);
        public UpdateBooks()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Cburnett\source\repos\Poli-eLibary\poli.mdf; Integrated Security = True; Connect Timeout = 30");
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (bookid.Text != "" && booktitle.Text != "" && bookauthor.Text != "" && bookpublisher.Text != "" && bookpages.Text != "")
            {
                string query = "Update Books Set BookTitle ='" + booktitle.Text.Trim() + "', Author ='" + bookauthor.Text.Trim() + "' , Publisher ='" + bookpublisher.Text.Trim() + "' , Pages ='" + bookpages.Text.Trim() + "' where BookID = '" + bookid.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                MessageBox.Show("Successfully Update!");
                Library lib = new Library();
                lib.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Please Fill-up!", "ATTENTION!");
            }
        }
        private void insert_Click(object sender, EventArgs e)
        {
            if (bookid.Text != "" && booktitle.Text != "" && bookauthor.Text != "" && bookpublisher.Text != "" && bookpages.Text != "")
            {
                string query = "Insert into Books VALUES('" + bookid.Text.Trim() + "','" + booktitle.Text.Trim() + "','" + bookauthor.Text.Trim() + "','" + bookpublisher.Text.Trim() + "','" + bookpages.Text.Trim() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                MessageBox.Show("Successfully Added!");
                Library lib = new Library();
                lib.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Please Fill-up!", "ATTENTION!");
            }
        }
        private void remove_Click(object sender, EventArgs e)
        {
            if (bookid.Text != "" && booktitle.Text != "" && bookauthor.Text != "" && bookpublisher.Text != "" && bookpages.Text != "")
            {
                string query = "Delete from Books  where BookID = '" + bookid.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                MessageBox.Show("Successfully Remove!");
                Library lib = new Library();
                lib.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Please Fill-up!", "ATTENTION!");
            }
        }
        private void bookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
