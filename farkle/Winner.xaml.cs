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

namespace farkle
{
    /// <summary>
    /// Interaction logic for Winner.xaml
    /// </summary>
    public partial class Winner : Window
    {
        public Winner()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            // Close application.
            this.Close();
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdoOnePlayer.IsChecked == true)
            {
                MainWindow FarkleGame = new MainWindow();
                FarkleGame.OnePlayer = true;
                FarkleGame.Show();
            }
            else if ((bool)rdoTwoPlayer.IsChecked == true)
            {
                MainWindow FarkleGame = new MainWindow();
                FarkleGame.TwoPlayer = true;
                FarkleGame.Show();
            }
            else if ((bool)rdoThreePlayers.IsChecked == true)
            {
                MainWindow FarkleGame = new MainWindow();
                FarkleGame.ThreePlayer = true;
                FarkleGame.Show();
            }
            else
            {
                // Four players was selected.
                MainWindow FarkleGame = new MainWindow();
                FarkleGame.FourPlayer = true;
                FarkleGame.Show();
            }

            // Close current Winner window.
            this.Close();
        }
    }
}
