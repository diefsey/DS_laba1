using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x, y;
            bool Q;
            x = double.Parse(textBox_x.Text);
            y = double.Parse(textBox_y.Text);

            Q = (y * y + x * x <= 4 && x >= 0 && y >= 0 && Math.Abs(x) <= Math.Abs(y)) ||
                (y * y + x * x <= 4 && x >= 0 && y <= 0 && Math.Abs(x) >= Math.Abs(y)) ||
                (y * y + x * x <= 4 && x <= 0 && y <= 0 && Math.Abs(x) <= Math.Abs(y)) ||
                (y * y + x * x <= 4 && x <= 0 && y >= 0 && Math.Abs(x) >= Math.Abs(y));

            if (Q == true)
            {
                textBox_rez.Text = "Точка входит в выделеную область.";
            }
            else
            {
                textBox_rez.Text = "Точка не входит в выделеную область";
            }
        }


        
    }
}
    
    
