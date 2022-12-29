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
using dental_sys.Models;

namespace dental_sys
{
    public partial class Form1 : Form
    {
        //DataBase database = new DataBase();
        public static string loginuser="";
        public static string usertypename = "";
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            guna2TextBox2.PasswordChar = '*';
            pictureBox2.Visible = false;
            guna2TextBox1.MaxLength = 50;
            guna2TextBox2.MaxLength = 50;
            

           // guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Loading _load = new Loading();
            // _load.Show();


            var auth = new dentistryContext();
           var doct = from c in auth.TableClient select c;
            var loginUser = guna2TextBox1.Text;
            var passUser = guna2TextBox2.Text;

            // var context = new SchoolContext();
            var studentsWithSameName = auth.TableDoctor
                                              .Where(s => s.Login == loginUser);
                                              
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();
            //string querystring = $"select ID, Login, Password from Table_doctor where Login='{loginUser}' and Password='{passUser}'";
            //SqlCommand command = new SqlCommand(querystring, database.getConnection());
            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            if (studentsWithSameName!=null)
            {
                Loading _load = new Loading();
                _load.Show();
                loginuser = loginUser;
            }
            else
                MessageBox.Show("Такого аккауунта не существует", "Аккаунт не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           

        }
    }
}
