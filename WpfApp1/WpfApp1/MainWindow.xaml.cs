using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly CalcViewModel ViewModel = new();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this.ViewModel;
        }


        private void Num_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            this.ViewModel.NumCommand(btn.Content);
        }
        private void Cmd_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            this.ViewModel.CmdCommand(btn.Content);

        }

    }
}