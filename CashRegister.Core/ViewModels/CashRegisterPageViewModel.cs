using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CashRegister.Core.Services;

namespace CashRegister.Core.ViewModels;

public class CashRegisterPageViewModel : SamplePageViewModel
{
    public CashRegisterPageViewModel(IFilesService filesService)
        : base(filesService)
    {
        DownloadTextCommand = new AsyncRelayCommand(DownloadTextAsync);
    }

    public IAsyncRelayCommand DownloadTextCommand { get; }

    private async Task<string> DownloadTextAsync()
    {
        await Task.Delay(3000); // Simulate a web request

        return "Hello world!";
    }
}
