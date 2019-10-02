using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Easy_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Button[,] arraybutton = new Button[4, 4];

        void findBlack(ref int x, ref int y)
        {
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<4;j++)
                {
                    if(arraybutton[i,j]==Black)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
        }

        void findButton(Button b, ref int x, ref int y)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; i < 4; j++)
                {
                    if (arraybutton[i, j] == b)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
        }
        bool Check()
        {
            if (arraybutton[0, 0] != a1)
                return false;
            if(arraybutton[0, 1] != a2)
                return false;
            if (arraybutton[0, 2] != a3)
                return false;
            if (arraybutton[0, 3] != a4)
                return false;
            if (arraybutton[1, 0] != a5)
                return false;
            if (arraybutton[1, 1] != a6)
                return false;
            if (arraybutton[1, 2] != a7)
                return false;
            if (arraybutton[1, 3] != a8)
                return false;
            if (arraybutton[2, 0] != a9)
                return false;
            if (arraybutton[2, 1] != a10)
                return false;
            if (arraybutton[2, 2] != a11)
                return false;
            if (arraybutton[2, 3] != a12)
                return false;
            if (arraybutton[3, 0] != a13)
                return false;
            if (arraybutton[3, 1] != a14)
                return false;
            if (arraybutton[3, 2] != a15)
                return false;
            win.Content = "you Win";
            return true;
        }
        void click(Button button)
        {
            //tìm vị trí của Black và button
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (button == arraybutton[i, j])
                    {
                        x = i;
                        y = j;
                    }
                    if (Black == arraybutton[i, j])
                    {
                        x1 = i;
                        y1 = j;
                    }
                }
            }
            
            //kiểm tra điều kiện nếu thỏa thì đổi chổ
            if ((x == x1 && (y - y1 == 1 || y - y1 == -1)) || (y == y1 && (x - x1 == 1 || x - x1 == -1)))
            {
                //đổi vị trí trong Grid
                Grid.SetRow(button, x1);
                Grid.SetColumn(button, y1);
                Grid.SetRow(Black, x);
                Grid.SetColumn(Black, y);

                //đổi vị trí trong mảng
                arraybutton[x1, y1] = button;
                arraybutton[x, y] = Black;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            //a.GetLocalValueEnumerator
            //var xy = a.GetLocalValueEnumerator();
            //DataGrid.SetFlowDirection()
            //đọc 1 hình
            //cắt ra từng phần
            //tạo mảng gán từng phần tử là từng hình
            
            //gán từng giá trị của mảng bằng vs từng button
            //mục đích: lưu trữ và truy xuất vị trí của button trong grid
            arraybutton[0,0] = a1;
            arraybutton[0,1] = a2;
            arraybutton[0,2] = a3;
            arraybutton[0,3] = a4;
            arraybutton[1,0] = a5;
            arraybutton[1,1] = a6;
            arraybutton[1,2] = a7;
            arraybutton[1,3] = a8;
            arraybutton[2, 0] = a9;
            arraybutton[2, 1] = a10;
            arraybutton[2, 2] = a11;
            arraybutton[2, 3] = a12;
            arraybutton[3, 0] = a13;
            arraybutton[3, 1] = a14;
            arraybutton[3, 2] = a15;
            arraybutton[3,3] = Black;

            ////Random X = new Random();
            ////int dem = X.Next(4);
            //for(int i=0;i<2;i++)
            //{
            //    for(int j=3;j>=0;j--)
            //    {
            //        Grid.SetRow(arraybutton[i, j], i);
            //        Grid.SetColumn(arraybutton[i, j], j);
            //    }
            //}

            //for (int i = 2; i < 4; i++)
            //{
            //    for (int j = 3; j >= 0; j--)
            //    {
            //        Grid.SetRow(arraybutton[i, j], i);
            //        Grid.SetColumn(arraybutton[i, j], j);
            //    }
            //}

            //xếp các button lên màng hình
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //Random rnd1 = new Random();
                    //Random rnd2 = new Random();
                    Grid.SetRow(arraybutton[i, j], i);
                    Grid.SetColumn(arraybutton[i, j], j);
                }
            }

            //if (Check())
            //{

            //}
        }

        int x, x1, y, y1;

        private void a1_Click(object sender, RoutedEventArgs b)
        {
            click(a1);
            Check();
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        {
            click(a2);
            Check();
        }

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            click(a3);
            Check();
        }

        private void a4_Click(object sender, RoutedEventArgs e)
        {
            click(a4);
            Check();
        }

        private void a5_Click(object sender, RoutedEventArgs e)
        {
            click(a5);
            Check();
        }

        private void a6_Click(object sender, RoutedEventArgs e)
        {
            click(a6);
            Check();
        }

        private void a7_Click(object sender, RoutedEventArgs e)
        {
            click(a7);
            Check();
        }

        private void a8_Click(object sender, RoutedEventArgs e)
        {
            click(a8);
            Check();
        }

        private void a9_Click(object sender, RoutedEventArgs e)
        {
            click(a9);
            Check();
        }

        private void a10_Click(object sender, RoutedEventArgs e)
        {
            click(a10);
            Check();
        }

        private void a11_Click(object sender, RoutedEventArgs e)
        {
            click(a11);
            Check();
        }

        private void a12_Click(object sender, RoutedEventArgs e)
        {
            click(a12);
            Check();
        }
        private void a13_Click(object sender, RoutedEventArgs e)
        {
            click(a13);
            Check();
        }

        private void a14_Click(object sender, RoutedEventArgs e)
        {
            click(a14);
            Check();
        }

        private void a15_Click(object sender, RoutedEventArgs e)
        {
            click(a15);
            Check();
        }


        private void tren_Click(object sender, RoutedEventArgs e)
        {
            findBlack(ref x1,ref y1);
            
            if (x1 < 3)
            {
                Grid.SetRow(Black, x1 + 1);
                Grid.SetRow(arraybutton[x1 + 1, y1], x1);
                arraybutton[x1, y1] = arraybutton[x1 + 1, y1];
                arraybutton[x1 + 1, y1] = Black;
            }
            Check();
        }

        private void tren_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void duoi_Click(object sender, RoutedEventArgs e)
        {
            findBlack(ref x1, ref y1);
            if (x1 > 0)
            {
                Grid.SetRow(Black, x1 - 1);
                Grid.SetRow(arraybutton[x1 - 1, y1], x1);
                arraybutton[x1, y1] = arraybutton[x1 - 1, y1];
                arraybutton[x1 - 1, y1] = Black;
            }
            Check();
        }

        private void trai_Click(object sender, RoutedEventArgs e)
        {
            findBlack(ref x1, ref y1);
            if (y1 < 3)
            {
                Grid.SetColumn(Black, y1 + 1);
                Grid.SetColumn(arraybutton[x1, y1 + 1], y1);
                arraybutton[x1, y1] = arraybutton[x1, y1+1];
                arraybutton[x1, y1+1] = Black;
            }
            Check();
        }

        private void phai_Click(object sender, RoutedEventArgs e)
        {
            findBlack(ref x1, ref y1);
            if (y1 > 0)
            {
                Grid.SetColumn(Black, y1 - 1);
                Grid.SetColumn(arraybutton[x1, y1-1], y1);
                arraybutton[x1, y1] = arraybutton[x1, y1-1];
                arraybutton[x1, y1-1] = Black;
            }
            Check();
        }
    }
}

