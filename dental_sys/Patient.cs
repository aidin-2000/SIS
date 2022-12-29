using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_sys.Models;

namespace dental_sys
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
             var db = new dentistryContext();
            var client = from c in db.TableClient select c;
            if (client != null)
            {
                if (client.Count() > 0)
                {
                    dataGridView1.DataSource = client.ToList();
                }
                else
                {
                    MessageBox.Show("косяк");
                }
            }




        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
