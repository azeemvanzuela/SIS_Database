using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Admin admin;
        Student student;
        Teachers teacher;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connection = "Server=LAB7-PC08\\ANILAB3DPC8;Database=Vanzuela;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {

                conn.Open();
                string sql = "SELECT * FROM user_login WHERE username = '" + txtUsername.Text + "' AND password_hash = '" + txtPassword.Text + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader rdr = cmd.ExecuteReader();

                        if (rdr.Read())
                        {
                            var id = rdr.GetInt32(0);
                            var user = rdr.GetString(1);
                            var pass = rdr.GetString(2);
                            var role_id = rdr.GetInt32(3);

                            if (role_id == 1)
                            {
                                Admin admin = new Admin();
                                admin.Show();
                                admin.lblWelcome.Text = "Welcome. " + user + "!";
                                this.Hide();
                            }
                            else if (role_id == 2)
                            {
                                Student student = new Student();
                                student.Show();
                                student.lblWelcome.Text = "Welcome. " + user + "!";
                                this.Hide();
                            }
                            else if (role_id == 3)
                            {
                                Teachers teacher = new Teachers();
                                teacher.Show();
                                teacher.lblWelcome.Text = "Welcome. " + user + "!";
                                this.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Login is unsuccessful!", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

            }
        }
    }
}
