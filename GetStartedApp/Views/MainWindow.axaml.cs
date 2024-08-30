using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Click!");
        Debug.WriteLine($"Click! Celsius={celsius.Text}");

        if (double.TryParse(celsius.Text, out double celsiusOut))
        {
            double fahrenheitCalc = (celsiusOut * (9d / 5d)) + 32;
            fahrenheit.Text = fahrenheitCalc.ToString("0.0");
        }
        else {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }
    }

    public void OnTextInputCelsius(object source, TextChangedEventArgs args)
    {
        Debug.WriteLine($"Type: {celsius.Text}");
        if (double.TryParse(celsius.Text, out double celsiusOut))
        {
            double fahrenheitCalc = (celsiusOut * (9d / 5d)) + 32;
            fahrenheit.Text = fahrenheitCalc.ToString("0.0");
        }
        else
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }
    }
}