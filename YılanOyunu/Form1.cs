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

namespace YılanOyunu
{
	public partial class Form1 : Form
	{
		public enum Direction
		{
			Up,
			Down,
			Left,
			Right
		}
		public int x = 1, y = 1;
		public Direction dr = Direction.Right;
		public location feed = new location(-1,-1);
		public List<location> tales = new List<location>();
		public bool Game = true;
		public Form1()
		{
			InitializeComponent();
			tales.Add(new YılanOyunu.location(0, 0));
			CalcTable();

			Thread thread = new Thread(new ThreadStart(new Action(() =>
			{
				while (Game)
				{
					if (dr == Direction.Right)
					{
						x++;
					}
					if (dr == Direction.Down)
					{
						y++;
					}
					if (dr == Direction.Up)
					{
						y--;
					}
					if (dr == Direction.Left)
					{
						x--;
					}
					//x++;
					CalcTable();
					Thread.Sleep(131);
				}

			})));
			thread.Start();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.ToString() == "S")
			{
				dr = Direction.Down;
			}
			else if (e.KeyCode.ToString() == "W")
			{
				dr = Direction.Up;
			}
			else if (e.KeyCode.ToString() == "D")
			{
				dr = Direction.Right;
			}
			else if (e.KeyCode.ToString() == "A")
			{
				dr = Direction.Left;
			}
			
		}

		public void CalcTable()
		{
			Random rnd = new Random();
			Bitmap bitmap = new Bitmap(500, 500);


			
            //tales coll
            if (tales.Count != 1)
            {
				for (int i = 1; i < tales.Count; i++)
				{
					if (tales[i].x == x && tales[i].y == y)
					{
			            Game = false;
						MessageBox.Show("Kaybettin!");
					}
				}
			}
			
            //feed coll
            if (x == feed.x && y == feed.y)
            {

				tales.Add(new YılanOyunu.location(feed.x, feed.y));
				feed = new location(-1, -1);
            }
			//outside coll
			/*if (x == 0 || y == 0 || x == 66 || y == 66)
            {
				Game = false;
				MessageBox.Show("Çıktın");
            }
            else
            {
				//SNAKE
				for (int i = (x - 1) * 10; i < x * 10; i++)
				{
					for (int j = (y - 1) * 10; j < y * 10; j++)
					{
						bitmap.SetPixel(i, j, Color.Black);
					}
				}
			}*/

			
			//SNAKE
			for (int i = (x - 1) * 10; i < x * 10; i++)
			{
				for (int j = (y - 1) * 10; j < y * 10; j++)
				{
					bitmap.SetPixel(i, j, Color.Black);
				}
			}

			tales[0] = new location(x, y);
            for (int i = tales.Count-1; i > 0; i--)
            {
				tales[i] = tales[i - 1];
            }
            if (tales.Count != 1)
            {
                for (int k = 0; k < tales.Count; k++)
                {
                    for (int i = (tales[k].x - 1)*10; i < tales[k].x*10; i++)
                    {
                        for (int j = (tales[k].y-1)*10; j < tales[k].y*10; j++)
                        {
							bitmap.SetPixel(i, j, Color.Black);
                        }
                    }
                }
            }

            if (feed.x == -1)
            {
				
				feed = new location(rnd.Next(0, 50), rnd.Next(0, 50));
            }

			for (int i = (feed.x - 1) * 10; i < feed.x * 10; i++)
			{
				for (int j = (feed.y - 1) * 10; j < feed.y * 10; j++)
				{
					bitmap.SetPixel(i, j, Color.Red);
				}
			}
    
			game.Image = bitmap;
		}


	}
	public class location
	{
		public int x, y;
		public location(int x,int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}
