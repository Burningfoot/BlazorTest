using Microsoft.AspNetCore.Components;

namespace BlazorTest.Client.Views
{
    public partial class FirstPageView
    {
        private int myProperty;
        private bool testMyVar;
        private int num;

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
                MyPropertyChanged.InvokeAsync(value);
            }
        }

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
                TestMyVarChanged.InvokeAsync(value);
            }
        }

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
            }
        }

        [Parameter]
        public EventCallback<bool> TestMyVarChanged { get; set; }

        [Parameter]
        public EventCallback<int> MyPropertyChanged { get; set; }

        [Parameter]
        public EventCallback<ChangeEventArgs> NumChanged { get; set; }

        protected override Task OnParametersSetAsync()
        {
            ViewModel.MyProperty = MyProperty;
            ViewModel.Num = Num;
            ViewModel.TestMyVar = TestMyVar;
            return base.OnParametersSetAsync();
        }
    }
}
