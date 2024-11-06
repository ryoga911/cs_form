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
        public TestButton(int id, int x, int y, int width, int height)
        {
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
            MessageBox.Show(Text);
        }


    }
}
