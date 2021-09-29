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
using System.Windows.Shapes;

namespace Perestanovka
{
    /// <summary>
    /// Логика взаимодействия для BlockWPF.xaml
    /// </summary>
    public partial class BlockWPF : Window
    {
        public BlockWPF()
        {
            InitializeComponent();
        }
        Perestan p = new Perestan();
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Key.Text, out _))
                Value.Content = "Некоректные данные";
            else
                Value.Content = p.BlockSimple(Key.Text, Text.Text);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
    }
}
