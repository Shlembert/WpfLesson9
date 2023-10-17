using System;
using System.Linq;
using System.Windows;

namespace WpfLesson9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisplaySplitList(object sender, RoutedEventArgs e)
        {
            myListBox.ItemsSource = SplitText(textSplit.Text).ToArray();
        }

        private void DisplayReverse(object sender, RoutedEventArgs e)
        {
            myLabel.Content = ReverseWords(textReverse.Text);
        }

        private string[] SplitText(string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        private string ReverseWords(string inputPhrase)
        {
            string[] words = SplitText(inputPhrase);
            Array.Reverse(words);

            return string.Join(" ", words);
        }

    }
}
