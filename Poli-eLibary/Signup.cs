using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Poli_eLibary
{
    public partial class Signup : Form
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
        public Signup()
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
        public static string SetValueForText2 = "";
        private void submit_Click(object sender, EventArgs e)
        {
            if (studentid.Text != "" && fullname.Text != "" && phonenumber.Text != "" && emailadd.Text != "")
            {
                string query = "Insert into Student  VALUES('" + studentid.Text.Trim() + "','" + fullname.Text.Trim() + "','" + phonenumber.Text.Trim() + "','" + emailadd.Text.Trim() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                SetValueForText2 = studentid.Text;
                MessageBox.Show("Successfully Registered!");
                Main m = new Main();
                m.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Please Fill-up the Registration!", "ATTENTION!");
            }
        }
        private void fill_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit_Click(this, new EventArgs());
            }
        }
    }
}
