
namespace ファイルを開いて何とかするやつ
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.たべる = new System.Windows.Forms.Button();
            this.ふんばる = new System.Windows.Forms.Button();
            this.ねる = new System.Windows.Forms.Button();
            this.exhaust = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 160);
            this.textBox1.TabIndex = 0;
            // 
            // たべる
            // 
            this.たべる.Location = new System.Drawing.Point(156, 25);
            this.たべる.Name = "たべる";
            this.たべる.Size = new System.Drawing.Size(100, 23);
            this.たべる.TabIndex = 3;
            this.たべる.Text = "食べる";
            this.たべる.UseVisualStyleBackColor = true;
            this.たべる.Click += new System.EventHandler(this.たべる_Click);
            // 
            // ふんばる
            // 
            this.ふんばる.Location = new System.Drawing.Point(156, 64);
            this.ふんばる.Name = "ふんばる";
            this.ふんばる.Size = new System.Drawing.Size(100, 23);
            this.ふんばる.TabIndex = 3;
            this.ふんばる.Text = "ふんばる";
            this.ふんばる.UseVisualStyleBackColor = true;
            this.ふんばる.Click += new System.EventHandler(this.ふんばる_Click);
            // 
            // ねる
            // 
            this.ねる.AutoSize = true;
            this.ねる.Location = new System.Drawing.Point(156, 164);
            this.ねる.Name = "ねる";
            this.ねる.Size = new System.Drawing.Size(100, 23);
            this.ねる.TabIndex = 3;
            this.ねる.Text = "寝る";
            this.ねる.UseVisualStyleBackColor = true;
            this.ねる.Click += new System.EventHandler(this.ねる_Click);
            // 
            // exhaust
            // 
            this.exhaust.Title = "go toilet";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "eatit";
            this.openFileDialog1.Title = "have some food";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(274, 199);
            this.Controls.Add(this.ねる);
            this.Controls.Add(this.ふんばる);
            this.Controls.Add(this.たべる);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "humancentipede";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button たべる;
        private System.Windows.Forms.Button ふんばる;
        private System.Windows.Forms.Button ねる;
        private System.Windows.Forms.SaveFileDialog exhaust;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

