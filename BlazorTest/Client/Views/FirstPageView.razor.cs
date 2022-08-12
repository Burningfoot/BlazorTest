using Microsoft.AspNetCore.Components;

namespace BlazorTest.Client.Views
{
    public partial class FirstPageView
    {
        private int myProperty;

        [Parameter]
        public int MyProperty
        {
            get
            {
                return myProperty;
            }
            set
            {
                if (myProperty == value) return;
                myProperty = value;
                ViewModel.MyProperty = value;
                MyPropertyChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }

        private bool testMyVar;

        public bool TestMyVar
        {
            get 
            {
                return testMyVar;
            }
            set
            {
                if (testMyVar == value) return;
                testMyVar = value;
                ViewModel.TestMyVar = value;
                TestMyVarChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }

        private int num;

        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                if (num == value) return;
                num = value;
                ViewModel.Num = value;
                NumChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }


        [Parameter]
        public EventCallback<bool> TestMyVarChanged { get; set; }

        [Parameter]
        public EventCallback<int> MyPropertyChanged { get; set; }

        [Parameter]
        public EventCallback<int> NumChanged { get; set; }
    }
}
