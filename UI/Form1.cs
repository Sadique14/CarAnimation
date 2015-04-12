using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        BoLayer bl = new BoLayer();
        Car cd = new Car();
        Graphics g;
        Graphics gr;
        Char keyPress;
        int x;
        int y;
        public Form1()
        {
            InitializeComponent();
    
            g = carPanel.CreateGraphics();
            gr = carPanel2.CreateGraphics();
            int x = bl.x;
            int y = bl.y;
            keyPress = 'd';
            carPanel2.Show();
            cd.carDown(gr);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentInfoLabel.Text = Convert.ToString(bl.getData());
            g.Clear(Color.Silver);
            carPanel.Hide();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            info.Text = null;

            cd.carDown(gr);
            
            if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(currentInfoLabel.Text))
            {
                timer1.Interval = bl.speedCalculation();
                timer1.Start();
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void speedButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(speedBox.Text))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(speedBox.Text);
                if (bl.saveSpeed(c))
                {
                    info.Text = "Now, Press 'Start'";
                    currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                    info.Text = null;
                }

            }
            stopButton.Focus();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bl.changeAxes(keyPress,g,gr);
            carPanel.Location = new Point(bl.x, bl.y);
            carPanel2.Location = new Point(bl.x2, bl.y2);
            bl.controlCaka(keyPress, g);
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                carPanel.Hide();
                carPanel2.Show();
                keyPress = bl.calc(gr, g, keyPress, bl.x, bl.y);
                
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                carPanel.Hide();
                carPanel2.Show();
                keyPress = bl.calc(gr, g, keyPress, bl.x, bl.y);
               
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                carPanel2.Hide();
                carPanel.Show();
                keyPress = bl.calc(gr, g, keyPress, bl.x, bl.y);
              
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                carPanel2.Hide();
                carPanel.Show();
                keyPress = bl.calc(gr, g, keyPress, bl.x, bl.y);
             
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
