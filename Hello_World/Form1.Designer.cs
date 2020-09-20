namespace Hello_World
{
    partial class Form_Message
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Message = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Message
            // 
            this.button_Message.Location = new System.Drawing.Point(59, 99);
            this.button_Message.Name = "button_Message";
            this.button_Message.Size = new System.Drawing.Size(75, 23);
            this.button_Message.TabIndex = 0;
            this.button_Message.Text = "message";
            this.button_Message.UseVisualStyleBackColor = true;
            this.button_Message.Click += new System.EventHandler(this.button_Message_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(34, 37);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(100, 19);
            this.textBox_Message.TabIndex = 1;
            // 
            // Form_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 158);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.button_Message);
            this.Name = "Form_Message";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Message;
        private System.Windows.Forms.TextBox textBox_Message;
    }
}

