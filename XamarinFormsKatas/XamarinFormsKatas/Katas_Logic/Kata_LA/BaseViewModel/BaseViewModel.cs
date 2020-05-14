using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    public BaseViewModel()
    {
        InitCommands();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void ONPropertyChanged([CallerMemberName] string propertyName = "")
    {
        if (PropertyChanged != null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    protected abstract void InitCommands();
}
