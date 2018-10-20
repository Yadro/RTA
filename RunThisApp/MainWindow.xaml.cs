using System.Collections.Generic;

namespace RunThisApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var list = new List<string> { "One", "Two", "Three" };
            this.ListView.ItemsSource = list;
        }
    }
}