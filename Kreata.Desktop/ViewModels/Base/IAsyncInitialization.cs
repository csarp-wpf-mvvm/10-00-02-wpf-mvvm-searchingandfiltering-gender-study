using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.Base
{
    public interface IAsyncInitialization
    {
        public Task InitializeAsync();
    }
}
