using GalaSoft.MvvmLight;
using System.Threading.Tasks;

namespace MVVM_Demo.ViewModels
{
    public abstract class BaseViewModel : ViewModelBase, IViewModel
    {
        public virtual Task LoadAsync(object parameter)
        {
            return Task.CompletedTask;
        }

        public virtual void Unload() {}
    }
}
