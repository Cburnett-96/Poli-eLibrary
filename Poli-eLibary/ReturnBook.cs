using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Poli_eLibary
{
    public partial class ReturnBook : Form
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
        public ReturnBook()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Cburnett\source\repos\Poli-eLibary\poli.mdf; Integrated Security = True; Connect Timeout = 30");
        const string dllfile = "C:\\Users\\Cburnett\\source\\repos\\Poli-eLibary\\Debug\\Poli-cpp.dll";
        //C:\Users\Cburnett\source\repos\Poli-eLibary\Debug\Poli-cpp.dll
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

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            studentid_textbox.Text = Main.SetValueForText1;
        }

        private void bookreturn_Click(object sender, EventArgs e)
        {
            if (bookid.Text != "")
            {
                string query = "Update BorrowReturn Set ReturnDate ='" + datereturn.Text.Trim() + "', LossValue ='" + loss.Text.Trim() + "', Penalty ='" + penalty.Text.Trim() + "' where StudentID = '" + studentid_textbox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                MessageBox.Show("Successfully Return!");
                Main m = new Main();
                m.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill-up!", "ATTENTION!");
            }
            }
        [DllImport(dllfile, CallingConvention = CallingConvention.Cdecl)]
        public static extern int date(int days, int l);
        private void calculate_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateborrow.Value;
            DateTime d2 = datereturn.Value;
            TimeSpan t = d2 - d1;
            double ddays = t.TotalDays;
            int days = Convert.ToInt32(ddays);
            int l = Convert.ToInt32(loss.Text);
            int total = date(days, l);

            penalty.Text = total.ToString();
        }
    }
}
