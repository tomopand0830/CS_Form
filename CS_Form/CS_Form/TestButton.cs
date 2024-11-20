using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_Form
{
    internal class TestButton : Button
    {
        Form1 _form1;
        public TestButton(Form1 form1,int id, int x, int y, int width, int height )
        {
            _form1 = form1;
            //int i; 
              //  for(i  = 0; i < 10; i++)
            //{
                //ClickイベントにOnClick関数を登録
                //ボタンをクリックしたときに登録した関数を実行します
                Click += Onclick;
            ///ボタン内に文字を表示させる
            //  i = i.ToString(i);
            string[] mozi = new string[10] {"あ","い", "う", "え", "お", "か", "き", "く","け", "こ"};
            Text = mozi[id];
       
                // Console.WriteLine(i);

                Location = new Point(x, y);

                Size = new Size(width, height);
            //}
           
        }
       
        public  void Onclick(object sender,EventArgs s)
        {
            string t = _form1.ReplacementButtonLabel(Text);

            Text = t;

            _form1.labelTextUpdate(Text);
        }


    }
}
