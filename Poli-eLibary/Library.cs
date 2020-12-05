using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Poli_eLibary
{
    public partial class Library : Form
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
        public Library()
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
        public static string bookids = "";
        private void search_Click(object sender, EventArgs e)
        {
            string find = findbook.Text;
            bookids = findbook.Text;

            if (find != "") {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from Books where BookID = @BookID", sqlcon);
                cmd.Parameters.Add("@BookID", SqlDbType.Int).Value = find;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                if (dt.Rows.Count > 0) {
                    search s = new search();
                    s.Show();
            }
                else
                {
                    MessageBox.Show("Not Available!", "ATTENTION!");
                }
        }
            else
            {
                MessageBox.Show("Please Fill-up!","ATTENTION!");
            }
        }
        private void borrow_Click(object sender, EventArgs e)
        {
            BorrowBook bb = new BorrowBook();
            bb.Show();
            this.Close();
        }
        private void Library_Load(object sender, EventArgs e)
        {
            studentid.Text = Main.SetValueForText1;
        }
        private void Return_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
            this.Close();
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (studentid.Text == "admin")
            {
                UpdateBooks ub = new UpdateBooks();
                ub.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Only Authorized Personnel Can Access!","ATTENTION!");
            }
        }
        private void findbook_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Click(this, new EventArgs());
            }
        }
        private void findbook_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
