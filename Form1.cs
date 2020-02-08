using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suduko2
{
    public partial class Form1 : Form
    {
        static int[,] a = new int[9, 9];

        public static int rowcol(int i, int j, int k, int[,] a)
        {
            for (int m = 0; m < 9; m++)
            {
                if (a[i,m] == k)
                {
                    return 1;
                }
            }
            for (int m = 0; m < 9; m++)
            {
                if (a[m,j] == k)
                {
                    return 1;
                }
            }
            return 0;
        }
        public static int block(int i, int j, int k, int[,] a)
        {
            i = i - i % 3;
            j = j - j % 3;
            for (int l = i; l < i + 3; l++)
            {
                for (int m = j; m < j + 3; m++)
                {
                    if (a[l,m] == k)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        public static int suduko(int[,] a)
        {
            bool empty = true;
            int i = 0, j = 0;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (a[i,j] == 0)
                    {
                        empty = false;
                        break;
                    }

                }
                if (empty == false)
                {
                    break;
                }
            }
            if (empty == true)
            {
                return 0;
            }
            for (int k = 1; k <= 9; k++)
            {
                int z = rowcol(i, j, k, a);
                int z1 = block(i, j, k, a);
                if (z == 0 && z1 == 0)
                {
                    a[i,j] = k;
                    int p1 = suduko(a);
                    if (p1 == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        a[i,j] = 0;
                    }
                }
            }
            return 1;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != null)
            {
                int i;
                i = int.Parse(textBox9.Text);
                a[0, 8] = i;
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != null)
            {
                int i;
                i = int.Parse(textBox18.Text);
                a[1, 8] = i;
            }
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            if (textBox66.Text != null)
            {
                int i;
                i = int.Parse(textBox66.Text);
                a[6, 2] = i;
            }
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            if (textBox77.Text != null)
            {
                int i;
                i = int.Parse(textBox77.Text);
                a[7, 4] = i;
            }
        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            if (textBox81.Text != null)
            {
                int i;
                i = int.Parse(textBox81.Text);
                a[8, 8] = i;
            }
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            if (textBox50.Text != null)
            {
                int i;
                i = int.Parse(textBox50.Text);
                a[5, 4] = i;
            }
        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {
            if (textBox80.Text != null)
            {
                int i;
                i = int.Parse(textBox80.Text);
                a[8, 7] = i;
            }
        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            if (textBox79.Text != null)
            {
                int i;
                i = int.Parse(textBox79.Text);
                a[8, 6] = i;
            }
        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            if (textBox78.Text != null)
            {
                int i;
                i = int.Parse(textBox78.Text);
                a[8, 5] = i;
            }
        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            if (textBox76.Text != null)
            {
                int i;
                i = int.Parse(textBox76.Text);
                a[8, 3] = i;
            }
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            if (textBox75.Text != null)
            {
                int i;
                i = int.Parse(textBox75.Text);
                a[8, 2] = i;
            }
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            if (textBox74.Text != null)
            {
                int i;
                i = int.Parse(textBox74.Text);
                a[8, 1] = i;
            }
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            if (textBox73.Text != null)
            {
                int i;
                i = int.Parse(textBox73.Text);
                a[8, 0] = i;
            }
        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            if (textBox72.Text != null)
            {
                int i;
                i = int.Parse(textBox72.Text);
                a[7, 8] = i;
            }
        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            if (textBox71.Text != null)
            {
                int i;
                i = int.Parse(textBox71.Text);
                a[7, 7] = i;
            }
        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            if (textBox70.Text != null)
            {
                int i;
                i = int.Parse(textBox70.Text);
                a[7, 6] = i;
            }
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            if (textBox69.Text != null)
            {
                int i;
                i = int.Parse(textBox69.Text);
                a[7, 5] = i;
            }
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            if (textBox68.Text != null)
            {
                int i;
                i = int.Parse(textBox68.Text);
                a[7, 4] = i;
            }
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            if (textBox67.Text != null)
            {
                int i;
                i = int.Parse(textBox67.Text);
                a[7, 3] = i;
            }
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            if (textBox65.Text != null)
            {
                int i;
                i = int.Parse(textBox65.Text);
                a[7, 1] = i;
            }
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            if (textBox64.Text != null)
            {
                int i;
                i = int.Parse(textBox64.Text);
                a[7, 0] = i;
            }
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            if (textBox63.Text != null)
            {
                int i;
                i = int.Parse(textBox63.Text);
                a[6, 8] = i;
            }
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            if (textBox62.Text != null)
            {
                int i;
                i = int.Parse(textBox62.Text);
                a[6, 7] = i;
            }
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            if (textBox61.Text != null)
            {
                int i;
                i = int.Parse(textBox61.Text);
                a[6, 6] = i;
            }
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            if (textBox60.Text != null)
            {
                int i;
                i = int.Parse(textBox60.Text);
                a[6, 5] = i;
            }
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            if (textBox59.Text != null)
            {
                int i;
                i = int.Parse(textBox59.Text);
                a[6, 4] = i;
            }
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            if (textBox58.Text != null)
            {
                int i;
                i = int.Parse(textBox58.Text);
                a[6, 3] = i;
            }
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            if (textBox57.Text != null)
            {
                int i;
                i = int.Parse(textBox57.Text);
                a[6, 2] = i;
            }
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            if (textBox56.Text != null)
            {
                int i;
                i = int.Parse(textBox56.Text);
                a[6, 1] = i;
            }
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            if (textBox55.Text != null)
            {
                int i;
                i = int.Parse(textBox55.Text);
                a[6, 0] = i;
            }
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            if (textBox54.Text != null)
            {
                int i;
                i = int.Parse(textBox54.Text);
                a[5, 8] = i;
            }
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            if (textBox53.Text != null)
            {
                int i;
                i = int.Parse(textBox53.Text);
                a[5, 7] = i;
            }
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            if (textBox52.Text != null)
            {
                int i;
                i = int.Parse(textBox52.Text);
                a[5, 6] = i;
            }
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            if (textBox51.Text != null)
            {
                int i;
                i = int.Parse(textBox51.Text);
                a[5, 5] = i;
            }
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            if (textBox49.Text != null)
            {
                int i;
                i = int.Parse(textBox49.Text);
                a[5, 3] = i;
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            if (textBox48.Text != null)
            {
                int i;
                i = int.Parse(textBox48.Text);
                a[5, 2] = i;
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            if (textBox47.Text != null)
            {
                int i;
                i = int.Parse(textBox47.Text);
                a[5, 1] = i;
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (textBox46.Text != null)
            {
                int i;
                i = int.Parse(textBox46.Text);
                a[5, 0] = i;
            }
        }
        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (textBox45.Text != null)
            {
                int i;
                i = int.Parse(textBox45.Text);
                a[4, 8] = i;
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (textBox44.Text != null)
            {
                int i;
                i = int.Parse(textBox44.Text);
                a[4, 7] = i;
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (textBox43.Text != null)
            {
                int i;
                i = int.Parse(textBox43.Text);
                a[4, 6] = i;
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (textBox42.Text != null)
            {
                int i;
                i = int.Parse(textBox42.Text);
                a[4, 5] = i;
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (textBox41.Text != null)
            {
                int i;
                i = int.Parse(textBox41.Text);
                a[4, 4] = i;
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (textBox40.Text != null)
            {
                int i;
                i = int.Parse(textBox40.Text);
                a[4, 3] = i;
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (textBox39.Text != null)
            {
                int i;
                i = int.Parse(textBox39.Text);
                a[4, 2] = i;
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (textBox38.Text != null)
            {
                int i;
                i = int.Parse(textBox38.Text);
                a[4, 1] = i;
            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (textBox37.Text != null)
            {
                int i;
                i = int.Parse(textBox37.Text);
                a[4, 0] = i;
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text != null)
            {
                int i;
                i = int.Parse(textBox36.Text);
                a[3, 8] = i;
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (textBox35.Text != null)
            {
                int i;
                i = int.Parse(textBox35.Text);
                a[3, 7] = i;
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (textBox34.Text != null)
            {
                int i;
                i = int.Parse(textBox34.Text);
                a[3, 6] = i;
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.Text != null)
            {
                int i;
                i = int.Parse(textBox33.Text);
                a[3, 5] = i;
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (textBox32.Text != null)
            {
                int i;
                i = int.Parse(textBox32.Text);
                a[3, 4] = i;
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text != null)
            {
                int i;
                i = int.Parse(textBox31.Text);
                a[3, 3] = i;
            }
        }
        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (textBox30.Text != null)
            {
                int i;
                i = int.Parse(textBox30.Text);
                a[3, 2] = i;
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (textBox29.Text != null)
            {
                int i;
                i = int.Parse(textBox29.Text);
                a[3, 1] = i;
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text != null)
            {
                int i;
                i = int.Parse(textBox28.Text);
                a[3, 0] = i;
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text != null)
            {
                int i;
                i = int.Parse(textBox27.Text);
                a[2, 8] = i;
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text != null)
            {
                int i;
                i = int.Parse(textBox26.Text);
                a[2, 7] = i;
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text != null)
            {
                int i;
                i = int.Parse(textBox25.Text);
                a[2, 6] = i;
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text != null)
            {
                int i;
                i = int.Parse(textBox24.Text);
                a[2, 5] = i;
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text != null)
            {
                int i;
                i = int.Parse(textBox23.Text);
                a[2, 4] = i;
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text != null)
            {
                int i;
                i = int.Parse(textBox22.Text);
                a[2, 3] = i;
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text != null)
            {
                int i;
                i = int.Parse(textBox21.Text);
                a[2, 2] = i;
            }
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text != null)
            {
                int i;
                i = int.Parse(textBox20.Text);
                a[2, 1] = i;
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text != null)
            {
                int i;
                i = int.Parse(textBox19.Text);
                a[2, 0] = i;
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text != null)
            {
                int i;
                i = int.Parse(textBox17.Text);
                a[1, 7] = i;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != null)
            {
                int i;
                i = int.Parse(textBox16.Text);
                a[1, 6] = i;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != null)
            {
                int i;
                i = int.Parse(textBox15.Text);
                a[1, 5] = i;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != null)
            {
                int i;
                i = int.Parse(textBox14.Text);
                a[1, 4] = i;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != null)
            {
                int i;
                i = int.Parse(textBox13.Text);
                a[1, 3] = i;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != null)
            {
                int i;
                i = int.Parse(textBox12.Text);
                a[1, 2] = i;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != null)
            {
                int i;
                i = int.Parse(textBox11.Text.ToString());
                a[1, 1] = i;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != null)
            {
                int i;
                i = int.Parse(textBox10.Text);
                a[1, 0] = i;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != null)
            {
                int i;
                i = int.Parse(textBox8.Text);
                a[0, 7] = i;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != null)
            {
                int i;
                i = int.Parse(textBox7.Text);
                a[0, 6] = i;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != null)
            {
                int i;
                i = int.Parse(textBox6.Text);
                a[0, 5] = i;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != null)
            {
                int i;
                i = int.Parse(textBox5.Text);
                a[0, 4] = i;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != null)
            {
                int i;
                i = int.Parse(textBox4.Text);
                a[0, 3] = i;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                int i;
                i = int.Parse(textBox3.Text);
                a[0, 2] = i;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                int i;
                i = int.Parse(textBox2.Text);
                a[0, 1] = i;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != null)
            {

                int i;
                i = int.Parse(textBox1.Text);
                a[0, 0] = i;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suduko(a);
            this.textBox1.Text = ""+a[0, 0];
            this.textBox2.Text = ""+a[0, 1];
            this.textBox3.Text = "" + a[0, 2];
            this.textBox4.Text = "" + a[0, 3];
            this.textBox5.Text = "" + a[0, 4];
            this.textBox6.Text = "" + a[0, 5];
            this.textBox7.Text = "" + a[0, 6];
            this.textBox8.Text = "" + a[0, 7];
            this.textBox9.Text = "" + a[0, 8];
            this.textBox10.Text = "" + a[1, 0];
            this.textBox11.Text = "" + a[1, 1];
            this.textBox12.Text = "" + a[1, 2];
            this.textBox13.Text = "" + a[1, 3];
            this.textBox14.Text = "" + a[1, 4];
            this.textBox15.Text = "" + a[1, 5];
            this.textBox16.Text = "" + a[1, 6];
            this.textBox17.Text = "" + a[1, 7];
            this.textBox18.Text = "" + a[1, 8];
            this.textBox19.Text = "" + a[2, 0];
            this.textBox20.Text = "" + a[2, 1];
            this.textBox21.Text = "" + a[2, 2];
            this.textBox22.Text = "" + a[2, 3];
            this.textBox23.Text = "" + a[2, 4];
            this.textBox24.Text = "" + a[2, 5];
            this.textBox25.Text = "" + a[2, 6];
            this.textBox26.Text = "" + a[2, 7];
            this.textBox27.Text = "" + a[2, 8];
            this.textBox28.Text = "" + a[3, 0];
            this.textBox29.Text = "" + a[3, 1];
            this.textBox30.Text = "" + a[3, 2];
            this.textBox31.Text = "" + a[3, 3];
            this.textBox32.Text = "" + a[3, 4];
            this.textBox33.Text = "" + a[3, 5];
            this.textBox34.Text = "" + a[3, 6];
            this.textBox35.Text = "" + a[3, 7];
            this.textBox36.Text = "" + a[3, 8];
            this.textBox37.Text = "" + a[4, 0];
            this.textBox38.Text = "" + a[4, 1];
            this.textBox39.Text = "" + a[4, 2];
            this.textBox40.Text = "" + a[4, 3];
            this.textBox41.Text = "" + a[4, 4];
            this.textBox42.Text = "" + a[4, 5];
            this.textBox43.Text = "" + a[4, 6];
            this.textBox44.Text = "" + a[4, 7];
            this.textBox45.Text = "" + a[4, 8];
            this.textBox46.Text = "" + a[5, 0];
            this.textBox47.Text = "" + a[5, 1];
            this.textBox48.Text = "" + a[5, 2];
            this.textBox49.Text = "" + a[5, 3];
            this.textBox50.Text = "" + a[5, 4];
            this.textBox51.Text = "" + a[5, 5];
            this.textBox52.Text = "" + a[5, 6];
            this.textBox53.Text = "" + a[5, 7];
            this.textBox54.Text = "" + a[5, 8];
            this.textBox55.Text = "" + a[6, 0];
            this.textBox56.Text = "" + a[6, 1];
            this.textBox57.Text = "" + a[6, 2];
            this.textBox58.Text = "" + a[6, 3];
            this.textBox59.Text = "" + a[6, 4];
            this.textBox60.Text = "" + a[6, 5];
            this.textBox61.Text = "" + a[6, 6];
            this.textBox62.Text = "" + a[6, 7];
            this.textBox63.Text = "" + a[6, 8];
            this.textBox64.Text = "" + a[7, 0];
            this.textBox65.Text = "" + a[7, 1];
            this.textBox66.Text = "" + a[7, 2];
            this.textBox67.Text = "" + a[7, 3];
            this.textBox68.Text = "" + a[7, 4];
            this.textBox69.Text = "" + a[7, 5];
            this.textBox70.Text = "" + a[7, 6];
            this.textBox71.Text = "" + a[7, 7];
            this.textBox72.Text = "" + a[7, 8];
            this.textBox73.Text = "" + a[8, 0];
            this.textBox74.Text = "" + a[8, 1];
            this.textBox75.Text = "" + a[8, 2];
            this.textBox76.Text = "" + a[8, 3];
            this.textBox77.Text = "" + a[8, 4];
            this.textBox78.Text = "" + a[8, 5];
            this.textBox79.Text = "" + a[8, 6];
            this.textBox80.Text = "" + a[8, 7];
            this.textBox81.Text = "" + a[8, 8];
        }
    }
}
