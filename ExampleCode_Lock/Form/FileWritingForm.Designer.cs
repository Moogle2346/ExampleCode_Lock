
namespace ExampleCode_Lock
{
    partial class Form1
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
            this.txt_WriteText = new System.Windows.Forms.TextBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_WriteText
            // 
            this.txt_WriteText.Location = new System.Drawing.Point(12, 12);
            this.txt_WriteText.Multiline = true;
            this.txt_WriteText.Name = "txt_WriteText";
            this.txt_WriteText.Size = new System.Drawing.Size(299, 191);
            this.txt_WriteText.TabIndex = 0;
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(317, 42);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(110, 54);
            this.btn_Write.TabIndex = 1;
            this.btn_Write.Text = "書き込み";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 215);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.txt_WriteText);
            this.Name = "Form1";
            this.Text = "ファイル書き込み";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_WriteText;
        private System.Windows.Forms.Button btn_Write;
    }
}

