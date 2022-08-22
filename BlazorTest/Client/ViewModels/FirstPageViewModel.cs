using BlazorTest.Client.ViewModels;
using ReactiveUI;

namespace BlazorTest.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {
        private bool testMyVar;
        private int myProperty;
        private int num;

        public int MyProperty
        {
            get => myProperty;
            set => this.RaiseAndSetIfChanged(ref myProperty, value);
        }
        public bool TestMyVar
        {
            get => testMyVar;
            set => this.RaiseAndSetIfChanged(ref testMyVar, value);
        }
        public int Num
        {
            get => num;
            set => this.RaiseAndSetIfChanged(ref num, value);
        }

        public FirstPageViewModel()
        {
            MyProperty = 1;
        }


    }
}
