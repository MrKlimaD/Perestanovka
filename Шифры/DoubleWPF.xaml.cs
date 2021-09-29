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
    /// Логика взаимодействия для DoubleWPF.xaml
    /// </summary>
    public partial class DoubleWPF : Window
    {
        public DoubleWPF()
        {
            InitializeComponent();
        }
        Perestan p = new Perestan();
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Keyx.Text, out _) && !int.TryParse(Keyy.Text, out _))
                Value.Content = "Некоректные данные";
            else
                Value.Content = p.Double(Keyx.Text, Keyy.Text, Text.Text);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
    }
}
