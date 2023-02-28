using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        Graphics g;
        Tree[] t = new Tree[500];

        Param[] p = new Param[2];
        ParamOneYearTree p1 = new ParamOneYearTree();
        ParamTwoYearTree p2 = new ParamTwoYearTree();
        
        int count = 0;
        Random r = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (r.Next(0, 10) % 2 == 0)
                t[count] = new Tree(r.Next(10, 1500), r.Next(10, 1500), p1);
            else
                t[count] = new Tree(r.Next(10, 1500), r.Next(10, 1500), p2);

            g.DrawImage(t[count].p.pic, new Rectangle(t[count].x, t[count].y, t[count].p.h, 20));
            if (count < 499)
                count++;
            else
                timer2.Stop();
        }
    }
}