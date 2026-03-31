using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Eremex.AvaloniaUI.Controls.Common;

namespace EremexAvaloniaEmptyWindowIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ICommand OpenFile { get; }
    public ICommand SaveFile { get; }

    public MainWindowViewModel()
    {
        OpenFile = new AsyncRelayCommand<MxWindow>(async (window) =>
        {
            if (window == null)
            {
                throw new Exception("Window is Null");
            }
        });
        
        SaveFile = new AsyncRelayCommand<MxWindow>(async (window) =>
        {
            if (window == null)
            {
                throw new Exception("Window is Null");
            }
        });
    }
}