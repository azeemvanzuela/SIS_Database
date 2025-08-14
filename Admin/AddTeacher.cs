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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            lblStatus.Visible = false;
            cboStatus.Visible = false;
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
                    string sqlTeacher = "UPDATE Teacher SET first_name = '" + txtFname.Text + "', last_name = '" + txtLname.Text + "', email = '" + txtEmail.Text + "', phone = '" + txtPhone.Text + "', hire_date = '" + dtpHireDate.Value.ToString("yyyy/MM/dd") + "', department = '" + txtDepartment + "', specialization = '" + txtSpecialization.Text + "', status = '" + cboStatus.SelectedItem + "' WHERE account_id = '" + lblId.Text + "'";
                    SqlCommand cmdTeacher = new SqlCommand(sqlTeacher, conn, transaction);
                    cmdTeacher.ExecuteNonQuery();

                    string sqlUser = "UPDATE user_login SET username = '" + txtUser.Text + "', password_hash = '" + txtPass.Text + "' WHERE user_id = '" + lblId.Text + "'";
                    SqlCommand cmdUser = new SqlCommand(sqlUser, conn, transaction);
                    cmdUser.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Teacher updated successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erorr updating teacher:" + ex.Message);
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "Server=DESKTOP-DVN25EF\\SQLEXPRESS;Database=Vanzuela;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    string sqlUser = "INSERT INTO user_login (username, password_hash, role_id) VALUES ('" + txtUser.Text + "','" + txtPass.Text + "'," + 3 + ");" + "SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdUser = new SqlCommand(sqlUser, conn, transaction);
                    int newUserId = Convert.ToInt32(cmdUser.ExecuteScalar());


                    string sqlTeacher = "INSERT INTO Teacher (first_name, last_name, email, phone, hire_date, department, specialization, status, role_id, account_id) VALUES ('"+txtFname.Text + "','" + txtLname.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + dtpHireDate.Value.ToString("yyyy/MM/dd") + "','" + txtDepartment.Text + "','" + txtSpecialization.Text + "','"+"Active"+"'," + 3 + ", '"+newUserId+"')";
                    SqlCommand cmdTeacher = new SqlCommand(sqlTeacher, conn, transaction);
                    cmdTeacher.ExecuteNonQuery();

                  

                    transaction.Commit();

                    MessageBox.Show("Teacher added successfully!");
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error adding teacher: " + ex.Message);
                   
                }
                
            }

        }
    }
}
