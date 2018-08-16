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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(float I=0; I<=360; I++)
            {
                plnLinea.Points.Add(new Point(Math.Cos(I) *100 + 50, Math.Sin(I) * 100 + 50));
            }


            plnLinea2.Points.Add(new Point(100.0, 350.0));
            plnLinea2.Points.Add(new Point(350.0, 350.0));
            plnLinea2.Points.Add(new Point(350.0, 200.0));
            plnLinea2.Points.Add(new Point(100.0, 200.0));
            plnLinea2.Points.Add(new Point(100.0, 350.0));


            plnLinea4.Points.Add(new Point(140.0, 275.0));
            plnLinea4.Points.Add(new Point(310.0, 275.0));


            plnLinea5.Points.Add(new Point(227.0, 240.0));
            plnLinea5.Points.Add(new Point(227.0, 310.0));

            plnLinea3.Points.Add(new Point(0.0, 380.0));
            plnLinea3.Points.Add(new Point(800.0, 380.0));


            plnLinea7.Points.Add(new Point(600.0, 380.0));
            plnLinea7.Points.Add(new Point(600.0, 200.0));

            for (float I = 0; I <= 360; I++)
            {
                plnLinea8.Points.Add(new Point(Math.Cos(I) * 100 + 600, Math.Sin(I) * 100 + 60));
            }


            plnLinea6.Points.Add(new Point(40.0, 160.0));
            plnLinea6.Points.Add(new Point(405.0, 160.0));
            plnLinea6.Points.Add(new Point(220.0, 90.0));
            plnLinea6.Points.Add(new Point(40.0, 160.0));







        }
    }
}
