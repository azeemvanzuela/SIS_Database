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

namespace WindowsFormsApp1.Admin
{
    public partial class AddStudent : Form
    {
      
        public AddStudent()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Connect to database and display on DataGrid
            string connection= "Server=DESKTOP-DVN25EF\\SQLEXPRESS;Database=Vanzuela;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //Insert into Student table
                    string sqlStudent = "INSERT INTO Student (first_name, last_name, date_of_birth, gender, email, phone, address, enrollment_date, status, role_id) VALUES ('" + txtFname.Text + "','" + txtLname.Text + "','" + dtpBday.Value.ToString("yyyy/MM/dd") + "','" + (rdoMale.Checked ? "Male" : "Female") + "', '" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + dtpEnrollment.Value.ToString("yyyy/MM/dd") + "','" + "Enrolled" + "'," + 2 + ")";
                    SqlCommand cmdStudent = new SqlCommand(sqlStudent, conn, transaction);
                    cmdStudent.ExecuteNonQuery();

                    //Insert into user_login table
                    string sqlUser = "INSERT INTO user_login (username, password_hash, role_id) VALUES ('" + txtUser.Text + "','" + txtPass.Text + "'," + 2 + ")";
                    SqlCommand cmdUser = new SqlCommand(sqlUser, conn, transaction);
                    cmdUser.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Student added successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error adding student: " + ex.Message);
                }
            }
 
        }
    }
}
