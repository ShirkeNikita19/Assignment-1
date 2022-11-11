using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SGM_Student_Mgt_System.cs
{
    public partial class frm_View_All_Student_List : Form
    {
        public frm_View_All_Student_List()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Student_Mgt_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();

        }
        private void lbl_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();

        }

          private void frm_View_All_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGM_Student_Mgt_SystemDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.sGM_Student_Mgt_SystemDataSet1.Student_Details);

        }

     }
}
