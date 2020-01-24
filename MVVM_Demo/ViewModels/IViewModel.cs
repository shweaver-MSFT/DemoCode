using System.Threading.Tasks;

namespace MVVM_Demo.ViewModels
{
    public interface IViewModel
    {
        Task LoadAsync(object parameter);
        void Unload();
    }
}
