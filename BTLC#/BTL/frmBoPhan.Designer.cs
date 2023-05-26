namespace BTL
{
    partial class frmBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoPhan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayThanhLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaBP = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenBP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errThongTinBP = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnMoiBP = new System.Windows.Forms.Button();
            this.btnThoatBP = new System.Windows.Forms.Button();
            this.btnXoaBP = new System.Windows.Forms.Button();
            this.btnLuuBP = new System.Windows.Forms.Button();
            this.btnSuaBP = new System.Windows.Forms.Button();
            this.dgvBoPhan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errThongTinBP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayThanhLap);
            this.groupBox1.Controls.Add(this.txtMaBP);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtTenBP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(848, 155);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về bộ phận";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày thành lập";
            // 
            // dtpNgayThanhLap
            // 
            this.dtpNgayThanhLap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayThanhLap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThanhLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThanhLap.Location = new System.Drawing.Point(140, 91);
            this.dtpNgayThanhLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayThanhLap.Name = "dtpNgayThanhLap";
            this.dtpNgayThanhLap.Size = new System.Drawing.Size(182, 28);
            this.dtpNgayThanhLap.TabIndex = 1;
            // 
            // txtMaBP
            // 
            this.txtMaBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaBP.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBP.Location = new System.Drawing.Point(140, 41);
            this.txtMaBP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBP.Name = "txtMaBP";
            this.txtMaBP.Size = new System.Drawing.Size(182, 28);
            this.txtMaBP.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(466, 87);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(182, 38);
            this.txtGhiChu.TabIndex = 6;
            // 
            // txtTenBP
            // 
            this.txtTenBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenBP.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBP.Location = new System.Drawing.Point(466, 41);
            this.txtTenBP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBP.Name = "txtTenBP";
            this.txtTenBP.Size = new System.Drawing.Size(182, 28);
            this.txtTenBP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bộ phận";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ phận";
            // 
            // errThongTinBP
            // 
            this.errThongTinBP.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnMoiBP);
            this.groupBox2.Controls.Add(this.btnThoatBP);
            this.groupBox2.Controls.Add(this.btnXoaBP);
            this.groupBox2.Controls.Add(this.btnLuuBP);
            this.groupBox2.Controls.Add(this.btnSuaBP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(848, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "các chức năng";
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIn.BackgroundImage")));
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(572, 32);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(107, 46);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnMoiBP
            // 
            this.btnMoiBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoiBP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMoiBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoiBP.BackgroundImage")));
            this.btnMoiBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoiBP.FlatAppearance.BorderSize = 0;
            this.btnMoiBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMoiBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMoiBP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoiBP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMoiBP.Image = ((System.Drawing.Image)(resources.GetObject("btnMoiBP.Image")));
            this.btnMoiBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoiBP.Location = new System.Drawing.Point(28, 32);
            this.btnMoiBP.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoiBP.Name = "btnMoiBP";
            this.btnMoiBP.Size = new System.Drawing.Size(100, 46);
            this.btnMoiBP.TabIndex = 7;
            this.btnMoiBP.Text = "Mới   ";
            this.btnMoiBP.UseVisualStyleBackColor = false;
            this.btnMoiBP.Click += new System.EventHandler(this.btnMoiBP_Click);
            this.btnMoiBP.MouseEnter += new System.EventHandler(this.btnMoiBP_MouseEnter);
            this.btnMoiBP.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnThoatBP
            // 
            this.btnThoatBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoatBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoatBP.BackgroundImage")));
            this.btnThoatBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoatBP.FlatAppearance.BorderSize = 0;
            this.btnThoatBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoatBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoatBP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatBP.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatBP.Image")));
            this.btnThoatBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatBP.Location = new System.Drawing.Point(714, 32);
            this.btnThoatBP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatBP.Name = "btnThoatBP";
            this.btnThoatBP.Size = new System.Drawing.Size(107, 46);
            this.btnThoatBP.TabIndex = 11;
            this.btnThoatBP.Text = "Thoát ";
            this.btnThoatBP.UseVisualStyleBackColor = true;
            this.btnThoatBP.Click += new System.EventHandler(this.btnThoatBP_Click);
            // 
            // btnXoaBP
            // 
            this.btnXoaBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaBP.BackgroundImage")));
            this.btnXoaBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaBP.FlatAppearance.BorderSize = 0;
            this.btnXoaBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoaBP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBP.Image")));
            this.btnXoaBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBP.Location = new System.Drawing.Point(430, 32);
            this.btnXoaBP.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaBP.Name = "btnXoaBP";
            this.btnXoaBP.Size = new System.Drawing.Size(103, 46);
            this.btnXoaBP.TabIndex = 10;
            this.btnXoaBP.Text = "Xóa   ";
            this.btnXoaBP.UseVisualStyleBackColor = true;
            this.btnXoaBP.Click += new System.EventHandler(this.btnXoaBP_Click);
            // 
            // btnLuuBP
            // 
            this.btnLuuBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuuBP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuuBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuuBP.BackgroundImage")));
            this.btnLuuBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuuBP.FlatAppearance.BorderSize = 0;
            this.btnLuuBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuuBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLuuBP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuBP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuBP.Image")));
            this.btnLuuBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuBP.Location = new System.Drawing.Point(158, 32);
            this.btnLuuBP.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuBP.Name = "btnLuuBP";
            this.btnLuuBP.Size = new System.Drawing.Size(103, 46);
            this.btnLuuBP.TabIndex = 8;
            this.btnLuuBP.Text = "Lưu";
            this.btnLuuBP.UseVisualStyleBackColor = false;
            this.btnLuuBP.Click += new System.EventHandler(this.btnLuuBP_Click);
            // 
            // btnSuaBP
            // 
            this.btnSuaBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaBP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuaBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaBP.BackgroundImage")));
            this.btnSuaBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaBP.FlatAppearance.BorderSize = 0;
            this.btnSuaBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSuaBP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBP.Image")));
            this.btnSuaBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBP.Location = new System.Drawing.Point(293, 32);
            this.btnSuaBP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaBP.Name = "btnSuaBP";
            this.btnSuaBP.Size = new System.Drawing.Size(101, 46);
            this.btnSuaBP.TabIndex = 9;
            this.btnSuaBP.Text = "Sửa   ";
            this.btnSuaBP.UseVisualStyleBackColor = false;
            this.btnSuaBP.Click += new System.EventHandler(this.btnSuaBP_Click);
            // 
            // dgvBoPhan
            // 
            this.dgvBoPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoPhan.Location = new System.Drawing.Point(0, 244);
            this.dgvBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBoPhan.Name = "dgvBoPhan";
            this.dgvBoPhan.RowHeadersWidth = 51;
            this.dgvBoPhan.Size = new System.Drawing.Size(848, 260);
            this.dgvBoPhan.TabIndex = 7;
            this.dgvBoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoPhan_CellClick);
            // 
            // frmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 504);
            this.Controls.Add(this.dgvBoPhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBoPhan";
            this.Text = "frmBoPhan";
            this.Load += new System.EventHandler(this.frmBoPhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errThongTinBP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhLap;
        private System.Windows.Forms.TextBox txtMaBP;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenBP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errThongTinBP;
        private System.Windows.Forms.DataGridView dgvBoPhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnMoiBP;
        private System.Windows.Forms.Button btnThoatBP;
        private System.Windows.Forms.Button btnXoaBP;
        private System.Windows.Forms.Button btnLuuBP;
        private System.Windows.Forms.Button btnSuaBP;
    }
}