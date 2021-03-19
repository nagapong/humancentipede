using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*とりあえずの予定としては、データを書き出す→データを読み込むを一つのフォームで完結
* 無限ループを目指す
             * アプリケーション名は「ムカデ人間」
             * csvから配列を作成し、その後csvに出力する
             * ※最終的には、一行目を無視するようにして、1行目に項目名が入っててもいいようにしたい。
             */

namespace ファイルを開いて何とかするやつ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /*

         */
        private void ふんばる_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "poop.csv";
            save.InitialDirectory = @"./";
            save.Title = "Go Toilet";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8))
                {
                    sw.Write(textBox1.Text);
                }
            }

        }

        private void ねる_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void たべる_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "csv";
            open.InitialDirectory = @"./";
            open.Title = "Have Some Food";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(open.FileName, Encoding.UTF8))
                {
                    textBox1.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
