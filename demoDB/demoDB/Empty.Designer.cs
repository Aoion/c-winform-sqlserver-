namespace demoDB
{
    partial class Empty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.客房编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客房价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客房类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客房状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注信息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 38);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.客房编号,
            this.客房价格,
            this.客房类型,
            this.客房状态,
            this.备注信息});
            this.dataGridView1.Location = new System.Drawing.Point(1, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(799, 417);
            this.dataGridView1.TabIndex = 1;
            // 
            // 客房编号
            // 
            this.客房编号.HeaderText = "客房编号";
            this.客房编号.Name = "客房编号";
            // 
            // 客房价格
            // 
            this.客房价格.HeaderText = "客房类型";
            this.客房价格.Name = "客房价格";
            // 
            // 客房类型
            // 
            this.客房类型.HeaderText = "客房价格";
            this.客房类型.Name = "客房类型";
            // 
            // 客房状态
            // 
            this.客房状态.HeaderText = "客房状态";
            this.客房状态.Name = "客房状态";
            // 
            // 备注信息
            // 
            this.备注信息.HeaderText = "备注信息";
            this.备注信息.Name = "备注信息";
            // 
            // Empty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Empty";
            this.Text = "Empty";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客房编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客房价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客房类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客房状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注信息;
    }
}