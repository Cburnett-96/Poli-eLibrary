using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Poli_eLibary
{
    public partial class Main : Form
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
        public Main()
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
        public static string SetValueForText1 = "";
        private void login_Click(object sender, EventArgs e)
        {
          //  sqlcon.Open();
            string student = studentid.Text;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from Student where StudentID = @StudentID", sqlcon);
            cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = student;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            if (studentid.Text == "admin" || studentid.Text == "ADMIN" || dt.Rows.Count > 0)
            {
                SetValueForText1 = studentid.Text;
                //sqlcon.Close();
                    MessageBox.Show("Successfully Login!");
                    Library lib = new Library();
                    lib.Show();
                    this.Hide();
            }
            else {
                MessageBox.Show("Wrong or Not Registered!");
                DialogResult dialogResult = MessageBox.Show("Do you want to Register?", "ATTENTION!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Signup su = new Signup();
                    su.Show();
                    this.Hide();
                }
            }
        }
        private void signup_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }
        private void studentid_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(this, new EventArgs());
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            studentid.Text = Signup.SetValueForText2;
        }
    }
}
