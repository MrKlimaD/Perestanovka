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

namespace Perestanovka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SimpleS_Click(object sender, RoutedEventArgs e)
        {
            SimpleWPF w = new SimpleWPF();
            w.Show();
            this.Close();
        }

        private void BlockS_Click(object sender, RoutedEventArgs e)
        {
            BlockWPF w = new BlockWPF();
            w.Show();
            this.Close();
        }

        private void TableS_Click(object sender, RoutedEventArgs e)
        {
            TableWPF w = new TableWPF();
            w.Show();
            this.Close();
        }

        private void VerticalS_Click(object sender, RoutedEventArgs e)
        {
            VerticalWPF w = new VerticalWPF();
            w.Show();
            this.Close();
        }

        private void RotateS_Click(object sender, RoutedEventArgs e)
        {
            RotateWPF w = new RotateWPF();
            w.Show();
            this.Close();
        }

        private void MagicalS_Click(object sender, RoutedEventArgs e)
        {
            MagicalWPF w = new MagicalWPF();
            w.Show();
            this.Close();
        }

        private void DoubleS_Click(object sender, RoutedEventArgs e)
        {
            DoubleWPF w = new DoubleWPF();
            w.Show();
            this.Close();
        }
    }
}
