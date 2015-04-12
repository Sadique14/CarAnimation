using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class Car
    {
        public int speed;

       
        

        public void carRight(Graphics g)
        {
            g.Clear(Color.Silver);
            Pen p = new Pen(Color.Red, 1);
            //nicher line
            g.DrawLine(p, 8, 44, 10, 44);
            g.DrawLine(p, 32, 44, 82, 44);
            g.DrawLine(p, 104, 44, 115, 44);
            g.DrawLine(p, 31, 40, 83, 40);
            //headlight
            g.DrawLine(p, 115, 44, 117, 44);
            g.DrawLine(p, 117, 44, 117, 38);
            g.DrawLine(p, 117, 38, 114, 38);
            g.DrawLine(p, 116, 38, 116, 44);
            g.DrawLine(p, 115, 38, 115, 44);
            //chakar uporer curve
            Point[] pd = { new Point(10,44), new Point(14, 36), new Point(21, 33), new Point(28, 36), new Point(32, 44)};
            g.DrawCurve(p, pd);
            Point[] ps = { new Point(82,44), new Point(86, 36), new Point(93, 33), new Point(100, 36), new Point(104, 44)};
            g.DrawCurve(p, ps);
            //2 paser line
            g.DrawLine(p, 8, 25, 8, 44);
            //g.DrawLine(p, 108, 25, 108, 44);
            g.DrawLine(p, 8, 25, 28, 20);
  
            //chad
            Point[] po = { new Point(28, 20), new Point(40, 12), new Point(58, 9), new Point(76, 12), new Point(94, 27) };
            g.DrawCurve(p, po);
            //samner curve
            Point[] pp = { new Point(94, 27), new Point(112, 32), new Point(115, 44) };
            g.DrawCurve(p, pp);
            //janala
            g.DrawLine(p, 56, 15, 56, 27);
            g.DrawLine(p, 35, 27, 56, 27);
            Point[] pon = { new Point(35, 27), new Point(43, 17), new Point(56, 15)};
            g.DrawCurve(p, pon);
            g.DrawLine(p, 60, 15, 60, 27);
            g.DrawLine(p, 60, 27, 81, 27);
            Point[] pong = { new Point(60, 15), new Point(73, 17), new Point(81, 27) };
            g.DrawCurve(p, pong);
            //pichoner part
            g.DrawRectangle(p, 4, 39, 4, 4);
            g.DrawRectangle(p, 0, 36, 8, 3);
            //chader alo
            g.DrawEllipse(p, 55, 1, 7, 7);
            g.DrawLine(p, 55, 3, 55, 8);
            g.DrawLine(p, 62, 3, 62, 8);

            p = new Pen(Color.Black, 1);
            g.DrawEllipse(p, 14, 36, 14, 14);
            g.DrawEllipse(p, 86, 36, 14, 14);
            g.FillEllipse(new SolidBrush(Color.Black), 18, 40, 6, 6);
            g.FillEllipse(new SolidBrush(Color.Black), 90, 40, 6, 6);
            
            
            
        }
        public void carLeft(Graphics g)
        {
            g.Clear(Color.Silver);
            Pen p = new Pen(Color.Red, 1);
            //nicher line
            g.DrawLine(p, 2, 44, 10, 44);
            g.DrawLine(p, 32, 44, 82, 44);
            g.DrawLine(p, 104, 44, 108, 44);
            g.DrawLine(p, 31, 40, 83, 40);
            //headlight
            g.DrawLine(p, 0, 44, 2, 44);
            g.DrawLine(p, 0, 44, 0, 38);
            g.DrawLine(p, 0, 38, 3, 38);
            g.DrawLine(p, 1, 38, 1, 44);
            g.DrawLine(p, 2, 38, 2, 44);
            //chakar uporer curve
            Point[] pd = { new Point(10, 44), new Point(14, 36), new Point(21, 33), new Point(28, 36), new Point(32, 44) };
            g.DrawCurve(p, pd);
            Point[] ps = { new Point(82, 44), new Point(86, 36), new Point(93, 33), new Point(100, 36), new Point(104, 44) };
            g.DrawCurve(p, ps);
            //2 paser line
            g.DrawLine(p, 108, 25, 108, 44);
            g.DrawLine(p, 108, 25, 88, 20);
            //chad
            Point[] po = { new Point(23, 27), new Point(40, 12), new Point(58, 9), new Point(76, 12), new Point(88, 20) };
            g.DrawCurve(p, po);
            //samner curve
            Point[] pp = { new Point(2, 44), new Point(5, 32), new Point(23, 27) };
            g.DrawCurve(p, pp);

            g.DrawLine(p, 56, 15, 56, 27);
            g.DrawLine(p, 35, 27, 56, 27);
            Point[] pon = { new Point(35, 27), new Point(43, 17), new Point(56, 15) };
            g.DrawCurve(p, pon);
            g.DrawLine(p, 60, 15, 60, 27);
            g.DrawLine(p, 60, 27, 81, 27);
            Point[] pong = { new Point(60, 15), new Point(73, 17), new Point(81, 27) };
            g.DrawCurve(p, pong);
            //pichoner part
            g.DrawRectangle(p, 108, 39, 4, 4);
            g.DrawRectangle(p, 108, 36, 9, 3);
            //chader alo
            g.DrawEllipse(p, 55, 1, 7, 7);
            g.DrawLine(p, 55, 3, 55, 8);
            g.DrawLine(p, 62, 3, 62, 8);

            p = new Pen(Color.Black, 1);
            g.DrawEllipse(p, 14, 36, 14, 14);
            g.DrawEllipse(p, 86, 36, 14, 14);
            g.FillEllipse(new SolidBrush(Color.Black), 18, 40, 6, 6);
            g.FillEllipse(new SolidBrush(Color.Black), 90, 40, 6, 6);
        }
        public void carUp(Graphics g)
        {
            g.Clear(Color.Silver);
            Pen p = new Pen(Color.Red, 1);

            g.DrawLine(p, 1, 12, 1, 100);
            g.DrawLine(p, 50, 12, 50, 100);
            Point[] pp = { new Point(1,12),new Point(11, 4), new Point(30, 2), new Point(42, 5), new Point(50, 12) };
            g.DrawCurve(p, pp);
            Point[] pd = { new Point(1, 100), new Point(15, 102), new Point(35, 102), new Point(50, 100) };
            g.DrawCurve(p,pd);

            //samner kach
            Point[] sc = { new Point(1, 30), new Point(26, 27), new Point(50, 30) };
            g.DrawCurve(p, sc);
            //up
            Point[] pul = { new Point(8, 29), new Point(11, 41), new Point(14, 53), new Point(12, 68) };
            g.DrawCurve(p,pul);
            Point[] pur = { new Point(43, 29), new Point(40, 41), new Point(37, 53), new Point(39, 68) };
            g.DrawCurve(p, pur);
            
            //g.DrawRectangle(p, 3, 68, 45, 15);
            g.DrawLine(p, 14, 53, 1, 53);
            g.DrawLine(p, 37, 53, 50, 53);
            g.DrawLine(p, 10, 83, 15, 102);
            g.DrawLine(p, 40, 83, 35, 102);
            Point[] pdo = { new Point(11,41), new Point(26, 38), new Point(40, 41) };
            g.DrawCurve(p,pdo);
            Point[] pdn = { new Point(1, 80), new Point(10, 83), new Point(40, 83),new Point(50,80) };
            g.DrawCurve(p, pdn);
            g.DrawLine(p, 1, 80, 12, 68);
            g.DrawLine(p, 50, 80, 39, 68);
            g.DrawLine(p, 12, 68, 39, 68);
            //headlight
            g.FillRectangle(new SolidBrush(Color.Red), 11, 4, 7, 4);
            g.FillRectangle(new SolidBrush(Color.Red), 35, 4, 7, 4);
            //chader alo
            g.DrawEllipse(p, 23, 53, 7, 7);
        }

        public void carDown(Graphics g)
        {
            g.Clear(Color.Silver);
            Pen p = new Pen(Color.Red, 1);

            g.DrawLine(p, 1, 12, 1, 100);
            g.DrawLine(p, 50, 12, 50, 100);
            Point[] pp = { new Point(1, 100), new Point(11, 108), new Point(30, 110), new Point(42, 107), new Point(50, 100) };
            g.DrawCurve(p, pp);
            Point[] pd = { new Point(1, 12), new Point(15, 10), new Point(35, 10), new Point(50, 12) };
            g.DrawCurve(p, pd);

            //samner kach
            Point[] sc = { new Point(1, 82), new Point(26, 85), new Point(50, 82) };
            g.DrawCurve(p, sc);

            //up
            Point[] pul = { new Point(8, 83), new Point(11, 71), new Point(14, 59), new Point(12, 44) };
            g.DrawCurve(p, pul);
            Point[] pur = { new Point(43, 83), new Point(40, 71), new Point(37, 59), new Point(39, 44) };
            g.DrawCurve(p, pur);

            g.DrawLine(p, 14, 59, 1, 59);
            g.DrawLine(p, 37, 59, 50, 59);
            g.DrawLine(p, 10, 29, 15, 10);
            g.DrawLine(p, 40, 29, 35, 10);

            Point[] pdo = { new Point(11, 71), new Point(26, 74), new Point(40, 71) };
            g.DrawCurve(p, pdo);
            Point[] pdn = { new Point(1, 32), new Point(10, 29), new Point(40, 29), new Point(50, 32) };
            g.DrawCurve(p, pdn);

            g.DrawLine(p, 1, 32, 12, 44);
            g.DrawLine(p, 50, 32, 39, 44);
            g.DrawLine(p, 12, 44, 39, 44);

            //headlight
            g.FillRectangle(new SolidBrush(Color.Red), 11, 105, 7, 4);
            g.FillRectangle(new SolidBrush(Color.Red), 35, 105, 7, 4);
            //chader alo
            g.DrawEllipse(p, 23, 53, 7, 7);

        }
        int flag = 1;
        public void leftRightAlo(Graphics g)
        {   
            if (flag == 1)
            {
                SolidBrush b = new SolidBrush(Color.Red);
                g.FillEllipse(b, 55, 1, 7, 7);
                flag = flag * (-1);
            }
            else
            {
                SolidBrush b = new SolidBrush(Color.Yellow);
                g.FillEllipse(b, 55, 1, 7, 7);
                flag = flag * (-1);
            }
        }
        int flag2 = 1;
        public void UpDownAlo(Graphics g)
        {
            if (flag2 == 1)
            {
                SolidBrush b = new SolidBrush(Color.Red);
                g.FillEllipse(b, 23, 53, 7, 7);
                flag2 = flag2 * (-1);
            }
            else
            {
                SolidBrush b = new SolidBrush(Color.Yellow);
                g.FillEllipse(b, 23, 53, 7, 7);
                flag2 = flag2 * (-1);
            }
        }

        public void rightFrontCaka(Graphics g, Pen p, int a, int b, int c, int d)
        {
           
            g.DrawLine(p, a, b, c, d);
           
        }
        public void rightBackCaka(Graphics g,Pen p, int a, int b, int c, int d)
        {
            
            g.DrawLine(p, a, b, c, d);
            
        }
        public void leftFrontCaka(Graphics g, Pen p, int a, int b, int c, int d)
        {

            g.DrawLine(p, a, b, c, d);

        }
        public void leftBackCaka(Graphics g, Pen p, int a, int b, int c, int d)
        {

            g.DrawLine(p, a, b, c, d);

        }
    }
   
}
