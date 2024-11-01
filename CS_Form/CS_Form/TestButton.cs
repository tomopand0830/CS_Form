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
        public TestButton(int id, int x, int y, int width, int height )
        {
            //int i; 
              //  for(i  = 0; i < 10; i++)
            //{
                //ClickイベントにOnClick関数を登録
                //ボタンをクリックしたときに登録した関数を実行します
                Click += Onclick;
                ///ボタン内に文字を表示させる
              //  i = i.ToString(i);
                Text = id.ToString();
                // Console.WriteLine(i);

                Location = new Point(x, y);

                Size = new Size(width, height);
            //}
           
        }
       
        public  void Onclick(object sender,EventArgs s)
        {
            MessageBox.Show(Text);
        }

    }
}
