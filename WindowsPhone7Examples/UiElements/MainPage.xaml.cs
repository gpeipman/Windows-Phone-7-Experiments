using System.Windows;
using System.Windows.Input;

namespace UiElements
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPageLoaded;
        }

        void MainPageLoaded(object sender, RoutedEventArgs e)
        {
            var numericScope = new InputScope();
            var numericScopeName = new InputScopeName();
            numericScopeName.NameValue = InputScopeNameValue.Number;
            numericScope.Names.Add(numericScopeName);
            numberTextBox.InputScope = numericScope;           
        }
    }
}