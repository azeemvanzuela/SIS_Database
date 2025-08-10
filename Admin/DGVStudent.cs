using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Admin;


namespace WindowsFormsApp1
{
    public partial class DGVStudent : Form
    {
        public DGVStudent()
        {
            InitializeComponent();
            //Display data
            LoadStudent();
            
        }

        public void LoadStudent()
        {

            //Connect database and table Student to DataGrid
            string connection = "Server=DESKTOP-DVN25EF\\SQLEXPRESS;Database=Vanzuela;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {

                conn.Open();
                string sql = "SELECT * FROM Student";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    var dataReader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    DGVStudents.DataSource = dt;


                }

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           AddStudent addStudentForm = new AddStudent();
           addStudentForm.Show();
        }
    }
}
