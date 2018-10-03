using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brick_Buster
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        Label[] bricks = new Label[25];
        PictureBox ball = new PictureBox();
        PictureBox[] littleball;
        Label[] gifts = new Label[6];
        int[] list = new int[6];
        int[] time = new int[] { 0, 0, 0 };
        int mdx, Vx, Vy, change;
        bool bl = true, fin = false;
        int blx = 1, bly = 1, num = 25;
        bool bonusbutton = false;
        public Form1()
        {
            InitializeComponent();
        }

        private Label Brick(int x,int y)
        {
            Label lb = new Label();
            lb.Width = 100;
            lb.Height = 50;
            lb.BackColor = Color.DarkRed;
            lb.BorderStyle = BorderStyle.FixedSingle;
            lb.Left = x;
            lb.Top = y;
            return lb;
        }

        private PictureBox LittleBall(int x,int y)
        {
            PictureBox pb = new PictureBox();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            pb.Width = 10;
            pb.Height = 10;
            pb.Left = x;
            pb.Top = y;
            pb.BackColor = Color.LightBlue;
            gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1);
            Region rg = new Region(gp);
            pb.Region = rg;
            return pb;
        }

        private void reset()
        {
            for (int i = 0; i < 25; i++)
                bricks[i].Dispose();
            bonusbutton = false;
        }

        private void restart()
        {
            blx = 1;
            bly = 1;
            num = 25;
            button3.Enabled = true;
            //brick
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bricks[index] = Brick(i * 100, j * 50);
                    Controls.Add(bricks[index]);
                    index++;
                }
            }
            //ball
            ball.Image = Image.FromFile("ball.png");
            ball.SizeMode = PictureBoxSizeMode.AutoSize;
            ball.Left = (Bounds.Width - ball.Width) / 2;
            ball.Top = 450;
            Controls.Add(ball);
            //
            timer1.Enabled = false;
            //把picturebox變圓形
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(ball.ClientRectangle);
            Region reg = new Region(path);
            ball.Region = reg;
            //board
            board.Left = (Bounds.Width - board.Width) / 2;
            board.Top = ball.Top + ball.Height;
            if (!bl)
            {
                MessageBox.Show("Game over!");
                bl = true;
            }
            if (fin)
            {
                MessageBox.Show("Win!");
                fin = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            restart();  
        }

        private void button1_Click(object sender, EventArgs e)//start
        {
            for (int i = 0; i < 6; i++)
            {
                gifts[i] = gift(i, list);
                gifts[i].Enabled = false;
                gifts[i].Visible = false;
            }
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
            {
                timer1.Enabled = true;
                button3.Enabled = false;//不能切換Bonus狀態
            }
            if (radioButton4.Checked)//bonus1
            {
                change = 1; 
                littleball = new PictureBox[10];
                //設定哪些brick被撞到後會掉東西
                list[0] = rnd.Next(25);
                for (int i = 1; i < 6; i++)
                {
                    list[i] = rnd.Next(25);
                    for (int j = 0; j < i; j++)
                    {
                        if (list[i] == list[j])
                        {
                            i--;
                            break;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//restart
        {
            reset();
            restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!bonusbutton)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                bonusbutton = true;
            }
            else
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;
                bonusbutton = false;
            }
        }//bonus

        private Label gift(int i, int[] array)
        {
            if (i == 0 || i == 1)//long
            {
                Label gift1 = new Label();
                gift1.Location = new Point(bricks[array[i]].Bottom + 1, bricks[array[i]].Left + bricks[array[i]].Width / 2);
                gift1.Size = new Size(50, 15);
                gift1.BackColor = Color.YellowGreen;
                Controls.Add(gift1);
                return gift1;
            }
            else if (i == 2 || i == 3)//many ball
            {
                Label gift2 = new Label();
                gift2.Location = new Point(bricks[array[i]].Bottom + 1, bricks[array[i]].Left + bricks[array[i]].Width / 2);
                gift2.BackColor = Color.AliceBlue;
                gift2.Size = new Size(25, 25);
                Controls.Add(gift2);
                return gift2;
            }
            else// if (i == 4 || i == 5) //speed
            {
                Label gift3 = new Label();
                gift3.Location = new Point(bricks[array[i]].Bottom + 1, bricks[array[i]].Left + bricks[array[i]].Width / 2);
                gift3.BackColor = Color.LightPink;
                gift3.Size = new Size(20, 40);
                Controls.Add(gift3);
                return gift3;
            }
        }//create gifts

        private void timer1_Tick(object sender, EventArgs e)
        {
            //move the ball
            if (radioButton1.Checked)
            {
                if (blx == 1)
                    Vx = 2;
                else
                    Vx = -2;
                if (bly == 1)
                    Vy = 2;
                else
                    Vy = -2;
            }
            else if (radioButton2.Checked || radioButton4.Checked || change == 2)
            {
                if (blx == 1)
                    Vx = 8;
                else
                    Vx = -8;
                if (bly == 1)
                    Vy = 8;
                else
                    Vy = -8;
            }
            else if (radioButton3.Checked)
            {
                if (blx == 1)
                    Vx = 15;
                else
                    Vx = -15;
                if (bly == 1)
                    Vy = 15;
                else
                    Vy = -15;
            }
            else if (change == 1)
            {
                if (blx == 1)
                    Vx = 20;
                else
                    Vx = -20;
                if (bly == 1)
                    Vy = 20;
                else
                    Vy = -20;
            }
            else if (change == 3)
            {
                if (blx == 1)
                    Vx = 1;
                else
                    Vx = -1;
                if (bly == 1)
                    Vy = 1;
                else
                    Vy = -1;
            }
            if (ball.Top > board.Top + board.Height)//低於球拍
            {
                bl = false;
                reset();
                restart();
            }                
            else
            {
                if (ball.Left < 0)//左邊的牆
                {
                    Vx = Math.Abs(Vx);
                    blx = blx * (-1);
                }
                if (ball.Right > ClientSize.Width)//右邊的牆
                {
                    Vx = -Math.Abs(Vx);
                    blx = blx * (-1);
                }
                if (ball.Top < 0)//上面的牆
                {
                    Vy = -Math.Abs(Vy);
                    bly = bly * (-1);
                }
                if ((ball.Bottom > board.Top) && ((ball.Top + ball.Height / 2) <= board.Top) && ((ball.Left + ball.Width / 2) >= board.Left && (ball.Left + ball.Width / 2) <= board.Right))//打到球拍
                {
                    Vy = Math.Abs(Vy);
                    bly = bly * (-1);
                }
                for (int i = 0; i < bricks.Length; i++)
                {
                    if (!bricks[i].IsDisposed)
                    {
                        //打到磚塊底部
                        if (Vy > 0 && ball.Top < bricks[i].Bottom && (bricks[i].Bottom - ball.Top) <= bricks[i].Height / 2 && ball.Left >= bricks[i].Left && ball.Right <= bricks[i].Right)
                        {
                            Vy = -Math.Abs(Vy);
                            bly = bly * (-1);
                            for (int j = 0; j < 6; j++)
                                if (i == list[j])
                                {
                                    gifts[j].Enabled = true;
                                    gifts[j].Visible = true;
                                }   
                            bricks[i].Dispose();
                            num--;
                            continue;
                        }
                        //打到磚塊右邊
                        if (Vx < 0 && ball.Left < bricks[i].Right && (bricks[i].Right - ball.Left) <= bricks[i].Width && ball.Top >= bricks[i].Top && ball.Bottom <= bricks[i].Bottom)
                        {
                            Vx = Math.Abs(Vx);
                            blx = blx * (-1);
                            for (int j = 0; j < 6; j++)
                                if (i == list[j])
                                {
                                    gifts[j].Enabled = true;
                                    gifts[j].Visible = true;
                                }
                            bricks[i].Dispose();
                            num--;
                            continue;
                        }
                        //打到磚塊左邊
                        if (Vx > 0 && ball.Right > bricks[i].Left && (ball.Right - bricks[i].Left) <= bricks[i].Width && ball.Top >= bricks[i].Top && ball.Bottom <= bricks[i].Bottom)
                        {
                            Vx = -Math.Abs(Vx);
                            blx = blx * (-1);
                            for (int j = 0; j < 6; j++)
                                if (i == list[j])
                                {
                                    gifts[j].Enabled = true;
                                    gifts[j].Visible = true;
                                }
                            bricks[i].Dispose();
                            num--;
                            continue;
                        }
                        //打到磚塊頂端
                        if (Vy < 0 && ball.Bottom > bricks[i].Top && (ball.Bottom - bricks[i].Top) <= bricks[i].Height / 2 && ball.Left >= bricks[i].Left && ball.Right <= bricks[i].Right)
                        {
                            Vy = Math.Abs(Vy);
                            bly = bly * (-1);
                            for (int j = 0; j < 6; j++)
                                if (i == list[j])
                                {
                                    gifts[j].Enabled = true;
                                    gifts[j].Visible = true;
                                }
                            bricks[i].Dispose();
                            num--;
                            continue;
                        }
                    }
                    if (num <= 0)
                    {
                        fin = true;
                        break;
                    }
                }
                ball.Location = new Point(ball.Location.X + Vx, ball.Location.Y - Vy);
                for (int j = 0; j < 6; j++)
                {
                    if (gifts[j].Enabled && !gifts[j].IsDisposed && gifts[j].Visible)
                    {
                        gifts[j].Location = new Point(gifts[j].Location.X, gifts[j].Location.Y + 2);
                        if (gifts[j].Bottom > board.Top && (gifts[j].Right - board.Left) < (gifts[j].Width + board.Width))
                        {
                            if (j == 0 || j == 1)
                            {
                                board.Width = ClientSize.Width - 10;
                                if (time[0] != 0)
                                    time[0] = 0;
                                else
                                    time[0]++;
                            }
                            else if (j == 2 || j == 3)
                            {
                                int index = 0;
                                for (int k = 0; k < 10; k++)
                                {
                                    int x = rnd.Next(5, ClientSize.Width - 5);
                                    int y = rnd.Next(280, board.Top - 5);
                                    littleball[index] = LittleBall(x, y);
                                    Controls.Add(littleball[index]);
                                    index++;
                                }
                                if (time[1] != 0)
                                    time[1] = 0;
                                else
                                    time[1]++;
                            }
                            else
                            {
                                if (time[2] != 0)
                                    time[2] = 0;
                                else
                                    time[2]++;
                                if (time[2] <= 110)
                                    change = 1;
                                else if (time[2] > 110 && time[2] <= 220)
                                    change = 2;
                                else if (time[2] > 220 && time[2] <= 330)
                                    change = 3;
                                else
                                    gifts[j].Dispose();
                            }
                            gifts[j].Visible = false;
                        }
                    } 
                }
                for(int i = 0; i < 3; i++)
                {
                    if (time[i] != 0)
                    {
                        time[i]++;
                        if (time[i] == 330)
                        {
                            if (gifts[i * 2].Visible == false)
                                gifts[i * 2].Dispose();
                            if (gifts[i * 2 + 1].Visible == false)
                                gifts[i * 2 + 1].Dispose();
                            if (i == 0)
                                board.Width = 95;
                            else if (i == 1)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (!littleball[j].IsDisposed)
                                        littleball[j].Dispose();
                                }
                            }
                            else if (i == 2)
                            {
                                if (blx == 1)
                                    Vx = 8;
                                else
                                    Vx = -8;
                                if (bly == 1)
                                    Vy = 8;
                                else
                                    Vy = -8;
                            }
                        }
                    } 
                }
                /////ball.Location = new Point(ball.Location.X + Vx, ball.Location.Y - Vy);
            }
            if (fin)
            {
                reset();
                restart();
            }
        }   

        private void board_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;//拖曳起點
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = board.Left + (e.X - mdx);//計算拖曳位置
                    if (x < 0)
                        x = 0;//左邊界
                    if (x > ClientSize.Width - board.Width)
                        x = ClientSize.Width - board.Width;//右邊界
                    board.Left = x;//球拍位置(不超出邊界)
                }
            }
        }
    }
}