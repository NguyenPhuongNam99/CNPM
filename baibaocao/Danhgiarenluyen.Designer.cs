namespace baibaocao
{
    partial class Danhgiarenluyen
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1mucdanhgia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1hienthi = new System.Windows.Forms.Button();
            this.button1sua = new System.Windows.Forms.Button();
            this.textBox1malop = new System.Windows.Forms.TextBox();
            this.masv = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Label();
            this.textBox1up = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(180, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐÁNH GIÁ RÈN LUYỆN SINH VIÊN KHOA CNTT-EPU\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(67, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(416, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Sinh Viên";
            // 
            // comboBox1mucdanhgia
            // 
            this.comboBox1mucdanhgia.FormattingEnabled = true;
            this.comboBox1mucdanhgia.Location = new System.Drawing.Point(174, 195);
            this.comboBox1mucdanhgia.Name = "comboBox1mucdanhgia";
            this.comboBox1mucdanhgia.Size = new System.Drawing.Size(196, 21);
            this.comboBox1mucdanhgia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(67, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mức Đánh Gía";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 179);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1hienthi
            // 
            this.button1hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            this.button1hienthi.Location = new System.Drawing.Point(251, 240);
            this.button1hienthi.Name = "button1hienthi";
            this.button1hienthi.Size = new System.Drawing.Size(75, 23);
            this.button1hienthi.TabIndex = 8;
            this.button1hienthi.Text = "Hiển Thị";
            this.button1hienthi.UseVisualStyleBackColor = false;
            this.button1hienthi.Click += new System.EventHandler(this.button1hienthi_Click);
            // 
            // button1sua
            // 
            this.button1sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            this.button1sua.Location = new System.Drawing.Point(374, 240);
            this.button1sua.Name = "button1sua";
            this.button1sua.Size = new System.Drawing.Size(75, 23);
            this.button1sua.TabIndex = 9;
            this.button1sua.Text = "Sửa";
            this.button1sua.UseVisualStyleBackColor = false;
            this.button1sua.Click += new System.EventHandler(this.button1sua_Click);
            // 
            // textBox1malop
            // 
            this.textBox1malop.Location = new System.Drawing.Point(168, 127);
            this.textBox1malop.Name = "textBox1malop";
            this.textBox1malop.Size = new System.Drawing.Size(201, 20);
            this.textBox1malop.TabIndex = 10;
            // 
            // masv
            // 
            this.masv.Location = new System.Drawing.Point(516, 127);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(201, 20);
            this.masv.TabIndex = 11;
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.LightGray;
            this.Update.Location = new System.Drawing.Point(416, 195);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(47, 15);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            // 
            // textBox1up
            // 
            this.textBox1up.Location = new System.Drawing.Point(515, 189);
            this.textBox1up.Name = "textBox1up";
            this.textBox1up.Size = new System.Drawing.Size(201, 20);
            this.textBox1up.TabIndex = 13;
            // 
            // Danhgiarenluyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(751, 476);
            this.Controls.Add(this.textBox1up);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.textBox1malop);
            this.Controls.Add(this.button1sua);
            this.Controls.Add(this.button1hienthi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1mucdanhgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Danhgiarenluyen";
            this.Text = "Danhgiarenluyen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1mucdanhgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1hienthi;
        private System.Windows.Forms.Button button1sua;
        private System.Windows.Forms.TextBox textBox1malop;
        private System.Windows.Forms.TextBox masv;
        private System.Windows.Forms.Label Update;
        private System.Windows.Forms.TextBox textBox1up;
    }
}