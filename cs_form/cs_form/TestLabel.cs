﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_form
{
    internal class TestLabel : Label
    {
        

        
            public TestLabel(string str, int x, int y, int width, int height)
            {
                
                //ボタン内に文字を表示させる
                Text = str;


                //ボタンの生成場所を指定
                Location = new Point(x, y);

                //ボタンの大きさを指定
                Size = new Size(width, height);
            }
            public void Onclick(object sender, EventArgs s)
            {
                MessageBox.Show(Text);
            }

        public void TextUpdate(string str)
        {
            Text = str;
        }



        }
    }


