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
    public partial class TranferForm : Form
    {

        BlTransferItems blTransfer = new BlTransferItems();
        

        public TranferForm()
        {
            InitializeComponent();
        }

        private void TranferForm_Load(object sender, EventArgs e)
        {
            FillOutListofWinerys();
            this.cbxItems.Enabled = false;
            this.txtAmountTransfer.Enabled = false;
        }


        private void FillOutListofWinerys()
        {
            DataSet dsWineire = blTransfer.GetWineries();

            DataTable dtWineire = dsWineire.Tables["tlbWineries"];

            DataSet dsWineire2 = blTransfer.GetWineries();

            DataTable dtWineire2= dsWineire2.Tables["tlbWineries"];

            if (dsWineire.Tables[0].Rows.Count > 0 && dsWineire2.Tables[0].Rows.Count > 0)
            {
                this.cbxOriginWinery.DataSource = dtWineire;
                this.cbxOriginWinery.DisplayMember = "name";
                this.cbxOriginWinery.ValueMember = "id";
                this.cbxDestinationWinery.DataSource = dtWineire2;
                this.cbxDestinationWinery.DisplayMember = "name";
                this.cbxDestinationWinery.ValueMember = "id";
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            if (cbxItems.Enabled == true)
            {
                if (!String.IsNullOrEmpty(txtAmountTransfer.Text))
                {
                    if (cbxOriginWinery.SelectedValue.GetType() == 5.GetType()
                        && cbxItems.SelectedValue.GetType() == 5.GetType())
                    {
                        int id_winerie_origin = int.Parse(cbxOriginWinery.SelectedValue.ToString());
                        int id_winerie_destination = int.Parse(cbxDestinationWinery.SelectedValue.ToString());
                        int id_item = int.Parse(cbxItems.SelectedValue.ToString());
                        uint amount = uint.Parse(txtAmountTransfer.Text.Trim());

                        if (id_winerie_origin != id_winerie_destination)
                        {
                            if (blTransfer.ValidateAmount(amount, id_winerie_origin, id_item))
                            {
                                blTransfer.UpdateInventoryRegister(false, id_winerie_origin, id_item, amount);
                                blTransfer.UpdateInventoryRegister(true, id_winerie_destination, id_item, amount);
                            }
                            else
                            {
                                MessageBox.Show("The number of items entered exceeds the existing number ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The origin winery and the destination winery are same");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("The amount to transfer is not valid ");
                }
            }
            else
            {
                MessageBox.Show("Choose a source winery first");
            }
        }

        private void cbxOriginWinery_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cbxItems.Enabled = true;
            this.txtAmountTransfer.Enabled = true;
            if (cbxOriginWinery.SelectedValue.GetType() == 5.GetType()
                && cbxDestinationWinery.SelectedValue.GetType() == 5.GetType())
            {
                int id_winerie_origin = int.Parse(cbxOriginWinery.SelectedValue.ToString());
                int id_winerie_destination = int.Parse(cbxDestinationWinery.SelectedValue.ToString());


                DataSet dsWineire = blTransfer.GetItems(id_winerie_origin);

                DataTable dtWineire = dsWineire.Tables["tlbItems"];

                if (dsWineire.Tables[0].Rows.Count > 0)
                {
                    this.cbxItems.DataSource = dtWineire;
                    this.cbxItems.DisplayMember = "name";
                    this.cbxItems.ValueMember = "id";
                }

                int id_item = int.Parse(cbxItems.SelectedValue.ToString());

                GetStockofWinery(id_winerie_origin, id_winerie_destination, id_item);

            }

        }

        public void GetStockofWinery(int id_winerie_origin, int id_winerie_destination, int id_item)
        {
            lblAmountOrigin.Text = blTransfer.GetStock(id_winerie_origin, id_item).ToString();
            lblAmountDestination.Text = blTransfer.GetStock(id_winerie_destination, id_item).ToString();
        }

        
        private void cbxDestinationWinery_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ( cbxDestinationWinery.SelectedValue.GetType() == 5.GetType() &&
                cbxOriginWinery.SelectedValue.GetType() == 5.GetType() && cbxItems.Enabled == true)
            {
                int id_winerie_origin = int.Parse(cbxOriginWinery.SelectedValue.ToString());
                int id_winerie_destination = int.Parse(cbxDestinationWinery.SelectedValue.ToString());
                int id_item = int.Parse(cbxItems.SelectedValue.ToString());

                GetStockofWinery(id_winerie_origin, id_winerie_destination, id_item);
            }
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDestinationWinery.SelectedValue.GetType() == 5.GetType() &&
                cbxOriginWinery.SelectedValue.GetType() == 5.GetType()
                && cbxItems.SelectedValue.GetType() == 5.GetType())
            {
                int id_winerie_origin = int.Parse(cbxOriginWinery.SelectedValue.ToString());
                int id_winerie_destination = int.Parse(cbxDestinationWinery.SelectedValue.ToString());
                int id_item = int.Parse(cbxItems.SelectedValue.ToString());

                GetStockofWinery(id_winerie_origin, id_winerie_destination, id_item);
            }
        }

        private void txtAmountTransfer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }


}