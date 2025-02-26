using Avalonia.Controls;

namespace ajkCefGlue.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextBox_KeyDown(object? sender, Avalonia.Input.KeyEventArgs e)
    {
        if(e.Key == Avalonia.Input.Key.Enter)
        {
            string? address = addressTextBox.Text;
            if (address == null) return;
            browser.Address = address;
        }
    }

}
