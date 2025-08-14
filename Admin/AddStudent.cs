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
            btnUpdate.Visible = false;
            
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
                    //Insert into user_login table
                    string sqlUser = "INSERT INTO user_login (username, password_hash, role_id) VALUES ('" + txtUser.Text + "','" + txtPass.Text + "'," + 2 + ");" + "SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdUser = new SqlCommand(sqlUser, conn, transaction);
                    int newUserId = Convert.ToInt32(cmdUser.ExecuteScalar());



                    //Insert into Student table
                    string sqlStudent = "INSERT INTO Student (first_name, last_name, date_of_birth, gender, email, phone, address, enrollment_date, status, role_id, account_id) VALUES ('" + txtFname.Text + "','" + txtLname.Text + "','" + dtpBday.Value.ToString("yyyy/MM/dd") + "','" + (rdoMale.Checked ? "Male" : "Female") + "', '" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + dtpEnrollment.Value.ToString("yyyy/MM/dd") + "','" + "Enrolled" + "'," + 2 + ",'"+newUserId+"')";
                    SqlCommand cmdStudent = new SqlCommand(sqlStudent, conn, transaction);
                    cmdStudent.ExecuteNonQuery();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            dtpBday.Value = DateTime.Now;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpEnrollment.Value = DateTime.Now;
            txtUser.Clear();
            txtPass.Clear();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string connection = "Server=DESKTOP-DVN25EF\\SQLEXPRESS;Database=Vanzuela;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //UPDATE STUDENT, CONDITIONS NOT SET
                    string sqlStudent = "UPDATE Student SET first_name = '"+txtFname.Text+"', last_name = '"+txtLname.Text+"', date_of_birth = '"+dtpBday.Value.ToString("yyyy/MM/dd")+"', gender = '"+(rdoMale.Checked ? "Male" : "Female")+"', email = '"+txtEmail.Text+"', phone = '"+txtPhone.Text+"', address = '"+txtAddress.Text+"', enrollment_date = '"+dtpEnrollment.Value.ToString("yyyy/MM/dd")+"' WHERE account_id = '"+lblId.Text+"'";
                    SqlCommand cmdStudent = new SqlCommand(sqlStudent, conn, transaction);
                    cmdStudent.ExecuteNonQuery();

                    //UPDATE USER_LOGIN, SET COLUMNS AND CONDITIONS NOT SET
                    string sqlUser = "UPDATE user_login SET username = '" + txtUser.Text + "', password_hash = '" + txtPass.Text + "' WHERE user_id = '"+ lblId.Text + "'";
                    SqlCommand cmdUser = new SqlCommand(sqlUser, conn, transaction);
                    cmdUser.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error updating student: " + ex.Message);
                }
                finally
                {
                    transaction.Commit();
                    MessageBox.Show("Student updated successfully!");
                }

            }
        }
    }
}
