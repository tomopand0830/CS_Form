using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testlabel;

        TestTextBox _textBox;
        public Form1()

        {
            //int i;
            // for(i = 0; i < 10; i++)
            //{   
            //      InitializeComponent();
            //    TestButton testButtoni = new TestButton(i, 100, 50, 50);

            //  Controls.Add(testButtoni);

            //}
            int i;
           
            InitializeComponent();
            for (i = 0;i < 10; i++)
            {
               
                TestButton testButtoni = new TestButton(this,i,(i%5)*100,(i/5)*100,100, 100);
                
                  Controls.Add(testButtoni);
            }
          _testlabel = new TestLabel("ラベルです", 10, 300, 100, 500);
            Controls.Add(_testlabel);

            _textBox = new TestTextBox(Text, 150, 300, 500, 100);

            Controls.Add(_textBox);

            
            //Label label = new Label();
            ///label.Location = new Point(39,400);
            //label.Text = "ラベルです";

            //Controls.Add(label);
        }
        public void labelTextUpdate(string str)
        {
            _testlabel.TextUpdate(str); 
        }


        public string ReplacementButtonLabel(string str)
        {
           string s =  _textBox.TextReplacement(str);
            return s;
        }
        
    }
}
