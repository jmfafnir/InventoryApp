
namespace UserLayer
{
    partial class TranferForm
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
            this.cbxOriginWinery = new System.Windows.Forms.ComboBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDestinationWinery = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountOrigin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAmountDestination = new System.Windows.Forms.Label();
            this.txtAmountTransfer = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
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
            this.lblTitle.Size = new System.Drawing.Size(293, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Make Transfers ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxOriginWinery
            // 
            this.cbxOriginWinery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(140)))));
            this.cbxOriginWinery.FormattingEnabled = true;
            this.cbxOriginWinery.Location = new System.Drawing.Point(172, 109);
            this.cbxOriginWinery.Name = "cbxOriginWinery";
            this.cbxOriginWinery.Size = new System.Drawing.Size(121, 23);
            this.cbxOriginWinery.TabIndex = 2;
            this.cbxOriginWinery.SelectedIndexChanged += new System.EventHandler(this.cbxOriginWinery_SelectedIndexChanged);
            // 
            // cbxItems
            // 
            this.cbxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(140)))));
            this.cbxItems.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(342, 155);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(121, 28);
            this.cbxItems.TabIndex = 3;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(360, 112);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(154, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Destination Winery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(183, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item to Transfer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Origin Winery";
            // 
            // cbxDestinationWinery
            // 
            this.cbxDestinationWinery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(140)))));
            this.cbxDestinationWinery.FormattingEnabled = true;
            this.cbxDestinationWinery.Location = new System.Drawing.Point(519, 109);
            this.cbxDestinationWinery.Name = "cbxDestinationWinery";
            this.cbxDestinationWinery.Size = new System.Drawing.Size(121, 23);
            this.cbxDestinationWinery.TabIndex = 7;
            this.cbxDestinationWinery.SelectedIndexChanged += new System.EventHandler(this.cbxDestinationWinery_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(264, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount to Transfer";
            // 
            // lblAmountOrigin
            // 
            this.lblAmountOrigin.AutoSize = true;
            this.lblAmountOrigin.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAmountOrigin.Location = new System.Drawing.Point(280, 238);
            this.lblAmountOrigin.Name = "lblAmountOrigin";
            this.lblAmountOrigin.Size = new System.Drawing.Size(13, 20);
            this.lblAmountOrigin.TabIndex = 9;
            this.lblAmountOrigin.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount in Origin Winery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(360, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amount in Destination Winery";
            // 
            // lblAmountDestination
            // 
            this.lblAmountDestination.AutoSize = true;
            this.lblAmountDestination.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAmountDestination.Location = new System.Drawing.Point(619, 238);
            this.lblAmountDestination.Name = "lblAmountDestination";
            this.lblAmountDestination.Size = new System.Drawing.Size(13, 20);
            this.lblAmountDestination.TabIndex = 12;
            this.lblAmountDestination.Text = ".";
            // 
            // txtAmountTransfer
            // 
            this.txtAmountTransfer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtAmountTransfer.Location = new System.Drawing.Point(425, 301);
            this.txtAmountTransfer.Name = "txtAmountTransfer";
            this.txtAmountTransfer.Size = new System.Drawing.Size(38, 27);
            this.txtAmountTransfer.TabIndex = 13;
            this.txtAmountTransfer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountTransfer_KeyPress);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.btnTransfer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.Location = new System.Drawing.Point(281, 378);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(182, 78);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Make Transfer ";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // TranferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(721, 511);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAmountTransfer);
            this.Controls.Add(this.lblAmountDestination);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAmountOrigin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDestinationWinery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.cbxOriginWinery);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TranferForm";
            this.Text = "TranferForm";
            this.Load += new System.EventHandler(this.TranferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxOriginWinery;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDestinationWinery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmountOrigin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAmountDestination;
        private System.Windows.Forms.TextBox txtAmountTransfer;
        private System.Windows.Forms.Button btnTransfer;
    }
}