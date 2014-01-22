namespace Tobin_3
{
    partial class SummaryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expeditedShippingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carStyleLable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carColorLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.carOptionsLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printOrderSummaryDocument = new System.Drawing.Printing.PrintDocument();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expedited Shipping:";
            // 
            // expeditedShippingLabel
            // 
            this.expeditedShippingLabel.AutoSize = true;
            this.expeditedShippingLabel.Location = new System.Drawing.Point(194, 83);
            this.expeditedShippingLabel.Name = "expeditedShippingLabel";
            this.expeditedShippingLabel.Size = new System.Drawing.Size(122, 13);
            this.expeditedShippingLabel.TabIndex = 2;
            this.expeditedShippingLabel.Text = "EXPEDITED SHIPPING";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Model:";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Location = new System.Drawing.Point(194, 115);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(70, 13);
            this.carModelLabel.TabIndex = 4;
            this.carModelLabel.Text = "CAR MODEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Car Style:";
            // 
            // carStyleLable
            // 
            this.carStyleLable.AutoSize = true;
            this.carStyleLable.Location = new System.Drawing.Point(194, 144);
            this.carStyleLable.Name = "carStyleLable";
            this.carStyleLable.Size = new System.Drawing.Size(66, 13);
            this.carStyleLable.TabIndex = 6;
            this.carStyleLable.Text = "CAR STYLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Car Color:";
            // 
            // carColorLabel
            // 
            this.carColorLabel.AutoSize = true;
            this.carColorLabel.Location = new System.Drawing.Point(194, 176);
            this.carColorLabel.Name = "carColorLabel";
            this.carColorLabel.Size = new System.Drawing.Size(69, 13);
            this.carColorLabel.TabIndex = 8;
            this.carColorLabel.Text = "CAR COLOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Car Options:";
            // 
            // carOptionsLabel
            // 
            this.carOptionsLabel.AutoSize = true;
            this.carOptionsLabel.Location = new System.Drawing.Point(194, 208);
            this.carOptionsLabel.Name = "carOptionsLabel";
            this.carOptionsLabel.Size = new System.Drawing.Size(80, 13);
            this.carOptionsLabel.TabIndex = 10;
            this.carOptionsLabel.Text = "CAR OPTIONS";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(155, 318);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 11;
            this.printButton.Text = "&Print";
            this.toolTip1.SetToolTip(this.printButton, "Print Order Summary");
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printOrderSummaryDocument
            // 
            this.printOrderSummaryDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printOrderSummaryDocument_PrintPage);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 353);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.carOptionsLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.carColorLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.carStyleLable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expeditedShippingLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SummaryForm";
            this.Text = "Order Summary";
            this.Activated += new System.EventHandler(this.SummaryForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label expeditedShippingLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label carStyleLable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label carColorLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label carOptionsLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printOrderSummaryDocument;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}