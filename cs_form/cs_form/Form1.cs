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
        public Form1()
        {
            InitializeComponent();
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(i, (i % 3) * 100, (i/3) * 100,100,100);
                Controls.Add(testButton);
            }

            TestLabel testLabel = new TestLabel("ラベルです。", 10,300,100,500);
            Controls.Add(testLabel);


        }
    }
}