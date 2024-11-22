using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        TestTextBox _testBox;
        public Form1()
        {
            InitializeComponent();

            string[] strs =
            {
                "あか",
                "あお",
                "きいろ",
                "みどり",
                "くろ",
                "しろ",
                "ちゃいろ",
                "ピンク",
                "むらさき",
                "きみどり",

            };

            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this,  i, (i % 3) * 100, (i/3) * 100,100,100);
                Controls.Add(testButton);
            }

            _testLabel = new TestLabel("ラベルです。", 10,400,500,100);
            Controls.Add(_testLabel);


            _testBox = new TestTextBox("テキストボックスです", 10,500,500,100);
            Controls.Add(_testBox);


        }

        public void LabelTextUpdate(string str)
        {
            _testLabel.Text = str;
        }


    }

}
