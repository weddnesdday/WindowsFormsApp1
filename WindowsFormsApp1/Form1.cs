using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            count++;

            int x = e.X;
            int y = e.Y;

            if (count % 2 == 0)
            {
                Button b = new Button();
                b.Parent = this;
                b.Left = x;
                b.Top = y;
                b.Text = "btn" + count;
            }
            else
            {
                TextBox tb = new TextBox();
                tb.Parent = this;
                tb.Left = x;
                tb.Top = y;
                tb.Text = "tb" + count;
            }
        }
    }
}  
