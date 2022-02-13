namespace PointofSaleSoftware.Screens.ProductsF
{
    partial class Suppliers
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
            this.Supp_Code = new MetroFramework.Controls.MetroTextBox();
            this.Supp_Name = new MetroFramework.Controls.MetroTextBox();
            this.Supp_Address = new System.Windows.Forms.RichTextBox();
            this.Supp_CellNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_Add = new MetroFramework.Controls.MetroButton();
            this.btn_Update = new MetroFramework.Controls.MetroButton();
            this.btn_Close = new MetroFramework.Controls.MetroButton();
            this.btn_Clear = new MetroFramework.Controls.MetroButton();
            this.SuppID = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Supp_Code
            // 
            // 
            // 
            // 
            this.Supp_Code.CustomButton.Image = null;
            this.Supp_Code.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.Supp_Code.CustomButton.Name = "";
            this.Supp_Code.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Supp_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Supp_Code.CustomButton.TabIndex = 1;
            this.Supp_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Supp_Code.CustomButton.UseSelectable = true;
            this.Supp_Code.CustomButton.Visible = false;
            this.Supp_Code.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Supp_Code.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Supp_Code.Lines = new string[0];
            this.Supp_Code.Location = new System.Drawing.Point(6, 35);
            this.Supp_Code.MaxLength = 32767;
            this.Supp_Code.Name = "Supp_Code";
            this.Supp_Code.PasswordChar = '\0';
            this.Supp_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Supp_Code.SelectedText = "";
            this.Supp_Code.SelectionLength = 0;
            this.Supp_Code.SelectionStart = 0;
            this.Supp_Code.ShortcutsEnabled = true;
            this.Supp_Code.Size = new System.Drawing.Size(112, 30);
            this.Supp_Code.TabIndex = 0;
            this.Supp_Code.UseSelectable = true;
            this.Supp_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Supp_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Supp_Name
            // 
            this.Supp_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.Supp_Name.CustomButton.Image = null;
            this.Supp_Name.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.Supp_Name.CustomButton.Name = "";
            this.Supp_Name.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Supp_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Supp_Name.CustomButton.TabIndex = 1;
            this.Supp_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Supp_Name.CustomButton.UseSelectable = true;
            this.Supp_Name.CustomButton.Visible = false;
            this.Supp_Name.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Supp_Name.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Supp_Name.Lines = new string[0];
            this.Supp_Name.Location = new System.Drawing.Point(124, 35);
            this.Supp_Name.MaxLength = 32767;
            this.Supp_Name.Name = "Supp_Name";
            this.Supp_Name.PasswordChar = '\0';
            this.Supp_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Supp_Name.SelectedText = "";
            this.Supp_Name.SelectionLength = 0;
            this.Supp_Name.SelectionStart = 0;
            this.Supp_Name.ShortcutsEnabled = true;
            this.Supp_Name.Size = new System.Drawing.Size(193, 30);
            this.Supp_Name.TabIndex = 1;
            this.Supp_Name.UseSelectable = true;
            this.Supp_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Supp_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Supp_Address
            // 
            this.Supp_Address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supp_Address.Location = new System.Drawing.Point(323, 35);
            this.Supp_Address.Name = "Supp_Address";
            this.Supp_Address.Size = new System.Drawing.Size(234, 46);
            this.Supp_Address.TabIndex = 2;
            this.Supp_Address.Text = "";
            this.Supp_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Supp_Address_KeyPress);
            // 
            // Supp_CellNumber
            // 
            this.Supp_CellNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.Supp_CellNumber.CustomButton.Image = null;
            this.Supp_CellNumber.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.Supp_CellNumber.CustomButton.Name = "";
            this.Supp_CellNumber.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Supp_CellNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Supp_CellNumber.CustomButton.TabIndex = 1;
            this.Supp_CellNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Supp_CellNumber.CustomButton.UseSelectable = true;
            this.Supp_CellNumber.CustomButton.Visible = false;
            this.Supp_CellNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Supp_CellNumber.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Supp_CellNumber.Lines = new string[0];
            this.Supp_CellNumber.Location = new System.Drawing.Point(563, 35);
            this.Supp_CellNumber.MaxLength = 32767;
            this.Supp_CellNumber.Name = "Supp_CellNumber";
            this.Supp_CellNumber.PasswordChar = '\0';
            this.Supp_CellNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Supp_CellNumber.SelectedText = "";
            this.Supp_CellNumber.SelectionLength = 0;
            this.Supp_CellNumber.SelectionStart = 0;
            this.Supp_CellNumber.ShortcutsEnabled = true;
            this.Supp_CellNumber.Size = new System.Drawing.Size(148, 30);
            this.Supp_CellNumber.TabIndex = 3;
            this.Supp_CellNumber.UseSelectable = true;
            this.Supp_CellNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Supp_CellNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Supplier Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 292);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(124, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Supplier Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(323, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Address";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(563, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Cell Phone";
            // 
            // btn_Add
            // 
            this.btn_Add.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Add.Location = new System.Drawing.Point(717, 13);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 28);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseSelectable = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Update.Location = new System.Drawing.Point(808, 13);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 28);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Close.Location = new System.Drawing.Point(808, 68);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 27);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseSelectable = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Clear.Location = new System.Drawing.Point(717, 68);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 27);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // SuppID
            // 
            // 
            // 
            // 
            this.SuppID.CustomButton.Image = null;
            this.SuppID.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.SuppID.CustomButton.Name = "";
            this.SuppID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.SuppID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SuppID.CustomButton.TabIndex = 1;
            this.SuppID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SuppID.CustomButton.UseSelectable = true;
            this.SuppID.CustomButton.Visible = false;
            this.SuppID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.SuppID.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.SuppID.Lines = new string[0];
            this.SuppID.Location = new System.Drawing.Point(6, 79);
            this.SuppID.MaxLength = 32767;
            this.SuppID.Name = "SuppID";
            this.SuppID.PasswordChar = '\0';
            this.SuppID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SuppID.SelectedText = "";
            this.SuppID.SelectionLength = 0;
            this.SuppID.SelectionStart = 0;
            this.SuppID.ShortcutsEnabled = true;
            this.SuppID.Size = new System.Drawing.Size(112, 30);
            this.SuppID.TabIndex = 13;
            this.SuppID.UseSelectable = true;
            this.SuppID.Visible = false;
            this.SuppID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SuppID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 436);
            this.ControlBox = false;
            this.Controls.Add(this.SuppID);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Supp_CellNumber);
            this.Controls.Add(this.Supp_Address);
            this.Controls.Add(this.Supp_Name);
            this.Controls.Add(this.Supp_Code);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Supp_Code;
        private MetroFramework.Controls.MetroTextBox Supp_Name;
        private System.Windows.Forms.RichTextBox Supp_Address;
        private MetroFramework.Controls.MetroTextBox Supp_CellNumber;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btn_Add;
        private MetroFramework.Controls.MetroButton btn_Update;
        private MetroFramework.Controls.MetroButton btn_Close;
        private MetroFramework.Controls.MetroButton btn_Clear;
        private MetroFramework.Controls.MetroTextBox SuppID;
    }
}