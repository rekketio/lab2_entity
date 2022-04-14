using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class CarsForm : Form
    {
        private bool needToClose = true;
        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToClose)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            needToClose = false;
            this.Close();
        }
    }
}
