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
    /// Логика взаимодействия для RotateWPF.xaml
    /// </summary>
    public partial class RotateWPF : Window
    {
        public RotateWPF()
        {
            InitializeComponent();
        }

        Perestan p = new Perestan();

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (Text.Text.Length > 16)
                Value.Content = "Некоректные данные";
            else
                Value.Content = p.Rotate(Text.Text);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
    }
}
