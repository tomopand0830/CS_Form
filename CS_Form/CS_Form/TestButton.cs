using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_Form
{
    internal class TestButton : Button
    {
        public TestButton(int x, int y, int width, int height )
        { 
            
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += Onclick;
            ///ボタン内に文字を表示させる
            Text = "ボタン";
            Location = new Point(x, y);

            Size = new Size(width,height);
        }
       
        public  void Onclick(object sender,EventArgs s)
        {
            MessageBox.Show("👍");
        }

    }
}
