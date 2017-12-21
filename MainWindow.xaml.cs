using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Utils.Extensions;

namespace BlurTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int BlurRadius = 10;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txt.BlurApply(BlurRadius, new TimeSpan(0, 0, 1), TimeSpan.Zero);
                MessageBox.Show("Test");
            }
            finally
            {
                txt.BlurDisable(new TimeSpan(0, 0, 5), TimeSpan.Zero);
            }

        }
    }
}
