using BlazorTest.Client.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BlazorTest.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {
        private bool testMyVar;

        public int MyProperty { get; set; }
        public bool TestMyVar
        {
            get { return testMyVar; }
            set 
            { 
                testMyVar = value;
                if (value)
                {
                    Num = 0;
                }
            }
        }
        public int Num { get; set; }

        public FirstPageViewModel()
        {
            MyProperty = 1;
        }


    }
}
