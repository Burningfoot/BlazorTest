using BlazorTest.Client.Models;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

namespace BlazorTest.Client.ViewModels
{
    public class SecondPageViewModel : BaseViewModel
    {

        private bool isActive;
        private int? randomeNumber;

        public bool IsActive
        {
            get { return isActive; }
            set 
            {
                if (isActive == value) return;
                isActive = value;
            }
        }

        public int? RandomNumber
        {
            get { return randomeNumber; }
            set 
            { 
                if (randomeNumber == value) return;
                randomeNumber = value;
            }
        }

        public bool? IsLoading { get; set; }

        private ObservableCollection<Animal>? animalList;

        public ObservableCollection<Animal>? AnimalList
        {
            get
            {
                return animalList;
            }
            set
            {
                animalList = value;
            }
        }
        public string? SelectedAnimalName { get; set; }


        public ReactiveCommand<Unit, Unit>? com { get; set; }
        public ReactiveCommand<Unit, Unit>? diceRoleCommand { get; set; }
        public ReactiveCommand<Unit, Unit>? AddDogCommand { get; set; }
        public ReactiveCommand<Unit, Unit>? AddCatCommand { get; set; }

        public SecondPageViewModel()
        {
            RegisterCommands();
            AnimalList = new ObservableCollection<Animal>();
        }

        private void RegisterCommands()
        {
            com = ReactiveCommand.CreateFromTask(async () => { await Task.Delay(0); IsActive = !IsActive; });
            diceRoleCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                Random rand = new Random();
                RandomNumber = rand.Next();
            }, this.WhenAnyValue(x => x.IsActive));
            AddDogCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                AnimalList.Add(new Dog() { Name = "Dog " + RandomNumber.ToString(), BackgroundColor = "blue"});

            });
            AddCatCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                AnimalList.Add(new Cat() { Name = "Cat " + RandomNumber.ToString(), BackgroundColor = "red"});
            });
        }
    }
}
