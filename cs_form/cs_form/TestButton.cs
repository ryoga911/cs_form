using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace cs_form
{

    internal class TestButton : Button
    {
        Form1  _form1;

        public TestButton(Form1 form1,  int id, int x, int y, int width, int height)
        {
            _form1 = form1;

            Click += Onclick;
            //ボタン内に文字を表示させる
            Text = id.ToString();


            //ボタンの生成場所を指定
            Location = new Point(x, y);

            //ボタンの大きさを指定
            Size = new Size(width, height);
        }
        public void Onclick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdate(Text);
        }


    }
}
