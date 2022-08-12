using Microsoft.AspNetCore.Components;
using ReactiveUI;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorTest.Client.ViewModels
{
    public class BaseViewModel : ReactiveObject
    {
        public BaseViewModel()
        {
        }
        //public event PropertyChangedEventHandler? PropertyChanged;

        //public void OnPropertyChange([CallerMemberName] string propertyName = null)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
