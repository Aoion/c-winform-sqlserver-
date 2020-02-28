namespace demoDB
{
    partial class All
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.顾客编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顾客名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.其他信息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.顾客编号,
            this.顾客名字,
            this.性别,
            this.身份证号,
            this.地址,
            this.其他信息});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(698, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // 顾客编号
            // 
            this.顾客编号.HeaderText = "顾客编号";
            this.顾客编号.Name = "顾客编号";
            // 
            // 顾客名字
            // 
            this.顾客名字.HeaderText = "顾客名字";
            this.顾客名字.Name = "顾客名字";
            // 
            // 性别
            // 
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            // 
            // 身份证号
            // 
            this.身份证号.HeaderText = "身份证号";
            this.身份证号.Name = "身份证号";
            // 
            // 地址
            // 
            this.地址.HeaderText = "地址";
            this.地址.Name = "地址";
            // 
            // 其他信息
            // 
            this.其他信息.HeaderText = "其他信息";
            this.其他信息.MinimumWidth = 20;
            this.其他信息.Name = "其他信息";
            this.其他信息.Width = 150;
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "All";
            this.Text = "All";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顾客编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顾客名字;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 其他信息;
    }
}