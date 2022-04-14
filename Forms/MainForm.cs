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
    public partial class MainForm : Form
    {
        private bool needToClose = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarsForm form = new CarsForm();
            form.Show();
            needToClose = false;
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToClose)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContractsForm form = new ContractsForm();
            form.Show();
            needToClose = false;
            this.Close();
        }
    }
}
