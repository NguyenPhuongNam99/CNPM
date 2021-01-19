namespace baibaocao
{
    partial class giaovien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxmagv = new System.Windows.Forms.TextBox();
            this.textBox1tengv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTimkiem = new System.Windows.Forms.Button();
            this.button2xoa = new System.Windows.Forms.Button();
            this.button3sua = new System.Windows.Forms.Button();
            this.button4them = new System.Windows.Forms.Button();
            this.buttonhienthi = new System.Windows.Forms.Button();
            this.dataGridView1gvien = new System.Windows.Forms.DataGridView();
            this.comboBoxmalop = new System.Windows.Forms.ComboBox();
            this.textBoxupdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1gvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(243, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN GIÁO VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(59, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // textBoxmagv
            // 
            this.textBoxmagv.Location = new System.Drawing.Point(187, 89);
            this.textBoxmagv.Name = "textBoxmagv";
            this.textBoxmagv.Size = new System.Drawing.Size(301, 20);
            this.textBoxmagv.TabIndex = 2;
            // 
            // textBox1tengv
            // 
            this.textBox1tengv.Location = new System.Drawing.Point(187, 140);
            this.textBox1tengv.Name = "textBox1tengv";
            this.textBox1tengv.Size = new System.Drawing.Size(301, 20);
            this.textBox1tengv.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(59, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Giáo Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(59, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Lớp";
            // 
            // buttonTimkiem
            // 
            this.buttonTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            this.buttonTimkiem.Location = new System.Drawing.Point(187, 247);
            this.buttonTimkiem.Name = "buttonTimkiem";
            this.buttonTimkiem.Size = new System.Drawing.Size(91, 31);
            this.buttonTimkiem.TabIndex = 7;
            this.buttonTimkiem.Text = "Tìm Kiếm";
            this.buttonTimkiem.UseVisualStyleBackColor = false;
            this.buttonTimkiem.Click += new System.EventHandler(this.buttonTimkiem_Click);
            // 
            // button2xoa
            // 
            this.button2xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            this.button2xoa.Location = new System.Drawing.Point(563, 180);
            this.button2xoa.Name = "button2xoa";
            this.button2xoa.Size = new System.Drawing.Size(91, 31);
            this.button2xoa.TabIndex = 8;
            this.button2xoa.Text = "Xóa";
            this.button2xoa.UseVisualStyleBackColor = false;
            this.button2xoa.Click += new System.EventHandler(this.button2xoa_Click);
            // 
            // button3sua
            // 
            this.button3sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            this.button3sua.Location = new System.Drawing.Point(345, 247);
            this.button3sua.Name = "button3sua";
            this.button3sua.Size = new System.Drawing.Size(91, 31);
            this.button3sua.TabIndex = 9;
            this.button3sua.Text = "Sửa";
            this.button3sua.UseVisualStyleBackColor = false;
            this.button3sua.Click += new System.EventHandler(this.button3sua_Click);
            // 
            // button4them
            // 
            this.button4them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            this.button4them.Location = new System.Drawing.Point(563, 129);
            this.button4them.Name = "button4them";
            this.button4them.Size = new System.Drawing.Size(91, 31);
            this.button4them.TabIndex = 10;
            this.button4them.Text = "Thêm";
            this.button4them.UseVisualStyleBackColor = false;
            this.button4them.Click += new System.EventHandler(this.button4them_Click);
            // 
            // buttonhienthi
            // 
            this.buttonhienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonhienthi.ForeColor = System.Drawing.Color.LightGray;
            this.buttonhienthi.Location = new System.Drawing.Point(563, 86);
            this.buttonhienthi.Name = "buttonhienthi";
            this.buttonhienthi.Size = new System.Drawing.Size(91, 31);
            this.buttonhienthi.TabIndex = 11;
            this.buttonhienthi.Text = "Hiển Thị";
            this.buttonhienthi.UseVisualStyleBackColor = false;
            this.buttonhienthi.Click += new System.EventHandler(this.buttonhienthi_Click);
            // 
            // dataGridView1gvien
            // 
            this.dataGridView1gvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1gvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1gvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1gvien.Location = new System.Drawing.Point(54, 300);
            this.dataGridView1gvien.Name = "dataGridView1gvien";
            this.dataGridView1gvien.Size = new System.Drawing.Size(650, 163);
            this.dataGridView1gvien.TabIndex = 12;
            this.dataGridView1gvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1gvien_CellContentClick);
            // 
            // comboBoxmalop
            // 
            this.comboBoxmalop.FormattingEnabled = true;
            this.comboBoxmalop.Location = new System.Drawing.Point(187, 190);
            this.comboBoxmalop.Name = "comboBoxmalop";
            this.comboBoxmalop.Size = new System.Drawing.Size(301, 21);
            this.comboBoxmalop.TabIndex = 13;
            // 
            // textBoxupdate
            // 
            this.textBoxupdate.Location = new System.Drawing.Point(453, 253);
            this.textBoxupdate.Name = "textBoxupdate";
            this.textBoxupdate.Size = new System.Drawing.Size(113, 20);
            this.textBoxupdate.TabIndex = 14;
            this.textBoxupdate.Text = "Update";
            // 
            // giaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.textBoxupdate);
            this.Controls.Add(this.comboBoxmalop);
            this.Controls.Add(this.dataGridView1gvien);
            this.Controls.Add(this.buttonhienthi);
            this.Controls.Add(this.button4them);
            this.Controls.Add(this.button3sua);
            this.Controls.Add(this.button2xoa);
            this.Controls.Add(this.buttonTimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1tengv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxmagv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giaovien";
            this.Text = "giaovien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1gvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxmagv;
        private System.Windows.Forms.TextBox textBox1tengv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTimkiem;
        private System.Windows.Forms.Button button2xoa;
        private System.Windows.Forms.Button button3sua;
        private System.Windows.Forms.Button button4them;
        private System.Windows.Forms.Button buttonhienthi;
        private System.Windows.Forms.DataGridView dataGridView1gvien;
        private System.Windows.Forms.ComboBox comboBoxmalop;
        private System.Windows.Forms.TextBox textBoxupdate;
    }
}