﻿using System;
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
               
                TestButton testButtoni = new TestButton(i,(i%3)*100,(i/3)*100,100, 100);

                  Controls.Add(testButtoni);
            }
        }
    }
}
