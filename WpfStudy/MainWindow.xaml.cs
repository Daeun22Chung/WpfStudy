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
using WpfStudy.Models;
using WpfStudy.ViewModels;

namespace WpfStudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            viewModel.ProgressValue = 30;
            DataContext = viewModel;
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            //List<User> users = new List<User>();
            //labelTest1.Content = "클릭했당";
            //MessageBox.Show(CheckBox1.IsChecked + "");
            //User userA = new User();
            //userA.Name = "Noah";
            //userA.UserAge = 15;
            //userA.UserImg = @"C:\Users\ddaeu\Desktop\wpfStudy\WpfStudy\WpfStudy\Resources\photo1.jpg";

            //User userB = new User();
            //userB.UserImg = @"C:\Users\ddaeu\Desktop\wpfStudy\WpfStudy\WpfStudy\Resources\photo1.jpg";
            //userB.Name = "Liam";
            //userB.UserAge = 15;


            //users.Add(userA);
            //users.Add(userB);

            //listView1.ItemsSource = users;
            viewModel.ProgressValue = 100;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}