namespace baibaocao
{
    partial class khoa
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
            this.textBox1makhoa = new System.Windows.Forms.TextBox();
            this.textBox1tenkhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1hienthi = new System.Windows.Forms.Button();
            this.button2them = new System.Windows.Forms.Button();
            this.button3sua = new System.Windows.Forms.Button();
            this.dataGridView1k = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1upda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1k)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(229, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA CNTT- TRƯỜNG ĐẠI HỌC ĐIỆN LỰC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khoa";
            // 
            // textBox1makhoa
            // 
            this.textBox1makhoa.Location = new System.Drawing.Point(168, 97);
            this.textBox1makhoa.Name = "textBox1makhoa";
            this.textBox1makhoa.Size = new System.Drawing.Size(141, 20);
            this.textBox1makhoa.TabIndex = 2;
            // 
            // textBox1tenkhoa
            // 
            this.textBox1tenkhoa.Location = new System.Drawing.Point(549, 97);
            this.textBox1tenkhoa.Name = "textBox1tenkhoa";
            this.textBox1tenkhoa.Size = new System.Drawing.Size(124, 20);
            this.textBox1tenkhoa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(433, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khoa";
            // 
            // button1hienthi
            // 
            this.button1hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            this.button1hienthi.Location = new System.Drawing.Point(168, 176);
            this.button1hienthi.Name = "button1hienthi";
            this.button1hienthi.Size = new System.Drawing.Size(113, 27);
            this.button1hienthi.TabIndex = 5;
            this.button1hienthi.Text = "Hiển Thị";
            this.button1hienthi.UseVisualStyleBackColor = false;
            this.button1hienthi.Click += new System.EventHandler(this.button1hienthi_Click);
            // 
            // button2them
            // 
            this.button2them.ForeColor = System.Drawing.Color.Black;
            this.button2them.Location = new System.Drawing.Point(26, 38);
            this.button2them.Name = "button2them";
            this.button2them.Size = new System.Drawing.Size(75, 23);
            this.button2them.TabIndex = 6;
            this.button2them.Text = "Thêm";
            this.button2them.UseVisualStyleBackColor = true;
            this.button2them.Click += new System.EventHandler(this.button2them_Click);
            // 
            // button3sua
            // 
            this.button3sua.ForeColor = System.Drawing.Color.Black;
            this.button3sua.Location = new System.Drawing.Point(26, 97);
            this.button3sua.Name = "button3sua";
            this.button3sua.Size = new System.Drawing.Size(75, 23);
            this.button3sua.TabIndex = 7;
            this.button3sua.Text = "Sửa";
            this.button3sua.UseVisualStyleBackColor = true;
            this.button3sua.Click += new System.EventHandler(this.button3sua_Click);
            // 
            // dataGridView1k
            // 
            this.dataGridView1k.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1k.Location = new System.Drawing.Point(58, 220);
            this.dataGridView1k.Name = "dataGridView1k";
            this.dataGridView1k.ReadOnly = true;
            this.dataGridView1k.Size = new System.Drawing.Size(478, 160);
            this.dataGridView1k.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2them);
            this.groupBox1.Controls.Add(this.button3sua);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(557, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 161);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD";
            // 
            // textBox1upda
            // 
            this.textBox1upda.Location = new System.Drawing.Point(549, 180);
            this.textBox1upda.Name = "textBox1upda";
            this.textBox1upda.Size = new System.Drawing.Size(124, 20);
            this.textBox1upda.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(433, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Update";
            // 
            // khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(784, 440);
            this.Controls.Add(this.textBox1upda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1k);
            this.Controls.Add(this.button1hienthi);
            this.Controls.Add(this.textBox1tenkhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1makhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "khoa";
            this.Text = "khoa";
            this.Load += new System.EventHandler(this.khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1k)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1makhoa;
        private System.Windows.Forms.TextBox textBox1tenkhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1hienthi;
        private System.Windows.Forms.Button button2them;
        private System.Windows.Forms.Button button3sua;
        private System.Windows.Forms.DataGridView dataGridView1k;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1upda;
        private System.Windows.Forms.Label label4;
    }
}