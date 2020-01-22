using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MVVM_Demo
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            ViewModel.Load();
        }
    }
}
