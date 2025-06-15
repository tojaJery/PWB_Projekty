using Avalonia.Controls;

namespace AvaloniaLab9;

public partial class SummaryWindow : Window
{
    public SummaryWindow(string tekst)
    {
        InitializeComponent();
        SummaryText.Text = tekst;
    }
}