using GetStartedApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GetStartedApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia! This is my added text.";
#pragma warning restore CA1822 // Mark members as static
    public ObservableCollection<TestCase> TestCaseList
    {
        get
        {
            return new ObservableCollection<TestCase>(
        [
            new TestCase("abc", "asdf"),
            new TestCase("def", "bsdf"),
            new TestCase("xyz", "csdf"),
        ]);
        }
    }
}
