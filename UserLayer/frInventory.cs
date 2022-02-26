using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace UserLayer
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openChildForm(object childForm)
        {
            if (this.container_panel.Controls.Count > 0)
                this.container_panel.Controls.RemoveAt(0);
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.container_panel.Controls.Add(fh);
            this.container_panel.Tag = fh;
            fh.Show();
            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            openChildForm(new GetInventoryForm());
        }

        private void btnTransfers_Click(object sender, EventArgs e)
        {
            openChildForm(new TranferForm());
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            openChildForm(new LogForm());
        }
    }
}
