﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CS_Form
{
    internal class TestLabel : Label
    {
        public TestLabel(string str, int x, int y, int width, int height)
        {
          
            Text = str;
          
            Location = new Point(x, y);

            Size = new Size(width, height);
            

        }

        
    }

    
}
