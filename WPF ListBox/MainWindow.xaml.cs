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

namespace WPF_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match (){ Team1 = "Jack", Team2 = "Rayan", Score1 = 67, Score2 = 44, Completion = 66 });
            matches.Add(new Match() { Team1 = "Hulk", Team2 = "Buster", Score1 = 43, Score2 = 25, Completion = 35 });
            matches.Add(new Match() { Team1 = "Black", Team2 = "Widow", Score1 = 23, Score2 = 65, Completion = 42 });
            matches.Add(new Match() { Team1 = "Tony", Team2 = "Stark", Score1 = 66, Score2 = 64, Completion = 54});

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match:"
                    + (lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " +
                    (lbMatches.SelectedItem as Match).Score2 + " " +
                    (lbMatches.SelectedItem as Match).Team2);
            }
        }
    }
}

public class Match
{
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public int Score1 { get; set; } 
    public int Score2 { get; set; }
    public int Completion { get; set; }

}

