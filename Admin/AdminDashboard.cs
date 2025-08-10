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
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1.Admin
{ 
    public partial class AdminDashboard : Form
    {
       



        public AdminDashboard()
        {
            InitializeComponent();

            //Controls visibility start
            chBar.Visible = true;
            chColumn.Visible = true;
            chLine.Visible = true;
            chPie.Visible = true;
            

            //Controls visibility end
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            //Controls visibility start

            chBar.Visible = true;
            chColumn.Visible = true;
            chLine.Visible = true;
            chPie.Visible = true;

            displayPanel.Controls.Clear();

            //Controls visibility end
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

                //Controls visibility start

                chBar.Visible = false;
            chColumn.Visible = false;
            chLine.Visible = false;
            chPie.Visible = false;

            //Controls visibility end

           //Displaying datagridview 

            displayPanel.Controls.Clear();

            DGVStudent dgvstudent = new DGVStudent();

            dgvstudent.TopLevel = false;
            dgvstudent.FormBorderStyle = FormBorderStyle.None;
            dgvstudent.Dock = DockStyle.Fill;

            displayPanel.Controls.Add(dgvstudent);
            dgvstudent.BringToFront();
            dgvstudent.Show();




        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            //Controls visibility start

            chBar.Visible = false;
            chColumn.Visible = false;
            chLine.Visible = false;
            chPie.Visible = false;

            //Controls visibility end

            //Displaying datagridview 

            displayPanel.Controls.Clear();

            DGVTeachers dgvteachers = new DGVTeachers();

            dgvteachers.TopLevel = false;
            dgvteachers.FormBorderStyle = FormBorderStyle.None;
            dgvteachers.Dock = DockStyle.Fill;

            displayPanel.Controls.Add(dgvteachers);
            dgvteachers.BringToFront();
            dgvteachers.Show();
        }

        



    }
}
