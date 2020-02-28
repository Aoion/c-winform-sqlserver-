namespace demoDB
{
    partial class SuccessDelete
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
            this.办理退房成功 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 办理退房成功
            // 
            this.办理退房成功.Font = new System.Drawing.Font("宋体", 14F);
            this.办理退房成功.Location = new System.Drawing.Point(1, 1);
            this.办理退房成功.Name = "办理退房成功";
            this.办理退房成功.Size = new System.Drawing.Size(342, 214);
            this.办理退房成功.TabIndex = 0;
            this.办理退房成功.Text = "办理退房成功";
            this.办理退房成功.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuccessDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.办理退房成功);
            this.Name = "SuccessDelete";
            this.Text = "SuccessDelete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 办理退房成功;
        private System.Windows.Forms.Button button1;
    }
}