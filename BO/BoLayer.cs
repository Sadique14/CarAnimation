using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;

namespace BO
{
    public class BoLayer
    {
        DalLayer dl = new DalLayer();
        Car cd = new Car();
        public int x = 25;
        public int y= 19;
        public int x2 = 59;
        public int y2 = 0;
        public void set(Graphics g)
        {
            x = 12;
            y = 126;
            cd.carRight(g);
        }
        public char key = 'o';
        public int a = 21;
        public int b = 36;
        public int c = 21;
        public int d = 51;

        public int a1 = 93;
        public int b1 = 36;
        public int c1 = 93;
        public int d1 = 50;
        
        public bool saveSpeed(Car c)
        {
            return dl.save(Convert.ToString(c.speed));
        }
        public int speedCalculation()
        {
            Car c = dl.getData();
            if (c.speed == 10)
                return 1000;
            else if (c.speed == 20)
                return 650;
            else if (c.speed == 30)
                return 350;
            else if (c.speed == 40)
                return 250;
            else if (c.speed == 50)
                return 180;
            else if (c.speed == 60)
                return 100;
            else if (c.speed == 70)
                return 65;
            else if (c.speed == 80)
                return 40;
            else if (c.speed == 90)
                return 20;
            else if (c.speed == 100)
                return 1;
            else
                return 0;
        }

        public int getData()
        {
            Car c = dl.getData();
            int speed = c.speed;
            return speed;
        }
        int q = 1;
        int flag = 3;
        
        public bool checking(int x,int y)
        {
            if (x < 300 && x > 308)
            {
                return false;
            }
            else if (y > 110 && y < 134)
            {
                return false;
            }
            else
                return true;
        }
        public void changeAxes(char key,Graphics g, Graphics gr)
        {
         
            if (key == 'u' )
            {
                if ((x2 <= 23 && y2 <= 95) || (x2 + 52 >= 136 && x2 <= 476 && y2 <= 95) || (x2+52>=714 && y2<=95)||(x2<=616 && y<=268 && y>=234))
                {
                    cd.UpDownAlo(gr);
                }
                else
                {
                    y = y - 3;
                    y2 = y2 - 3;
                }
            }
            else if (key == 'd' )
            {
                if ((x2 + 52 < 572 && y2 + 111 <= 616 && y2 + 111 >= 233) || (y>267 && y+111>=247)/*||(x+52>=572 && x<= && y+111>=130)*/)
                {
                    cd.UpDownAlo(gr);
                }
                else
                {
                    y = y + 3;
                    y2 = y2 + 3;
                }
            }
            else if (key == 'l' )
            {
                if ((x < 454 && x > 136 && y <= 94) || (y <= 95 && x < 23 && x < 136)||(y<=249 && y+52>113 && x<598 && x>572))
                {
                    cd.leftRightAlo(g);
                }
                else
                {
                    x = x - 3;
                    x2 = x2 - 3;
                }
            }
            else if (key == 'r' )
            {
               if((y<=95 && x+118>=135 && x+118<476) || (y<=94 && x+118>=713) || (y>94 && x>620 && x+118>=798)||(y+52>=113 && y<267 && x+118<616 && x+118>=571))
                {
                    cd.leftRightAlo(g);
                }
                else
                {
                    x = x + 3;
                    x2 = x2 + 3;
                }
            }
           
        }
        public void rotateBackChaka()
        {
            a = a - 7 * q;
            b = b + 7 * q;
            c = c + 8 * q;
            d = d - 8 * q;
            q = q * -1;
        }
        int w = 1;
        public void rotateFrontChaka()
        {
            a1 = a1 - 7 * w;
            b1 = b1 + 7 * w;
            c1 = c1 + 8 * w;
            d1 = d1 - 8 * w;
            w = w * -1;
        }
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }
       
        public void controlCaka(char keyPress, Graphics g)
        {
            switch (keyPress)
            {
                case 'r':
                    Pen p = new Pen(Color.Black);
                    Pen p2 = new Pen(Color.Silver);
                    cd.rightFrontCaka(g, p2, a, b, c, d);
                    rotateBackChaka();
                    cd.rightFrontCaka(g, p, a, b, c, d);

                    
                    cd.leftBackCaka(g, p2, a1, b1, c1, d1);
                    rotateFrontChaka();
                    cd.leftBackCaka(g, p, a1, b1, c1, d1);
                    break;
                case 'l':
                    Pen p1 = new Pen(Color.Black);
                    Pen p3 = new Pen(Color.Silver);
                    cd.leftFrontCaka(g, p3, a, b, c, d);
                    rotateBackChaka();
                    cd.leftFrontCaka(g, p1, a, b, c, d);

                    
                    cd.leftBackCaka(g, p3, a1, b1, c1, d1);
                    rotateFrontChaka();
                    cd.leftBackCaka(g, p1, a1, b1, c1, d1);
                    break;
            }

        
        }
        public char calc(Graphics gr, Graphics g, char keyPress, int x, int y)
        {
            if(keyPress == 'u')
            {
          
                cd.carUp(gr);
                return 'u';
            }
            else if (keyPress == 'd')
            {
                
                cd.carDown(gr);
                return 'd';
            }
            else if (keyPress == 'l')
            {
                
                cd.carLeft(g);
                return 'l';
            }
            else if (keyPress == 'r')
            {
                
                cd.carRight(g);
                return 'r';
            }
            return 'o';
        }
    }
}