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

namespace Square
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(UserInput.Text);
            int j = 1, k = 1;
            string q = "", c = "", d = "";
            ShowUser.Content = "您輸入的邊長為" + x;

            while (j <= x)
            {
                while (k <= x)
                {
                    q = q + "*";
                    k++;
                }
                q = q + "\n";
                k = 1;
                j++;
            }

            Output.Content = q;
        }

        private void Air_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(UserInput.Text);
            int w = 1, b = 2;
            string p = "", n = "";

            ShowUser.Content = "您輸入的邊長為" + x;
            for (int i = 1; i <= x; i++)
            {
                if (i == 1 || i == x)
                {
                    while (w <= x)
                    {
                        p = p + '*';
                        w++;
                    }
                }
                else
                {
                    p = p + "*";
                    while (b <= x)
                    {
                        if (b < x)
                        {
                            p = p + "  ";
                        }
                        else
                        {
                            p = p + '*';
                        }
                        b++;
                    }
                }
                p.PadLeft(x);
                p = p + "\r\n";
                w = 1;
                b = 2;
            }

            Output.Content = p;
        }

        private void Odd_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(UserInput.Text);
            string q = "";
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i % 2 != 0 || i == 1)
                    {
                        q = q + "*";
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            q = q + "  ";
                        }
                        else
                        {
                            q = q + "*";
                        }
                    }
                }
                q = q + "\r\n";
            } Output.Content = q;
        }

        private void Cross_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(UserInput.Text);
            string q = "", t = "", y = "";

            int k = 0;
            k = x / 2 + 1;

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i == k)
                    {
                        t = t + q.PadLeft(1, '*');
                    }
                    else
                    {
                        if (j == k)
                        {
                            t = t + q.PadLeft(1, '*');
                        }
                        else
                        {
                            t = t + y.PadLeft(1, ' ');
                        }
                    }
                } t = t + "\r\n";
            } Output.Content = t;
        }
    }
}