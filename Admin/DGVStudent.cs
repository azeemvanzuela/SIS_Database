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
                string sql = "SELECT s.student_id, s.first_name, s.last_name, s.date_of_birth, s.gender, s.email, s.phone, s.address, s.enrollment_date, s.status, ul.username, ul.password_hash, ul.user_id FROM Student s INNER JOIN user_login ul ON s.account_id = ul.user_id WHERE ul.role_id = 2";

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


        private void DGVStudents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddStudent updateStudentForm = new AddStudent();
            updateStudentForm.Show();
            updateStudentForm.btnUpdate.Visible = true;
            updateStudentForm.lblId.Text = DGVStudents.Rows[e.RowIndex].Cells[12].Value.ToString();

            updateStudentForm.txtFname.Text = DGVStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateStudentForm.txtLname.Text = DGVStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateStudentForm.dtpBday.Value = Convert.ToDateTime(DGVStudents.Rows[e.RowIndex].Cells[3].Value);
           string gender = DGVStudents.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (gender == "Male")
            {
                updateStudentForm.rdoMale.Checked = true;
            }
            else
            {
                updateStudentForm.rdoFemale.Checked = true;
            }
            updateStudentForm.txtEmail.Text = DGVStudents.Rows[e.RowIndex].Cells[5].Value.ToString();
            updateStudentForm.txtPhone.Text = DGVStudents.Rows[e.RowIndex].Cells[6].Value.ToString();
            updateStudentForm.txtAddress.Text = DGVStudents.Rows[e.RowIndex].Cells[7].Value.ToString();
            updateStudentForm.dtpEnrollment.Value = Convert.ToDateTime(DGVStudents.Rows[e.RowIndex].Cells[8].Value);
            updateStudentForm.txtUser.Text = DGVStudents.Rows[e.RowIndex].Cells[10].Value.ToString();
            updateStudentForm.txtPass.Text = DGVStudents.Rows[e.RowIndex].Cells[11].Value.ToString();
        }
    }
}
