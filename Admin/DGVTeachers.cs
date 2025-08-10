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

namespace WindowsFormsApp1
{
    public partial class DGVTeachers : Form
    {
        public DGVTeachers()
        {
            InitializeComponent();
            LoadTeachers();
        }

   
        private void LoadTeachers()
        {
            string connection = "Server=DESKTOP-DVN25EF\\SQLEXPRESS;Database=Vanzuela;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string sql = "SELECT * FROM Teacher";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    var dataReader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    DGVTeacher.DataSource = dt;
                }
            }
        }


    }
}
