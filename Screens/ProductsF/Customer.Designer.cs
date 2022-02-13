namespace PointofSaleSoftware.Screens.ProductsF
{
    partial class Customer
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
            this.CustomerName = new MetroFramework.Controls.MetroTextBox();
            this.CustomerAddress = new System.Windows.Forms.RichTextBox();
            this.CustomerCell = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btn_Update = new MetroFramework.Controls.MetroButton();
            this.btn_Clearform = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.CustomerName.CustomButton.Image = null;
            this.CustomerName.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.CustomerName.CustomButton.Name = "";
            this.CustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerName.CustomButton.TabIndex = 1;
            this.CustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerName.CustomButton.UseSelectable = true;
            this.CustomerName.CustomButton.Visible = false;
            this.CustomerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CustomerName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.CustomerName.Lines = new string[0];
            this.CustomerName.Location = new System.Drawing.Point(10, 174);
            this.CustomerName.MaxLength = 32767;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.PasswordChar = '\0';
            this.CustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerName.SelectedText = "";
            this.CustomerName.SelectionLength = 0;
            this.CustomerName.SelectionStart = 0;
            this.CustomerName.ShortcutsEnabled = true;
            this.CustomerName.Size = new System.Drawing.Size(306, 23);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.UseSelectable = true;
            this.CustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.Location = new System.Drawing.Point(10, 236);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(356, 96);
            this.CustomerAddress.TabIndex = 1;
            this.CustomerAddress.Text = "";
            // 
            // CustomerCell
            // 
            this.CustomerCell.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.CustomerCell.CustomButton.Image = null;
            this.CustomerCell.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.CustomerCell.CustomButton.Name = "";
            this.CustomerCell.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerCell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerCell.CustomButton.TabIndex = 1;
            this.CustomerCell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerCell.CustomButton.UseSelectable = true;
            this.CustomerCell.CustomButton.Visible = false;
            this.CustomerCell.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.CustomerCell.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.CustomerCell.Lines = new string[0];
            this.CustomerCell.Location = new System.Drawing.Point(10, 372);
            this.CustomerCell.MaxLength = 32767;
            this.CustomerCell.Name = "CustomerCell";
            this.CustomerCell.PasswordChar = '\0';
            this.CustomerCell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerCell.SelectedText = "";
            this.CustomerCell.SelectionLength = 0;
            this.CustomerCell.SelectionStart = 0;
            this.CustomerCell.ShortcutsEnabled = true;
            this.CustomerCell.Size = new System.Drawing.Size(231, 23);
            this.CustomerCell.TabIndex = 2;
            this.CustomerCell.UseSelectable = true;
            this.CustomerCell.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerCell.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(10, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Customer Name";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(-1, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(166, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Customer Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(-1, 344);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Cell Phone";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(10, 441);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 40);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Add New";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(846, 441);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 40);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Close";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(385, 47);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(561, 326);
            this.DataGridView1.TabIndex = 8;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(10, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Customer ID";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(10, 103);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Update.Location = new System.Drawing.Point(143, 441);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 40);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Clearform
            // 
            this.btn_Clearform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Clearform.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Clearform.Location = new System.Drawing.Point(711, 441);
            this.btn_Clearform.Name = "btn_Clearform";
            this.btn_Clearform.Size = new System.Drawing.Size(115, 40);
            this.btn_Clearform.TabIndex = 12;
            this.btn_Clearform.Text = "Clear Fields";
            this.btn_Clearform.UseSelectable = true;
            this.btn_Clearform.Click += new System.EventHandler(this.btn_Clearform_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 486);
            this.Controls.Add(this.btn_Clearform);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CustomerCell);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.CustomerName);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox CustomerName;
        private System.Windows.Forms.RichTextBox CustomerAddress;
        private MetroFramework.Controls.MetroTextBox CustomerCell;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btn_Update;
        private MetroFramework.Controls.MetroButton btn_Clearform;
    }
}