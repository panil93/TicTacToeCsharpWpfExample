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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayerOneTurn { get; set; }
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        public void NewGame()
        {
            IsPlayerOneTurn = false;
            Counter = 0;
            A1.Content = string.Empty;
            A2.Content = string.Empty;
            A3.Content = string.Empty;
            B1.Content = string.Empty;
            B2.Content = string.Empty;
            B3.Content = string.Empty;
            C1.Content = string.Empty;
            C2.Content = string.Empty;
            C3.Content = string.Empty;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsPlayerOneTurn ^= true; //Is player one turn?
            Counter++;
            if (Counter > 9)
            {
                NewGame();
                return;
            }
            var button = sender as Button;
            //If there is player one turn, buttons content is "O" and when isn't content is "X"
            button.Content = IsPlayerOneTurn ? "O" : "X";

            if (CheckIfPlayerWon())
            {
                Counter = 9;
            }
        }
        private bool CheckIfPlayerWon()
        {
            
            if(A1.Content.ToString() != string.Empty && A1.Content==B1.Content && B1.Content == C1.Content)
            {
                A1.Background = Brushes.Green;
                B1.Background = Brushes.Green;
                C1.Background = Brushes.Green;
                return true;
            }
            else if (A2.Content.ToString() != string.Empty && A2.Content == B2.Content && B2.Content == C2.Content)
            {
                A2.Background = Brushes.Green;
                B2.Background = Brushes.Green;
                C2.Background = Brushes.Green;
                return true;
            }
            else if (A3.Content.ToString() != string.Empty && A3.Content == B3.Content && B3.Content == C3.Content)
            {
                A3.Background = Brushes.Green;
                B3.Background = Brushes.Green;
                C3.Background = Brushes.Green;
                return true;
            }
            else if (A1.Content.ToString() != string.Empty && A1.Content == A2.Content && A2.Content == A3.Content)
            {
                A3.Background = Brushes.Green;
                A2.Background = Brushes.Green;
                A1.Background = Brushes.Green;
                return true;
            }
            else if (B1.Content.ToString() != string.Empty && B1.Content == B2.Content && B2.Content == B3.Content)
            {
                B3.Background = Brushes.Green;
                B2.Background = Brushes.Green;
                B1.Background = Brushes.Green;
                return true;
            }
            else if (C1.Content.ToString() != string.Empty && C1.Content == C2.Content && C2.Content == C3.Content)
            {
                C3.Background = Brushes.Green;
                C2.Background = Brushes.Green;
                C1.Background = Brushes.Green;
                return true;
            }            
            else if (A1.Content.ToString() != string.Empty && A1.Content == B2.Content && B2.Content == C3.Content)
            {
                A1.Background = Brushes.Green;
                B2.Background = Brushes.Green;
                C3.Background = Brushes.Green;
                return true;
            }            
            else if (A3.Content.ToString() != string.Empty && A3.Content == B2.Content && B2.Content == C1.Content)
            {
                A3.Background = Brushes.Green;
                B2.Background = Brushes.Green;
                C1.Background = Brushes.Green;
                return true;
            }
            return false;
        }
    }
}

