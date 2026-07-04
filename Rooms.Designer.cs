namespace QUẢN_LÝ_KHÁCH_SẠN
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboTT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtLP = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(18, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(779, 353);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cboTT
            // 
            this.cboTT.BackColor = System.Drawing.Color.Transparent;
            this.cboTT.BorderRadius = 21;
            this.cboTT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTT.ItemHeight = 30;
            this.cboTT.Items.AddRange(new object[] {
            "Trống",
            "Có khách",
            "Đang sửa"});
            this.cboTT.Location = new System.Drawing.Point(357, 119);
            this.cboTT.Name = "cboTT";
            this.cboTT.Size = new System.Drawing.Size(129, 36);
            this.cboTT.StartIndex = 0;
            this.cboTT.TabIndex = 68;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 21;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(619, 176);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(122, 38);
            this.txtSearch.TabIndex = 67;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtGP
            // 
            this.txtGP.BorderRadius = 21;
            this.txtGP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGP.DefaultText = "";
            this.txtGP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGP.ForeColor = System.Drawing.Color.DimGray;
            this.txtGP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGP.Location = new System.Drawing.Point(589, 62);
            this.txtGP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtGP.Name = "txtGP";
            this.txtGP.PlaceholderText = "Giá Phòng";
            this.txtGP.SelectedText = "";
            this.txtGP.Size = new System.Drawing.Size(129, 33);
            this.txtGP.TabIndex = 63;
            // 
            // txtTenP
            // 
            this.txtTenP.BorderRadius = 21;
            this.txtTenP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenP.DefaultText = "";
            this.txtTenP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenP.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenP.Location = new System.Drawing.Point(95, 122);
            this.txtTenP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTenP.Name = "txtTenP";
            this.txtTenP.PlaceholderText = "Tên Phòng";
            this.txtTenP.SelectedText = "";
            this.txtTenP.Size = new System.Drawing.Size(129, 33);
            this.txtTenP.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(338, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 38);
            this.label2.TabIndex = 60;
            this.label2.Text = "Rooms";
            // 
            // txtMP
            // 
            this.txtMP.BorderRadius = 21;
            this.txtMP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMP.DefaultText = "";
            this.txtMP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMP.ForeColor = System.Drawing.Color.DimGray;
            this.txtMP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMP.Location = new System.Drawing.Point(98, 62);
            this.txtMP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMP.Name = "txtMP";
            this.txtMP.PlaceholderText = "Mã Phòng";
            this.txtMP.SelectedText = "";
            this.txtMP.Size = new System.Drawing.Size(129, 33);
            this.txtMP.TabIndex = 59;
            // 
            // btnDel
            // 
            this.btnDel.AutoRoundedCorners = true;
            this.btnDel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.btnDel.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDel.CheckedState.Image = global::QUẢN_LÝ_KHÁCH_SẠN.Properties.Resources.home_button;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::QUẢN_LÝ_KHÁCH_SẠN.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(477, 178);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 38);
            this.btnDel.TabIndex = 66;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.btnEdit.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.CheckedState.Image = global::QUẢN_LÝ_KHÁCH_SẠN.Properties.Resources.home_button;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(287, 178);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 38);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedState.Image = global::QUẢN_LÝ_KHÁCH_SẠN.Properties.Resources.home_button;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(92, 176);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 38);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLP
            // 
            this.txtLP.BorderRadius = 21;
            this.txtLP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLP.DefaultText = "";
            this.txtLP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLP.ForeColor = System.Drawing.Color.DimGray;
            this.txtLP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLP.Location = new System.Drawing.Point(357, 62);
            this.txtLP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtLP.Name = "txtLP";
            this.txtLP.PlaceholderText = "Loại Phòng";
            this.txtLP.SelectedText = "";
            this.txtLP.Size = new System.Drawing.Size(129, 33);
            this.txtLP.TabIndex = 62;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(806, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboTT);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGP);
            this.Controls.Add(this.txtLP);
            this.Controls.Add(this.txtTenP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMP);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox cboTT;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtGP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenP;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMP;
        private Guna.UI2.WinForms.Guna2TextBox txtLP;
    }
}