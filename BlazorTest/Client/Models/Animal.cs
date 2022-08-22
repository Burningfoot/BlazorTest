using ReactiveUI;

namespace BlazorTest.Client.Models
{
    public abstract class Animal : ReactiveObject
    {
        private string name;

        public string Name
        {
            get => name;
            set => this.RaiseAndSetIfChanged(ref name, value);
        }

        private string description;

        public string Description
        {
            get => description;
            set => this.RaiseAndSetIfChanged(ref description, value);
        }

        private string backgroundColor;

        public string BackgroundColor
        {
            get => backgroundColor;
            set => this.RaiseAndSetIfChanged(ref backgroundColor, value);
        }

    }
}
