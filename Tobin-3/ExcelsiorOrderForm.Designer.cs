namespace Tobin_3
{
    partial class ExcelsiorOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelsiorOrderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summarizeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expeditedShippingCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carModelComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hardTopRadioButton = new System.Windows.Forms.RadioButton();
            this.convertibleRadioButton = new System.Windows.Forms.RadioButton();
            this.carColorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carOptionsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summarizeOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summarizeOrderToolStripMenuItem
            // 
            this.summarizeOrderToolStripMenuItem.Name = "summarizeOrderToolStripMenuItem";
            this.summarizeOrderToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.summarizeOrderToolStripMenuItem.Text = "&Summarize Order";
            this.summarizeOrderToolStripMenuItem.Click += new System.EventHandler(this.summarizeOrderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColorToolStripMenuItem,
            this.removeColorToolStripMenuItem,
            this.resetFormToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addColorToolStripMenuItem
            // 
            this.addColorToolStripMenuItem.Name = "addColorToolStripMenuItem";
            this.addColorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addColorToolStripMenuItem.Text = "&Add Color";
            this.addColorToolStripMenuItem.Click += new System.EventHandler(this.addColorToolStripMenuItem_Click);
            // 
            // removeColorToolStripMenuItem
            // 
            this.removeColorToolStripMenuItem.Name = "removeColorToolStripMenuItem";
            this.removeColorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeColorToolStripMenuItem.Text = "&Remove Color";
            this.removeColorToolStripMenuItem.Click += new System.EventHandler(this.removeColorToolStripMenuItem_Click);
            // 
            // resetFormToolStripMenuItem
            // 
            this.resetFormToolStripMenuItem.Name = "resetFormToolStripMenuItem";
            this.resetFormToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.resetFormToolStripMenuItem.Text = "Reset &Form";
            this.resetFormToolStripMenuItem.Click += new System.EventHandler(this.resetFormToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 270);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(101, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excelsior Automobile Company";
            // 
            // expeditedShippingCheckBox
            // 
            this.expeditedShippingCheckBox.AutoSize = true;
            this.expeditedShippingCheckBox.Location = new System.Drawing.Point(350, 514);
            this.expeditedShippingCheckBox.Name = "expeditedShippingCheckBox";
            this.expeditedShippingCheckBox.Size = new System.Drawing.Size(117, 17);
            this.expeditedShippingCheckBox.TabIndex = 11;
            this.expeditedShippingCheckBox.Text = "Expedited Shipping";
            this.expeditedShippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Model:";
            // 
            // carModelComboBox
            // 
            this.carModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carModelComboBox.FormattingEnabled = true;
            this.carModelComboBox.Location = new System.Drawing.Point(198, 337);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(121, 21);
            this.carModelComboBox.Sorted = true;
            this.carModelComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Styles:";
            // 
            // hardTopRadioButton
            // 
            this.hardTopRadioButton.AutoSize = true;
            this.hardTopRadioButton.Location = new System.Drawing.Point(198, 364);
            this.hardTopRadioButton.Name = "hardTopRadioButton";
            this.hardTopRadioButton.Size = new System.Drawing.Size(70, 17);
            this.hardTopRadioButton.TabIndex = 5;
            this.hardTopRadioButton.TabStop = true;
            this.hardTopRadioButton.Text = "Hard Top";
            this.hardTopRadioButton.UseVisualStyleBackColor = true;
            // 
            // convertibleRadioButton
            // 
            this.convertibleRadioButton.AutoSize = true;
            this.convertibleRadioButton.Location = new System.Drawing.Point(274, 364);
            this.convertibleRadioButton.Name = "convertibleRadioButton";
            this.convertibleRadioButton.Size = new System.Drawing.Size(78, 17);
            this.convertibleRadioButton.TabIndex = 6;
            this.convertibleRadioButton.TabStop = true;
            this.convertibleRadioButton.Text = "Convertible";
            this.convertibleRadioButton.UseVisualStyleBackColor = true;
            // 
            // carColorComboBox
            // 
            this.carColorComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.carColorComboBox.FormattingEnabled = true;
            this.carColorComboBox.Location = new System.Drawing.Point(198, 387);
            this.carColorComboBox.Name = "carColorComboBox";
            this.carColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.carColorComboBox.Sorted = true;
            this.carColorComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Car Color:";
            // 
            // carOptionsListBox
            // 
            this.carOptionsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.carOptionsListBox.FormattingEnabled = true;
            this.carOptionsListBox.Location = new System.Drawing.Point(198, 413);
            this.carOptionsListBox.Name = "carOptionsListBox";
            this.carOptionsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.carOptionsListBox.Size = new System.Drawing.Size(120, 95);
            this.carOptionsListBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Car Options:";
            // 
            // ExcelsiorOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(479, 543);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carOptionsListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carColorComboBox);
            this.Controls.Add(this.convertibleRadioButton);
            this.Controls.Add(this.hardTopRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carModelComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expeditedShippingCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExcelsiorOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excelsior Order Form";
            this.Load += new System.EventHandler(this.ExcelsiorOrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summarizeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox expeditedShippingCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox carModelComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton hardTopRadioButton;
        private System.Windows.Forms.RadioButton convertibleRadioButton;
        private System.Windows.Forms.ComboBox carColorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox carOptionsListBox;
        private System.Windows.Forms.Label label5;
    }
}

