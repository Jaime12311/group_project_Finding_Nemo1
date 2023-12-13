using System;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Navigate(new HomePage());
    }

    private void Navigate(Page page)
    {
        FrameContent.NavigationService.Navigate(page);
    }

    private void HomeButton_Click(object sender, RoutedEventArgs e)
    {
        Navigate(new HomePage());
    }

    private void EntryButton_Click(object sender, RoutedEventArgs e)
    {
        Navigate(new EntryPage());
    }

    private void AboutButton_Click(object sender, RoutedEventArgs e)
    {
        Navigate(new AboutPage());
    }
}
