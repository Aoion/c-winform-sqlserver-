namespace demoDB
{
    partial class HStatus
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
            this.房间名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 35);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房间名,
            this.房间价格,
            this.房间类型,
            this.房间状态,
            this.备注});
            this.dataGridView1.Location = new System.Drawing.Point(4, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(945, 573);
            this.dataGridView1.TabIndex = 1;
            // 
            // 房间名
            // 
            this.房间名.HeaderText = "房间编号";
            this.房间名.Name = "房间名";
            this.房间名.Width = 150;
            // 
            // 房间价格
            // 
            this.房间价格.HeaderText = "房间类型";
            this.房间价格.Name = "房间价格";
            this.房间价格.Width = 150;
            // 
            // 房间类型
            // 
            this.房间类型.HeaderText = "房间价格";
            this.房间类型.Name = "房间类型";
            this.房间类型.Width = 150;
            // 
            // 房间状态
            // 
            this.房间状态.HeaderText = "房间状态";
            this.房间状态.Name = "房间状态";
            this.房间状态.Width = 150;
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 599);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "HStatus";
            this.Text = "HStatus";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}