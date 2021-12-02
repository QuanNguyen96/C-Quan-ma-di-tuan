using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace quân_mã_đi_tuần_bản_chuẩn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw_chessboard();
        }
        private List<List<Button>> chessboard;
        private List<List<int>> nhan_chessboard;
        private int cot = 8;
        private void  draw_chessboard()
        {
            chessboard = new List<List<Button>>();
            nhan_chessboard = new List<List<int>>();
            Button btnn = new Button()
            {
                Width = 40,
                Height = 40,
                Location = new Point(60, 30),
                FlatStyle=FlatStyle.Flat,
            };
            for(int i=0;i<cot;i++)
            {
                chessboard.Add(new List<Button>());
                nhan_chessboard.Add(new List<int>());
                for (int j=0;j< cot; j++)
                {
                    Button btn = new Button()
                    {
                        Width = btnn.Width,
                        Height = btnn.Height,
                        Location = new Point(btnn.Location.X + btnn.Width * j, btnn.Location.Y + btnn.Height * i),
                        Tag = i,
                        FlatStyle = FlatStyle.Flat,
                    };
                    panel1.Controls.Add(btn);
                    chessboard[i].Add(btn);
                    nhan_chessboard[i].Add(0);
                    btn.Click += Btn_Click;
                }

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point p = location_button(btn);
            txt_vitrixuatphat.Text = "(" + p.X + "," + p.Y + ")";
        }

        private Point location_button(Button btn)
        {
            int location_X = Convert.ToInt32(btn.Tag);
            int location_Y = chessboard[location_X].IndexOf(btn);
            return new Point(location_X,location_Y);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private int speed = 10;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                speed = int.Parse(txt_speed.Text);
            }
            catch { speed = 10; }
        }
        private int start_locationX = 0;
        private int start_locationY = 0;
        private void btn_run_Click(object sender, EventArgs e)
        {
            try
            {
                string s = txt_vitrixuatphat.Text;
                string[] data = s.Split('.', ',', '(', ')', ' ');
                int dem = 0;
                for(int i=0;i<data.Count();i++)
                {
                    if(data[i]!="")
                    {
                        dem++;
                        if(dem==1)
                        {
                            start_locationX = int.Parse(data[i]);
                        }
                        if (dem == 2)
                        {
                            start_locationY = int.Parse(data[i]);
                        }
                    }
                }
                nhan_chessboard[start_locationX][start_locationY] = 1;   // vi xuat phat tai vi tri nay nen mac dinh nhan =1 ko duoc gan vao nua
                chessboard[start_locationX][start_locationY].Text = "1";
                Thread ts = new Thread(() => Try(start_locationX, start_locationY, 1));
                ts.Start();
                
            }
            catch { }
        }
        #region --- thuật toán đệ qui cho bài toán quân mã đi tuần ----

        private int[] X = new int[] { 2, 2, 1, -1, -2, -2, -1, 1 };
        private int[] Y = new int[] { 1, -1, -2, -2, -1, 1, 2, 2 };
        private void Try(int x,int y,int dem)
        {
            int xthe = 0;
            int ythe = 0;
            for(int i=0;i< 8; i++)
            {
                xthe = x + X[i];
                ythe = y + Y[i];
                if (xthe < cot && ythe < cot && xthe >= 0 && ythe >= 0)
                {
                    if (nhan_chessboard[xthe][ythe] == 0)
                    {
                        chessboard[xthe][ythe].Text = (dem+1).ToString();
                        nhan_chessboard[xthe][ythe] = 1;
                        Thread.Sleep(speed);
                        if (dem == cot*cot)
                        {
                            MessageBox.Show("ok");
                            chessboard[xthe][ythe].Text = "";
                            nhan_chessboard[xthe][ythe] = 0;
                            break;
                        }
                        else
                        {
                            Try(xthe, ythe, dem + 1);
                            chessboard[xthe][ythe].Text = "";
                            nhan_chessboard[xthe][ythe] = 0;
                            Thread.Sleep(speed);
                        }
                        
                    }
                }
            }
        }
        #endregion
    }
}
