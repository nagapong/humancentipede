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
        string strdata;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ふんばる_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(SaveFileDialog, false, Encoding.UTF8))

        }
    }
}
