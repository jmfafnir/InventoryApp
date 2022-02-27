using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace UserLayer
{
    public partial class GetInventoryForm : Form
    {
        BlWinerie blWinerie = new BlWinerie();
        BlWinerieStock blwinerieStock = new BlWinerieStock(); 

        public GetInventoryForm()
        {
            InitializeComponent();
        }

        private void GetInventoryForm_Load(object sender, EventArgs e)
        {
            ListWinerie();
        }


        private void ListWinerie()
        {
            DataSet dsWineire = blWinerie.GetWinerieData();

            DataTable dtWineire = dsWineire.Tables["tlbWineries"];
            DataRow[] drWineir = dsWineire.Tables["tlbWineries"].Select();

            if (dsWineire.Tables[0].Rows.Count > 0)
            {
                this.cbxWinerie.DataSource = dtWineire;
                this.cbxWinerie.DisplayMember = "name";
                this.cbxWinerie.ValueMember = "id";
            }

            
        }

        private void ListItemsWinerie(int id)
        {
            DataSet dsWineireStock = blwinerieStock.GetWinerieStockData(id);

            DataTable dtWineireStock = dsWineireStock.Tables["tlbWinerieStock"];

            this.gridItems.DataSource = dtWineireStock;
        }

        private void cbxWinerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbxWinerie.SelectedValue.GetType() == 5.GetType())
            {
                int id_winerie = int.Parse(cbxWinerie.SelectedValue.ToString());
                ListItemsWinerie(id_winerie);
            }
        }

        
    }
}
