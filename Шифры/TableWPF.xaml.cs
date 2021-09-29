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
    /// Логика взаимодействия для TableWPF.xaml
    /// </summary>
    public partial class TableWPF : Window
    {
        public TableWPF()
        {
            InitializeComponent();
        }
        int X, Y;

        Perestan p = new Perestan();

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Count.Text, out _))
                Value.Content = "Некоректные данные";
            else
                Value.Content = p.Table(Text.Text, X, Y, Convert.ToInt32(Count.Text));
        }

        private void RL_Checked(object sender, RoutedEventArgs e)
        {
            X = 2;
        }

        private void UD_Checked(object sender, RoutedEventArgs e)
        {
            Y = 1;
        }

        private void DU_Checked(object sender, RoutedEventArgs e)
        {
            Y = 2;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void LR_Checked(object sender, RoutedEventArgs e)
        {
            X = 1;
        }
    }
}
