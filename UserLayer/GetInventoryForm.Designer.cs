
namespace UserLayer
{
    partial class GetInventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxWinerie = new System.Windows.Forms.ComboBox();
            this.lblWinerie = new System.Windows.Forms.Label();
            this.gridItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(303, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Check Inventory";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxWinerie
            // 
            this.cbxWinerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(155)))), ((int)(((byte)(173)))));
            this.cbxWinerie.FormattingEnabled = true;
            this.cbxWinerie.Location = new System.Drawing.Point(108, 107);
            this.cbxWinerie.Name = "cbxWinerie";
            this.cbxWinerie.Size = new System.Drawing.Size(121, 23);
            this.cbxWinerie.TabIndex = 1;
            this.cbxWinerie.SelectedIndexChanged += new System.EventHandler(this.cbxWinerie_SelectedIndexChanged);
            // 
            // lblWinerie
            // 
            this.lblWinerie.AutoSize = true;
            this.lblWinerie.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWinerie.Location = new System.Drawing.Point(27, 110);
            this.lblWinerie.Name = "lblWinerie";
            this.lblWinerie.Size = new System.Drawing.Size(75, 20);
            this.lblWinerie.TabIndex = 2;
            this.lblWinerie.Text = "Winerie";
            // 
            // gridItems
            // 
            this.gridItems.BackgroundColor = System.Drawing.Color.White;
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Location = new System.Drawing.Point(247, 96);
            this.gridItems.Name = "gridItems";
            this.gridItems.RowTemplate.Height = 25;
            this.gridItems.Size = new System.Drawing.Size(462, 375);
            this.gridItems.TabIndex = 6;
            // 
            // GetInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(721, 511);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.lblWinerie);
            this.Controls.Add(this.cbxWinerie);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetInventoryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GetInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxWinerie;
        private System.Windows.Forms.Label lblWinerie;
        private System.Windows.Forms.DataGridView gridItems;
    }
}