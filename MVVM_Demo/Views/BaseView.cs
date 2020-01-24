using MVVM_Demo.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MVVM_Demo.Views
{
    public abstract class BaseView : Page
    {
        private IViewModel _vm => DataContext as IViewModel;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _vm?.LoadAsync(e.Parameter);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _vm?.Unload();
            base.OnNavigatedFrom(e);
        }
    }
}
