using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace UserLayer
{
    public partial class LogForm : Form
    {
        BlLogRegistry blLogRegistry = new BlLogRegistry();
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            DataSet dsLogRegister = blLogRegistry.GetLogRegistries();

            DataTable dtLogRegister = dsLogRegister.Tables["tlbLogRegistries"];

            this.gridLogRegister.DataSource = dtLogRegister;
        }
    }
}
