using Avalonia.Controls;
using System.Collections.Generic;

namespace AvaloniaLab7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAnalyzeClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ResultsBox.ItemsSource = AnalyzeDna(DnaInput.Text);
        }

        private IEnumerable<string> AnalyzeDna(string input)
        {
            var result = new List<string>();
            var counts = new Dictionary<string, int>();
            input = input?.ToUpper() ?? "";

            for (int i = 0; i <= input.Length - 4; i++)
            {
                var quad = input.Substring(i, 4);
                if (IsValid(quad))
                {
                    if (counts.ContainsKey(quad))
                        counts[quad]++;
                    else
                        counts[quad] = 1;
                }
            }

            foreach (var kvp in counts)
                result.Add($"{kvp.Key}: {kvp.Value}");

            return result;
        }

        private bool IsValid(string s)
        {
            foreach (var c in s)
                if (c != 'A' && c != 'C' && c != 'G' && c != 'T')
                    return false;
            return true;
        }
    }
}
