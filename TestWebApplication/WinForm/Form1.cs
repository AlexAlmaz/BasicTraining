using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var module = (int)this.nudModule.Value;

            var resultModel = Calculate(module);

            Draw(resultModel);
        }

        private ResultModel Calculate(int module)
        {
            var result = new ResultModel();

            result.d1 = 2;
            //Calculation
            return result;
        }

        private void Draw(ResultModel resultModel)
        {
            var center_x = pictureBox1.Width / 2;
            var center_y = pictureBox1.Height / 2;

            var r = 50;

            //SolidBrush iconBrush = new SolidBrush(Color.Green);
            var pen = new Pen(Color.Red);

            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            graphics.DrawEllipse(pen, new Rectangle(center_x - r, center_y - r, center_x + r, center_y + r));
        }
    }
}
