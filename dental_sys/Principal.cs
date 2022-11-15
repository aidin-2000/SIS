using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());

            if (Form1.loginuser != null) {
                label1.Text = Form1.loginuser;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new Patient());
        }

        //StatusLabelUser.Text = Resources.FormMain_FormMain_Пользователь___ + GlobalVariable.CurrentUser.SurName.ToUpperInvariant() + @" " +
        //        GlobalVariable.CurrentUser.Name.Substring(0, 1).ToUpperInvariant() + @".";
        //    StatusLabelWorkPlace.Text = Resources.FormMain_FormMain_Рабочее_место___ + (GlobalVariable.CurrentWorkplace == null ? "" : GlobalVariable.CurrentWorkplace.Name.ToUpperInvariant());
        //    StatusLabelPunkt.Text = Resources.FormMain_FormMain_Пункт___ + GlobalVariable.CurrentPunkt.Name.ToUpperInvariant();
        //    StatusLabelDate.Text = Resources.FormMain_FormMain_Дата___ + DateTime.Now.Date.ToShortDateString();
        //    statusLabelIpAddress.Text = CommonUITools.GetLocalIpAddress();
        //    взаимодействиеСВнешнимиСистемамиToolStripMenuItem.Enabled = FunctionalityManager.IsAvailable(Functionality.ExternalSystemsInteraction);

        //    SetIfaPath();

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label_val.Text = "Messages";
            guna2PictureBox_val.Image = Properties.Resources.chat__1_;
            container(new Messages());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
